namespace EnumExample
{
    // Явно указываем тип для перечисления
    
    /// <summary>
    /// Время дня
    /// </summary>
    public enum Time : byte
    {
        Morning,
        Afternoon,
        Evening,
        Night
    }
}