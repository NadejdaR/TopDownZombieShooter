using System;

namespace TDZS.Infrastructure.SceneLoading
{
    public interface ISceneLoader 
    {
        void Load(string sceneName, Action onLoaded = null);
    }
}
