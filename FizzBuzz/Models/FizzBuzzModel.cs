using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FizzBuzz.Models
{
    public class FizzBuzzModel
    {
        List<string> fizzBuzzList;
        public IEnumerable<string> GetFizzBuzzCollection(int minimum, int maximum)
        {
            fizzBuzzList = new List<string>();
            for(var i = minimum; i <= maximum; i++)
            {
                fizzBuzzList.Add(i.ToString());
            }
            return fizzBuzzList;
        }
    }
}
