namespace CourseApp.Tests
{
    using Xunit;

    public class TaskTest
    {
        [Fact]
        public void Test1()
        {
            var a = 1.2;
            var b = 0.48;
            var x = 0.7;
            var expected = 0.326;
            var actual = new Test().Calculate(a, b, x);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test2()
        {
            var a = 1.2;
            var b = 0.48;
            var x = 1;
            var expected = 0.584;
            var actual = new Test().Calculate(a, b, x);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test3()
        {
            var a = 1.2;
            var b = 0.48;
            var x = 1.3;
            var expected = 0.968;
            var actual = new Test().Calculate(a, b, x);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test4()
        {
            var a = 1.2;
            var b = 0.48;
            var x = 1.6;
            var expected = double.NaN;
            var actual = new Test().Calculate(a, b, x);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test5()
        {
            var a = 1.2;
            var b = 0.48;
            var x = 1.9;
            var expected = double.NaN;
            var actual = new Test().Calculate(a, b, x);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test6()
        {
            var a = 1.2;
            var b = 0.48;
            var x = 2.2;
            var expected = double.NaN;
            var actual = new Test().Calculate(a, b, x);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test7()
        {
            var a = 1.2;
            var b = 0.48;
            var x = 0.25;
            var expected = 0.082;
            var actual = new Test().Calculate(a, b, x);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test8()
        {
            var a = 1.2;
            var b = 0.48;
            var x = 0.36;
            var expected = 0.122;
            var actual = new Test().Calculate(a, b, x);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test9()
        {
            var a = 1.2;
            var b = 0.48;
            var x = 0.56;
            var expected = 0.229;
            var actual = new Test().Calculate(a, b, x);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test10()
        {
            var a = 1.2;
            var b = 0.48;
            var x = 0.94;
            var expected = 0.527;
            var actual = new Test().Calculate(a, b, x);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test11()
        {
            var a = 1.2;
            var b = 0.48;
            var x = 1.28;
            var expected = 0.93;
            var actual = new Test().Calculate(a, b, x);
            Assert.Equal(expected, actual);
        }
    }
}
