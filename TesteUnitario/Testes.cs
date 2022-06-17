using System;
using Xunit;
using System.Collections.Generic;

using Main;
using Entidades;

namespace TesteUnitario
{
    public class Testes
    {
        [Fact]
        public void TesteQuantoPagar()
        {

        }
        [Fact]
        public void TesteValidarListaItemVazia()
        {
            List<Item> listaItem = new();
            Assert.True(Metodo.ValidarListaItemVazia(listaItem));
        }
        [Fact]
        public void TesteValidarEmailsRepetidos()
        {
            List<Email> listaEmail = new();
            Assert.True(Metodo.ValidarListaEmailVazia(listaEmail));
        }
        [Fact]
        public void TesteValidarNegativo()
        {

        }
        [Fact]
        public void TesteSomarValores()
        {

        }
        [Fact]
        public void TesteDividirEntreEmails()
        {

        }
    }
}
