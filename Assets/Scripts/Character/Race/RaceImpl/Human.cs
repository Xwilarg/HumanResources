using HumanResources.Character.Name;
using System.Collections.Generic;
using UnityEngine;

namespace HumanResources.Character.Race.RaceImpl
{
    public class Human : IRace
    {
        public string GetRaceName()
        {
            return "Human";
        }

        public float GetHeight()
        {
            return Random.Range(160f, 180f);
        }

        public float GetWeight()
        {
            return Random.Range(60f, 80f);
        }

        // Based on https://en.wikipedia.org/wiki/Letter_frequency
        public Dictionary<char, LetterInfo> GetLettersInfo()
        {
            return new()
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
                { 'y', new(2f, LetterType.CONSONANTE) },
                { 'z', new(0.074f, LetterType.CONSONANTE) }
            };
        }
    }
}
