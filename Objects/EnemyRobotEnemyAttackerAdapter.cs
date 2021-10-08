namespace AdapterDesignPattern.Objects
{
    public class EnemyRobotEnemyAttackerAdapter : EnemyAttacker
    {
        private EnemyRobot EnemyRobot { get; set; }

        public EnemyRobotEnemyAttackerAdapter(EnemyRobot enemyRobot)
        {
            EnemyRobot = enemyRobot;
        }

        public void Attack()
        {
            EnemyRobot.Smash();
        }

        public void MoveForward()
        {
            EnemyRobot.GoForward();
        }

        public void AssignUser(string user)
        {
            EnemyRobot.DrivenBy(user);
        }
    }
}