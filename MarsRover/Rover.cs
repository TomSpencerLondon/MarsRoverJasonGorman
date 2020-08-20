using System;
using System.Collections;

namespace MarsRover.Tests
{
    public class Rover
    {
        private string _facing;
        public char Facing;
        public int[] Position;

        public Rover(string facing)
        {
            _facing = facing;
        }

        public Rover(char facing, int[] position)
        {
            Facing = facing;
            Position = position;
        }

        public void Right()
        {
            Turn(new[] {"N", "E", "S", "W"});
        }

        public void Left()
        {
            Turn(new[] {"N", "W", "S", "E"});
        }

        private void Turn(string[] compass)
        {
            int current = Array.IndexOf(compass, Facing);
            Facing = compass[(current + 1) % 4];
        }

        public void Forward()
        {
            Move(new[] {new[] {0, 1}, new[] {1, 0}, new[] {0, -1}, new[] {-1, 0}});
        }

        public void Back()
        {
            Move(new[] { new[]{0, -1}, new []{-1, 0}, new[]{0, 1}, new []{1, 0}});
        }

        public void Move(int[][] vectors)
        {
            int facing = Array.IndexOf(new[] {"N", "E", "S", "W"}, Facing);
            int[] vector = vectors[facing];
            Position[0] += vector[0];
            Position[1] += vector[1];
        }

        public Action FindAction(char instruction)
        {
            return new DictionaryEntry<char, Action>()
            {
                {'R', Right },
                {'L', Left },
                {'F', Forward },
                {'B', Back }
            }
        }

        public void Go(string instruction)
        {
            throw new System.NotImplementedException();
        }
    }
}