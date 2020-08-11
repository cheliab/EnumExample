namespace EnumExample
{
    /// <summary>
    /// Пример с одинаковыми значениями в перечислении
    /// </summary>
    public enum Color
    {
        White = 1,
        Black = 2,
        Green = 2,
        Blue = White // Blue = 1
    }
}