using System;
using System.Collections.Generic;
using System.Linq;
using FluentNHibernate;
using FluentNHibernate.Automapping;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Diagnostics;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Engine;
using NHibernate.Event;
using NHibernate.Event.Default;
using NHibernate.Persister.Entity;

namespace PostGis.DAL.Providers
{
    [Serializable]
    public abstract class AbstractDataServicesProvider : IDataServicesProvider
    {

        public abstract IPersistenceConfigurer GetPersistenceConfigurer(bool createDatabase);

        protected AbstractDataServicesProvider()
        {
            //Logger = NullLogger.Instance;
        }

        //public ILogger Logger { get; set; }

        public Configuration BuildConfiguration(SessionFactoryParameters parameters)
        {
            var database = GetPersistenceConfigurer(parameters.CreateDatabase);
            var persistenceModel = CreatePersistenceModel(parameters.RecordDescriptors.ToList());

            var config = Fluently.Configure();

            parameters.Configurers.Invoke(c => c.Created(config, persistenceModel), Logger);

            config = config.Database(database)
                           .Mappings(m => m.AutoMappings.Add(persistenceModel))
                           .ExposeConfiguration(cfg =>
                           {
                               cfg.EventListeners.LoadEventListeners = new ILoadEventListener[] { new PostGisLoadEventListener() };
                               parameters.Configurers.Invoke(c => c.Building(cfg), Logger);
                           });

            parameters.Configurers.Invoke(c => c.Prepared(config), Logger);

            return config.BuildConfiguration();
        }

        public static AutoPersistenceModel CreatePersistenceModel(ICollection<Molde> recordDescriptors)
        {
            if (recordDescriptors == null)
            {
                throw new ArgumentNullException("recordDescriptors");
            }

            return AutoMap.Source(new TypeSource(recordDescriptors))
                // Ensure that namespaces of types are never auto-imported, so that 
                // identical type names from different namespaces can be mapped without ambiguity
                .Conventions.Setup(x => x.Add(AutoImport.Never()))
                .Conventions.Add(new RecordTableNameConvention(recordDescriptors))
                .Conventions.Add(new CacheConventions(recordDescriptors))
                .Alterations(alt =>
                {
                    foreach (var recordAssembly in recordDescriptors.Select(x => x.Type.Assembly).Distinct())
                    {
                        alt.Add(new AutoMappingOverrideAlteration(recordAssembly));
                    }
                    alt.AddFromAssemblyOf<DataModule>();
                    alt.Add(new ContentItemAlteration(recordDescriptors));
                })
                .Conventions.AddFromAssemblyOf<DataModule>();
        }

        [Serializable]
        class TypeSource : ITypeSource
        {
            private readonly IEnumerable<RecordBlueprint> _recordDescriptors;

            public TypeSource(IEnumerable<RecordBlueprint> recordDescriptors) { _recordDescriptors = recordDescriptors; }

            public IEnumerable<Type> GetTypes() { return _recordDescriptors.Select(descriptor => descriptor.Type); }

            public void LogSource(IDiagnosticLogger logger)
            {
                throw new NotImplementedException();
            }

            public string GetIdentifier()
            {
                throw new NotImplementedException();
            }
        }

        [Serializable]
        class PostGisLoadEventListener : DefaultLoadEventListener, ILoadEventListener
        {

            public new void OnLoad(LoadEvent localEvent, LoadType loadType)
            {
                var source = (ISessionImplementor)localEvent.Session;
                IEntityPersister entityPersister;
                if (localEvent.InstanceToLoad != null)
                {
                    entityPersister = source.GetEntityPersister(null, localEvent.InstanceToLoad);
                    localEvent.EntityClassName = localEvent.InstanceToLoad.GetType().FullName;
                }
                else
                    entityPersister = source.Factory.GetEntityPersister(localEvent.EntityClassName);
                if (entityPersister == null)
                    throw new HibernateException("Unable to locate persister: " + localEvent.EntityClassName);
                
                var keyToLoad = new EntityKey(localEvent.EntityId, entityPersister, source.EntityMode);

                if (loadType.IsNakedEntityReturned)
                {
                    localEvent.Result = Load(localEvent, entityPersister, keyToLoad, loadType);
                }
                else if (localEvent.LockMode == LockMode.None)
                {
                    localEvent.Result = ProxyOrLoad(localEvent, entityPersister, keyToLoad, loadType);
                }
                else
                {
                    localEvent.Result = LockAndLoad(localEvent, entityPersister, keyToLoad, loadType, source);
                }
            }
        }
    }
}
