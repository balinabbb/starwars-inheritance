namespace StarWars.Warriors
{
    class Yoda : Jedi
    {
        public override string Name { get; } = "Yoda";
        public override bool IsLightSide { get; } = true;

        public Yoda(int power) : base(power)
        {

        }

        public override void DecreasePower(int power)
        {
            if(Simulator.Chance(10))
                base.DecreasePower(power/2);
            else
                base.DecreasePower(power);
        }

        public override void OnJoinBattle()
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
