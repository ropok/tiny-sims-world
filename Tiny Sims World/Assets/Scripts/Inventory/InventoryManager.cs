using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace TinySimsWorld.Inventory
{
    public class InventoryManager : MonoBehaviour
    {
        public ItemDatabase itemDatabase;
        private void Awake()
        {
            // foreach (var item in itemDatabase.ListItemSetting)
            // {
            //     Debug.Log(item.ItemName);
            // }
            SellItem("T001");
        }

        public void SellItem(string id)
        {
            var item = itemDatabase.ListItemSetting.FirstOrDefault(i => i.Id == id);
            if (item != null) Debug.Log(item.SellPrice);
        }
        
        
    }
}