using UnityEngine.SceneManagement;

namespace Game
{
    public class LoginModule : IModule
    {
        public Master Master { get; set; }

        public void Create(Master master)
        {
            Master = master;
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