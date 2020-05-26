using Core;
using UnityEngine.SceneManagement;

namespace Game
{
    public class Master : Singleton<Master>
    {
        private IModule _curModule = null;

        public void Create()
        {
            GotoPlay();
        }

        public void Release()
        {
            if (_curModule == null) return;
            _curModule.Release();
            _curModule = null;
        }

        public void Update()
        {
            _curModule?.Update();
        }

        #region 切换模块
        public void GotoInitialize()
        {
            var module = new InitializeModule();
            Switch(module);
        }

        public void GotoLogin()
        {
            var module = new LoginModule();
            Switch(module);
        }

        public void GotoPlay()
        {
            var module = new PlayModule();
            Switch(module);
        }

        private void Switch(IModule module)
        {
            if (_curModule != null)
            {
                _curModule.Release();
                _curModule = null;
            }

            _curModule = module;
            _curModule.Create(this);
        }
        

        #endregion

        #region 场景加载

        public void OnSceneLoaded(Scene scene, LoadSceneMode loadSceneMode)
        {
            _curModule?.OnSceneLoaded(scene, loadSceneMode);
        }
        

        #endregion
        
    }
}