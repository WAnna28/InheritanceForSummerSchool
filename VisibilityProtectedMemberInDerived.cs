using System;
using System.Collections.Generic;
using System.Text;

namespace VisibilityProtectedMemberInDerived
{
    public class ProtectedVisibilityBase
    {
        protected string protectedMember = "8/27/2020";        
    }

    public class ProtectedVisibilityDerived : ProtectedVisibilityBase
    {
        public string UseProtectedMember()
        {
            return this.protectedMember;
        }
    }
}
