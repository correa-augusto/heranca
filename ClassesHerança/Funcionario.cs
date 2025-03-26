using System;

namespace ClassesHerança;

public class Funcionario:Pessoa
{
    public decimal Salario{get; set;}
    public string Matricula{get; set;}

public Funcionario(string nome = "", string cpf = "", string rg = "", decimal salario =0, Endereco? logradouro = null, string
matricula = "") : base(nome, cpf, rg, logradouro)
{
// os atributos da classe base são herdados e inicializados pelo construtor da classe base
// atributos específicos da classe derivada
Salario = salario;
Matricula = matricula;
}
}
