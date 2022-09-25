using System;
using UnityEngine;

namespace TinySimsWorld
{
    public class Npc : MonoBehaviour, IInteractable, INpc
    {
        [SerializeField] private string _npcName;
        private PopupButton _popupButton;
        private PopupDialogue _popupDialogue;
        [SerializeField] private string dialogue;


        private void Awake()
        {
            npcName = _npcName;
            _popupButton = GetComponent<PopupButton>();
            _popupDialogue = GetComponent<PopupDialogue>();
        }

        private void Interaction()
        {
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
        
        public string npcName { get; set; }

        public void Talking()
        {
            // Debug.Log(dialogue);
            // Debug.Log("My name is " + npcName);
            _popupDialogue.Popup();
        }
    }
}