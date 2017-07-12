using System;

namespace StarWars.Warriors
{
    class BobaFett : Warrior
    {
        public override string Name { get; } = "Boba Fett";

        public BobaFett(int power) : base(power)
        {
        }

        public override void OnJoinBattle(BattleSimulator simulator)
        {
            if (simulator.DarkSide.Morale > simulator.LightSide.Morale)
                Power += 2;
        }

        public override void OnLeaveBattle(BattleSimulator simulator)
        {

        }

        public override void PostCombatEffect(BattleSimulator simulator)
        {
            if (simulator.Chance(50))
                Power += 1;
        }

        public override void PreCombatEffect(BattleSimulator simulator)
        {

        }
    }
}
