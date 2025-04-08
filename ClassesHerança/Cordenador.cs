namespace ClassesHerança;
//AUGUSTO DOS SANTOS CORREA

public class Cordenador : Funcionario
{
    public string SenhaAlarme { get; set; }

    public Cordenador(string nome, string cpf, string rg, string matricula, decimal salario, Endereco logradouro, string senhaAlarme)
        : base(nome, cpf, rg, salario, logradouro, matricula) 
    {
        SenhaAlarme = senhaAlarme;
    }

     public override List<(string campo, string valor)> RetornarDados()
       {
            // cria uma lista de tuplas com os dados do aluno, utilizando variavel temporaria embutida para criar a lista de tuplas
             return new List<(string campo, string valor)>
            {
                ("Nome", Nome), ("Cpf", Cpf), ("Rg", Rg), ("Matricula", Matricula.ToString()), ("Salário", Salario.ToString()), ("Rua", Logradouro.Rua),
                ("Numero", Logradouro.Numero.ToString()), ("Bairro", Logradouro.Bairro), ("Cidade", Logradouro.Cidade),
                ("Estado", Logradouro.Estado), ("Cep", Logradouro.Cep.ToString()),
                ("Senha Alarme", SenhaAlarme)
            };
        }


    public override string ToString()
    {
        return $"{Nome}, {Matricula}\n";
    }
}