namespace StarWars.Warriors
{
    class ObiWanKenobi : Jedi
    {
        public override string Name { get; } = "Obi Wan Kenobi";
        public override bool IsLightSide { get; } = true;

        public ObiWanKenobi(int power) : base(power)
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
            foreach (var opponent in Simulator.Instance.DarkSide.Warriors)
                if (!(opponent is Sith))
                    return;
            Power += 2;
        }
    }
}
