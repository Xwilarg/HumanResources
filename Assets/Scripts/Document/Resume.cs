using HumanResources.Character;
using TMPro;

namespace HumanResources.Document
{
    public class Resume : UnityEngine.MonoBehaviour, IDocument
    {
        [UnityEngine.SerializeField]
        private TMP_Text _name, _address;

        public void LoadCharacterInfo(CharacterInfo character)
        {
            _name.text = character.LastName + " " + character.FirstName;
        }
    }
}
