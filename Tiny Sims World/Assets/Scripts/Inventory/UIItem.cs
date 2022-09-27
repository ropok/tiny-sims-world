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
        private ItemSettings _itemData;
        [SerializeField] private MoneyManager moneyManager;
        
        private void Awake()
        {
            _uiInventory = GetComponentInParent<UIInventory>();
            _itemData = _uiInventory.ItemData;
            AssignIcon(_itemData);
        }

        private void AssignIcon(ItemSettings item)
        {
            icon.sprite = item.Icon;
            price.text = "£ " + item.SellPrice;

        }

        private void SellItem(ItemSettings item)
        {
            Debug.Log("Sold: " + item.SellPrice);
            moneyManager.Money += item.SellPrice;
            Destroy(gameObject);
        }

        public void Interact()
        {
            SellItem(_itemData);
            // Debug.Log("clicked");
        }

        private void OnMouseDown()
        {
            if (Input.GetMouseButtonDown(0)) Debug.Log("test lcik");
        }

        public void Hover()
        {
            throw new System.NotImplementedException();
        }
    }
}