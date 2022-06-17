using System;
using System.Collections.Generic;

using Entidades;

namespace Main
{
    public class Metodo
    {
        public static Dictionary <String, int> QuantoPagar (List <Item> listaItem, List <Email> listaEmail)
        {
            int totalConta;
            Dictionary<String, int> dicionario = new();
            if (!ValidarListaItemVazia(listaItem))
            {
                if (!ValidarListaEmailVazia(listaEmail))
                {
                    if (!ValidarEmailsRepetidos(listaEmail))
                    {
                        if (!ValidarNegativo(listaItem))
                        {
                            totalConta = SomarValores(listaItem);
                            return DividirEntreEmails(totalConta, listaEmail);
                        }
                        else
                        {
                            dicionario.Add("Encontrado valor negativo!", -1);
                        }
                    }
                    else
                    {
                        dicionario.Add("Encontrado email repetido!", -1);
                    }
                }
                else
                {
                    dicionario.Add("Lista email vazia!", -1);
                }
            }
            else
            {
                dicionario.Add("Lista item vazia!", -1);
            }
            return dicionario;
        }

        public static bool ValidarListaItemVazia(List<Item> lista)
        {
            if (lista.Count > 0)
                return false;
            return true;
        }

        public static bool ValidarListaEmailVazia(List<Email> lista)
        {
            if (lista.Count > 0)
                return false;
            return true;
        }

        public static bool ValidarEmailsRepetidos (List <Email> listaEmail)
        {
            int qtd;
            foreach (Email item in listaEmail)
            {
                qtd = 0;
                foreach (Email item2 in listaEmail)
                {
                    if (item.email == item2.email)
                        qtd++;
                    if(qtd == 2)
                        return true;
                }
            }
            return false;
        }

        public static bool ValidarNegativo (List <Item> listaItem)
        {
            foreach (Item item in listaItem)
            {
                if(item.quantidade < 0 || item.preco < 0)
                    return true;
            }
            return false;
        }

        public static int SomarValores (List <Item> listaItem)
        {
            int valor = 0;
            foreach (Item item in listaItem)
            {
                valor += (item.quantidade * item.preco);
            }
            return valor;
        }

        public static Dictionary <String, int> DividirEntreEmails (int totalConta, List <Email> listaEmail)
        {
            Dictionary <String, int> dicionario = new ();
            int valorIndividual = totalConta / listaEmail.Count;
            int resto = totalConta % listaEmail.Count;

            foreach(Email item in listaEmail)
            {
                if(resto > 0)
                {
                    dicionario.Add(item.email, valorIndividual + 1);
                    resto--;
                }
                else
                {
                    dicionario.Add(item.email, valorIndividual);
                }

            }
            return dicionario;
        }

    }
}