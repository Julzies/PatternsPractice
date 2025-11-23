namespace Enemies
{
    public class MeleeAttackComponent : IAttackComponent
    {
        public void Attack()
        {
            Console.WriteLine("Melee Attack");
        }

        public void Update()
        {
            // Update logic for melee attack component
        }
    }
}