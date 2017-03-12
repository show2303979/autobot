using System;
using System.Text;

namespace AutoBuddy.Utilities.AutoShop
{
    internal static class StringDistance
    {
        private const double defaultMismatchScore = 0.0;
        private const double defaultMatchScore = 1.0;

        public static double RateSimilarity(string _firstWord, string _secondWord)
        {
            _firstWord = _firstWord.Replace("\'", string.Empty).Replace(" ", string.Empty).ToLower();
            _secondWord = _secondWord.Replace("\'", string.Empty).Replace(" ", string.Empty).ToLower();
            if (_firstWord == _secondWord)
                return defaultMatchScore;
            var halfLength = Math.Min(_firstWord.Length, _secondWord.Length)/2 + 1;

            var common1 = GetCommonCharacters(_firstWord, _secondWord, halfLength);
            var commonMatches = common1.Length;

            if (commonMatches == 0)
                return defaultMismatchScore;

            var common2 = GetCommonCharacters(_secondWord, _firstWord, halfLength);

            if (commonMatches != common2.Length)
                return defaultMismatchScore;
            var transpositions = 0;
            for (var i = 0; i < commonMatches; i++)
            {
                if (common1[i] != common2[i])
                    transpositions++;
            }

            transpositions /= 2;
            var jaroMetric = commonMatches/(3.0*_firstWord.Length) + commonMatches/(3.0*_secondWord.Length) +
                                (commonMatches - transpositions)/(3.0*commonMatches);
            return jaroMetric;
        }

        private static StringBuilder GetCommonCharacters(string firstWord, string secondWord, int separationDistance)
        {
            if ((firstWord == null) || (secondWord == null)) return null;
            var returnCommons = new StringBuilder(20);
            var copy = new StringBuilder(secondWord);
            var firstWordLength = firstWord.Length;
            var secondWordLength = secondWord.Length;

            for (var i = 0; i < firstWordLength; i++)
            {
                var character = firstWord[i];
                var found = false;

                for (var j = Math.Max(0, i - separationDistance);
                    !found && j < Math.Min(i + separationDistance, secondWordLength);
                    j++)
                {
                    if (copy[j] == character)
                    {
                        found = true;
                        returnCommons.Append(character);
                        copy[j] = '#';
                    }
                }
            }
            return returnCommons;
        }

        public static double Match(this string s, string t)
        {
            return RateSimilarity(t, s);
        }
    }
}