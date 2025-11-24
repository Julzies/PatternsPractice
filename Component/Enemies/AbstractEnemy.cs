// TODO: Implement setting and removing components at runtime
namespace Enemies
{
    class AbstractEnemy
    {
        protected IAttackComponent? attackComponent { get; set; }
        protected IDefendComponent? defendComponent { get; set; }

        public AbstractEnemy(IAttackComponent? attackComponent, IDefendComponent? defendComponent)
        {
            this.attackComponent = attackComponent;
            this.defendComponent = defendComponent;
        }

        public void TakeTurn()
        {
            attackComponent?.Attack();
            defendComponent?.Defend();
        }
    }
}