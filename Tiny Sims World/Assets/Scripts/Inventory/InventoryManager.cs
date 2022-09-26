using System;
using System.Collections.Generic;
using UnityEngine;

namespace TinySimsWorld.Inventory
{
    public class InventoryManager : MonoBehaviour
    {
        public List<ItemSettings> listItemSettings;

        private void Awake()
        {
            foreach (var listItemSetting in listItemSettings)
            {
                Debug.Log(listItemSetting.ItemName);
            }
        }
    }
}