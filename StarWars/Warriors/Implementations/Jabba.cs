namespace StarWars.Warriors
{
    class Jabba : Warrior
    {
        public override string Name { get; } = "Jabba";

        public Jabba(int power) : base(power)
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
            if (Simulator.Chance(50))
                Power += 1;
        }

        public override void PreCombatEffect()
        {

        }
    }
}
