using TinySimsWorld.Core;
using TinySimsWorld.Inventory;
using UnityEngine;

namespace TinySimsWorld.InteractableObjects
{
    public class ButtonBuy : MonoBehaviour, IButtonAction
    {
        private UIInventory _uiInventory;
        private PopupButton _popupButton;
        private PopupButton _popupButton2;
        private GameObject _uiInteraction;
        private GameObject _uiPopupButtons;
        private GameObject _uiPopupButtons2;

        private void Awake()
        {
            _uiInteraction = GameObject.Find("SlotBuying");
            _uiPopupButtons = GameObject.Find("Hat Racks");
            _uiPopupButtons2 = GameObject.Find("Shirt Racks");
            _uiInventory = _uiInteraction.GetComponent<UIInventory>();
            _popupButton = _uiPopupButtons.GetComponent<PopupButton>();
            _popupButton2 = _uiPopupButtons2.GetComponent<PopupButton>();
        }

        public void Action()
        {
            _uiInventory.Popup();
            _popupButton.Popdown();
            _popupButton2.Popdown();
        }
    }
}