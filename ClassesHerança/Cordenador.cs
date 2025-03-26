using System;

namespace ClassesHerança;

public class Cordenador:Funcionario
{
    public String SenhaAlarme{get; set;}

public Cordenador(string nome = "", string cpf = "", string rg = "", string matricula ="", decimal salario=0, Endereco? logradouro = null, string
senhaAlarme = "") : base(nome, cpf, rg, salario, logradouro)
{
SenhaAlarme = senhaAlarme;
}
}
