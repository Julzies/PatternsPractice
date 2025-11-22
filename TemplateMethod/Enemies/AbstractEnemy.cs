namespace Enemies
{
    abstract class AbstractEnemy
    {
        // Attack and Defend are protected virtual methods
        // Private members cannot be accessed by derived classes
        // Protected members can be accessed by derived classes
        public void TakeTurn()
        {
            Attack();
            Defend();
        }

        protected virtual void Attack()
        {
            Console.WriteLine("Default Attack");
        }

        protected virtual void Defend()
        {
            Console.WriteLine("Default Defend");
        }
    }
}