using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace trilha_explorando_C_.Models
{
    public class Pessoa
    {   
        //criando um construtor
        public Pessoa()
        {
            
        }

        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        // campo para armazenar o nome
        private string _nome;
        private int _idade;

        // propriedade com get e set
        public string Nome { 
            //body expression
            get => _nome.ToUpper();
            
            
            set
            {
                //validando e criando uma exceção 
                if(value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _nome = value;
            }
             }
        
        public string Sobrenome { get; set; }

        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        public int Idade { 
            get => _idade; 
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("O valor não pode ser negativo");
                }
                _idade = value;
            }
            }

        public void Apresentar()
        {
            Console.WriteLine($"Meu nome é {NomeCompleto} e tenho {Idade} anos");
        }
    }
}