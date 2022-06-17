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
            List<Item> listaItem = new();

            Item item = new Item();
            item.preco = -10;
            item.quantidade = 10;
            item.item = "Banana";

            listaItem.Add(item);

            Assert.True(Metodo.ValidarNegativo(listaItem));
        }
        [Fact]
        public void TesteSomarValores()
        {
            List<Item> listaItem = new();

            Item item = new Item();
            item.preco = 100;
            item.quantidade = 10;
            item.item = "Banana";
            listaItem.Add(item);

            item = new ();
            item.preco = 234;
            item.quantidade = 5;
            item.item = "Uva";
            listaItem.Add(item);

            Assert.Equal(2170, Metodo.SomarValores(listaItem));
        }
        [Fact]
        public void TesteDividirEntreEmails()
        {

        }
    }
}
