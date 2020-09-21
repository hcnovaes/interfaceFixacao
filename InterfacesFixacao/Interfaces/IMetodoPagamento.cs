using InterfacesFixacao.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesFixacao.Interfaces
{
    interface IMetodoPagamento
    {
        void CalcularParcela(double valorTotalContrato, DateTime dataContrato, int parcelas);

    }
}
