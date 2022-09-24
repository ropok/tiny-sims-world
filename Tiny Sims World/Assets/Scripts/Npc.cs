using System;
using UnityEngine;

namespace TinySimsWorld
{
    public class Npc : MonoBehaviour, IInteractable
    {
        private string _npcName;

        private void Awake()
        {
            _npcName = gameObject.name;
        }

        private void Talk()
        {
            Debug.Log("Welcome! My name is " + _npcName);
        }

        public void Interact()
        {
            Talk();
        }

        public void Hover()
        {
            Debug.Log("Hovering " + _npcName);
        }
    }
}