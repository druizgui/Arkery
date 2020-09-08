// -----------------------------------------------------------------
// <copyright>Copyright (C) 2020, David Ruiz.</copyright>
// Licensed under the Apache License, Version 2.0.
// You may not use this file except in compliance with the License:
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Software is distributed on an "AS IS", WITHOUT WARRANTIES
// OR CONDITIONS OF ANY KIND, either express or implied.
// -----------------------------------------------------------------

namespace Arkery.Domain
{
    using System;

    public class DomainKey
    {
        public string Source { get; set; }
        public string Type { get; set; }

        public static explicit operator DomainKey(Type type)
        {
            return ToDomainKey(type);
        }

        public static DomainKey ToDomainKey(Type type)
        {
            if (type == null) throw new ArgumentNullException(nameof(type));

            return new DomainKey
            {
                Type = $"{type.Namespace}.{type.Name}",
                Source = type.Assembly.GetName(true).Name
            };
        }

        public override string ToString()
        {
            return $"{Source}:{Type}";
        }
    }
}