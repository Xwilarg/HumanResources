using HumanResources.Character.Name;
using TMPro;
using UnityEngine;

namespace HumanResources.Character
{
    public class CharacterInfo : MonoBehaviour
    {
        [SerializeField]
        private TMP_Text _name;

        private string _lastName, _firstName;

        private void Start()
        {
            _lastName = NameGenerator.GetName();
            _firstName = NameGenerator.GetName();

            _name.text = _lastName + " " + _firstName;
        }
    }
}
