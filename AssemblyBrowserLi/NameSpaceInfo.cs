using System.Collections.Generic;

namespace AssemblyBrowserLib
{
    public class NameSpaceInfo
    {
        public string Signature { get; set; }
        public List<Container> MemberInfo { get; set; }

        public NameSpaceInfo(string signature)
        {
            MemberInfo = new List<Container>();
            Signature = signature;
        }

        public NameSpaceInfo(List<Container> memberInfo, string signature)
        {
            Signature = signature;
            MemberInfo = memberInfo;
        }
    }
}