namespace AdapterDesignPattern.Objects
{
    public interface EnemyAttacker
    {
        public void Attack();
        public void MoveForward();
        public void AssignUser(string user);
    }
}