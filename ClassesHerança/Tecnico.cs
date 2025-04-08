using System;

namespace ClassesHerança;
//AUGUSTO DOS SANTOS CORREA

public class Tecnico : Funcionario
{
    public string Funcao { get; set; }

    public Tecnico(string nome = "", string cpf = "", string rg = "", Endereco? logradouro = null, decimal salario = 0, string matricula = "", string funcao = "")
        : base(nome, cpf, rg, salario, logradouro, matricula)
    {
        Funcao = funcao;
    }

         public override List<(string campo, string valor)> RetornarDados()
       {
             return new List<(string campo, string valor)>
            {
                ("Nome", Nome), ("Cpf", Cpf), ("Rg", Rg),  ("Rua", Logradouro.Rua),
                ("Numero", Logradouro.Numero.ToString()), ("Bairro", Logradouro.Bairro), ("Cidade", Logradouro.Cidade),
                ("Estado", Logradouro.Estado), ("Cep", Logradouro.Cep.ToString()),
                ("Salário", Salario.ToString()), 
                ("Função", Funcao)
            };
        }


    public override string ToString()
    {
        return $"{Nome}, {Funcao}\n";
    }
}