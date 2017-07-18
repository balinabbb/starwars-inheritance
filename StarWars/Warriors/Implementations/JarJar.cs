using System;

namespace StarWars.Warriors
{
    class JarJar : Warrior
    {
        public override string Name { get; } = "Jar Jar";
        public override bool IsLightSide { get; } = true;

        public JarJar(int power) : base(power)
        {
        }

        /// <summary>
        /// 5% eséllyel növeli csapata morálját 20 egységgel, 
        /// ha ez nem sikerül akkor további 20% esélye van 5-el növelni azt.
        /// </summary>
        public override void OnJoinBattle()
        {
            if (Simulator.Chance(5))
            {
                Simulator.Instance.LightSide.Morale += 20;
                Console.WriteLine($"Jar Jar nagyon szerencsés, csapata új morálja: {Simulator.Instance.LightSide.Morale}");
            }
            else if (Simulator.Chance(20))
            {
                Simulator.Instance.LightSide.Morale += 5;
                Console.WriteLine($"Jar Jar szerencsés, csapata új morálja: {Simulator.Instance.LightSide.Morale}");
            }
            else
            {
                Console.WriteLine($"Jar Jar semmit nem tett a csapatért...");
            }
        }

        public override void OnLeaveBattle()
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
