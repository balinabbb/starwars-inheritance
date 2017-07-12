using System;

namespace StarWars.Warriors
{
    class Jabba : Warrior
    {
        public override string Name { get; } = "Jabba";

        public Jabba(int power) : base(power)
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
            if (simulator.Chance(50))
                Power += 1;
        }

        public override void PreCombatEffect(BattleSimulator simulator)
        {

        }
    }
}
