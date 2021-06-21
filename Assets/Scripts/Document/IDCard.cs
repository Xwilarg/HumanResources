using HumanResources.Character;
using TMPro;

namespace HumanResources.Document
{
    public class IDCard : UnityEngine.MonoBehaviour, IDocument
    {
        [UnityEngine.SerializeField]
        private TMP_Text _name, _country, _id;

        public void LoadCharacterInfo(CharacterInfo character)
        {
            _name.text = character.LastName + " " + character.FirstName;
            _country.text = character.Nationality;
            _id.text = character.IdCardNumber;
        }
    }
}
