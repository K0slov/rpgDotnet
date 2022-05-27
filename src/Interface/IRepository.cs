namespace NewDot.src.Interface
{
    public interface IRepository<T>
    {
         List<T> Lista();
         T RetornaPorId(int id);
         void Insere(T hero);
         void Atualiza(int id, T hero);
         int ProximoId();         
    }
}