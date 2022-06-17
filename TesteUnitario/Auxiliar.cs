using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;

namespace TesteUnitario
{
    public class Auxiliar
    {
        public static void PreencherListaItem(List<Item> listaItem)
        {
            Item item = new();
            item.preco = 100;
            item.quantidade = 10;
            item.item = "Banana";
            listaItem.Add(item);

            item = new();
            item.preco = 234;
            item.quantidade = 5;
            item.item = "Uva";
            listaItem.Add(item);
        }

        public static void PreencherListaEmail (List<Email> listaEmail)
        {
            Email email = new();
            email.email = "lucas@gmail.com.br";
            listaEmail.Add(email);

            email = new();
            email.email = "irineu@gmail.com.br";
            listaEmail.Add(email);

            email = new();
            email.email = "tadeu@gmail.com.br";
            listaEmail.Add(email);
        }

    }
}
