using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace trilha_explorando_C_.Models
{
    public class LeituraArquivo
    {
        //metodo com tupla
        public (bool Sucesso, string[] Linhas, int QuantidadeLinhas) LerArquivo(string caminho)
        {
            try
            {
                string[] linhas = File.ReadAllLines(caminho);
                return (true, linhas, linhas.Count());
            }catch(Exception)
            {
                return(false, new string[0], 0);
            }
        }
    }
}