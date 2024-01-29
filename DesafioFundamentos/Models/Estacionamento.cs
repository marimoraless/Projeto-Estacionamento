namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string>  veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public List<string> GetVeiculos()
        {
            return veiculos;
        }

        public void AdicionarVeiculo(string placa)
        {   
            veiculos.Add(placa);
            Console.WriteLine ($"Veículo com a placa {placa} foi estacionado com sucesso!");
        }

        public void RemoverVeiculo(string placa, decimal horas)
        {
            if (veiculos.Any(veiculoPlaca => veiculoPlaca.ToUpper() == placa.ToUpper()))
            {
                decimal valorTotal = 0; 
                
                valorTotal = precoInicial + (precoPorHora * horas);

                veiculos.Remove(placa);
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }
        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
            
                foreach (var carro in veiculos)
                {
                    Console.WriteLine(carro);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
