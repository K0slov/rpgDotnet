namespace NewDot.src.Entities
{
    public class Archer : Hero
    {
        public Archer(string Name, int Level, string HeroType)  : base(Name, Level, HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack(int Bonus)
        {
            if(Bonus > 6){
                return this.Name + " Ataque com a flecha super efetivo, bonus no ataque de " + Bonus + "\n";
            }else if(Bonus > 0){
                return this.Name + " Ataque com a flecha com bonus no ataque de " + Bonus + "\n";
            }else if (Bonus < 0){
                return this.Name + " Ataque com a flecha não efetivo" + "\n";
            }else{
            return this.Name + " Atirou uma flecha" + "\n";
            }
    }
}}