namespace StarWars.Warriors
{
    class BobaFett : Warrior
    {
        public override string Name { get; } = "Boba Fett";

        public BobaFett(int power) : base(power)
        {
        }

        public override void OnJoinBattle()
        {
            if (Simulator.Instance.DarkSide.Morale > Simulator.Instance.LightSide.Morale)
                Power += 2;
        }

        public override void OnLeaveBattle()
        {

        }

        public override void PostCombatEffect()
        {
            if (Simulator.Chance(50))
                Power += 1;
        }

        public override void PreCombatEffect()
        {

        }
    }
}
