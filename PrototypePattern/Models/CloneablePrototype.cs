using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.Models
{
    public abstract class CloneablePrototype<T> where T : class
    {
        public T Clone()
        {
            return (T)MemberwiseClone();
        }

        public T DeepCopy()
        {
            string result = JsonConvert.SerializeObject(this);
            return JsonConvert.DeserializeObject<T>(result);
        }
    }
}
