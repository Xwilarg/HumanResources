using HumanResources.Character.Race;
using HumanResources.Character.Race.RaceImpl;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace HumanResources.Character.Name
{
    public static class NameGenerator
    {
        /// <summary>
        /// Generate a random name
        /// </summary>
        public static string GetName(IRace race)
        {
            var letters = race.GetLettersInfo();

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
