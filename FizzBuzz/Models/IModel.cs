using System.Collections.Generic;
using FizzBuzz.Trigger;

namespace FizzBuzz.Models
{
    public interface IModel
    {
        IEnumerable<string>  CreateFizzBuzzCollection(int minimum, int maximum, TriggerCollection triggers);
    }
}
