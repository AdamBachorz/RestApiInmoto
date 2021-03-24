using FluentNHibernate.Mapping;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiInmoto.Model.Domain.Mappings
{
    public class MyEntityMapping : ClassMap<MyEntity>
    {
        public MyEntityMapping()
        {
            Table("MY_ENTITY");
            Id(x => x.Id, "ID").GeneratedBy.Identity();
            Map(x => x.Text, "TEXT");
            HasMany(x => x.MyReferences)
                .KeyColumn("my_entity_id")
                .Not.LazyLoad()
                .Inverse()
                ;
            
        }
    }
}

