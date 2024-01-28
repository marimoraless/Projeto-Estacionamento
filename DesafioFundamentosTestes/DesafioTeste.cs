using DesafioFundamentos.Models;

namespace DesafioFundametoTestes
{
    public class FundamentoTestes
    {
        [Fact]
        public void DeveSalvarUmaPlaca()
        {
            Estacionamento estacionamento = new Estacionamento(5,1);
    
            estacionamento.AdicionarVeiculo("ABC123");

            var resultado = estacionamento.GetVeiculos().Count;

            Assert.Equal(1,resultado);

        }


        [Fact]
        public void DeveRemoverUmaPlaca()
        {

            Estacionamento estacionamento = new Estacionamento(5, 1);

            estacionamento.AdicionarVeiculo("ABC123");

            estacionamento.RemoverVeiculo("ABC123" , 3);

            var resultado = estacionamento.GetVeiculos().Count;

            Assert.Equal(0, resultado);

        }
    }
}
