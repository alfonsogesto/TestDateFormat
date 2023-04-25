using NUnit.Framework;
using TestDateFormat;

namespace Library.Tests;

public class DateFormatterTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestDateCorrectFormat()
    {
        const string input = "05/11/2000";
        const string expected = "05-11-2000";

        string actual = DateFormatter.ChangeFormat(input);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void TestDateWrongFormat()
    {
        const string input  = "31/05/2020";
        const string expected = "31-05-2020";

        string actual2 = DateFormatter.ChangeFormat(input);

        Assert.That(actual2, Is.EqualTo(expected));
    }

    [Test]
    public void TestDateFormatNoDate()
    {
     const string input = "";
     const string expected = "";

     string actual3 = DateFormatter.ChangeFormat(input);

     Assert.That(actual3, Is.EqualTo(expected));   
    }
}