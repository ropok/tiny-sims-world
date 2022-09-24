using System;
using UnityEngine;

namespace TinySimsWorld
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private PlayerSettings playerSettings;

        private IPlayerInput _playerInput;
        private PlayerMovement _playerMovement;

        private void Awake()
        {
            _playerInput = new ControllerInput();
            _playerMovement = new PlayerMovement(_playerInput, transform, playerSettings);
        }

        private void Update()
        {
            _playerInput.ReadInput();
            _playerMovement.Move();
        }
    }
}