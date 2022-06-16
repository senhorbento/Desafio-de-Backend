using System;

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

            Retornar um mapa/dicionário onde a chave será o e-mail e o valor será quanto ele deve pagar nessa conta.
            Ter testes unitários.
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

        public Dictionary <String, int> DividirEntreEmails (int totalConta, List <Email> listaEmail)
        {
            valorIndividual = totalConta/listaEmail.Count;
        }

    }
}