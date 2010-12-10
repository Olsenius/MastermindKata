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
            if (guesses.Any(x => _secret.Contains(x)))
                return "m";
            return "";
        }
    }
}
