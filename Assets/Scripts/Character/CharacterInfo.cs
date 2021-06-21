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
        public string IdCardNumber { private set; get; }
        public RaceType Race { private set; get; }
        public DateTime BirthDate { private set; get; }
        public string BirthPlace { private set; get; }
        public float Height { private set; get; }
        public float Weight { private set; get; }

        [SerializeField]
        private GameObject _documentHolder;

        private void Start()
        {
            LastName = NameGenerator.GetName();
            FirstName = NameGenerator.GetName();

            Nationality = CountryName.GetName();

            IdCardNumber = IDGenerator.GetID();

            Race = RacialTraitGenerator.GetRace();
            Height = RacialTraitGenerator.GetHeight(Race);
            Weight = RacialTraitGenerator.GetWeight(Race);

            foreach (var document in _documentHolder.GetComponents<Component>().Where(x => x is IDocument).Cast<IDocument>())
            {
                document.LoadCharacterInfo(this);
            }
        }
    }
}
