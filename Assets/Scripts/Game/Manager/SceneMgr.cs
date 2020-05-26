using Core;
using UnityEngine.SceneManagement;

namespace Game
{
    public class SceneMgr : Singleton<SceneMgr>
    {
        public void LoadScene(string sceneName)
        {
            SceneManager.sceneLoaded += OnSceneLoaded;
        }

        private void OnSceneLoaded(Scene scene, LoadSceneMode loadSceneMode)
        {
            Master.Instance.OnSceneLoaded(scene, loadSceneMode);
        }
    }
}