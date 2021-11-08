using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Jenkins.CoreApp;

namespace Jenkins.TestApp
{
    [TestClass]
    public class  UnitRuleLogicTest
    {
        RuleLogic  objRulelogic= new RuleLogic();

       [DataTestMethod]       
       [DataRow(5,5,10)]
       [DataRow(12, 8, 20)]       
        public void ValidateAdd(int a ,int b ,int expeted)
        {
            var actual = objRulelogic.Sumlogic(a, b);

            Assert.AreEqual(expeted, actual, "Not matching ,rule got failed");
        }
    }
}
