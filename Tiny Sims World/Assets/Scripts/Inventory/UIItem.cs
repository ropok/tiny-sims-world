using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

namespace TinySimsWorld.Inventory
{
    public class UIItem : MonoBehaviour
    {
        private UIInventory _uiInventory;
        [SerializeField] private Image icon;
        [SerializeField] private TextMeshProUGUI price;
        private ItemSettings _itemData;
        private void Awake()
        {
            _uiInventory = GetComponentInParent<UIInventory>();
            _itemData = _uiInventory.ItemData;
            icon.sprite = _itemData.Icon;
            price.text = "£ " + _itemData.SellPrice;
        }
    }
}