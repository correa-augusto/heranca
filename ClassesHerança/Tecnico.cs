using System;

namespace ClassesHerança;

public class Tecnico: Funcionario
{

    public string Funcao {get; set;}
public Tecnico(string nome = "", string cpf="", string rg="", Endereco? endereco = null, decimal salario =0, string matricula = "", string funcao ="")
     : base(nome, cpf, rg, salario, endereco, matricula)
     {
        Funcao = funcao;
     }
}
