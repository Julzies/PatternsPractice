namespace Enemies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AbstractEnemy enemy = new AbstractEnemy(new MeleeAttackComponent(), null);
            enemy.TakeTurn();
        }
    }
}