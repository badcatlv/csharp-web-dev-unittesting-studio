namespace BalancedBracketsTests;
using BalancedBrackets;

[TestClass]
public class BalancedBracketsTests
{
    // TODO: Add tests to this file.

    [TestMethod]
    public void EmptyTest()
    {
        Assert.AreEqual(true, true);
    }

    [TestMethod]
    public void HasBalancedBrackets_WithOnlyBrackets_IsTrue()
    {
        Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
    }

    [TestMethod]
    public void HasBalancedBrackets_WithDoubleBrackets_IsTrue()
    {
        Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[][]"));
    }

    [TestMethod]
    public void HasBalancedBrackets_WithNestedBrackets_IsTrue()
    {
        Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[[]]"));
    }

    [TestMethod]
    public void HasBalancedBrackets_WithNestedDoubleBrackets_IsTrue()
    {
        Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[[][]]"));
    }

    [TestMethod]
    public void HasBalancedBrackets_BracketsWithCharactersWithInBrackets_IsTrue()
}
