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
            if (listaItem.Count > 0)
            {
                if (listaEmail.Count > 0)
                {
                    if (!ValidarEmailsRepetidos(listaEmail))
                    {
                        if (!ValidarNegativo(listaItem))
                        {
                            totalConta = somarValores(listaItem);
                            return DividirEntreEmails(totalConta, listaEmail);
                        }
                        else
                        {
                            Console.WriteLine("Encontrado valor negativo!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Encontrado email repetido!");
                    }
                }
                else
                {
                    Console.WriteLine("Lista email vazia!");
                }
            }
            else
            {
                Console.WriteLine("Lista item vazia!");
            }
            return dicionario;
        }

        private static bool ValidarEmailsRepetidos (List <Email> listaEmail)
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

        private static bool ValidarNegativo (List <Item> listaItem)
        {
            foreach (Item item in listaItem)
            {
                if(item.quantidade < 0 || item.preco < 0)
                return true;
            }
            return false;
        }

        private static int somarValores (List <Item> listaItem)
        {
            int valor = 0;
            foreach (Item item in listaItem)
            {
                valor += (item.quantidade * item.preco);
            }
            return valor;
        }

        private static Dictionary <String, int> DividirEntreEmails (int totalConta, List <Email> listaEmail)
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