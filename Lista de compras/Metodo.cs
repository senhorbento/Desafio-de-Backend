using System;
using System.Collections.Generic;

using Entidades;

namespace Main 
{
    public class Metodo
    {
        int totalConta;
        public Dictionary <String, int> QuantoPagar (List <Item> listaItem, List <Email> listaEmail)
        {
            if (listaItem != null)
            {
                if (listaEmail != null)
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
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }
            }
            else
            {
                break;
            }
        }

        private bool ValidarEmailsRepetidos (List <Email> listaEmail)
        {
            int qtd=0;
            foreach (Email item in listaEmail)
            {
                foreach (Email item2 in listaEmail)
                {
                    if(item == item2){
                        qtd++;
                    }
                    if(qtd==2){
                        return true;
                    }
                }
            }
            return false;
        }

        private bool ValidarNegativo (List <Item> listaItem)
        {
            foreach (Email item in listaItem)
            {
                if(item.quantidade < 0 || item.preco < 0)
                return true;
            }
            return false;
        }

        private int somarValores (List <Item> listaItem)
        {
            int valor = 0;
            foreach (Email item in listaItem)
            {
                valor += (item.quantidade * item.preco);
            }
            return valor;
        }

        private Dictionary <String, int> DividirEntreEmails (int totalConta, List <Email> listaEmail)
        {
            Dictionary <String, int> dicionario = new ();
            int valorIndividual = totalConta / listaEmail.Count;
            int resto = totalConta % listaEmail.Count;

            foreach(Email item in listaEmail)
            {
                if(resto > 0)
                {
                    dicionario.Add(valorIndividual+1,item);
                    resto--;
                }
                else
                {
                    dicionario.Add(valorIndividual,item);
                }

            }
            return dicionario;
        }

    }
}