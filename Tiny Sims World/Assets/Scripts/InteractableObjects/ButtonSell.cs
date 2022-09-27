using System;
using TinySimsWorld.Core;
using TinySimsWorld.Inventory;
using UnityEngine;
using UnityEngine.UI;

namespace TinySimsWorld.InteractableObjects
{
    public class ButtonSell : MonoBehaviour, IButtonAction
    {
        private UIInventory _uiInventory;
        private PopupButton _popupButton;
        private GameObject _uiInteraction;
        private GameObject _uiPopupButtons;

        private void Awake()
        {
            _uiInteraction = GameObject.Find("SlotSelling");
            _uiPopupButtons = GameObject.Find("Shop Keeper");
            _uiInventory = _uiInteraction.GetComponent<UIInventory>();
            _popupButton = _uiPopupButtons.GetComponent<PopupButton>();
        }

        public void Action()
        {
            _uiInventory.Popup();
            _popupButton.Popdown();
        }
    }
}