using System;

namespace AdapterDesignPattern.Objects
{
    public class EnemyTank : EnemyAttacker
    {
        public void Attack()
        {
            Console.WriteLine("Tank Attacks!");
        }

        public void MoveForward()
        {
            Console.WriteLine("Tank moves forward!");
        }

        public void AssignUser(string user)
        {
            Console.WriteLine(user + " assigned to tank!");
        }
    }
}