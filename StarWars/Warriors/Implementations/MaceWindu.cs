namespace StarWars.Warriors
{
    class MaceWindu : Jedi
    {
        public override string Name { get; } = "Mace Windu";
        public override bool IsLightSide { get; } = true;

        public MaceWindu(int power) : base(power)
        {
        }

        public override void OnJoinBattle()
        {
            
        }

        public override void OnLeaveBattle()
        {
            var opponent = Simulator.Instance
                .DarkSide
                .GetWarrior();

            if (Power <= 0 && opponent != null && opponent.Power > 0)
                opponent.DecreasePower(1);
        }

        public override void PostCombatEffect()
        {

        }

        public override void PreCombatEffect()
        {
            
        }
    }
}
