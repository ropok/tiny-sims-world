using UnityEngine;

namespace TinySimsWorld.Money
{
    public class MoneyManager : MonoBehaviour
    {
        [SerializeField] private MoneySetting moneySetting;

        public void Add(float amount)
        {
            moneySetting.Money += amount;
        }

        public void Subtract(float amount)
        {
            moneySetting.Money -= amount;
        }

        public float Money
        {
            get => moneySetting.Money;
            set => moneySetting.Money = value;
        }
    }
}