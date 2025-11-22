namespace Enemies
{
    class WizardEnemy : AbstractEnemy
    {
        protected override void Attack()
        {
            Console.WriteLine("Wizard Attack");
        }
    }
}