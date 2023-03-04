namespace AddOne.Tests;

[TestClass]
public class UnitTest1
{
    private readonly Class1 _test;

    public UnitTest1()
    {
        _test = new Class1();
    }

    [TestMethod]
    public void TestMethod1()
    {
        int[] digits = { 1, 2, 3 };
        int[] result = _test.PlusOne(digits);
        int[] answer = { 1, 2, 4 };

        bool isTrue = true;

        for (int i = 0; i < result.Length; i++)
        {
            if (result[i] != answer[i])
            {
                isTrue= false;
            }
        }

        Assert.IsTrue(isTrue);
    }
    
    [TestMethod]
    public void TestMethod2()
    {
        int[] digits = { 4,3,2,1 };
        int[] result = _test.PlusOne(digits);
        int[] answer = {4,3,2,2};

        bool isTrue = true;

        for (int i = 0; i < result.Length; i++)
        {
            if (result[i] != answer[i])
            {
                isTrue= false;
            }
        }

        Assert.IsTrue(isTrue);
    }
    
    [TestMethod]
    public void TestMethod3()
    {
        int[] digits = { 9 };
        int[] result = _test.PlusOne(digits);
        int[] answer = { 1, 0 };

        bool isTrue = true;


        Assert.IsTrue(isTrue);
    }
}