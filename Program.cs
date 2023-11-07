namespace Calculadora_De_Ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int vitorias = 0;
            int derrotas = 0;

            Console.WriteLine("Informe o Nome do Jogador");
            nome = Console.ReadLine();

            Console.WriteLine("Informe a Quantidade de Vitorias");
            vitorias = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a Quantidade de Derrotas");
            derrotas = int.Parse(Console.ReadLine());

            int saldoDeVitorias = vitorias - derrotas;

            int opcao = 0;

            while (opcao != 3)
            {
                Console.Clear();
                Console.WriteLine("Escolha a Opção Desejada:");
                Console.WriteLine("1 - Consultar saldo de Vitorias");
                Console.WriteLine("2 - Consultar Ranking");
                Console.WriteLine("3 - Sair");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        ConsultarsaldodeVitorias(saldoDeVitorias, nome);
                        break;

                    case 2:
                        ConsultarRanking(vitorias, nome);
                        break;

                    case 3:
                        Console.WriteLine("Saindo do programa...");
                        break;

                    default:
                        Console.WriteLine("Opção Inválida. Tente novamente.");
                        break;
                }

                Console.WriteLine("Pressione Enter para continuar...");
                Console.ReadLine();
            }
        }

        private static void ConsultarRanking(int vitorias, string nome)
        {
            string nivel = CalcularNivel(vitorias);
            Console.WriteLine($"O nível do player {nome} é {nivel}");
        }

        private static string CalcularNivel(int vitorias)
        {
            if (vitorias < 10)
            {
                return "Ferro";
            }
            else if (vitorias >= 11 && vitorias <= 20)
            {
                return "Bronze";
            }
            else if (vitorias >= 21 && vitorias <= 50)
            {
                return "Prata";
            }
            else if (vitorias >= 51 && vitorias <= 80)
            {
                return "Ouro";
            }
            else if (vitorias >= 81 && vitorias <= 90)
            {
                return "Diamante";
            }
            else if (vitorias >= 91 && vitorias <= 100)
            {
                return "Lendário";
            }
            else
            {
                return "Imortal";
            }
        }

        private static void ConsultarsaldodeVitorias(int saldoDeVitorias, string nome)
        {
            Console.WriteLine($"O saldo atual de vitórias do player {nome} é {saldoDeVitorias}");
        }
    }
}
