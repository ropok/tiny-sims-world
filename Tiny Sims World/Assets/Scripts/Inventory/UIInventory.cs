using Unity.Mathematics;
using UnityEngine;

namespace TinySimsWorld.Inventory
{
    public class UIInventory : MonoBehaviour
    {
        [SerializeField] private GameObject itemPrefab;
        private InventoryManager _inventoryManager;

        public ItemSettings ItemData { get; private set; }

        private void Awake()
        {
            _inventoryManager = GetComponent<InventoryManager>();
            foreach (var itemSetting in _inventoryManager.listItemSettings)
            {
                CreateItem(itemSetting);
            }
        }

        private void CreateItem(ItemSettings itemSetting)
        {
            var parentUI = transform;
            ItemData = itemSetting;
            var item = Instantiate(itemPrefab, parentUI.position, quaternion.identity, parentUI);
        }
    }
}