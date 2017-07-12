using System;

namespace StarWars.Warriors
{
    class DarthVader : Sith
    {
        public override string Name { get; } = "Darth Vader";

        public DarthVader(int power) : base(power)
        {
        }

        public override void OnJoinBattle(BattleSimulator simulator)
        {
            
        }

        public override void OnLeaveBattle(BattleSimulator simulator)
        {

        }

        public override void PostCombatEffect(BattleSimulator simulator)
        {

        }

        public override void PreCombatEffect(BattleSimulator simulator)
        {

        }

        public override bool IsStrongerThan(BattleSimulator simulator, Warrior other)
        {
            if (other is ForceUser)
                return base.IsStrongerThan(simulator, other);
            return Power + 3 > other.Power;
        }
    }
}
