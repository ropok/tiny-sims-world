using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TinySimsWorld
{
    public class PopupButton : MonoBehaviour
    {
        [SerializeField] private List<Canvas> canvasPopups;
        private List<GameObject> _listCanvasPopups = new List<GameObject>();
        private const float Padding = -1f;
        private bool IsPopped;

        private void Awake()
        {
            IsPopped = false;

        }

        public void Popup()
        {
            if (IsPopped) return;
            var position = gameObject.transform.position;
            var paddingCanvas = position.y;
            foreach (var canvasPopup in canvasPopups)
            {
                var canvasPopupObject = Instantiate(canvasPopup, new Vector2(position.x, paddingCanvas), Quaternion.identity);
                paddingCanvas += Padding;
                if(canvasPopup != null)
                    _listCanvasPopups.Add(canvasPopupObject.gameObject);
            }

            IsPopped = true;
        }

        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.E)) Popdown();
        }

        public void Popdown()
        {
            foreach (var listCanvasPopup in _listCanvasPopups)
            {
                Destroy(listCanvasPopup);
                // Debug.Log(listCanvasPopup);
            }
            
            IsPopped = false;
        }
    }
}