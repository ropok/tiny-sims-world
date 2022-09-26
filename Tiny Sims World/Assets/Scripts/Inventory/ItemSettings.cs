using UnityEngine;

namespace TinySimsWorld.Inventory
{
    [CreateAssetMenu(fileName = "ItemData", menuName = "Items/ItemSettings", order = 2)]
    public class ItemSettings : ScriptableObject
    {
        [SerializeField] private string id;
        [SerializeField] private string itemName;
        [SerializeField] private Sprite icon;
        [SerializeField] private Sprite texture;
        [SerializeField] private float buyPrice;
        [SerializeField] private float sellPrice;
        [SerializeField] private Color color;
        
        public string Id => id;
        public string ItemName => itemName;
        public Sprite Icon => icon;
        public Sprite Texture => texture;
        public float BuyPrice => buyPrice;
        public float SellPrice => sellPrice;
        public Color Color => color;
    }
}