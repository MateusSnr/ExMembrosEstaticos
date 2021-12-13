using System;
using System.Collections.Generic;
using System.Text;

namespace MembrosEstaticos
{
    class ConversorDeMoeda
    {
        static public double CotacaoDolar;
        static public double QtdASerComprada;

        static public double ValorASerPagoEmReais()
        {
            return ((QtdASerComprada * CotacaoDolar)+((CotacaoDolar * QtdASerComprada) * 0.06));
        }
    }
}
