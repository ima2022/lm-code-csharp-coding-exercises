using System;
using System.Collections.Generic;
using Exercises.Models;
using System.Linq;

namespace Exercises
{
    public class Exercise001
    {
        public string CapitalizeWord(string word)
        {
            return char.ToUpper(word[0]) + word.Substring(1);
        }
        public string GenerateInitials(string firstName, string lastName)
        {
            return char.ToUpper(firstName[0]) + "." + char.ToUpper(lastName[0]);
        }

        public double AddVat(double originalPrice, double vatRate)
        {
            return Math.Round(originalPrice * vatRate * 0.01 + originalPrice, 2);
        }

        public string Reverse(string sentence)
        {
            char[] charArray = sentence.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public int CountLinuxUsers(List<User> users)
        {
            return users.Where(u => u.Type == "Linux").Count();
        }
    }
}
