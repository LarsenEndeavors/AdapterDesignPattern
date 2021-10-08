using System;

namespace AdapterDesignPattern.Objects
{
    public class EnemyRobot
    {
        public void Smash()
        {
            Console.WriteLine("Robot smashes!");
        }

        public void GoForward()
        {
            Console.WriteLine("Robot goes forward!");
        }

        public void DrivenBy(string human)
        {
            Console.WriteLine(human + " is now driving the robot!");
        }
    }
}