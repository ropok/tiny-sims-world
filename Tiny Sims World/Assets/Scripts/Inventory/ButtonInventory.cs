using TinySimsWorld.Core;
using UnityEngine;

namespace TinySimsWorld.Inventory
{
    public class ButtonInventory : MonoBehaviour, IButtonAction
    {
        [SerializeField] private UIInventory uiInventory;
        private bool _isPopped;

        private void Awake()
        {
            _isPopped = false;
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.I)) Action();
        }

        public void Action()
        {
            if (!_isPopped)
            {
                uiInventory.Popup();
                _isPopped = true;
            }
            else
            {
                uiInventory.Popdown();
                _isPopped = false;
            }
        }
        
    }
}