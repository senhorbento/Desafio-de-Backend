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
            Item item = new Item();
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
    }
}
