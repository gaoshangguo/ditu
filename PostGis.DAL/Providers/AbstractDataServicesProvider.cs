using System;
using System.Collections.Generic;
using System.Linq;
using FluentNHibernate;
using FluentNHibernate.Automapping;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Conventions;
using FluentNHibernate.Conventions.Helpers;
using FluentNHibernate.Conventions.Instances;
using FluentNHibernate.Diagnostics;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Engine;
using NHibernate.Event;
using NHibernate.Event.Default;
using NHibernate.Persister.Entity;
using NHibernate.Tool.hbm2ddl;
using PostGis.Model;

namespace PostGis.DAL.Providers
{
    public abstract class AbstractDataServicesProvider
    {
        public abstract IPersistenceConfigurer GetPersistenceConfigurer(bool createDatabase);

        private const bool CreateDatabase = true;

        public Configuration BuildConfiguration()
        {
            var database = GetPersistenceConfigurer(CreateDatabase);
            var persistenceModel = CreatePersistenceModel();
            var config = Fluently.Configure();
            config = config.Database(database)
                .Mappings(m => m.AutoMappings.Add(persistenceModel));
            return config.BuildConfiguration();
        }

        public AutoPersistenceModel CreatePersistenceModel()
        {
            return AutoMap.AssemblyOf<ChangesetTags>(new AutomappingConfiguration()).Conventions.Add(new CascadeConvention()).Conventions.Add(Table.Is(x=>x.TableName.ToLower())).Conventions.Add(new PrimaryKeyConvention());
        }

        public ISessionFactory CreateSessionFactory()
        {
            BuildSchema(BuildConfiguration());
            return Fluently.Configure(BuildConfiguration()).BuildSessionFactory();
        }

        private void BuildSchema(Configuration config)
        {
            // this NHibernate tool takes a configuration (with mapping info in)
            // and exports a database schema from it
            new SchemaExport(config).SetOutputFile(@"C:\abc.txt");
        }
    }

    public class AutomappingConfiguration : DefaultAutomappingConfiguration
    {
        public override bool ShouldMap(Type type)
        {
            return type.GetInterfaces().Contains(typeof(ITable));
        }

        public override bool IsId(Member member)
        {
            return member.Name == "Id";
        }
    }

    public class CascadeConvention : IReferenceConvention, IHasManyConvention, IHasManyToManyConvention
    {
        public void Apply(IManyToOneInstance instance)
        {
            instance.Cascade.All();
        }

        public void Apply(IOneToManyCollectionInstance instance)
        {
            instance.Cascade.All();
        }

        public void Apply(IManyToManyCollectionInstance instance)
        {
            instance.Cascade.All();
        }
    }

    public class PrimaryKeyConvention : IIdConvention
    {
        public void Apply(IIdentityInstance instance)
        {
            instance.GeneratedBy.Sequence(instance.EntityType.Name + "_id_seq");
        }
    }
}