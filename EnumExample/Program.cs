using System;
using System.Reflection;
using EnumExample.Attributes;
using EnumExample.EnumsWithAttribute;

namespace EnumExample
{
    class Program
    {
        /// <summary>
        /// Получить значение идентификатора базы данных из атрибута
        /// </summary>
        /// <param name="bank"></param>
        /// <returns></returns>
        /// <exception cref="NullReferenceException"></exception>
        public static string GetIdentityValue(Banks bank)
        {
            var type = bank.GetType();

            string identityValue = "";
            foreach(var field in type.GetFields())
            {
                var attribute = field.GetCustomAttribute<IdentityValueAttribute>();

                if (attribute == null)
                {
                    throw new NullReferenceException("Не удалось получить атрибут и его значение");
                }

                identityValue = attribute.Value;
            }

            return identityValue;
        }
        
        static void Main(string[] args)
        {
            
            
            Console.ReadLine();
        }
    }
}