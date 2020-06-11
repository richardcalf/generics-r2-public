﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CollectIt.Tests
{
    [TestClass]
    public class DictionaryTests
    {
        [TestMethod]
        public void Can_Use_Dictionary_As_Map()
        {
            var map = new Dictionary<int, string>();
            map.Add(1, "one");
            map.Add(2, "two");

            Assert.AreEqual("one", map[1]);
        }

        [TestMethod]
        public void Can_Search_Key_With_ContainsKey()
        {
            var map = new Dictionary<int, string>();
            map.Add(1, "one");
            map.Add(2, "two");

            Assert.IsTrue(map.ContainsKey(2));
        }

        [TestMethod]
        public void Can_Remove_By_Key()
        {
            var map = new Dictionary<int, string>();
            map.Add(1, "one");
            map.Add(2, "two");

            map.Remove(1);

            Assert.AreEqual(1, map.Count);
        }
    }
}
