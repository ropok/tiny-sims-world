using TinySimsWorld.Core;
using UnityEngine;

namespace TinySimsWorld.InteractableObjects
{
    public class Racks : MonoBehaviour, IInteractable
    {
        private string _racksName;
        private PopupButton _popupButton;

        private void Awake()
        {
            _racksName = gameObject.name;
            _popupButton = GetComponent<PopupButton>();
        }

        private void Interaction()
        {
            _popupButton.Popup();
        }

        public void Interact()
        {
            Interaction();
        }

        public void Interact2()
        {
            Debug.Log("Hovering " + _racksName);
        }
    }
}