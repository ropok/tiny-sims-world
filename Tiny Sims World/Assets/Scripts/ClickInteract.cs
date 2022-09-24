using Unity.VisualScripting;
using UnityEngine;

namespace TinySimsWorld
{
    public class ClickInteract : MonoBehaviour
    {
        private Camera _camera;

        private void Start()
        {
            _camera = Camera.main;
        }

        private void Update()
        {
            var clickedGameObject = GetClickableGameObject();
            if (clickedGameObject == null) return;
            if (Input.GetMouseButton(0))
            {
                var interactable = clickedGameObject.GetComponent<IInteractable>();
                interactable?.Interact();
            }
        }

        private GameObject GetClickableGameObject()
        {
            GameObject result = null;
            var ray = _camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hitInfo = Physics2D.Raycast(ray.origin, Vector2.zero);
            if (hitInfo)
            {
                result = hitInfo.transform.gameObject;
            }

            return result;
        }
    }
}