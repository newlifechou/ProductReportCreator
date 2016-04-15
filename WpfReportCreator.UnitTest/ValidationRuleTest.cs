using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfReportCreator.Resource.ValidationRules;
using System.Windows.Controls;

namespace WpfReportCreator.UnitTest
{
    [TestClass]
    public class ValidationRuleTest
    {
        [TestMethod]
        public void TestRequiredRuleEmpty()
        {
            RequiredRule rule = new RequiredRule();
            string input = "";
            ValidationResult result = rule.Validate(input, null);
            Assert.IsFalse(result.IsValid);
        }

        [TestMethod]
        public void TestRequiredRuleNotEmpty()
        {
            RequiredRule rule = new RequiredRule();
            string input = "hello world";
            ValidationResult result = rule.Validate(input, null);
            Assert.IsFalse(result.IsValid);
        }
    }
}
