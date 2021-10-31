using System;
using Xunit;
using TableProj;

namespace TestTable
{
    public class TestTable
    {
        [Fact]
        public void emptyConstructor_SetWidth0_Heigth0()
        {
            Table table = new Table();

            int width = table.width;
            int height = table.height;

            Assert.Equal(0, width);
            Assert.Equal(0, height);
        }

        [Fact]
        public void constructor_WithWidthAndHeight_SetWidthAndHeight()
        {
            Table table = new Table(25, 25);

            int width = table.width;
            int height = table.height;

            Assert.Equal(25, width);
            Assert.Equal(25, height);
        }

        [Fact]
        public void emptyConstructor_ReturnsArea0()
        {
            Table table = new Table();

            int result = table.areaOfTable();

            Assert.Equal(0, result);
        }

        [Fact]
        public void width25_AndHeight25_ReturnsArea625()
        {
            Table table = new Table(25, 25);

            int width = table.width;
            int height = table.height;

            int result = table.areaOfTable();

            Assert.Equal(width * height, result);
        }

        [Fact]
        public void isDishedOnTheTable_ReturnsTrueOrFalse()
        {
            Table table = new Table();

            bool result = table.isDishedOnTheTable();

            if(result == true)
            {
                Assert.True(result);
            }
            else
            {
                Assert.False(result);
            }
        }
    }
}
