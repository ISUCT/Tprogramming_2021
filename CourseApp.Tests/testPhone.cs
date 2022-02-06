
using Xunit;

public class testPhone{

    [Fact]
    public void sumOfNumberInts_Return_58(){
        Phone phone = new Phone("89290880518");

        int expectedNumber = 58;
        int resNumber = phone.sumOfNumberInts();

        Assert.Equal(expectedNumber, resNumber);
    }

    [Fact]
    public void callJohn_Mike_classNumber(){
        Phone phone = new Phone("89290880518");

        string John = "John";
        string Mike = "Mike";

        string expectedString = phone.callSomebody(John, Mike);
        string resString = $"John called Mike, with {phone.getPhoneNumber()}";

        Assert.Equal(expectedString, resString);
    }
}