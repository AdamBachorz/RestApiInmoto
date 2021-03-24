using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiInmoto.Model.Domain.Mappings
{
    public class MyReferenceMapping : ClassMap<MyReference>
    {
        public MyReferenceMapping()
        {
            Table("my_reference");
            Id(x => x.Id, "id").GeneratedBy.Identity();
            Map(x => x.ReferenceCode, "reference_code");
            References(x => x.MyEntity)
                .Column("my_entity_id")
                .Not.LazyLoad()
                ;
        }
    }
}
