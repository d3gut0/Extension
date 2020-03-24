using System;

namespace Domain
{
    public class StringValue : Attribute
    {
        public string Value { get; private set; }
        public StringValue(string value)
        {
            Value = value;
        }
    }
}
