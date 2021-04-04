using System;

namespace leave_management.Data
{
    internal class ForeingKeyAttribute : Attribute
    {
        private string v;

        public ForeingKeyAttribute(string v)
        {
            this.v = v;
        }
    }
}