using System.Collections;
using TinySimsWorld.Core;
using UnityEngine;

namespace TinySimsWorld.InteractableObjects
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

        public void Interact2()
        {
            Debug.Log("Hovering " + _npcName);
        }
        
        public string npcName { get; set; }

        public void Talking()
        {
            _popupDialogue.Popup();
            _popupButton.Popdown();
            StartCoroutine(DestroyDialogueCoroutine(3));
        }

        IEnumerator DestroyDialogueCoroutine(float waitForSeconds)
        {
            yield return new WaitForSeconds(waitForSeconds);
            _popupDialogue.Popdown();
        }
    }
}