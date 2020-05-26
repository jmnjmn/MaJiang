using System.Collections.Generic;
using Core;
using UnityEngine.SceneManagement;

namespace Game
{
    public class PlayModule : IModule
    {
        public Master Master { get; set; }

        private MahjongPlayer[] _players = new MahjongPlayer[4];

        private List<Mahjong> _mahjongs;
        
        public void Create(Master master)
        {
            Master = master;
            CreatePlayers();
            CreateMahjongs();
            LoadPlayScene();
        }

        public void Release()
        {
        }

        public void Update()
        {
        }

        public void OnSceneLoaded(Scene scene, LoadSceneMode loadSceneMode)
        {
            //TODO play start animation
            //TODO play fapai animation
            
        }


        private void LoadPlayScene()
        {
            SceneManager.LoadScene("mahjong_table");
        }

        private void CreatePlayers()
        {
            for (int i = 0; i < _players.Length; i++)
            {
                _players[i] = new MahjongPlayer();
            }
        }

        private void CreateMahjongs()
        {
            _mahjongs = MahjongUtil.CreateMahjongs();
        }
    }
}