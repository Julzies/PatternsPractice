namespace Enemies
{
    public class MeleeDefendComponent : IDefendComponent
    {
        public void Defend()
        {
            Console.WriteLine("Melee Defend");
        }

        public void Update()
        {
            // Update logic for melee defend component
        }
    }
}