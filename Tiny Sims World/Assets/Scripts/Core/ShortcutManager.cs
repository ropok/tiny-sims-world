using System;
using UnityEngine;

namespace TinySimsWorld.Core
{
    public class ShortcutManager : MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.F12)) Application.Quit();
        }
    }
}