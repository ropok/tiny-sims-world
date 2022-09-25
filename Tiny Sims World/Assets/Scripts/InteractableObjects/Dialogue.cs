using UnityEngine;

namespace TinySimsWorld.InteractableObjects
{
    [System.Serializable]
    public class Dialogue : MonoBehaviour
    {
        public string name;

        [TextArea(3, 10)] public string sentence;
    }
}