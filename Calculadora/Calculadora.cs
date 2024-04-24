using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Calculadora
    {
        public List<string> Historico { get; set; }

        public Calculadora()
        {
            Historico = [];
        }

        public int Somar(int x, int y)
        {
            int resultado = x + y;

            AdicionarHistorico(resultado);

            return resultado;
        }

        public int Subtrair(int x, int y)
        {
            int resultado = x - y;

            AdicionarHistorico(resultado);

            return resultado;
        }

        public int Multiplicar(int x, int y)
        {
            int resultado = x * y;

            AdicionarHistorico(resultado);

            return resultado;
        }

        public int Dividir(int x, int y)
        {
            int resultado = x / y;

            AdicionarHistorico(resultado);

            return resultado;
        }

        public List<string> HistoricoResultados()
        {
            return Historico;
        }

        public void AdicionarHistorico(int x)
        {
            if (Historico.Count < 3)
            {
                Historico.Add(x.ToString());
            }
            else
            {
                Historico.RemoveAt(0);
                Historico.Add(x.ToString());
            }
        }
    }
}
