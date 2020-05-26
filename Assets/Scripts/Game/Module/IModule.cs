using UnityEngine.SceneManagement;

namespace Game
{
    public interface IModule
    {
        Master Master { get; set; }

        void Create(Master master);

        void Release();

        void Update();

        void OnSceneLoaded(Scene scene, LoadSceneMode loadSceneMode);
    }
}