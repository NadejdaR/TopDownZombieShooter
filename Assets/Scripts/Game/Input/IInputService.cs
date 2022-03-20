using UnityEngine;
using TDZS.Infrastructure.Services;

namespace TDZS.Game.Input
{
    public interface IInputService : IService
    {
        Vector2 Axis { get; }
        Vector3 MousePosition { get; } // TODO: Change to V2 LookDirection

        bool IsFireButtonClicked();
    }
}
