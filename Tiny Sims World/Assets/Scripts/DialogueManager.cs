using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

namespace TinySimsWorld
{
    public class DialogueManager : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI nameText;
        [SerializeField] private TextMeshProUGUI dialogueText;
        private Dialogue _parentInteraction;

        private void Awake()
        {
            var parentGameObject = GetParentGameObject();
            if (parentGameObject == null) return;
            var parentInteraction = parentGameObject.GetComponent<Dialogue>();
            _parentInteraction = parentInteraction;
            
            // test purpose
            StartDialogue();
        }

        private void StartDialogue()
        {
            nameText.text = _parentInteraction.name;
            dialogueText.text = _parentInteraction.sentence;
        }

        private GameObject GetParentGameObject()
        {
            GameObject result = null;
            result = transform.parent.GameObject();
            return result;
        }
    }
}