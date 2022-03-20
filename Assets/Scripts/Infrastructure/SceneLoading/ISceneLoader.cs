using System;
using TDZS.Infrastructure.Services;

namespace TDZS.Infrastructure.SceneLoading
{
    public interface ISceneLoader : IService
    {
        void Load(string sceneName, Action onLoaded = null);
    }
}
