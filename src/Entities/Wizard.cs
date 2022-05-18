namespace NewDot.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        
        public override string Attack(int Bonus)
        {
            if(Bonus > 6){
                return this.Name + " Ataque magico super efetivo, bonus no ataque de " + Bonus + "\n";
            }else if(Bonus > 0){
                return this.Name + " Ataque magico com bonus no ataque de " + Bonus + "\n";
            }else if (Bonus < 0){
                return this.Name + " Ataque magico não efetivo" + "\n";
            }else{
            return this.Name + " Atacou usando bola de fogo" + "\n";
            }
            
        }
        }
    }