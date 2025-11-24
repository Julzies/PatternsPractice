// Template Method is what I want when the structure of a class
// is a fixed pipeline, but the intermediate steps can vary

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