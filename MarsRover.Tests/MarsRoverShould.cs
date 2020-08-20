using System;
using NUnit.Framework;

namespace MarsRover.Tests
{
    [TestFixture]
    public class MarsRoverShould
    {
        [TestCase("N", "E")]
        [TestCase("E", "S")]
        [TestCase("S", "W")]
        [TestCase("W", "N")]
        public void turns_right_north_to_east(string startsFacing, string endsFacing)
        {
            Rover rover = new Rover(startsFacing);
            Assert.AreEqual(endsFacing, rover.Facing);
        }

        [TestCase("N", "W")]
        [TestCase("W", "S")]
        [TestCase("S", "E")]
        [TestCase("E", "N")]
        public void turns_left_anticlockwise(string startsFacing, string endsFacing)
        {
            Rover rover = new Rover(startsFacing);
            Assert.AreEqual(endsFacing, rover.Facing);
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