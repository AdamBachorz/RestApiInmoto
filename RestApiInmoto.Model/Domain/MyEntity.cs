using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiInmoto.Model.Domain
{
    public class MyEntity : Entity
    {
        public virtual string Text { get; set; }
        public virtual IEnumerable<MyReference> MyReferences { get; set; } 
    }
}
