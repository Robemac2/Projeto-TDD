namespace CalculadoraTest
{
    public class CalculadoraTest
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(3, 4, 7)]
        [InlineData(5, 6, 11)]
        public void TestarSomar(int x, int y, int resultado)
        {
            Calculadora.Calculadora calc = new();

            int resultadoCalculadora = calc.Somar(x, y);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(3, 4, 12)]
        [InlineData(5, 6, 30)]
        public void TestarMultiplicar(int x, int y, int resultado)
        {
            Calculadora.Calculadora calc = new();

            int resultadoCalculadora = calc.Multiplicar(x, y);

            Assert.Equal(resultado,resultadoCalculadora);
        }

        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(14, 7, 7)]
        [InlineData(16, 4, 12)]
        public void TestarSubtrair(int x, int y, int resultado)
        {
            Calculadora.Calculadora calc = new();

            int resultadoCalculadora = calc.Subtrair(x, y);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(8, 2, 4)]
        [InlineData(14, 7, 2)]
        [InlineData(16, 2, 8)]
        public void TestarDividir(int x, int y, int resultado)
        {
            Calculadora.Calculadora calc = new();

            int resultadoCalculadora = calc.Dividir(x, y);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Fact]
        public void TestarDividirPorZero()
        {
            Calculadora.Calculadora calc = new();

            Assert.Throws<DivideByZeroException>(() => calc.Dividir(3, 0));
        }

        [Fact]
        public void TestarHistorico()
        {
            Calculadora.Calculadora calc = new();

            calc.Somar(1, 6);
            calc.Somar(3, 3);
            calc.Somar(7, 9);
            calc.Somar(2, 1);
            calc.Somar(5, 4);

            var historico = calc.HistoricoResultados();

            Assert.NotEmpty(historico);
            Assert.Equal(3, historico.Count);
        }

        [Fact]
        public void TestarAdicionarHistoricoUnico()
        {
            Calculadora.Calculadora calc = new();

            calc.AdicionarHistorico(1);

            Assert.Single(calc.Historico);
        }

        [Fact]
        public void TestarAdicionarHistoricoMultiplo()
        {
            Calculadora.Calculadora calc = new();

            calc.AdicionarHistorico(1);
            calc.AdicionarHistorico(1);
            calc.AdicionarHistorico(1);
            calc.AdicionarHistorico(1);

            Assert.Equal(3, calc.Historico.Count);
        }
    }
}