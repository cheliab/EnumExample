using System;

namespace EnumExample.Attributes
{
    /// <summary>
    /// Значение идентификатора в базе данных
    /// </summary>
    public sealed class IdentityValueAttribute : Attribute
    {
        private string _value;

        public IdentityValueAttribute(string value)
        {
            this._value = value;
        }
        
        public string Value => _value;
    }
}