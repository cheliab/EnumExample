using System;

namespace EnumExample
{
    
    /// <summary>
    /// Пример использования перечисления как битовых флагов
    /// </summary>
    public class FlagsEnumExample
    {
        public static void Run()
        {
            // Объединение флагов
            Filters allFilters = Filters.filterOne | Filters.filterTwo | Filters.filterThree | Filters.filterFour;
            Console.WriteLine(allFilters);

            // Проверка наличия флага в комбинации
            if ((allFilters & Filters.filterOne) == Filters.filterOne)
            {
                Console.WriteLine("Первый фильтр установлен");
            }
            
            // Другая проверка наличия фильтра
            if (allFilters.HasFlag(Filters.filterTwo))
            {
                Console.WriteLine("Второй флаг установлен");
            }

            // Удаление значения из комбинации
            Filters deleteFilter = Filters.filterFour;
            Filters newFilters = allFilters ^ deleteFilter;
            Console.WriteLine("Новый список фильтров {0}", newFilters);
        }
    }
}