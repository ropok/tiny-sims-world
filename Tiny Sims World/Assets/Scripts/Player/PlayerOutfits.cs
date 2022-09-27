using UnityEngine;

namespace TinySimsWorld.Player
{
    [CreateAssetMenu(fileName = "Player Outfit", menuName = "Player/Outfits", order = 1)]
    public class PlayerOutfits : ScriptableObject
    {
        [SerializeField] private Color color;

        public Color Color
        {
            get => color;
            set => color = value;
        }
    }
}