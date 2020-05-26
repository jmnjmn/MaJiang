using System.Collections.Generic;
using Core;

namespace Game
{
    public class MahjongPlayer : RoleBase
    {
        public bool IsBanker = false;
        
        private List<Mahjong> _cards = new List<Mahjong>();
    }
}