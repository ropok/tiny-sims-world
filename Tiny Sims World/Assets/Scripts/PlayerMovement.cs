using UnityEngine;

namespace TinySimsWorld
{
    public class PlayerMovement
    {
        private readonly IPlayerInput playerInput;
        private readonly Transform transformToMove;
        private readonly PlayerSettings playerSettings;

        private float moveSpeed;

        public PlayerMovement(IPlayerInput playerInput, Transform transformToMove, PlayerSettings playerSettings)
        {
            this.playerInput = playerInput;
            this.transformToMove = transformToMove;
            this.playerSettings = playerSettings;
        }

        public void Move()
        {
            var position = transformToMove.position;
            position +=
                transformToMove.right * (playerInput.Speed.x * Time.deltaTime * playerSettings.MoveSpeed);
            position +=
                transformToMove.up * (playerInput.Speed.y * Time.deltaTime * playerSettings.MoveSpeed);
            transformToMove.position = position;
        }
    }
}