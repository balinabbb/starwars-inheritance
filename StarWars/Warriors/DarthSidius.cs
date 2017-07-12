using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars.Warriors
{
    class DarthSidius : Sith
    {
        public override string Name { get; } = "Darth Sidius";

        public DarthSidius(int power) : base(power)
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
            var count = 0;
            foreach (var opponent in simulator.LightSide.Warriors)
                if (opponent is Jedi)
                    count++;
            simulator.LightSide.Morale -= count;
        }
    }
}
