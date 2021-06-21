using HumanResources.Character.Race.RaceImpl;
using UnityEngine;

namespace HumanResources.Character.Race
{
    public static class RacialTraitGenerator
    {
        public static IRace GetRace()
        {
            return new Human();
        }
    }
}
