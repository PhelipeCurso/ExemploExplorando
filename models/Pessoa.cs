using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.models
{
    
    public class Pessoa
    {
         public Pessoa ()
         {

         }


        public Pessoa(string nome,string sobrenome)
        {
            Nome = nome;
            SobreNome = sobrenome;
        }

        public void Deconstruct(out string nome,out string sobrenome)
        {
            nome = Nome;
            sobrenome = SobreNome;

        }
        private string _nome;
        private string _sobrenome;
        private int _idade;
        public string Nome { get =>_nome.ToUpper();         
        
        set
        { 
            if (value=="")
            {
                throw new ArgumentException("O nome não pode ser vazio");
 
            }
            _nome = value;
        }
         }
        public int Idade 
        {
             get => _idade;
             
              set 
              {
                if (value <0)
                {
                    throw new ArgumentException("A idade não pode ser menor que zero");

                }
                _idade = value;
              }
         }
        public string SobreNome { get =>_sobrenome.ToUpper();
         set{
            if (value=="")
            {
                throw new ArgumentException("O Sobrenome não pode ser vazio");

            }
            _sobrenome = value;
         } }
        public string NomeCompleto =>$"{Nome} {SobreNome}";
        public void Apresentar()
        {
            System.Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");

        }
    }
}