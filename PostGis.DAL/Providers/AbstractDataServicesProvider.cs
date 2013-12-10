﻿using System;
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

        public static AutoPersistenceModel CreatePersistenceModel()
        {
            return AutoMap.AssemblyOf<Users>(new AutomappingConfiguration());
        }
    }

    public class AutomappingConfiguration : DefaultAutomappingConfiguration
    {
        public override bool ShouldMap(Type type)
        {
            return type.Namespace == typeof (Users).Namespace;
        }

        public override bool IsComponent(Type type)
        {
            return false;
        }
    }
}