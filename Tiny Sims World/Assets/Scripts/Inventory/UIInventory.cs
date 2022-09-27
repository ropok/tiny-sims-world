using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

namespace TinySimsWorld.Inventory
{
    public class UIInventory : MonoBehaviour
    {
        [SerializeField] private GameObject itemPrefab;
        private InventoryManager _inventoryManager;
        private float _padding = 0f;
        private const float Padding = 480f;
        private bool IsPopped;
        private List<GameObject> _listCanvasPopups = new List<GameObject>();

        public ItemSettings ItemData { get; private set; }

        private void Awake()
        {
            IsPopped = false;
            _inventoryManager = GetComponent<InventoryManager>();
        }

        public void Popup()
        {
            foreach (var itemSetting in _inventoryManager.itemDatabase.ListItemSetting)
            {
                CreateItem(itemSetting, _padding);
                _padding += Padding;
            }

            IsPopped = true;
        }

        public void Popdown()
        {
            foreach (var listCanvasPopup in _listCanvasPopups)
            {
                Destroy(listCanvasPopup);
            }
            _padding = 0f;
            IsPopped = false;
        }
        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.Escape)) Popdown();
        }

        private void CreateItem(ItemSettings itemSetting, float _padding)
        {
            if (IsPopped) return;
            var position = gameObject.transform.position;
            var paddingCanvas = position.x + _padding;
            var parentUI = transform;
            ItemData = itemSetting;
            // var item = Instantiate(itemPrefab, parentUI.position, quaternion.identity, parentUI);
            var item = Instantiate(itemPrefab, new Vector2(paddingCanvas, position.y), quaternion.identity, parentUI);
            if(item != null)
                _listCanvasPopups.Add(item.gameObject);
        }
    }
}