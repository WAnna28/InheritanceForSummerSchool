using System;
using System.Collections.Generic;
using System.Text;

namespace VisibilityPublicMemberInDerived
{
    public class PublicVisibilityBase
    {
        public void PublicMethod()
        {
            // Method implementation.
        }
    }

    public class PublicVisibilityDerived : PublicVisibilityBase
    {     
    }
}
