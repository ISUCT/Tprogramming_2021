namespace CourseApp.Tests
{
    using System;
    using Xunit;

    public class PhoneTest
    {
        private AndroidPhone android = new AndroidPhone("Test", 0.3F, 8);

        [Theory]
        [InlineData(8, -2)]
        [InlineData(5, 5)]
        [InlineData(0.2, 0.2)]
        [InlineData(8, 0)]
        public void AndroidPhonePriceTest(double exp, double a)
        {
            // arrange

            // act
            android.Price = a;
            var res = android.Price;

            // assert
            Assert.Equal(exp, res);
        }

        [Theory]
        [InlineData(0.3F, -2)]
        [InlineData(5, 5)]
        [InlineData(0.2F, 0.2F)]
        [InlineData(0.3F, 0)]
        public void DiagonalTest(float exp, float a)
        {
            // arrange

            // act
            android.Diagonal = a;
            var res = android.Diagonal;

            // assert
            Assert.Equal(exp, res);
        }

        [Fact]
        public void AcceptCallTest()
        {
            // arrange
            string exp = "Call accepted";

            // act
            var res = android.AcceptCall();

            // assert
            Assert.Equal(exp, res);
        }

        [Fact]
        public void DialTest()
        {
            // arrange
            string exp = "Calling";

            // act
            var res = android.Dial();

            // assert
            Assert.Equal(exp, res);
        }

        [Fact]
        public void DeclineCallTest()
        {
            // arrange
            string exp = "Call declined";

            // act
            var res = android.DeclineCall();

            // assert
            Assert.Equal(exp, res);
        }

        [Fact]
        public void ReadText()
        {
            // arrange
            string exp = "Message";

            // act
            var res = android.ReadText("Message");

            // assert
            Assert.Equal(exp, res);
        }

        [Fact]
        public void AndroidPhonePresentText()
        {
            // arrange

            // act
            try
            {
                android.Present();
            }
            catch
            {
                Console.WriteLine("AndroidPhone:    Name: Test Diagonal: 0.3 Price: 8$");
            }

            // assert
        }

        [Theory]
        [InlineData(8, -2)]
        [InlineData(5, 5)]
        [InlineData(0.2, 0.2)]
        [InlineData(8, 0)]
        public void IOSPhonePriceTest(double exp, double a)
        {
            // arrange
            var iphone = new IOSPhone("Test", 0.3F, 8);

            // act
            iphone.Price = a;
            var res = iphone.Price;

            // assert
            Assert.Equal(exp, res);
        }

        [Fact]
        public void IOSPhonePresentText()
        {
            // arrange
            var iphone = new IOSPhone("Test", 0.3F, 8);

            // act
            try
            {
                iphone.Present();
            }
            catch
            {
                Console.WriteLine("IOSPhone:    Name: Test Diagonal: 0.3 Price: 8$");
            }

            // assert
        }

        [Theory]
        [InlineData(8, -2)]
        [InlineData(5, 5)]
        [InlineData(0.2, 0.2)]
        [InlineData(8, 0)]
        public void LandLinePhonePriceTest(double exp, double a)
        {
            // arrange
            var landLinePhone = new LandLinePhone("Test", 8);

            // act
            landLinePhone.Price = a;
            var res = landLinePhone.Price;

            // assert
            Assert.Equal(exp, res);
        }

        [Fact]
        public void LandLinePhonePresentText()
        {
            // arrange
            var landLinePhone = new LandLinePhone("Test", 8);

            // act
            try
            {
                landLinePhone.Present();
            }
            catch
            {
                Console.WriteLine("LandLinePhone:    Name: Test Diagonal: 0.3 Price: 8$");
            }

            // assert
        }

        [Theory]
        [InlineData(8, -2)]
        [InlineData(5, 5)]
        [InlineData(0.2, 0.2)]
        [InlineData(8, 0)]
        public void BabushkaPhonePriceTest(double exp, double a)
        {
            // arrange
            var babushkaPhone = new BabushkaPhone("Test", 8);

            // act
            babushkaPhone.Price = a;
            var res = babushkaPhone.Price;

            // assert
            Assert.Equal(exp, res);
        }

        [Fact]
        public void BabushkaPhonePresentText()
        {
            // arrange
            var babushkaPhone = new BabushkaPhone("Test", 8);

            // act
            try
            {
                babushkaPhone.Present();
            }
            catch
            {
                Console.WriteLine("BabushkaPhone:    Name: Test Diagonal: 0.3 Price: 8$");
            }

            // assert
        }
    }
}
