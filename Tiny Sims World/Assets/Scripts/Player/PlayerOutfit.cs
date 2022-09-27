using System;
using UnityEngine;

namespace TinySimsWorld.Player
{
    public class PlayerOutfit : MonoBehaviour
    {
        [SerializeField] private PlayerOutfits playerOutfits;
        [SerializeField] private SpriteRenderer torsoGameObject;


        private void Update() => torsoGameObject.color = playerOutfits.Color;
            
    }
}