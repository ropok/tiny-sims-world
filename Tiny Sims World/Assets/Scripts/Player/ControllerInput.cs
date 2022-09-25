using UnityEngine;

namespace TinySimsWorld.Player
{
    public class ControllerInput : IPlayerInput
    {
        public void ReadInput()
        {
            var moveX = Input.GetAxis("Horizontal");
            var moveY = Input.GetAxis("Vertical");
            Speed = new Vector2(moveX, moveY);
        }
        
        public Vector2 Speed { get; private set; }
    }
}