using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bowling;
namespace BowlingFixtures
{
    [TestClass]
    public class GameFixture
    {
        Game g = new Game();
        [TestMethod]
        public void gutters()
        {
            for (int i = 0; i < 20; i++)
                g.Roll(0);

            Assert.AreEqual(0, g.GetScore());
        }
        [TestMethod]
        public void neitherstrikenorspare()
        {
            g.Roll(5);
            g.Roll(1);
            g.Roll(2);
            g.Roll(1);
            g.Roll(8);
            g.Roll(0);
            g.Roll(3);
            g.Roll(1);
            Assert.AreEqual(21, g.GetScore());
        }

        [TestMethod]
        public void perfectgame()
        {
            for (int i = 0; i < 12; i++)
                g.Roll(10);

            Assert.AreEqual(300, g.GetScore());
        }

       

         [TestMethod]
        public void withsomestrikes()
        {
            g.Roll(5);
            g.Roll(1);
            g.Roll(2);
            g.Roll(3);
            g.Roll(10);
            g.Roll(8);
            g.Roll(0);
            g.Roll(3);
            g.Roll(1);

            Assert.AreEqual(41, g.GetScore());
        }


         [TestMethod]
         public void spareatlast()
         {
             g.Roll(5);
             g.Roll(1);
             g.Roll(2);
             g.Roll(3);
             g.Roll(10);
             g.Roll(8);
             g.Roll(0);
             g.Roll(3);
             g.Roll(7);
             Assert.AreEqual(47, g.GetScore());
         }

         [TestMethod]
         public void allspares()
         {
             g.Roll(3);
             g.Roll(7);
             g.Roll(3);
             g.Roll(7);
             g.Roll(3);
             g.Roll(7);
             g.Roll(3);
             g.Roll(7);
             g.Roll(3);
             g.Roll(7);
             g.Roll(3);
             g.Roll(7);
             g.Roll(3);
             g.Roll(7);
             g.Roll(3);
             g.Roll(7);
             g.Roll(3);
             g.Roll(7);
             g.Roll(3);
             g.Roll(7);
             g.Roll(9);
         

             Assert.AreEqual(136, g.GetScore());
         }
    }

   
}
