using System;
using System.Reflection;
using EnumExample.Attributes;
using EnumExample.EnumsWithAttribute;
using EnumExample.Reflection;

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
                if (bank.ToString() == field.Name)
                {
                    var attribute = field.GetCustomAttribute<IdentityValueAttribute>();

                    if (attribute == null)
                    {
                        throw new NullReferenceException("Не удалось получить атрибут и его значение");
                    }

                    identityValue = attribute.Value;
                }
            }

            return identityValue;
        }

        /// <summary>
        /// Получить значение идентификаторв базы данных из кэша
        /// </summary>
        /// <param name="bank"></param>
        /// <returns></returns>
        public static string GetIdentityValueFromCache(Banks bank)
        {
            Type type = bank.GetType();
            
            TypeCache typeCache = TypeCache.Get(type);

            string identityValue = "";
            foreach (var field in typeCache.Fields)
            {
                if (bank.ToString() == field.Key)
                {
                    var attribute = field.Value.GetCustomAttribute<IdentityValueAttribute>();

                    if (attribute == null)
                    {
                        throw new NullReferenceException("Не удалось получить атрибут и его значение");
                    }

                    identityValue = attribute.Value;
                }
            }

            return identityValue;
        } 
        
        static void Main(string[] args)
        {
            string identityValueSberbank = GetIdentityValue(Banks.Sberbank);

            Console.WriteLine(identityValueSberbank);
            
            Console.WriteLine(new string('-', 20));

            string idValueFromChache = GetIdentityValueFromCache(Banks.TinkoffBank);
            
            Console.WriteLine(idValueFromChache);
            
            Console.WriteLine(new string('-', 20));
            
            FlagsEnumExample.Run();
            
            Console.ReadLine();
        }
    }
}