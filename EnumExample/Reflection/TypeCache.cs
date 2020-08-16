using System;
using System.Collections.Concurrent;
using System.Reflection;

namespace EnumExample.Reflection
{
    /// <summary>
    /// Кэшируем публичные свойства
    /// </summary>
    public class TypeCache
    {
        /// <summary>
        /// Кэш полученных типов
        /// </summary>
        private static ConcurrentDictionary<Type, TypeCache> _typeCache = new ConcurrentDictionary<Type, TypeCache>();
        
        /// <summary>
        /// Публичные поля
        /// </summary>
        public ConcurrentDictionary<string, FieldInfo> Fields { get; private set; }

        /// <summary>
        /// Получить кэш заданного типа
        /// </summary>
        /// <param name="type">Кэшируемый тип</param>
        /// <returns>Кэш типа</returns>
        public static TypeCache Get(Type type)
        {
            TypeCache typeCache;

            if (!TypeCache._typeCache.TryGetValue(type, out typeCache))
            {
                typeCache = new TypeCache(type);
                TypeCache._typeCache[type] = typeCache;
            }

            return typeCache;
        }

        /// <summary>
        /// Получение значений полей
        /// </summary>
        /// <param name="type"></param>
        private TypeCache(Type type)
        {
            Fields = new ConcurrentDictionary<string, FieldInfo>();

            var fieldInfos = type.GetFields();

            foreach (var fieldInfo in fieldInfos)
            {
                Fields[fieldInfo.Name] = fieldInfo;
            }
        }
    }
}