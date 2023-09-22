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

        public int Xxd 
        {
            get{ return x; }
            set{ x = value; }
        }
        public int Yxd
        {
            get { return x; }
            set { x = value; }
        }

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
        private string name;
        private Position Position;

        private Position positionxd { get => Position; }

        public Warrior(string name, Position p)
        {
            this.name = name;
            this.Position = p;
        }

        public void MoveHorizontal(int distance)
        {
            Position.Xxd += distance;

        }

        public void MoveVertical(int distance)
        {
            Position.Yxd += distance;
        }

        public void ToConsole()
        {
            Console.WriteLine($"{name}, position ({this.Position.Xxd},{this.Position.Yxd})");
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
