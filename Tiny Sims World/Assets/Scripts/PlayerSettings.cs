using UnityEngine;

namespace TinySimsWorld
{
    [CreateAssetMenu(fileName = "PlayerData", menuName = "Player/Settings", order = 0)]
    public class PlayerSettings : ScriptableObject
    {
        [SerializeField] private float moveSpeed = 10f;
        
        
        public float MoveSpeed => moveSpeed;
    }
}