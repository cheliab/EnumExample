using System;

namespace EnumExample
{
    /// <summary>
    /// Перечисление которое используется как битовые флаги
    /// </summary>
    [Flags]
    public enum Filters
    {
        None = 0,
        filterOne = 1,
        filterTwo = 2,
        filterThree = 4,
        filterFour = 8
    }
}