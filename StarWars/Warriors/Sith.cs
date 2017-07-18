namespace StarWars
{
    abstract class Sith : ForceUser
    {
        protected Sith(int power) : base(power)
        {
        }

        public override void OnJoinBattle()
        {
            Simulator.Instance.LightSide.Morale -= 5;
        }
    }
}
