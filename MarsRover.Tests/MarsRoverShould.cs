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

        [TestCase('R', "Right")]
        [TestCase('L', "Left")]
        [TestCase('F', "Forward")]
        [TestCase('B', "Back")]
        public void finds_action_for_instruction(char instruction, string methodName)
        {
            Assert.AreEqual(methodName, new Rover(null, null).FindAction(instruction).Method.Name);
        }

        [Test]
        public void executes_sequence_of_instructions()
        {
            Rover rover = new Rover("N", new[] {5, 5});
            rover.Go("RFF");
            Assert.AreEqual("E", rover.Facing);
            Assert.AreEqual(new []{7, 5}, rover.Position);
        }
    }
}