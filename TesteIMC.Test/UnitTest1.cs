namespace TesteIMC.Tests;

public class UnitTest1
{
    [Fact]
    public void Teste_Calculo_IMC()
    {
        double imc_previsto = 31.25;

        IMC i = new IMC();

        i.peso = 80;
        i.altura = 1.60;

        i.Calcular_IMC();

        Assert.Equal(imc_previsto, i.imc, 2);
    }

    [Theory]
    [InlineData("Abaixo do peso", 50, 1.80)] // Corrigido para corresponder ao método
    [InlineData("Peso normal", 70, 1.75)]
    [InlineData("Sobrepeso", 85, 1.75)]
    [InlineData("Obesidade de grau I", 95, 1.75)]
    [InlineData("Obesidade de grau II", 110, 1.75)]
    [InlineData("Obesidade de grau III", 130, 1.75)]
    public void Teste_Categoria_IMC(string categoriaEsperada, double peso, double altura)
    {
        IMC i = new IMC();

        i.peso = peso;
        i.altura = altura;

        i.Calcular_IMC();
        i.Classificar_IMC();

        Assert.Equal(categoriaEsperada, i.categoria);
    }
}
