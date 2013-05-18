using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KataTrigrams;

namespace KataTrigrams.Test
{  
    [TestClass]
    public class TrigramsTest
    {
        private string inputText;
        Trigram trigram;

        [TestInitialize]
        public void SetUp()
        {
            inputText = " I may You wish I may I wish I might";
            trigram = Analizer.Extract(inputText);
        }
      
        [TestMethod]
        public void Trigram_Contains_key()
        {
            string key = trigram.GetKey("I may");

            Assert.AreEqual("I may", key);           
        }

        [TestMethod]
        public void Trigram_Contains_keys()
        {
            string key1 = trigram.GetKey("I may");
            string key2 = trigram.GetKey("may I");

            Assert.AreEqual("I may", key1);
            Assert.AreEqual("may I", key2);
        }


        [TestMethod]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void Trigram_Not_Contains_key()
        {
            string key = trigram.GetKey("I might");          
        }

        [TestMethod]
        public void Trigram_Key_Contains_Value()
        {
            string key1 = trigram.GetKey("I may");

            Values values = trigram.GetValues(key1);

            Assert.IsTrue(values.Contains("I"));        
        }

        [TestMethod]
        public void Trigram_Key_Contains_Values()
        {
            string key1 = trigram.GetKey("I may");

            Values values = trigram.GetValues(key1);

            Assert.IsTrue(values.Contains("I"));
            Assert.IsTrue(values.Contains("You"));
        }
    }    
}
