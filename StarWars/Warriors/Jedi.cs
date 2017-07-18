namespace StarWars
{
    abstract class Jedi : ForceUser
    {
        protected Jedi(int power) : base(power)
        {
        }

        public override void OnLeaveBattle()
        {
            Simulator.Instance.LightSide.Morale += 5;
        }
    }
}
