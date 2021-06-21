using HumanResources.Character;
using System.Linq;
using TMPro;

namespace HumanResources.Document
{
    public class IDCard : UnityEngine.MonoBehaviour, IDocument
    {
        [UnityEngine.SerializeField]
        private TMP_Text _name, _country, _id, _race, _datePlaceBirth, _sexe, _height, _weight, _issuing, _expiry;

        public void LoadCharacterInfo(CharacterInfo character)
        {
            _name.text = character.LastName + " " + character.FirstName;
            _country.text = character.Nationality;
            _id.text = character.IdCardNumber;
            _race.text = character.Race.ToString()[0] + string.Join("", character.Race.ToString().Skip(1)).ToLowerInvariant();
            _height.text = character.Height.ToString("0.00");
            _weight.text = character.Weight.ToString("0.00");
        }
    }
}
