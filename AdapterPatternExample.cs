using AdapterDesignPattern.Objects;

namespace AdapterDesignPattern
{
    internal static class AdapterPatternExample
    {
        /*
         * The majority of this code is mocked or directly taken from the Derek Banas YouTube series in
         * an effort to teach myself and get familiar with these patterns.  None of this is meant to be
         * original content, and if you see this and wonder why it's in my repo, mostly it's for me, but
         * I'm happy that you're here and here's proof that I have at least heard of this particular
         * pattern!
         *
         * Author: Nicholas Larsen
         * Date: 2021/10/08
         */
        
        private static void Main()
        {
            EnemyAttacker attacker = new EnemyTank();
            var robot = new EnemyRobot();
            // This is the gist of the adapter, you just delegate the methods you need to work through an interface.
            EnemyAttacker adaptedRobot = new EnemyRobotEnemyAttackerAdapter(robot);

            adaptedRobot.Attack();
            attacker.Attack();
        }
    }
}
