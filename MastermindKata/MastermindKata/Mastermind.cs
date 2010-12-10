using System;
using System.Collections.Generic;
using System.Linq;

namespace MastermindKata
{
    public class Mastermind
    {
        private readonly string _secret;
        private const char P = 'p';
        private const char M = 'm';

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
                    matches += P;
                    pCounter++;
                    if (mCounter > 0 && matches.Contains(M))
                    {
                        matches = RemoveMatchedM(matches);
                    }
                }
                else
                {
                    if (Secret.Contains(guesses[i]))
                    {
                        matches += M;
                        mCounter++;
                        if (pCounter > 0 && matches.Contains(M))
                        {
                            matches = RemoveMatchedP(matches);
                        }
                            
                    }
                }
            }
            return matches;
        }

        private string RemoveMatchedP(string matches)
        {
            var firstP = matches.IndexOf(P);
            matches = matches.Remove(firstP, 1);
            return matches;
        }

        private string RemoveMatchedM(string matches)
        {
            var firstM = matches.IndexOf(M);
            matches = matches.Remove(firstM, 1);
            return matches;
        }
    }
}
