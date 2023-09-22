/*
 * A feladat a github-on olvasható!
 */

using System;

namespace WarriorProject
{

    public class Position
    {
        private int x; 
        private int y;

        public int Xxd { get { return x; } }
        public int Yxd { get { return y; } }

        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void ToConsole()
        {
            Console.WriteLine($"({x},{y})");
        }
    
    }

    public class Warrior
    {
        public string name;
        public Position position;

        public Warrior(string name, Position p)
        {
            this.name = name;
            this.position = p;
        }

        public void MoveHorizontal(int distance)
        {
            this.position.Xxd += distance;

        }

        public void MoveVertical(int distance)
        {

        }

        public void ToConsole()
        {
            Console.WriteLine($"");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Position position = new Position(2, -1);
            position.ToConsole();
            Warrior warrior = new Warrior("Peter the Iron Man", position);
            warrior.ToConsole();
            warrior.MoveHorizontal(3);
            warrior.MoveVertical(-2);
            warrior.ToConsole();
        }
    }
}
