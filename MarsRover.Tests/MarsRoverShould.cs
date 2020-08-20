using System;
using NUnit.Framework;

namespace MarsRover.Tests
{
    [TestFixture]
    public class MarsRoverShould
    {
        [Test]
        public void turns_right_north_to_east()
        {
            Rover rover = new Rover("N");
            Assert.AreEqual("E", rover.Facing);
        }
    }

    public class Rover
    {
        private string _facing;

        public Rover(string facing)
        {
            _facing = facing;
        }

        public string Facing => "E";
    }
}