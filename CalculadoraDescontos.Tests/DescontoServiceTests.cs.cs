using CalculadoraDescontos.App;

namespace CalculadoraDescontos.Tests;

public class DescontoServiceTests
{
    [Theory]
    [InlineData(0, "BRONZE")]
    [InlineData(4, "BRONZE")]
    [InlineData(5, "PRATA")]
    [InlineData(10, "PRATA")]
    [InlineData(11, "OURO")]
    public void Deve_Classificar_Categoria_Do_Cliente(
        int totalCompras,
        string categoriaEsperada)
    {
        var service = new DescontoService();

        var resultado = service.ObterCategoriaCliente(totalCompras);

        Assert.Equal(categoriaEsperada, resultado);
    }

    [Theory]
    [InlineData(100, 10, 90)]
    [InlineData(200, 20, 160)]
    [InlineData(500, 50, 250)]
    public void Deve_Calcular_Valor_Final_Com_Desconto(
        int valorOriginal,
        int percentualDesconto,
        int valorEsperado)
    {
        var service = new DescontoService();

        var resultado = service.CalcularDescontoPorPercentual(
            valorOriginal,
            percentualDesconto);

        Assert.Equal(valorEsperado, resultado);
    }

    [Theory]
    [InlineData(18, false, true)]
    [InlineData(25, false, true)]
    [InlineData(17, true, true)]
    [InlineData(17, false, false)]
    public void Deve_Verificar_Elegibilidade_Para_Cupom(
        int idade,
        bool primeiraCompra,
        bool resultadoEsperado)
    {
        var service = new DescontoService();

        var resultado = service.EValidoParaCupom(
            idade,
            primeiraCompra);

        Assert.Equal(resultadoEsperado, resultado);
    }
}