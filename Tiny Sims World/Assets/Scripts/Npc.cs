using System;
using UnityEngine;

namespace TinySimsWorld
{
    public class Npc : MonoBehaviour, IInteractable, INpc
    {
        private string _npcName;
        private PopupButton _popupButton;
        [SerializeField] private string dialogue;
        

        private void Awake()
        {
            _npcName = gameObject.name;
            _popupButton = GetComponent<PopupButton>();
        }

        private void Interaction()
        {
            // Debug.Log("Welcome! My name is " + _npcName);
            _popupButton.Popup();
        }

        public void Interact()
        {
            Interaction();
        }

        public void Hover()
        {
            Debug.Log("Hovering " + _npcName);
        }

        public void Talking()
        {
            Debug.Log(dialogue);
        }
    }
}