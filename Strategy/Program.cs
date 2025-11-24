// A Strategy pattern allows a class to have an interchangeable
// algorithm or behavior by having a member variable in that class
// that references an interface or abstract class

class Program
{
    static void Main(string[] args)
    {
        IAttackStrategy meleeAttack = new MeleeAttack();
        IDefendStrategy meleeDefend = new MeleeDefend();
        Character player = new Character(meleeAttack, meleeDefend);
        //player.SetAttackStrategy(new MeleeAttack());
        player.PerformAttack();
        player.PerformDefend();
    }
}