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
    using Newtonsoft.Json;

    [TestClass]
    public class DomainTests
    {
        [TestMethod]
        public void Entity_Ctor_Id()
        {
            var entity = new ExampleEntity();
            Console.WriteLine(JsonConvert.SerializeObject(entity, Formatting.Indented));
            Assert.AreNotEqual(Guid.Empty, entity.Id);
        }

        [TestMethod]
        public void Entity_Ctor_Id_Empty()
        {
            var entity = new ExampleEntityEmpty();
            Console.WriteLine(JsonConvert.SerializeObject(entity, Formatting.Indented));
            Assert.AreEqual(Guid.Empty, entity.Id);
        }

        public class ExampleEntity : Entity
        {
            public ExampleEntity()
            {
            }
        }

        public class ExampleEntityEmpty : Entity
        {
            public ExampleEntityEmpty() : base(false)
            {
            }
        }
    }
}