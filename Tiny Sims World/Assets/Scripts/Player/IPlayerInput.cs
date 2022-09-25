using UnityEngine;

namespace TinySimsWorld.Player
{
    public interface IPlayerInput
    {
        void ReadInput();
        Vector2 Speed { get; }
    }
}