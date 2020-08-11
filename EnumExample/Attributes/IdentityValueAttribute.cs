using System;

namespace EnumExample.Attributes
{
    public sealed class IdentityValueAttribute : Attribute
    {
        private string _value;

        /// <summary>
        /// Значение идентификатора в базе данных
        /// </summary>
        public IdentityValueAttribute(string value)
        {
            this._value = value;
        }
        
        public string Value => _value;
    }
}