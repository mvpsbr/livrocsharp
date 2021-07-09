using System;
using Xunit;

namespace Loja.Tests
{
    public class DescontoTests
    {
        [Fact]
        public void Quando_o_produto_eh_vermelho_o_desconto_eh_de_10_porcento()
        {
            //Preparar
            var desconto = new Desconto();
            
            //Executar
            var valor = desconto.Calcule(Cor.Vermelho);
            
            //Verificar
            Assert.Equal(10, valor);
        }

        [Fact]
        public void Quando_o_produto_eh_verde_o_desconto_eh_de_20_porcento()
        {
            //Preparar
            var desconto = new Desconto();
            
            //Executar
            var valor = desconto.Calcule(Cor.Verde);
            
            //Verificar
            Assert.Equal(20, valor);
        }

        [Fact]
        public void Quando_o_produto_eh_azul_o_desconto_eh_de_30_porcento()
        {
            //Preparar
            var desconto = new Desconto();
                    
            //Executar
            var valor = desconto.Calcule(Cor.Azul);
                    
            //Verificar
            Assert.Equal(30, valor);
        }

        [Fact]
        public void Quando_o_produto_eh_laranja_nao_ha_desconto()
        {
            //Preparar
            var desconto = new Desconto();
                    
            //Executar
            var valor = desconto.Calcule(Cor.Laranja);
                    
            //Verificar
            Assert.Equal(0, valor);
        }
    }
}
