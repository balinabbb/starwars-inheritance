namespace StarWars.Warriors
{
    class HanSolo : Warrior
    {
        public override string Name { get; } = "Han Solo";
        public override bool IsLightSide { get; } = true;

        public HanSolo(int power) : base(power)
        {
        }

        public override void OnJoinBattle()
        {
        }

        public override void OnLeaveBattle()
        {
            Simulator.Instance.LightSide.HanSoloDied = true;
        }

        public override void PostCombatEffect()
        {
        }

        public override void PreCombatEffect()
        {
        }
    }
}
