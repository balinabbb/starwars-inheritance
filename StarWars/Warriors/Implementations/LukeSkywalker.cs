namespace StarWars.Warriors
{
    class LukeSkywalker : Jedi
    {
        public override string Name { get; } = "Luke Skywalker";
        public override bool IsLightSide { get; } = true;

        public LukeSkywalker(int power) : base(power)
        {

        }

        public override void OnJoinBattle()
        {
            foreach (var opponent in Simulator.Instance.DarkSide.Warriors)
                if (opponent is Sith)
                    return;
            Simulator.Instance.LightSide.Morale += 3;
        }

        public override void PostCombatEffect()
        {
        }

        public override void PreCombatEffect()
        {
        }
    }
}
