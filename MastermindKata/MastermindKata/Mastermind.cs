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

        public string Guess(string guess)
        {
            var guesses = guess.Split(' ');
            var hitCount = guesses.Count(x => _secret.Contains(x));
            if (hitCount <= 0)
            {
                return "";
            }
            else
            {
                var ret = string.Empty;

                for (var i = 0; i < hitCount; i++)
                {
                    ret += 'm';
                }
                return ret;
            }
        }
    }
}
