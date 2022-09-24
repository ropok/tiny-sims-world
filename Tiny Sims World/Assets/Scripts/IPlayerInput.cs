using UnityEngine;

namespace TinySimsWorld
{
    public interface IPlayerInput
    {
        void ReadInput();
        Vector2 Speed { get; }
    }
}