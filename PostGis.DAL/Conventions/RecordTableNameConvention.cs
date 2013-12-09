using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Conventions;

namespace PostGis.DAL.Conventions
{
    class RecordTableNameConvention: IClassConvention {
        private readonly Dictionary<Type, RecordBlueprint> _descriptors;

        public RecordTableNameConvention(IEnumerable<RecordBlueprint> descriptors) {
            _descriptors = descriptors.ToDictionary(d => d.Type);
        }

        public void Apply(IClassInstance instance) {
            RecordBlueprint desc;
            if (_descriptors.TryGetValue(instance.EntityType, out desc)) {
                instance.Table(desc.TableName);
            }
        }
}
