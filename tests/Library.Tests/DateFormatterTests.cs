namespace TestDateFormat;

public class Tests
{
    [Test]
    public void TestCorrectDateFormat()
    {
        string testDate = "10/11/1997";
        string expectedDate = "1997-11-10";

        Assert.That(DateFormatter.ChangeFormat(testDate), Is.EqualTo(expectedDate));
    }
}