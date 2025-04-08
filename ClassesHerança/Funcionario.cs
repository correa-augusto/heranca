using System;

namespace ClassesHerança;
//AUGUSTO DOS SANTOS CORREA

public class Funcionario : Pessoa
{
    public decimal Salario { get; set; }
    public string Matricula { get; set; }

    public Funcionario(string nome = "", string cpf = "", string rg = "", decimal salario = 0, Endereco? logradouro = null, string matricula = "")
        : base(nome, cpf, rg, logradouro)
    {
        Salario = salario;
        Matricula = matricula;
    }

    // implementa membro abstrato herdado "Pessoa.RetornarDados()
    public override List<(string campo, string valor)> RetornarDados()
    {
        // cria uma lista de tuplas com os dados do aluno, utilizando variavel temporaria embutida para criar a lista de tuplas
        return new List<(string campo, string valor)>
        {
            ("Nome", Nome), ("Cpf", Cpf), ("Rg", Rg),  ("Salário", Salario.ToString()), ("Matricula", Matricula.ToString()), ("Rua", Logradouro.Rua),
            ("Numero", Logradouro.Numero.ToString()), ("Bairro", Logradouro.Bairro), ("Cidade", Logradouro.Cidade),
            ("Estado", Logradouro.Estado), ("Cep", Logradouro.Cep.ToString()),
            ("Matricula", Matricula)
       };
    }

    public override string ToString()
    {
        return $"{GetType().Name} => Nome: {Nome}, CPF: {Cpf}, RG: {Rg}, Endereço: {Logradouro.Rua}, Salário: {Salario}, Matrícula: {Matricula}\n";
    }
}