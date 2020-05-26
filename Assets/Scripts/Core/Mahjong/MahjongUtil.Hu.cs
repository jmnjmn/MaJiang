using System.Collections.Generic;

namespace Core
{
    public class Hu
    {
        /// <summary>
        /// lt 是按照从小到大排序后的集合
        /// </summary>
        /// <param name="lt"></param>
        /// <returns></returns>
        public static bool IsHu(List<Mahjong> lt, Mahjong p)
        {
            var newLt = new List<Mahjong>(lt.Count + 1);
            newLt.AddRange(lt);
            newLt.Add(p);
            newLt.Sort((a, b) => a.Id - b.Id);
            if (Is7DuiHu(newLt))
            {
                return true;
            }

            return NormalHu(newLt);
        }

        private static bool Is7DuiHu(IReadOnlyList<Mahjong> lt)
        {
            if (lt.Count != 14)
            {
                return false;
            }

            for (int i = 0; i < lt.Count; i += 2)
            {
                if (lt[i] != lt[i + 1])
                {
                    return false;
                }
            }

            return true;
        }

        private static bool NormalHu(List<Mahjong> lt)
        {
            for (int i = 0; i < lt.Count;)
            {
                var p = lt[i];
                var left = lt.FindAll(pai => pai.Id == p.Id);
                if (left.Count > 4)
                {
                    // 放置加入牌以外的牌
                    return false;
                }

                if (left.Count > 1)
                {
                    var newLt = new List<Mahjong>(lt);
                    newLt.RemoveRange(i, left.Count);
                    i += left.Count;
                    if (HuRule(newLt))
                    {
                        return true;
                    }
                }
                else
                {
                    i++;
                }
            }

            return false;
        }

        private static bool HuRule(List<Mahjong> lt)
        {
            if (lt.Count == 0)
            {
                return true;
            }

            var p = lt[0];
            var find = lt.FindAll(pai => pai.Id == p.Id);
            if (find.Count == 3)
            {
                lt.RemoveRange(0, 3);
                return HuRule(lt);
            }

            var next = lt.Find(pai => pai.Id == p.Id + 1);
            var nnext = lt.Find(pai => pai.Id == p.Id + 2);
            if (next != null && nnext != null)
            {
                lt.RemoveAt(0);
                lt.Remove(next);
                lt.Remove(nnext);
                return HuRule(lt);
            }

            return false;
        }
    }
}