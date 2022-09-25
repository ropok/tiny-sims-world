using UnityEngine;

namespace TinySimsWorld
{
    public class ButtonTalk : MonoBehaviour, IButtonAction
    {
        public void Action()
        {
            Talk("Hellow, my name is Cici!");
        }

        private void Talk(string dialogue)
        {
            Debug.Log(dialogue);
        }
    }
}