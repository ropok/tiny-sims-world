using System.Collections.Generic;
using UnityEngine;

namespace TinySimsWorld.Inventory
{
    [CreateAssetMenu(fileName = "ItemDatabase", menuName = "Databse/ItemDatabase", order = 4)]
    public class ItemDatabase : ScriptableObject
    {
        [SerializeField] private List<ItemSettings> listItemSetting;

        public List<ItemSettings> ListItemSetting => listItemSetting;
    }
}