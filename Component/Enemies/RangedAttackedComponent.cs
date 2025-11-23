namespace Enemies
{
    public class RangedAttackComponent : IAttackComponent
    {
        public void Attack()
        {
            Console.WriteLine("Ranged Attack");
        }

        public void Update()
        {
            // Update logic for ranged attack component
        }
    }
}