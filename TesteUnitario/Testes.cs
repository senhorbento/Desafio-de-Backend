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
        public void TesteQuantoPagar1()
        {
            List<Item> listaItem = new();
            List<Email> listaEmail = new();
            Dictionary<String, int> dicionario = new();

            Auxiliar.PreencherListaItem(listaItem);
            Auxiliar.PreencherListaEmail(listaEmail);

            dicionario.Add("lucas@gmail.com.br", 724);
            dicionario.Add("irineu@gmail.com.br", 723);
            dicionario.Add("tadeu@gmail.com.br", 723);

            Assert.Equal(dicionario, Metodo.DividirEntreEmails(Metodo.SomarValores(listaItem), listaEmail));
        }

        [Fact]
        public void TesteQuantoPagar2()
        {
            List<Item> listaItem = new();
            List<Email> listaEmail = new();
            Dictionary<String, int> dicionario = new();

            Item item = new();
            item.preco = 1;
            item.quantidade = 1;
            item.item = "Banana";
            listaItem.Add(item);

            Auxiliar.PreencherListaEmail(listaEmail);

            dicionario.Add("lucas@gmail.com.br", 1);
            dicionario.Add("irineu@gmail.com.br", 0);
            dicionario.Add("tadeu@gmail.com.br", 0);

            Assert.Equal(dicionario, Metodo.DividirEntreEmails(Metodo.SomarValores(listaItem), listaEmail));
        }

        [Fact]
        public void TesteQuantoPagar3()
        {
            List<Item> listaItem = new();
            List<Email> listaEmail = new();
            Dictionary<String, int> dicionario = new();

            Item item = new();
            item.preco = 100;
            item.quantidade = 1;
            item.item = "Banana";
            listaItem.Add(item);

            Auxiliar.PreencherListaEmail(listaEmail);

            dicionario.Add("lucas@gmail.com.br", 34);
            dicionario.Add("irineu@gmail.com.br", 33);
            dicionario.Add("tadeu@gmail.com.br", 33);

            Assert.Equal(dicionario, Metodo.DividirEntreEmails(Metodo.SomarValores(listaItem), listaEmail));
        }

        [Fact]
        public void TesteQuantoPagar4()
        {
            List<Item> listaItem = new();
            List<Email> listaEmail = new();
            Dictionary<String, int> dicionario = new();

            Item item = new();
            item.preco = 102;
            item.quantidade = 1;
            item.item = "Banana";
            listaItem.Add(item);

            Auxiliar.PreencherListaEmail(listaEmail);
            Email email = new();
            email.email = "joao@gmail.com.br";
            listaEmail.Add(email);

            dicionario.Add("lucas@gmail.com.br", 26);
            dicionario.Add("irineu@gmail.com.br", 26);
            dicionario.Add("tadeu@gmail.com.br", 25);
            dicionario.Add("joao@gmail.com.br", 25);

            Assert.Equal(dicionario, Metodo.DividirEntreEmails(Metodo.SomarValores(listaItem), listaEmail));
        }

        [Fact]
        public void TesteValidarListaItemVazia()
        {
            List<Item> listaItem = new();
            Assert.True(Metodo.ValidarListaItemVazia(listaItem));
        }

        [Fact]
        public void TesteListaEmailVazia()
        {
            List<Email> listaEmail = new();
            Assert.True(Metodo.ValidarListaEmailVazia(listaEmail));
        }

        [Fact]
        public void TesteValidarEmailsRepetidos()
        {
            List<Email> listaEmail = new();
            Email email = new();
            email.email = "lucas@gmail.com.br";
            listaEmail.Add(email);

            email = new();
            email.email = "irineu@gmail.com.br";
            listaEmail.Add(email);

            email = new();
            email.email = "lucas@gmail.com.br";
            listaEmail.Add(email);

            Assert.True(Metodo.ValidarEmailsRepetidos(listaEmail));
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
            Auxiliar.PreencherListaItem(listaItem);

            Assert.Equal(2170, Metodo.SomarValores(listaItem));
        }

        [Fact]
        public void TesteDividirEntreEmails()
        {
            List<Item> listaItem = new();
            List<Email> listaEmail = new();
            Dictionary<String, int> dicionario = new();

            Auxiliar.PreencherListaItem(listaItem);
            Auxiliar.PreencherListaEmail(listaEmail);

            dicionario.Add("lucas@gmail.com.br", 724);
            dicionario.Add("irineu@gmail.com.br", 723);
            dicionario.Add("tadeu@gmail.com.br", 723);

            Assert.Equal(dicionario, Metodo.DividirEntreEmails(Metodo.SomarValores(listaItem), listaEmail));
        }

    }
}
