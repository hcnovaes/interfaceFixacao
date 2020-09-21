using InterfacesFixacao.Entities;
using InterfacesFixacao.Interfaces;
using InterfacesFixacao.Services;
using Microsoft.VisualBasic;
using System;
using System.Dynamic;
using System.Globalization;

namespace InterfacesFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o número do contrato: ");
            int numeroContrato = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com a data do contrato: dd/mm/yyyy");
            DateTime dataContrato = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o valor total do contrato: ");
            double valorTotalContrato = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com a quantidade de parcelas: ");
            int parcelas = int.Parse(Console.ReadLine());

            PayPalService servico = new PayPalService();

            Contrato contrato = new Contrato(numeroContrato, dataContrato, valorTotalContrato, servico);

            servico.CalcularParcela(valorTotalContrato, dataContrato, parcelas);

            Console.WriteLine(servico);
        }
    }
}
