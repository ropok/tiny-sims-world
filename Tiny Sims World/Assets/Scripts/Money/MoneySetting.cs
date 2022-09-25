using UnityEngine;

namespace TinySimsWorld.Money
{
    [CreateAssetMenu(fileName = "MoneyData", menuName = "MoneySetting", order = 1)]
    public class MoneySetting : ScriptableObject
    {
        [SerializeField] private float money;

        public float Money
        {
            get => money;
            set => money = value;
        }
    }
}