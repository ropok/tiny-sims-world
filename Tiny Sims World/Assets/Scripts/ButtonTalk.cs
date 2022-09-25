using System;
using Unity.VisualScripting;
using UnityEngine;

namespace TinySimsWorld
{
    public class ButtonTalk : MonoBehaviour, IButtonAction
    {
        private INpc _parentInteraction;
        private void Awake()
        {
            var parentGameObject = GetParentGameObject();
            if (parentGameObject == null) return;
            var parentInteraction = parentGameObject.GetComponent<INpc>();
            _parentInteraction = parentInteraction;
        }

        public void Action()
        {
            _parentInteraction?.Talking();
        }

        private GameObject GetParentGameObject()
        {
            GameObject result = null;
            result = transform.parent.GameObject();
            return result;
        }
    }

}