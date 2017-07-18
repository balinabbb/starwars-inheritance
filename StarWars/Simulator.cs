using StarWars.Sides;
using System;

namespace StarWars
{
    class Simulator
    {
        public static Simulator Instance { get; private set; }

        public Side LightSide { get; }
        public Side DarkSide { get; }

        public Simulator(Warrior[] warriors)
        {
            LightSide = new Side(new LinearWarriorSource().Initialize(warriors, true));
            DarkSide = new Side(new LinearWarriorSource().Initialize(warriors, false));
            Instance = this;
            Console.WriteLine("Szimuláció indítása...");
        }

        public Warrior RunSimulation()
        {
            Warrior light = null, dark = null;
            while ((light = LightSide.GetWarrior()) != null &&
                   (dark = DarkSide.GetWarrior()) != null)
            {
                light.PreCombatEffect();
                dark.PreCombatEffect();
                if (light.IsStrongerThan(dark))
                {
                    light.DecreasePower(dark.Power);
                    if (light.Power <= 0)
                        LightSide.KillWarrior();
                    DarkSide.KillWarrior();
                }
                else if (dark.IsStrongerThan(light))
                {
                    dark.DecreasePower(light.Power);
                    if (dark.Power <= 0)
                        DarkSide.KillWarrior();
                    LightSide.KillWarrior();
                }
                else
                {
                    LightSide.KillWarrior();
                    DarkSide.KillWarrior();
                }
                light.PostCombatEffect();
                dark.PostCombatEffect();
            }

            return light ?? dark;
        }

        static readonly Random _rand = new Random();
        public static bool Chance(int percent)
        {
            return _rand.Next(1, 101) <= percent;
        }
    }
}
