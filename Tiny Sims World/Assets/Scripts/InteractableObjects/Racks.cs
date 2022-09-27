using TinySimsWorld.Core;
using UnityEngine;

namespace TinySimsWorld.InteractableObjects
{
    public class Racks : MonoBehaviour, IInteractable
    {
        private string _racksName;

        private void Awake()
        {
            _racksName = gameObject.name;
        }

        private void Use()
        {
            Debug.Log("Using " + _racksName);
        }

        public void Interact()
        {
            Use();
        }

        public void Interact2()
        {
            Debug.Log("Hovering " + _racksName);
        }
    }
}