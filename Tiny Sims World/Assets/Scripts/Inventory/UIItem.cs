using System;
using TinySimsWorld.Core;
using TinySimsWorld.Money;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

namespace TinySimsWorld.Inventory
{
    public class UIItem : MonoBehaviour, IInteractable
    {
        private UIInventory _uiInventory;
        [SerializeField] private Image icon;
        [SerializeField] private TextMeshProUGUI price;
        [SerializeField] private TextMeshProUGUI buttonInteract;
        
        private ItemSettings _itemData;
        private MoneyManager moneyManager;
        [SerializeField] private bool isSelling = true;
        
        
        private void Awake()
        {
            moneyManager = GetComponent<MoneyManager>();
            _uiInventory = GetComponentInParent<UIInventory>();
            _itemData = _uiInventory.ItemData;
            AssignIcon(_itemData);
        }

        private void AssignIcon(ItemSettings item)
        {
            var _assignedPrice = isSelling == true ? item.SellPrice : item.BuyPrice;
            var _buttonInteract = isSelling == true ? "Sell" : "Buy";
            icon.sprite = item.Icon;
            price.text = "£ " + _assignedPrice;
            buttonInteract.text = _buttonInteract;

        }

        private void SellItem(ItemSettings item)
        {
            Debug.Log("Sold: " + item.SellPrice);
            moneyManager.Money += item.SellPrice;
            Destroy(gameObject);
        }
        private void BuyItem(ItemSettings item)
        {
            Debug.Log("Bought: " + item.BuyPrice);
            moneyManager.Money -= item.BuyPrice;
            Destroy(gameObject);
        }

        public void Interact()
        {
            if (isSelling) SellItem(_itemData);
            else
            {
                BuyItem(_itemData);
            }
            // Debug.Log("clicked");
        }

        private void OnMouseDown()
        {
            if (Input.GetMouseButtonDown(0)) Debug.Log("test lcik");
        }

        public void Interact2()
        {
            throw new System.NotImplementedException();
        }
    }
}