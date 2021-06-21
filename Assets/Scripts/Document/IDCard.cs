using HumanResources.Character;
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
            _race.text = character.RaceName;
            _datePlaceBirth.text = character.BirthDate.ToString("yyyy/MM/dd") + " at " + character.BirthPlace;
            _sexe.text = character.Sexe.ToString()[0].ToString();
            _height.text = character.Height.ToString("0.00");
            _weight.text = character.Weight.ToString("0.00");
            _issuing.text = character.IdCardIssuing.ToString("yyyy/MM/dd");
            _expiry.text = character.IdCardExpiry.ToString("yyyy/MM/dd");
        }
    }
}
