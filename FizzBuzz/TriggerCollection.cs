using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz.Trigger
{
    public class TriggerCollection
    {
        private List<Trigger> collection;
        
        public IEnumerable<Trigger> Collection
        {
            get
            {
                if(collection == null)
                {
                    collection = new List<Trigger>();
                }
                return collection;
            }
            set
            {
                collection = value.ToList();
            }
        }
    }
}
