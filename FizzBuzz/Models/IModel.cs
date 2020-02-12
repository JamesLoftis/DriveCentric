using System.Collections.Generic;

namespace FizzBuzz.Models
{
    public interface IModel
    {
        IEnumerable<string>  CreateFizzBuzzCollection(string content);
    }
}
