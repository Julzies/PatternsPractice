namespace Enemies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AbstractEnemy enemy = new AbstractEnemy(new MeleeAttackComponent(), null);
            enemy.TakeTurn();
            enemy = new AbstractEnemy(null, new MeleeDefendComponent());
            enemy.TakeTurn();
        }
    }
}