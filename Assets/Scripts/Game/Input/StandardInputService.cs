using UnityEngine;

namespace TDZS.Game.Input
{
    public class StandardInputService : IInputService
    {
        public Vector2 Axis =>
            new Vector2(UnityEngine.Input.GetAxis("Horizontal"), UnityEngine.Input.GetAxis("Vertical"));
        public Vector3 MousePosition => UnityEngine.Input.mousePosition;

        public bool IsFireButtonClicked() =>
            UnityEngine.Input.GetButtonDown("Fire1");
    }
}
