namespace StarWars.Warriors
{
    class DarthSidius : Sith
    {
        public override string Name { get; } = "Darth Sidius";

        public DarthSidius(int power) : base(power)
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
            var count = 0;
            foreach (var opponent in Simulator.Instance.LightSide.Warriors)
                if (opponent is Jedi)
                    count++;
            Simulator.Instance.LightSide.Morale -= count;
        }
    }
}
