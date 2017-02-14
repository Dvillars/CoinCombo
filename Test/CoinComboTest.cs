using Xunit;

namespace CoinCombo.Objects
{
    public class CoinTest
    {
        [Fact]
        public void CoinCount_ConvertInputToCoins_75To3Quarters()
        {
            //Arrange
            int test = 75;
            Coin testCoin = new Coin();

            //Act
            testCoin.SetInput(test);
            string result = testCoin.CoinCount();

            //Assert
            Assert.Equal("3 Quarters ", result);
        }
        [Fact]
        public void CoinCount_ConvertInputToCoins_78To3Quarters()
        {
            int test = 78;
            Coin testCoin = new Coin();

            testCoin.SetInput(test);
            string result = testCoin.CoinCount();

            Assert.Equal("3 Quarters 3 Pennies ", result);
        }
        [Fact]
        public void CoinCount_ConvertInputToCoins_60To1Dimes()
        {
            int test = 60;
            Coin testCoin = new Coin();

            testCoin.SetInput(test);
            string result = testCoin.CoinCount();

            Assert.Equal("2 Quarters 1 Dimes ", result);
        }
        [Fact]
        public void CoinCount_ConvertInputToCoins_67To5Dimes()
        {
            int test = 67;
            Coin testCoin = new Coin();

            testCoin.SetInput(test);
            string result = testCoin.CoinCount();

            Assert.Equal("2 Quarters 1 Dimes 1 Nickels 2 Pennies ", result);
        }
        [Fact]
        public void CoinCount_ConvertInputToCoins_5To1Nickel()
        {
            int test = 5;
            Coin testCoin = new Coin();

            testCoin.SetInput(test);
            string result = testCoin.CoinCount();

            Assert.Equal("1 Nickels ", result);
        }
        [Fact]
        public void CoinCount_ConvertInputToCoins_15To1Nickel()
        {
            int test = 15;
            Coin testCoin = new Coin();

            testCoin.SetInput(test);
            string result = testCoin.CoinCount();

            Assert.Equal("1 Dimes 1 Nickels ", result);
        }
        [Fact]
        public void CoinCount_ConvertInputToCoins_2To2Pennies()
        {
            int test = 2;
            Coin testCoin = new Coin();

            testCoin.SetInput(test);
            string result = testCoin.CoinCount();

            Assert.Equal("2 Pennies ", result);
        }
        [Fact]
        public void CoinCount_ConvertInputToCoins_94To3114()
        {
            int test = 94;
            Coin testCoin = new Coin();

            testCoin.SetInput(test);
            string result = testCoin.CoinCount();

            Assert.Equal("3 Quarters 1 Dimes 1 Nickels 4 Pennies ", result);
        }
    }
}
