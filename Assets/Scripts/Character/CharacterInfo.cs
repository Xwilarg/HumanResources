using HumanResources.Character.Country;
using HumanResources.Character.ID;
using HumanResources.Character.Name;
using HumanResources.Character.Race;
using HumanResources.Document;
using System;
using System.Linq;
using UnityEngine;

namespace HumanResources.Character
{
    public class CharacterInfo : MonoBehaviour
    {
        public string LastName { private set; get; }
        public string FirstName { private set; get; }
        public string Nationality { private set; get; }
        public string RaceName { private set; get; }
        public DateTime BirthDate { private set; get; }
        public string BirthPlace { private set; get; }
        public float Height { private set; get; }
        public float Weight { private set; get; }
        public SexeType Sexe { private set; get; }

        public string IdCardNumber { private set; get; }
        public DateTime IdCardIssuing { private set; get; }
        public DateTime IdCardExpiry { private set; get; }

        [SerializeField]
        private GameObject _documentHolder;

        private readonly DateTime _currentDate = new(2500, 1, 1);

        private void Start()
        {
            var race = RacialTraitGenerator.GetRace();

            LastName = NameGenerator.GetName(race);
            FirstName = NameGenerator.GetName(race);

            Nationality = CountryName.GetCountry();

            IdCardNumber = IDGenerator.GetID();
            IdCardIssuing = _currentDate.Subtract(new TimeSpan(UnityEngine.Random.Range(60, 1200), 0, 0, 0));
            IdCardExpiry = IdCardIssuing.Add(new TimeSpan(1200, 0, 0, 0));

            RaceName = race.GetRaceName();

            Height = race.GetHeight();
            Weight = race.GetWeight();

            var age = race.GetAge();
            BirthDate = new(_currentDate.Year - age, UnityEngine.Random.Range(1, 12), UnityEngine.Random.Range(1, 28));
            BirthPlace = CountryName.GetCity();

            Sexe = UnityEngine.Random.Range(0, 1) == 0 ? SexeType.MALE : SexeType.FEMALE;

            foreach (var document in _documentHolder.GetComponents<Component>().Where(x => x is IDocument).Cast<IDocument>())
            {
                document.LoadCharacterInfo(this);
            }
        }
    }
}
