using CaixaEletronico.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    public class Caixa : ICaixa
    {
        public string RealizarSaque(int valor)
        {
            int[] cedulas = { 100, 50, 20, 10 };
            int[] lista = new int[4];
            
            int resto;
            string retorno = "";

            if (valor <= 0)
            {
                retorno = "Valor inválido! Insira um valor maior que 0";
            }

            for (int i = 0; i < cedulas.Length; i++)
            {
                if (valor >= cedulas[i])
                {
                    lista[i] = valor / cedulas[i];
                    valor = valor % cedulas[i];
                }
            }

            for (int i = 0; i < lista.Length; i++)
            {
                if (lista[i] >= 1 && lista[i] != 0)
                {
                    retorno += "Quantidade notas de R$ " + cedulas[i].ToString() + ": " + lista[i].ToString();                    
                }
            }
            if (valor <= 0)
            {
                return retorno;
            }
            else
            {
                return "Cédula indisponível";
            }                
        }
    }
}
