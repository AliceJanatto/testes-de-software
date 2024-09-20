namespace Calculadora.Tests
{
    public class CalculadoraTest
    {
        [Fact]
        public void Somar()
        {
            Assert.Equal(4, calculadora.Calculadora.Somar(2, 2));
        }

        [Fact]
        public void Subtrair()
        {
            Assert.Equal(2, calculadora.Calculadora.Subtrair(3, 1));
        }

        [Fact]
        public void Dividir()
        {
            Assert.Equal(2, calculadora.Calculadora.Dividir(4, 2));
        }

        [Fact]
        public void Multiplicar()
        {
            Assert.Equal(20, calculadora.Calculadora.Multiplicar(4, 5));
        }
    }
}