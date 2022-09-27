using System;
using TinySimsWorld.Core;
using TinySimsWorld.Money;
using TinySimsWorld.Player;
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
        [SerializeField] private PlayerOutfits playerOutfits;
        
        
        private ItemSettings _itemData;
        private MoneyManager moneyManager;
        [SerializeField] private bool isSelling = true;
        [SerializeField] private bool isInventory = false;
        
        
        
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
            if (!isInventory)
            {
                price.text = "£ " + _assignedPrice;
                buttonInteract.text = _buttonInteract;
            }
            else
            {
                price.text = "";
                buttonInteract.text = "Equip";
            }
                icon.sprite = item.Icon;

        }

        private void SellItem(ItemSettings item)
        {
            Debug.Log("Sold: " + item.SellPrice);
            moneyManager.Money += item.SellPrice;
            Destroy(gameObject);
        }
        private void BuyItem(ItemSettings item)
        {
            if (moneyManager.Money < item.BuyPrice) return;
            Debug.Log("Bought: " + item.BuyPrice);
            moneyManager.Money -= item.BuyPrice;
            Destroy(gameObject);
        }
        private void EquipItem(ItemSettings item)
        {
            Debug.Log("Equipped: " + item.name);
            playerOutfits.Color = item.Color;
        }

        public void Interact()
        {
            if (!isInventory)
            {
                if (isSelling) SellItem(_itemData);
                else
                {
                    BuyItem(_itemData);
                }
            } else EquipItem(_itemData);
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