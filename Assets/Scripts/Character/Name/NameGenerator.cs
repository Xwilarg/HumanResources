using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace HumanResources.Character.Name
{
    public static class NameGenerator
    {
        // Based on https://en.wikipedia.org/wiki/Letter_frequency
        public static readonly Dictionary<char, LetterInfo> letters = new()
        {
            { 'a', new(8.2f, LetterType.VOWEL) },
            { 'b', new(1.5f, LetterType.CONSONANTE) },
            { 'c', new(2.8f, LetterType.CONSONANTE) },
            { 'd', new(4.3f, LetterType.CONSONANTE) },
            { 'e', new(13f, LetterType.VOWEL) },
            { 'f', new(2.2f, LetterType.CONSONANTE) },
            { 'g', new(2f, LetterType.CONSONANTE) },
            { 'h', new(6.1f, LetterType.CONSONANTE) },
            { 'i', new(7f, LetterType.VOWEL) },
            { 'j', new(0.15f, LetterType.CONSONANTE) },
            { 'k', new(0.77f, LetterType.CONSONANTE) },
            { 'l', new(4f, LetterType.CONSONANTE) },
            { 'm', new(2.4f, LetterType.CONSONANTE) },
            { 'n', new(6.7f, LetterType.CONSONANTE) },
            { 'o', new(7.5f, LetterType.VOWEL) },
            { 'p', new(1.9f, LetterType.CONSONANTE) },
            { 'q', new(0.095f, LetterType.CONSONANTE) },
            { 'r', new(6f, LetterType.CONSONANTE) },
            { 's', new(6.3f, LetterType.CONSONANTE) },
            { 't', new(9.1f, LetterType.CONSONANTE) },
            { 'u', new(2.8f, LetterType.VOWEL) },
            { 'v', new(0.98f, LetterType.CONSONANTE) },
            { 'w', new(2.4f, LetterType.CONSONANTE) },
            { 'x', new(0.15f, LetterType.CONSONANTE) },
            { 'y', new(2f, LetterType.CONSONANTE )},
            { 'z', new(0.074f, LetterType.CONSONANTE) }
        };

        /// <summary>
        /// Generate a random name
        /// </summary>
        public static string GetName()
        {
            int nameLength = Random.Range(3, 8);
            var currType = Random.Range(0, 1) == 0 ? LetterType.CONSONANTE : LetterType.VOWEL;
            var lastType = currType == LetterType.CONSONANTE ? LetterType.VOWEL : LetterType.CONSONANTE;
            StringBuilder name = new();
            for (int i = 0; i < nameLength; i++)
            {
                var possibleLetters = letters.Where(x => x.Value.Type == currType).Select(x => (x.Key, x.Value)).ToArray();
                var max = possibleLetters.Sum(x => x.Value.Chance);

                var curr = Random.Range(0, max);
                var index = 0;
                var currChance = 0f;
                while (currChance + possibleLetters[index].Value.Chance < curr)
                {
                    currChance += possibleLetters[index].Value.Chance;
                    index++;
                }

                name.Append(possibleLetters[index].Key);

                if (currType == lastType)
                {
                    currType = currType == LetterType.CONSONANTE ? LetterType.VOWEL : LetterType.CONSONANTE;
                }
                else
                {
                    currType = Random.Range(0, 1) == 0 ? LetterType.CONSONANTE : LetterType.VOWEL;
                }
                lastType = currType;
            }
            return char.ToUpper(name.ToString()[0]) + string.Join("", name.ToString().Skip(1));
        }
    }
}
