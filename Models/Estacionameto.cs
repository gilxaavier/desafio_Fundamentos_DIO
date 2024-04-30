namespace SistemaEstacionamento
{
    class Estacionamento
    {
        List<string> veiculos = new List<string>();

        public void CadastrarVeiculo(string placaVeiculo)
        {
            veiculos.Add(placaVeiculo);
        }

        public void RemoverVeiculo(string placaVeiculo)
        {
            if (veiculos.Contains(placaVeiculo))
            {
                veiculos.Remove(placaVeiculo);
            }
            else
            {
                Console.WriteLine("Veículo não encontrado.");
            }
        }

        public void ListarVeiculo()
        {
            if (veiculos.Count == 0)
            {
                Console.WriteLine("Não há veículos cadastrados.");
            }
            else
            {
                Console.WriteLine("Veículos cadastrados:");
                foreach (string veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
        }

        public void CalcularVeiculo(int valorInicial, int valorHora, int qtdHoras)
        {
            int valorFinal = valorInicial + (valorHora * qtdHoras);
            System.Console.WriteLine("Valor a se pagar: " + valorFinal);
        }
    }
}
