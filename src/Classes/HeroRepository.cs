using NewDot.src.Interface;
using NewDot.src.Entities;

namespace NewDot
{
    public class HeroRepository : IRepository<Hero>
    {
        private List<Hero> listaHero = new List<Hero>();
        public void Atualiza(int id, Hero player)
        {
            listaHero[id] = player;
        }
        public void Exclui(int id)
        {
            listaHero[id].Excluir();
        }
        public void Insere(Hero player)
        {
            listaHero.Add(player);
        }
        public List<Hero> Lista()
        {
            return listaHero;
        }
        public int ProximoId()
        {
            return listaHero.Count;
        }
        public Hero RetornaPorId(int id)
        {
            return listaHero[id];
        }
    }

}