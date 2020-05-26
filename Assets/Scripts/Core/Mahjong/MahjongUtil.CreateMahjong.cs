using System;
using System.Collections.Generic;

namespace Core
{
    public partial class MahjongUtil
    {
        private const int MahjongCount = 4 * 17 * 2;

        private const int MahjongPlayerCount = 4;

        private static List<Mahjong> _rebackMahjongs = new List<Mahjong>(MahjongCount);

        private static List<Mahjong> _playingMahjongs;

        public static List<Mahjong> CreateMahjongs()
        {
            if (_playingMahjongs == null)
            {
                _playingMahjongs = new List<Mahjong>(MahjongCount);
                // 万条筒
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 1; j < 10; j++)
                    {
                        Mahjong p = new Mahjong();
                        p.Id = i * 10 + j;

                        for (int k = 0; k < 4; k++)
                        {
                            _playingMahjongs.Add(p);
                        }
                    }
                }

                // 东南西北31.33.35.37
                for (int i = 31; i < 39; i += 2)
                {
                    Mahjong p = new Mahjong();
                    p.Id = i;
                    for (int k = 0; k < 4; k++)
                    {
                        _playingMahjongs.Add(p);
                    }
                }

                // 中发白
                for (int i = 41; i < 46; i += 2)
                {
                    Mahjong p = new Mahjong();
                    p.Id = i;
                    for (int k = 0; k < 4; k++)
                    {
                        _playingMahjongs.Add(p);
                    }
                }
            }
            else
            {
                _playingMahjongs.Clear();
                foreach (var mahjong in _rebackMahjongs)
                {
                    _playingMahjongs.Add(mahjong);
                }

                _playingMahjongs.Sort((a, b) => a.Id - b.Id);
                _rebackMahjongs.Clear();
            }

            XiPai(ref _playingMahjongs);
            
            return _playingMahjongs;
        }

        public static void RebackMahjong(Mahjong mahjong)
        {
            _rebackMahjongs.Add(mahjong);
        }

        public static void RebackMahjong(List<Mahjong> mahjongs)
        {
            _rebackMahjongs.AddRange(mahjongs);
        }
    }
}