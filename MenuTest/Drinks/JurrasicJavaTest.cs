using DinoDiner.Menu;
using DinoDiner.Menu.Drinks;
using Xunit;
namespace MenuTest.Drinks
{
    public class JurrasicJavaTest
    {





        // The correct default price, calories, ice, and size
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            JurrasicJava tea = new JurrasicJava();
            Assert.Equal<double>(.59, tea.Price);
        }







        //The correct price and calories after changing to small, medium, and large sizes.
        [Fact]
        public void ShouldHaveCorrectPriceForSmall()
        {
            JurrasicJava tea = new JurrasicJava();
            tea.Size = Size.Small;
            Assert.Equal<double>(.59, tea.Price);


        }

        [Fact]
        public void ShouldHaveCorrectPriceForMedium()
        {
            JurrasicJava tea = new JurrasicJava();
            tea.Size = Size.Medium;
            Assert.Equal<double>(.99, tea.Price);

        }
        [Fact]
        public void ShouldHaveCorrectPriceForLarge()
        {
            JurrasicJava tea = new JurrasicJava();
            tea.Size = Size.Large;
            Assert.Equal<double>(1.49, tea.Price);

        }
        //That invoking HoldIce() results in the Ice property being false.

        [Fact]
        public void ShouldHaveDefaultPrice()
        {
            JurrasicJava tea = new JurrasicJava();

            Assert.Equal<double>(.59, tea.Price);

        }
        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            JurrasicJava ch = new JurrasicJava();
            Assert.Contains<string>("Coffee", ch.Ingredients);
            Assert.Contains<string>("Water", ch.Ingredients);
            Assert.Equal<int>(2, ch.Ingredients.Count);
          
        }
        [Fact]
        public void ShouldLeaveRoomForCream()
        {
            JurrasicJava ch = new JurrasicJava();
            ch.LeaveRoomForCream();
            Assert.True(ch.RoomForCream);

        }
        [Fact]
        public void ShouldHaveIce()
        {
            JurrasicJava ch = new JurrasicJava();
            ch.AddIce();
            Assert.True(ch.Ice);

        }


    }
}
