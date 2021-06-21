using HumanResources.Character.Country;
using HumanResources.Character.ID;
using HumanResources.Character.Name;
using HumanResources.Document;
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

        [SerializeField]
        private GameObject _documentHolder;

        private void Start()
        {
            LastName = NameGenerator.GetName();
            FirstName = NameGenerator.GetName();

            Nationality = CountryName.GetName();

            IdCardNumber = IDGenerator.GetID();

            foreach (var document in _documentHolder.GetComponents<Component>().Where(x => x is IDocument).Cast<IDocument>())
            {
                document.LoadCharacterInfo(this);
            }
        }
    }
}
