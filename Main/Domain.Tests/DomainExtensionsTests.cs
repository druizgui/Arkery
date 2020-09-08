// -----------------------------------------------------------------
// <copyright>Copyright (C) 2020, David Ruiz.</copyright>
// Licensed under the Apache License, Version 2.0.
// You may not use this file except in compliance with the License:
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Software is distributed on an "AS IS", WITHOUT WARRANTIES
// OR CONDITIONS OF ANY KIND, either express or implied.
// -----------------------------------------------------------------

namespace Arkery.Domain.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class DomainExtensionsTests
    {
        const string expected = "Arkery.Domain:Arkery.Domain.DomainKey";

        [TestMethod]
        [Timeout(100)]
        public void KeyDomain_Type()
        {
            var result = typeof(DomainKey).KeyDomain().ToString();
            Console.WriteLine(result);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [Timeout(100)]
        public void KeyDomain_Object()
        {
            var entity = new DomainKey();

            var result = entity.KeyDomain().ToString();
            Console.WriteLine(result);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [Timeout(100)]
        public void FromKeyDomain()
        {
            var entity = new DomainKey();

            var key = entity.KeyDomain();
            var result = key.FromKeyDomain();
            Console.WriteLine(result);
            Assert.AreEqual(typeof(DomainKey), result);
        }
    }
}