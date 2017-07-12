using System;

namespace StarWars.Warriors
{
    class DarthMaul : Sith
    {
        public override string Name { get; } = "Darth Maul";

        public DarthMaul(int power) : base(power)
        {
        }

        public override void OnJoinBattle(BattleSimulator simulator)
        {
            simulator.LightSide.Morale -= 3;
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
    }
}
