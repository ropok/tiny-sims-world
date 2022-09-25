using TMPro;
using UnityEngine;

namespace TinySimsWorld.Money
{
    public class MoneyDisplay : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI moneyDisplay;
        private MoneyManager _moneyManager;

        private void Awake()
        {
            _moneyManager = GetComponent<MoneyManager>();
        }

        private void Update()
        {
            MoneyDisplayUpdate(_moneyManager.Money);
        }

        private void MoneyDisplayUpdate(float amount)
        {
            moneyDisplay.text = "£: " + amount;
        }
    }
}