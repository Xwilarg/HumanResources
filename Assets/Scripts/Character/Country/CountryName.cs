using UnityEngine;

namespace HumanResources.Character.Country
{
    public static class CountryName
    {
        public static string GetCountry()
        {
            return "Ulnera";
        }

        public static string GetCity()
        {
            var city = new[]
            {
                "Thradis", "Operia", "Janel"
            };
            return city[Random.Range(0, city.Length)];
        }
    }
}
