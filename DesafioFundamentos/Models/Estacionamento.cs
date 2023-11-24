namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        string placaVeiculo = "";
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {          
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            placaVeiculo = Console.ReadLine();
            veiculos.Add(placaVeiculo);
        }

        public void RemoverVeiculo()
        {
            
             Console.WriteLine("Digite a placa do veículo para remover:");
             placaVeiculo = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placaVeiculo.ToUpper()))
            {
                   int horas = 0;
                   decimal valorTotal = 0;
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                horas = Convert.ToInt32(Console.ReadLine());             
                valorTotal = precoInicial + (precoPorHora * horas);
                veiculos.Remove(placaVeiculo);
                Console.WriteLine($"O veículo {placaVeiculo} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {

            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                 Console.WriteLine($"Os veículos estacionados são:");
                foreach(string veiculosNoEstacionamneto in veiculos)
                {
                     Console.WriteLine(veiculosNoEstacionamneto);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
