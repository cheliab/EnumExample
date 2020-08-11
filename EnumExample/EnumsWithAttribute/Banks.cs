using EnumExample.Attributes;

namespace EnumExample.EnumsWithAttribute
{
    /// <summary>
    /// Банки
    /// </summary>
    public enum Banks
    {
        /// <summary>
        /// Неизвестно
        /// </summary>
        [IdentityValue("0000")]
        Unknown,
        
        /// <summary>
        /// Альфа-Банк
        /// </summary>
        [IdentityValue("0001")]
        AlfaBank = 1,
        
        /// <summary>
        /// Сбербанк
        /// </summary>
        [IdentityValue("0002")]
        Sberbank = 2,
        
        /// <summary>
        /// Тинькофф банк
        /// </summary>
        [IdentityValue("0003")]
        TinkoffBank = 3
    }
}