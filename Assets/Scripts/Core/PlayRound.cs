using System;
using System.Collections.Generic;

namespace mj
{
    public class PlayRound
    {
        private static List<Pai> _ltPai;

        private const int PlayCount = 4;

        private static List<Player> _ltPlayer;

        public static void Start()
        {
            CreatPai();

            XiPai.Xi(ref _ltPai);

            CreatePlayers();

            FaPai();
        }

        private static void CreatPai()
        {
            _ltPai = new List<Pai>(17 * 4 * 2);
            // 万条筒
            for (int i = 0; i < 3; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Pai p = new Pai();
                    p.Id = i * 10 + j;

                    for (int k = 0; k < 4; k++)
                    {
                        _ltPai.Add(p);
                    }
                }
            }

            // 东南西北31.33.35.37
            for (int i = 31; i < 39; i += 2)
            {
                Pai p = new Pai();
                p.Id = i;
                for (int k = 0; k < 4; k++)
                {
                    _ltPai.Add(p);
                }
            }

            // 中发白
            for (int i = 41; i < 46; i += 2)
            {
                Pai p = new Pai();
                p.Id = i;
                for (int k = 0; k < 4; k++)
                {
                    _ltPai.Add(p);
                }
            }
        }

        private static void CreatePlayers()
        {
            _ltPlayer = new List<Player>(PlayCount);
            for (int i = 0; i < PlayCount; i++)
            {
                Player p = new Player();
                p.Id = i;
                _ltPlayer.Add(p);
            }
        }

        private static void FaPai()
        {
            // 起手三圈
            int m = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < PlayCount; j++)
                {
                    var r = _ltPai.GetRange(m * 4, 4);
                    _ltPlayer[j].Pais.AddRange(r);
                    m++;
                }

                Console.WriteLine();
            }

            // 跳牌
            int single = 3 * 4 * 4;
            for (int i = 0; i < PlayCount; i++)
            {
                _ltPlayer[i].Pais.Add(_ltPai[single + i]);
            }

            _ltPai.RemoveRange(0, 4 * 13);

            for (int i = 0; i < _ltPlayer.Count; i++)
            {
                _ltPlayer[i].Pais.ForEach(pai => Console.Write(pai.Id + "、"));

                Console.WriteLine("");
            }
        }
    }
}