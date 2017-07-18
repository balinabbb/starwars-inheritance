namespace StarWars.Warriors
{
    class DarthMaul : Sith
    {
        public override string Name { get; } = "Darth Maul";

        public DarthMaul(int power) : base(power)
        {
        }

        public override void OnJoinBattle()
        {
            Simulator.Instance.LightSide.Morale -= 3;
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
    }
}
