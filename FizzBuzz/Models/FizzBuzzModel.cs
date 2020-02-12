using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FizzBuzz.Trigger;
using FizzBuzz.Helpers;

namespace FizzBuzz.Models
{
    public class FizzBuzzModel : IModel
    {
       TriggerCollection triggerCollection;
        public IEnumerable<string> CreateFizzBuzzCollection(int minimum, int maximum, TriggerCollection triggers = null)
        {
            triggerCollection = triggers;

            var fizzBuzzList = new List<string>();
            
            for(var current = minimum; current <= maximum; current++)
            {
                fizzBuzzList.Add(GetProperString(current));
            }
            return fizzBuzzList;
        }

        protected string GetProperString(int number)
        {
            string returnString = "";
            foreach(var trigger in triggerCollection.Collection)
            {
                if(number.IsMultipleOf(trigger.Multiple))
                {
                    returnString = returnString += trigger.Word;
                }
            }
            return string.IsNullOrEmpty(returnString) ? number.ToString() : returnString;
        }


    }
}
