using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine("");
Console.Write("ABRINDO O SISTEMA DE ESTACIONAMENTO!!\n\n" +
                  "INFORME O PREÇO INICIAL : ");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.Write("INFORME O PREÇO POR HORA : ");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("-- SELECIONE SUA OPÇÃO --");
    Console.WriteLine("");
    Console.WriteLine("1 - CADASTRAR VEÍCULO");
    Console.WriteLine("2 - REMOVER VEÍCULO");
    Console.WriteLine("3 - LISTAR VEÍCULOS");
    Console.WriteLine("4 - ENCERRAR");

    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;

        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("OPÇÃO INVÁLIDA");
            break;
    }
    Console.WriteLine("");
    Console.WriteLine("PRESSIONE UMA TECLA PARA CONTINUAR");
    Console.ReadKey(true);
}

Console.WriteLine("!! PROGRAMA ENCERRADO !!");
