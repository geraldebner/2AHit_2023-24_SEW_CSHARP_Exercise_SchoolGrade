namespace TestSchool;
using School;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        Student stefan = new Student("Stefan", "Derler", 2, 2008);

        Assert.AreEqual("Stefan", stefan.Firstname);
        Assert.AreEqual("Derler", stefan.Lastname);
        Assert.AreEqual (2, stefan.Month);
        Assert.AreEqual(2008, stefan.Year);
    }
}