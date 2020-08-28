using System;
using System.Collections.Generic;
using System.Text;

namespace VisibilityPrivateMemberInDerived
{
    public class PrivateVisibilityBase
    {
        private int privateMember = 2020;

        public class PrivateVisibilityDerived : PrivateVisibilityBase
        {
            public int UsePrivateMember()
            {
                return this.privateMember;
            }
        }
    }

    public class NotNestedClass : PrivateVisibilityBase
    {
        //public int UsePrivateMember()
        //{
        //    return this.privateMember;
        //}
    }
}
