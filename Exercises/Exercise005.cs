using System;
using System.Linq;
namespace Exercises
{
    public class Exercise005
    {
        public bool IsPangram(string input)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            return alphabet.All(x => input.ToLower().Contains(x));
        }
    }
}
