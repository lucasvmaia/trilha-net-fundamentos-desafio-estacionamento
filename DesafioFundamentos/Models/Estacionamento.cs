namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
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
            
            Console.Write("Digite a placa do veículo para estacionar:");
            string idVeiculo = Console.ReadLine()!;
            if(!String.IsNullOrEmpty(idVeiculo)){
                veiculos.Add(idVeiculo);
                Console.WriteLine($"{idVeiculo} foi adicionado.");
            } else {
                Console.WriteLine($"erro ao cadastrar.");
            }
        }


        public void RemoverVeiculo()
        {
            Console.Write("Digite a placa do veículo para remover:");

            
            string placa = "";
            placa = Console.ReadLine()!;

            
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.Write("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                
                int horas = Convert.ToInt32(Console.ReadLine()!);
                decimal valorTotal = 0; 
                valorTotal = precoInicial + precoPorHora * horas;
                
                if(veiculos.Remove(placa)){
                    Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                } else {
                Console.WriteLine("Erro ao remover veículo");
                }
            } else {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                
                int i = 0;
                foreach(string veiculo in veiculos){
                    Console.WriteLine($"{i} - {veiculo}");
                    i++;
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
