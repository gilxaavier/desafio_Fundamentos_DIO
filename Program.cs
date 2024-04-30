using SistemaEstacionamento;

Estacionamento estacionamento = new Estacionamento();

Console.WriteLine("Seja bem-vindo ao sistema de Estacionamento");
Console.WriteLine("Digite o preço inicial:");
if (int.TryParse(Console.ReadLine(), out int precoInicial))
{
    Console.WriteLine("Agora digite o preço por hora:");
    if (int.TryParse(Console.ReadLine(), out int precoHora))
    {
        Console.WriteLine("Escolha a sua opção:");
        Console.WriteLine("1 - Cadastrar Veículo");
        Console.WriteLine("2 - Remover Veículo");
        Console.WriteLine("3 - Listar Veículos");
        Console.WriteLine("4 - Encerrar");

        while (true)
        {
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Informe a placa do veículo:");
                    string placa = Console.ReadLine();
                    estacionamento.CadastrarVeiculo(placa);
                    Console.WriteLine("Veículo cadastrado com sucesso.");
                    break;
                case "2":
                    Console.WriteLine("Informe a placa do veículo:");
                    string placaRemover = Console.ReadLine();
                    Console.WriteLine("Quantidade de horas que o veículo permaneceu:");
                    if (int.TryParse(Console.ReadLine(), out int qtdHoras))
                    {
                        estacionamento.CalcularVeiculo(precoInicial, precoHora, qtdHoras);
                        estacionamento.RemoverVeiculo(placaRemover);
                        Console.WriteLine("Veículo removido com sucesso.");
                    }
                    else
                    {
                        Console.WriteLine("Por favor, insira um valor numérico válido para a quantidade de horas.");
                    }
                    break;
                case "3":
                    estacionamento.ListarVeiculo();
                    break;
                case "4":
                    Console.WriteLine("Encerrando o sistema...");
                    return;
                default:
                    Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                    break;
            }
        }
    }
    else
    {
        Console.WriteLine("Por favor, insira um valor numérico válido para o preço por hora.");
    }
}
else
{
    Console.WriteLine("Por favor, insira um valor numérico válido para o preço inicial.");
}
