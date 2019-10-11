using DinoDiner.Menu;

using Xunit;
namespace MenuTest.Drinks
{
    public class JurrasicJavaTest
    {




        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            JurassicJava cof = new JurassicJava();
            Assert.Equal<double>(0.59, cof.Price);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            JurassicJava cof = new JurassicJava();
            Assert.Equal<double>(2, cof.Calories);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            JurassicJava cof = new JurassicJava();
            Assert.False(cof.Ice);

        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            JurassicJava cof = new JurassicJava();
            Assert.Equal(Size.Small, cof.Size);

        }





        
        [Fact]
        public void ShouldHaveCorrectPriceForSmall()
        {
            JurassicJava tea = new JurassicJava();
            tea.Size = Size.Small;
            Assert.Equal<double>(.59, tea.Price);


        }

        [Fact]
        public void ShouldHaveCorrectPriceForMedium()
        {
            JurassicJava tea = new JurassicJava();
            tea.Size = Size.Medium;
            Assert.Equal<double>(.99, tea.Price);

        }
        [Fact]
        public void ShouldHaveCorrectPriceForLarge()
        {
            JurassicJava tea = new JurassicJava();
            tea.Size = Size.Large;
            Assert.Equal<double>(1.49, tea.Price);

        }
        [Fact]
        public void ShouldLeaveRoomForCream()
        {
            JurassicJava ch = new JurassicJava();
            ch.LeaveRoomForCream();
            Assert.True(ch.RoomForCream);

        }
        [Fact]
        public void ShouldHaveIce()
        {
            JurassicJava ch = new JurassicJava();
            ch.AddIce();
            Assert.True(ch.Ice);

        }


        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            JurassicJava ch = new JurassicJava();
            Assert.Contains<string>("Coffee", ch.Ingredients);
            Assert.Contains<string>("Water", ch.Ingredients);
            Assert.Equal<int>(2, ch.Ingredients.Count);
          
        }
        


    }
}
