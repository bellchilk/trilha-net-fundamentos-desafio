using System.ComponentModel;

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
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();

            // Verifica se o veículo já está estacionado
            if (veiculos.Any(placaLista => placaLista.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("O veículo já está estacionado.");
                return;
            }
            // Adiciona o veículo à lista
            veiculos.Add(placa);
            Console.WriteLine($"O veículo {placa} foi adicionado com sucesso!");
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas = int.Parse(Console.ReadLine());

                // Calcula o valor total a ser pago
                decimal valorTotal = precoInicial + precoPorHora * horas;

                // Remove o veículo da lista
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
            // Verifica se há veículos no estacionamento (se a lista não está vazia)
            if (veiculos.Any()) 
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (string ListaVeiculo in veiculos)
                {
                    Console.WriteLine($"- {ListaVeiculo}");
                }
               
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
