using InterfacesFixacao.Entities;
using InterfacesFixacao.Interfaces;
using System;
using System.Collections.Generic;

namespace InterfacesFixacao.Services
{
    class PayPalService : IMetodoPagamento
    {
        public double ValorParcela { get; set; }
        public DateTime Vencimento { get; set; }

        public int Parcelas { get; set; }

        public List<Parcela> listaParcela = new List<Parcela>();
        public void CalcularParcela(double valorTotalContrato, DateTime dataContrato, int parcelas)
        {
            for (int i = 0; i < parcelas; i++)
            {
                ValorParcela = 0;
                if (i == 0)
                {
                    ValorParcela = valorTotalContrato / parcelas;
                    ValorParcela = ValorParcela + (ValorParcela * 0.01);
                    ValorParcela = ValorParcela + (ValorParcela * 0.02);
                }
                else
                {
                    ValorParcela = valorTotalContrato / parcelas;
                    double juros = listaParcela[listaParcela.Count - 1].ValorParcela * 0.01;
                    double taxaFixa = ValorParcela * 0.02;
                    ValorParcela = listaParcela[listaParcela.Count - 1].ValorParcela + juros + taxaFixa;
                }
                Vencimento = dataContrato.AddMonths(i + 1);

                Parcela parcela = new Parcela();
                parcela.ValorParcela = ValorParcela;
                parcela.VencimentoParcela = Vencimento;
                listaParcela.Add(parcela);
            }
        }

        public override string ToString()
        {
            string lista = "";
            foreach (Parcela parcela in listaParcela) {
                lista += "Vencimento: " + parcela.VencimentoParcela + "\n Valor da parcela: " + Math.Round(parcela.ValorParcela, 2) + "\n";
            }
            return lista;
        }
    }
}
