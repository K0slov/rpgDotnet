using System;
using NewDot.src.Entities;
using NewDot;
using NewDot.src.Interface;

class Program
{
    static HeroRepository repositorio = new HeroRepository();
    static void Main(string[] args)
    {
            string opcaoUsuario = NovoJogo();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        NovoPerfil();
                        break;
                    case "2":
                        ListarHerois();
                        break;
                    case "3":
                        VisualizarHeroi();
                        break;
                    case "4":
                        ExcluirHeroi();
                        break;
                    case "C":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();

                }
                opcaoUsuario = NovoJogo();
            }
    }

        private static void ExcluirHeroi()
		{
			Console.Write("Digite o id do herói: ");
			int indiceHeroi = int.Parse(Console.ReadLine());

			repositorio.Exclui(indiceHeroi);
		}

        private static void VisualizarHeroi()
		{
			Console.Write("Digite o id do Herói: ");
			int indiceHeroi = int.Parse(Console.ReadLine());

			var hero = repositorio.RetornaPorId(indiceHeroi);

			Console.WriteLine(hero);
		}

        private static void ListarHerois()
        {
            Console.WriteLine("Listar Herois");

            var lista = repositorio.Lista();

            if (lista.Count == 0)
            {
            Console.WriteLine("Nenhum herói registrado.");
            return;
            }

            foreach (var hero in lista)
            {
            var Excluido = hero.retornaExcluido();
            Console.WriteLine("ID {0}: - {1} {2}", hero.retornaId(), hero.retornaTitulo(), Excluido ? " *Excluido*" : " ");
            }}
        private static void NovoPerfil()
        {
            
            Console.Write("Primeiramente, qual o seu nome? ");
            string entradaNome = Console.ReadLine();
            Console.WriteLine();
            
            Console.WriteLine("Me diga qual a sua classe");

            foreach(int i in Enum.GetValues(typeof(TypeClass)))
            {
            Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(TypeClass), i));
            }
            Console.WriteLine();
            Console.Write("Digite a classe entre as opções acima: ");
            int entradaClasse = int.Parse(Console.ReadLine());

            Hero newHero = new Hero(id: repositorio.ProximoId(),
                                    name: entradaNome,
                                    level: 1,
                                    heroType: (TypeClass)entradaClasse,
                                    life: 0);      
            repositorio.Insere(newHero);

        string player = NovoJogo();
        // Hero champion = new Hero(id, entradaNome, 25, (TypeClass)entradaClasse, 80);
        //Archer support = new Archer("Chronos", 20, "Archer", 70);

        // Console.WriteLine(champion);
        //Console.WriteLine(support);
        //Console.WriteLine(champion.Attack(9));
        //Console.WriteLine(support.Attack(-1));

        player = NovoJogo();
        }
        private static string NovoJogo()
        {
            Console.WriteLine();
            Console.WriteLine("Fala DEV bem-vindo ao teste de RPG inspirado em D&D!");
            Console.WriteLine("Qual a opção que voce deseja?");
            
            Console.WriteLine("1 - Novo perfil");
            Console.WriteLine("2 - Listar heróis");
            Console.WriteLine("3 - Visualizar heroi");
            Console.WriteLine("4 - Excluir herói");
            Console.WriteLine("C - Limpar tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
}