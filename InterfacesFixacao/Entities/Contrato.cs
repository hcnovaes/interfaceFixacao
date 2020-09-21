using InterfacesFixacao.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesFixacao.Entities
{
    class Contrato
    {
        public int numeroContrato { get; set; }
        public DateTime dataContrato { get; set; }
        public double valorTotalContrato { get; set; }

        IMetodoPagamento MetodoPagamento;

        public Contrato(int numeroContrato, DateTime dataContrato, double valorTotalContrato, IMetodoPagamento metodoPagamento)
        {
            this.numeroContrato = numeroContrato;
            this.dataContrato = dataContrato;
            this.valorTotalContrato = valorTotalContrato;
            metodoPagamento = MetodoPagamento;
        }
    }
}
