using UnityEngine;

namespace TinySimsWorld.Player
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private PlayerSettings playerSettings;
        [SerializeField] private Animator animator;

        private IPlayerInput _playerInput;
        private PlayerMovement _playerMovement;
        private static readonly int Horizontal = Animator.StringToHash("Horizontal");
        private static readonly int Vertical = Animator.StringToHash("Vertical");
        private static readonly int Magnitude = Animator.StringToHash("Magnitude");

        private void Awake()
        {
            _playerInput = new ControllerInput();
            _playerMovement = new PlayerMovement(_playerInput, transform, playerSettings);
        }

        private void Update()
        {
            _playerInput.ReadInput();
            _playerMovement.Move();
            
            animator.SetFloat(Horizontal, _playerInput.Speed.x);
            animator.SetFloat(Vertical, _playerInput.Speed.y);
            animator.SetFloat(Magnitude, _playerInput.Speed.magnitude);
            
        }

    }
}