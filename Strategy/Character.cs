class Character
{
    private IAttackStrategy _attackStrategy;
    private IDefendStrategy _defendStrategy;

    public Character(IAttackStrategy attackStrategy, IDefendStrategy defendStrategy)
    {
        _attackStrategy = attackStrategy;
        _defendStrategy = defendStrategy;
    }

    public void SetAttackStrategy(IAttackStrategy attackStrategy)
    {
        _attackStrategy = attackStrategy;
    }

    public void SetDefendStrategy(IDefendStrategy defendStrategy)
    {
        _defendStrategy = defendStrategy;
    }

    public void PerformAttack()
    {
        _attackStrategy.Attack();
    }

    public void PerformDefend()
    {
        _defendStrategy.Defend();
    }
}