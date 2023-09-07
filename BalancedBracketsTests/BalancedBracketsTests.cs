namespace BalancedBracketsTests;
using BalancedBrackets;

[TestClass]
public class BalancedBracketsTests
{
    // TODO: Add tests to this file.
    [TestMethod]
    public void HasBalancedBrackets_ReturnTrue()
    {
        string[] toBeTrue = { "", "[]", "[LaunchCode]", "Launch[Code]", "[Launch][Code]", "[Launch[Code]]", "[Lau[ch[Code]]]" };
        for (int i = 0; i < toBeTrue.Length; i++)
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(toBeTrue[i]));
        }
    }

    [TestMethod]
    public void HasBalancedBrackets_ReturnFalse()
    {
        string[] toBeFalse = { "[", "]", "][", "]LaunchCode[", "[LaunchCode[", "[Launch][Code", "[Launch[Code]" };
        for (int i = 0; i < toBeFalse.Length; i++)
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets(toBeFalse[i]));
        }
    }
    //[TestMethod]
    //public void EmptyTest()
    //{
    //    Assert.AreEqual(true, true);
    //}

    //[TestMethod]
    //public void HasBalancedBrackets_WithOnlyBrackets_IsTrue()
    //{
    //    Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
    //}

    //[TestMethod]
    //public void HasBalancedBrackets_WithDoubleBrackets_IsTrue()
    //{
    //    Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[][]"));
    //}

    //[TestMethod]
    //public void HasBalancedBrackets_WithNestedBrackets_IsTrue()
    //{
    //    Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[[]]"));
    //}

    //[TestMethod]
    //public void HasBalancedBrackets_WithNestedDoubleBrackets_IsTrue()
    //{
    //    Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[[[]]]"));
    //}

    //[TestMethod]
    //public void HasBalancedBrackets_WithCharactersWithInBrackets_IsTrue()
    //{
    //    Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("Launch[Code]"));
    //}

    //[TestMethod]
    //public void HasBalancedBrackets_NotBalancedBrackets_IsFalse()
    //{
    //    Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]["));
    //    //this is where it fails but should pass.
    //}

    //[TestMethod]
    //public void HasBalancedBrackets_VeryNot()
    //{
    //    Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[["));
    //}
}
