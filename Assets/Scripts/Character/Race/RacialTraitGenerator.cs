using UnityEngine;

namespace HumanResources.Character.Race
{
    public static class RacialTraitGenerator
    {
        public static RaceType GetRace()
        {
            return RaceType.Human;
        }

        public static float GetHeight(RaceType race)
        {
            return race switch
            {
                RaceType.Human => Random.Range(160f, 180f),
                _ => throw new System.NotImplementedException(),
            };
        }

        public static float GetWeight(RaceType race)
        {
            return race switch
            {
                RaceType.Human => Random.Range(60f, 80f),
                _ => throw new System.NotImplementedException(),
            };
        }
    }
}
