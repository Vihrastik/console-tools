﻿using System.Collections.Generic;

namespace ConsoleTools.Binding
{
    /// <summary>
    /// Свойства, специфичные для различных типов аргументов.
    /// </summary>
    public class PropertySpecification
    {
        /// <summary>
        /// Ключ опции.
        /// </summary>
        public PropertyKey Key { get; set; }

        //----------------------------------------------------------------------[]
        /// <summary>
        /// Флаг, равный true, если значение опции является "переключателем" или флагом.
        /// </summary>
        public bool IsSwitch { get; set; }

        //----------------------------------------------------------------------[]
        /// <summary>
        /// Флаг, равный true, если аргумент содержит коллекцию элементов, false для скалярных значений.
        /// </summary>
        public bool IsCollection { get; set; }

        //----------------------------------------------------------------------[]
        /// <summary>
        /// Порядковый номер опции, используемый при связывании позиционных параметров.
        /// </summary>
        public int Position { get; set; }

        //----------------------------------------------------------------------[]
        /// <summary>
        /// Формат элемента при разборе. Для коллекций может указывать формат элементов.
        /// </summary>
        public string Format { get; set; }

        //----------------------------------------------------------------------[]
        /// <summary>
        /// Разделитель элементов коллекций.
        /// </summary>
        public string CollectionItemSeparator { get; set; }

        /// <summary>
        /// Справочник дополнительных спецификаций.
        /// </summary>
        public Dictionary<string, object> Custom { get; private set; }
    }
}
