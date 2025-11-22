namespace Enemies
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractEnemy enemy = new GoblinEnemy();
            enemy.TakeTurn();
            
            enemy = new WizardEnemy();
            enemy.TakeTurn();
        }
    }
}