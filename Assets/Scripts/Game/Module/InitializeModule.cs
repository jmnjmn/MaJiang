using UnityEngine.SceneManagement;

namespace Game
{
    public class InitializeModule : IModule
    {
        public Master Master { get; set; }

        public void Create(Master master)
        {
            Master = master;
            Master.GotoLogin();
        }

        public void Release()
        {
        }

        public void Update()
        {
        }

        public void OnSceneLoaded(Scene scene, LoadSceneMode loadSceneMode)
        {
        }
    }
}