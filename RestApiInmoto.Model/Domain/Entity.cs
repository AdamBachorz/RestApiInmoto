using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace RestApiInmoto.Model.Domain
{
    public abstract class Entity
    {
        public virtual int ID { get; set; }
    }
}
