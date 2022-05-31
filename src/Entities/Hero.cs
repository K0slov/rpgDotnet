using NewDot;
using System;

namespace NewDot.src.Entities
{
    public class Hero : dadosBase
    {
        public Hero(int id, string name, int level, TypeClass heroType, int life, int force)
        {
            this.Id = id;
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
            this.Life = life;
            this.Excluido = false;
            this.Force = force;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Level;
        public TypeClass HeroType {get; set; }
        private bool Excluido { get; set; }
        public int Life;
        public int Force;

        public virtual string Attack(int Bonus)
        {
            return this.Name + " Atacou usando bola de fogo";
        }

        public override string ToString()
        {
            
            string retorno = "";
            retorno += "Nome: " + this.Name + Environment.NewLine;
            retorno += "Classe: " + this.HeroType + Environment.NewLine;
            retorno += "Nivel: " + this.Level + Environment.NewLine;
            retorno += "Life: " + this.Life + Environment.NewLine;
            retorno += "Força: " + this.Force + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
            
            return retorno;
        }

        public string retornaTitulo()
        {
            return this.Name;
        }
        // public string retornaCard()
        // {
        //     return "ID: " + this.Id + "Name: " + this.Name + " " + "Life: " + this.Life + "\n" +"Level: " + this.Level + " " + "Hero Type: " + this.HeroType + "\n";
        // } 
        public int retornaId()
        {
            return this.Id;
        }
        public bool retornaExcluido()
        {
            return this.Excluido;
        }
        public void Excluir()
        {
            this.Excluido = true;
        }
    }
}