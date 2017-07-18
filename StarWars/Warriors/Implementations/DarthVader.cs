namespace StarWars.Warriors
{
    class DarthVader : Sith
    {
        public override string Name { get; } = "Darth Vader";

        public DarthVader(int power) : base(power)
        {
        }

        public override void OnJoinBattle()
        {
            
        }

        public override void OnLeaveBattle()
        {

        }

        public override void PostCombatEffect()
        {

        }

        public override void PreCombatEffect()
        {

        }

        public override bool IsStrongerThan(Warrior other)
        {
            if (other is ForceUser)
                return base.IsStrongerThan(other);
            return Power + 3 > other.Power;
        }
    }
}
