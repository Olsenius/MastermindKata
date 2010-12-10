using System.Collections.Generic;
using System.Linq;

namespace MastermindKata
{
    public class Mastermind
    {
        private readonly string _secret;

        public Mastermind(string secret)
        {
            _secret = secret;
        }

        private string[] Secret { get { return _secret.Split(' '); } }

        public string Guess(string guess)
        {
            var matches = string.Empty;
            var guesses = guess.Split(' ');
            var mCounter = 0;
            var pCounter = 0;


            for (var i = 0; i < Secret.Length; i++)
            {
                if (Secret[i] == guesses[i])
                {
                    matches += "p";
                    pCounter++;
                    if (mCounter > 0 && matches.Contains("m"))
                    {
                        var firstM = matches.IndexOf('m');
                        matches = matches.Remove(firstM, 1);
                    }
                }
                else
                {
                    if (Secret.Contains(guesses[i]))
                    {
                        matches += "m";
                        mCounter++;
                        if (pCounter > 0 && matches.Contains("m"))
                        {
                            var firstP = matches.IndexOf('p');
                            matches = matches.Remove(firstP, 1);
                        }
                            
                    }
                }
            }
            return matches;
        }
    }
}
