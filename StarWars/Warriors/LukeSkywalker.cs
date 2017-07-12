using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars.Warriors
{
    class LukeSkywalker : Jedi
    {
        public override string Name { get; } = "Luke Skywalker";
        public override bool IsLightSide { get; } = true;

        public LukeSkywalker(int power) : base(power)
        {

        }

        public override void OnJoinBattle(BattleSimulator simulator)
        {
            foreach (var opponent in simulator.DarkSide.Warriors)
                if (opponent is Sith)
                    return;
            simulator.LightSide.Morale += 3;
        }

        public override void PostCombatEffect(BattleSimulator simulator)
        {
        }

        public override void PreCombatEffect(BattleSimulator simulator)
        {
        }
    }
}
