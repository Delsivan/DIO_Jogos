using System;


namespace DIO.Jogos
{
    class Program
    {
        static JogoRepositorio repositorio = new JogoRepositorio();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarJogos();
                        break;
                     case "2":
                        InserirJogo();
                        break;
                     case "3":
                        AtualizarJogo();
                        break;
                     case "4":
                        ExcluirJogo();
                        break;
                     case "5":
                        //VisualizarJogo();
                        break;
                     case "C":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = ObterOpcaoUsuario();
            }
            Console.WriteLine("Obrigada por utilizar nossos serviços.");
            Console.ReadLine();

        }
        private static void ExcluirJogo()
		{
			Console.Write("Digite o id da jogo: ");
			int indiceJogo = int.Parse(Console.ReadLine());

			repositorio.Exclui(indiceJogo);
		}
        private static void AtualizarJogo()
		{
			Console.Write("Digite o id do jogo: ");
			int indiceJogo = int.Parse(Console.ReadLine());

			// https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getvalues?view=netcore-3.1
			// https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getname?view=netcore-3.1
			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
			Console.WriteLine("Digite o nome do jogo: ");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite a plataforma do jogo: ");
            string entradaPlataforma = Console.ReadLine();

            Console.WriteLine("Digite a Descrição do jogo: ");
            string entradaDescricao = Console.ReadLine();

            Console.WriteLine("Digite o genêro entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o idioma do jogo: ");
            string entradaIdioma = Console.ReadLine();

            Console.WriteLine("Digite o Ano de criação do jogo: ");
            int entradaAno_Lancamento = int.Parse(Console.ReadLine());

            Jogo atualizaJogo = new Jogo(id: indiceJogo, 
                                       titulo: entradaTitulo,
                                       plataforma: entradaPlataforma,
                                       descricao: entradaDescricao,
                                       genero: (Genero)entradaGenero,
                                       idioma: entradaIdioma,
                                       ano_Lancamento: entradaAno_Lancamento);

			repositorio.Atualiza(indiceJogo, atualizaJogo);
		}


        private static void ListarJogos()
        {
            Console.WriteLine("Listar Jogos");

            var lista = repositorio.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhum jogo encontrado.");
                return;
            }

            foreach (var jogo in lista)
            {
                var excluido = jogo.retornaExcluido();
                Console.WriteLine("#ID {0}: - {1} {2}", jogo.retornaId(), jogo.retornaTitulo(), (excluido ? "*Excluído*" : ""));
            }
        }

        private static void InserirJogo()
        {
            Console.WriteLine("Inserir Jogo");

            // https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getvalues?view=netcore-3.1
			// https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getname?view=netcore-3.1
            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.WriteLine("Digite o nome do jogo: ");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite a plataforma do jogo: ");
            string entradaPlataforma = Console.ReadLine();

            Console.WriteLine("Digite a Descrição do jogo: ");
            string entradaDescricao = Console.ReadLine();

            Console.WriteLine("Digite o genêro entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o idioma do jogo: ");
            string entradaIdioma = Console.ReadLine();

            Console.WriteLine("Digite o Ano de criação do jogo: ");
            int entradaAno_Lancamento = int.Parse(Console.ReadLine());

            Jogo novoJogo = new Jogo(id: repositorio.ProximoId(), 
                                       titulo: entradaTitulo,
                                       plataforma: entradaPlataforma,
                                       descricao: entradaDescricao,
                                       genero: (Genero)entradaGenero,
                                       idioma: entradaIdioma,
                                       ano_Lancamento: entradaAno_Lancamento);

            repositorio.Insere(novoJogo);
  
        }

        private static string ObterOpcaoUsuario()
        
        {
            Console.WriteLine("");
            Console.WriteLine("DIO_Jogos");
            Console.WriteLine("Informe a opção desejada: ");

            Console.WriteLine("1 - Listar Jogos");
            Console.WriteLine("2 - Cadastrar um novo jogo");
            Console.WriteLine("3 - Atualizar Jogos");
            Console.WriteLine("4 - Excluir Jogo");
            Console.WriteLine("5 - Visualizar Jogo");
            Console.WriteLine("C - Limpar tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;

        }
    }
}
