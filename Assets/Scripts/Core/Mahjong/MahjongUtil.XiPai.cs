using System;
using System.Collections.Generic;

namespace Core
{
    public partial class MahjongUtil
    {
        private static void XiPai(ref List<Mahjong> lt)
        {
            Random rd = new Random();
            for (int i = MahjongCount; i > 0; i--)
            {
                int r = rd.Next(0, i);
                var t = lt[r];
                lt[r] = lt[i - 1];
                lt[i - 1] = t;
            }
        }
        
//        private static void FaPai()
//        {
//            // 起手三圈
//            int m = 0;
//            for (int i = 0; i < 3; i++)
//            {
//                for (int j = 0; j < PlayCount; j++)
//                {
//                    var r = _ltPai.GetRange(m * 4, 4);
//                    _ltPlayer[j].Pais.AddRange(r);
//                    m++;
//                }
//
//                Console.WriteLine();
//            }
//
//            // 跳牌
//            int single = 3 * 4 * 4;
//            for (int i = 0; i < PlayCount; i++)
//            {
//                _ltPlayer[i].Pais.Add(_ltPai[single + i]);
//            }
//
//            _ltPai.RemoveRange(0, 4 * 13);
//
//            for (int i = 0; i < _ltPlayer.Count; i++)
//            {
//                _ltPlayer[i].Pais.ForEach(pai => Console.Write(pai.Id + "、"));
//
//                Console.WriteLine("");
//            }
//        }
    }
}