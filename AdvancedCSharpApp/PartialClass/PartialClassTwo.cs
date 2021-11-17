using System;

namespace AdvancedCSharpApp.PartialClass
{
    partial class  PartialClass
    {
        partial void testPartialMethod();
        public string GetFullName() {
            return FirstName + " " + LastName;
        }
    }

}
