using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars.Warriors
{
    class ObiWanKenobi : Jedi
    {
        public override string Name { get; } = "Obi Wan Kenobi";
        public override bool IsLightSide { get; } = true;

        public ObiWanKenobi(int power) : base(power)
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
            foreach (var opponent in simulator.DarkSide.Warriors)
                if (!(opponent is Sith))
                    return;
            Power += 2;
        }
    }
}
