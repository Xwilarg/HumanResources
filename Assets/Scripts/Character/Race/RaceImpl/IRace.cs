using HumanResources.Character.Name;
using System.Collections.Generic;

namespace HumanResources.Character.Race.RaceImpl
{
    public interface IRace
    {
        public string GetRaceName();
        public float GetHeight();
        public float GetWeight();
        public int GetAge();
        public Dictionary<char, LetterInfo> GetLettersInfo();
    }
}
