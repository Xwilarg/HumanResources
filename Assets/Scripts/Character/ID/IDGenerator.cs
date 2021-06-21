using System.Text;
using UnityEngine;

namespace HumanResources.Character.ID
{
    public static class IDGenerator
    {
        public static string GetID()
        {
            return GenerateString(RandomNumber, 3) + "-" + GenerateString(RandomLetter, 3) + "-" + GenerateString(RandomNumber, 3);
        }

        private static string GenerateString(System.Func<char> toCall, int count)
        {
            StringBuilder str = new();
            for (int i = 0; i < count; i++)
            {
                str.Append(toCall());
            }
            return str.ToString();
        }

        private static char RandomLetter()
        {
            return (char)('A' + Random.Range(0, 26));
        }

        private static char RandomNumber()
        {
            return (char)('0' + Random.Range(0, 10));
        }
    }
}
