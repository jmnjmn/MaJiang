namespace Game
{
    public class RoleBase
    {
        public int RoleId { get; private set; }

        public GlobalDefine.ERoleType RoleType { get; private set; }

        public string HeadIconUrl { get; private set; }

        public string RoleName { get; private set; }
    }
}