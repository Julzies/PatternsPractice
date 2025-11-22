namespace Enemies
{
    class GoblinEnemy : AbstractEnemy
    {
        protected override void Attack()
        {
            Console.WriteLine("Goblin Attack");
        }

        protected override void Defend()
        {
            Console.WriteLine("Goblin Defend");
        }
    }
}