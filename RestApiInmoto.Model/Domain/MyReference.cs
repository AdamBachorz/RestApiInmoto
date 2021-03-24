using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiInmoto.Model.Domain
{
    public class MyReference : Entity
    {
        public virtual int ReferenceCode { get; set; }
        public virtual MyEntity MyEntity { get; set; }
    }
}
