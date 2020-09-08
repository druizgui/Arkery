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

    public static class DomainExtensions
    {
        public static DomainKey KeyDomain(this Type type)
        {
            if (type == null) throw new ArgumentNullException(nameof(type));
            return DomainKey.ToDomainKey(type);
        }

        public static Type FromKeyDomain(this DomainKey domainKey, bool throwOnError = true)
        {
            if (domainKey == null) throw new ArgumentNullException(nameof(domainKey));
            return Type.GetType($"{domainKey.Type}, {domainKey.Source}", throwOnError);
        }

        public static DomainKey KeyDomain(this object entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));
            return entity.GetType().KeyDomain();
        }
    }
}