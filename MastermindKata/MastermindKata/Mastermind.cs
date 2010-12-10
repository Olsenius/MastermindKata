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

            for (int i = 0; i < Secret.Length; i++)
            {
                if (Secret[i] == guesses[i])
                    matches += "p";
            }

            var hitCount = guesses.Count(x => _secret.Contains(x)) - matches.Length;

            for (var i = 0; i < hitCount; i++)
            {
                matches += 'm';
            }

            return matches;
        }

    }
}
