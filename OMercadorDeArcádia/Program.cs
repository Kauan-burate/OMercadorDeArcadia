using OMercadorDeArcádia;

public class Program 
{
    public static void Main()
    {
        bool iniciar = true;

        Loja loja = new Loja();

        loja.AdicionarItem(new ArmaMagica("Espada do Dragão", 1500, Raridade.Epico, 85));
        loja.AdicionarItem(new ArmaMagica("Machado do Trovão", 900, Raridade.Raro, 60));
        loja.AdicionarItem(new ArmaMagica("Adaga Sombria", 350, Raridade.Comum, 25));

        loja.AdicionarItem(new PocaoMagica("Poção de Cura", 120, Raridade.Comum, "Recupera 50 de vida"));
        loja.AdicionarItem(new PocaoMagica("Poção de Invisibilidade", 800, Raridade.Epico, "Fica invisível por 30 segundos"));
        loja.AdicionarItem(new PocaoMagica("Poção de Força", 400, Raridade.Raro, "Aumenta o dano por 60 segundos"));

        loja.AdicionarItem(new PergaminhoMagico("Pergaminho de Bola de Fogo", 700, Raridade.Raro, "Fogo"));
        loja.AdicionarItem(new PergaminhoMagico("Pergaminho de Teleporte", 1200, Raridade.Epico, "Teleporte"));
        loja.AdicionarItem(new PergaminhoMagico("Pergaminho de Luz", 150, Raridade.Comum, "Iluminação"));

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("====LOJA ARCÁDIA====\n");
        Console.ResetColor();

        while (iniciar)
        {
            loja.ExibirMenu();
            Console.WriteLine("\nO que deseja fazer?");
            string entrada = Console.ReadLine();

            int funcao;

            bool numeroValido = int.TryParse(entrada, out funcao);

            if (numeroValido == false)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Digite apenas números!");
                Console.ResetColor();
                continue;
            }

            switch (funcao)
            {
                case 0:
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Saindo do Sistema...");
                    Console.ResetColor();
                    iniciar = false;

                    break;

                case 1:
                    Console.WriteLine("Digite o nome:");
                    string nome = Console.ReadLine();

                    Console.WriteLine("Digite o valor:");
                    double valor = double.Parse( Console.ReadLine());

                    Console.WriteLine("Digite a raridade:");
                    Console.WriteLine("1 - Comum");
                    Console.WriteLine("2 - Raro");
                    Console.WriteLine("3 - Epico");

                    int raridadeNum = int.Parse(Console.ReadLine());

                    if(raridadeNum > 0 && raridadeNum < 4) 
                    {
                        Raridade raridade = (Raridade)raridadeNum;

                        if (valor > 0)
                        {
                            loja.AdicionarItem(new ItemMagico(nome, valor, raridade));
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Item adicionado com sucesso!");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Erro! Valor inválido!");
                            Console.ResetColor();
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Erro! Raridade inválida!!");
                        Console.ResetColor();
                    }
                    break;

                case 2:
                    loja.Listar();
                    break;

                case 3:
                    Console.WriteLine("Digite o id do item que deseja vender:");
                    int id2 = int.Parse(Console.ReadLine());
                    loja.Vender(id2);

                    break;

                case 4:
                    Console.WriteLine("Digite o id do item que deseja remover:");
                    int id = int.Parse( Console.ReadLine());

                    loja.RemoverItem(id);
                                       
                    break;

                default:

                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Erro! digite outro número que esteja no MENU!");
                    Console.ResetColor();
                    break;
            }
           
        }

    }

}
