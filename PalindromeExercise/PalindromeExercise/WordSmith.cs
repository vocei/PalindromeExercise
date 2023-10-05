using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool isAPalinDrome(string word)
        {
            var reversed = word.Reverse();
            return word.ToLower().SequenceEqual(reversed);
        }
    }
}