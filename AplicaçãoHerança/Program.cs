using ClassesHerança;
internal class Program
{
    Program()
    {
        List<Pessoa> pessoas = new List<Pessoa>();


        var pessoa = new Pessoa("Augusto Dos Santos Corrêa", "013.177.149-75", "7283983", new Endereco("venezula", 667, "Frei rogerio", "lages", "sc"));

        var funcionario = new Funcionario("Augusto Dos Santos Corrêa", "013.177.249-75", "7283783", 1755, new Endereco("venezula", 667, "Frei rogerio", "lages", "sc"), "152122");
        
        var curso =  new Curso("Sistemas de informação", "curso de sistemas", 8000);

        var aluno1 = new Aluno("Augusto Dos Santos Corrêa", "013.177.149-75", "7283983", new Endereco("venezula", 667, "Frei rogerio", "lages", "sc"), 152122, curso);
        var aluno2 = new Aluno("Leonardo alves", "475.459.123-58", "7283983", new Endereco("venezula", 67, "Frei rogerio", "lages", "sc"), 152145, curso);
        var aluno3 = new Aluno("Nicolas Alves", "475.459.127-58", "7283983", new Endereco("rio do sul", 67, "varzea", "lages", "sc"), 152179, curso);

        var professor1 = new Professor("Augusto Dos Santos Corrêa", "013.177.149-75", "7283983",  new Endereco("venezula", 667, "Frei rogerio", "lages", "sc"), 1950, 2, "mestre", "tecnologia");
        var professor2 = new Professor("Tio lu", "013.177.149-75", "7283983", new Endereco("venezula", 667, "Frei rogerio", "lages", "sc"), 1755, 1, "mestre", "tecnologia");

        var cordenador = new Cordenador("Augusto Dos Santos Corrêa", "013.177.149-75", "7283983", "152122", 1800, new Endereco("venezula", 667, "Frei rogerio", "lages", "sc"), "AbcBolinhas");

        var tecnico = new Tecnico("Augusto Dos Santos Corrêa", "013.177.149-75", "7283983",  new Endereco("venezula", 667, "Frei rogerio", "lages", "sc"), 1, "1755", "Desenvolvedor");
        var tecnico2 = new Tecnico("Augusto Dos Santos Corrêa", "013.177.149-75", "7283983",  new Endereco("venezula", 667, "Frei rogerio", "lages", "sc"), 1, "1755", "Desenvolvedor");

Pessoa[] input = {
    pessoa,
    funcionario,
    aluno1,
    aluno2,
    aluno3,
    professor1,
    professor2,
    cordenador,
    tecnico,
    tecnico2
};
        pessoas.AddRange(input);

        foreach (var item in pessoas)
        {
            if (item.GetType() == typeof(Aluno))
            {
                Console.WriteLine($"{item.GetType().Name} => Nome: {item.Nome}, CPF: {item.Cpf}, RG: {item.Rg}, Endereço: {item.Logradouro.Rua}, Matrícula: {((Aluno)item).Matricula}, Curso: {((Aluno)item).CursoAluno.Nome}\n");
            }
            else if (item is Professor p) // verifica o tipo do objeto e referência em uma variável auxiliar do tipo correto
            {
                Console.WriteLine($"{item.GetType().Name} => Nome: {p.Nome}, CPF: {p.Cpf}, RG: {p.Rg}, Endereço: {p.Logradouro.Rua}, Salario:{p.Salario} Registro: {p.Registro}, Titulação: {p.Titulacao}, Área: {p.Area}\n");
            }
            else if(item is Funcionario f)
            {
                Console.WriteLine($"{item.GetType().Name} => Nome: {f.Nome}, CPF: {f.Cpf}, RG: {f.Rg}, Endereço: {f.Logradouro.Rua}, Salario; {f.Salario}, Matricula: {f.Matricula}\n");
            }
            else if(item is Tecnico t)
            {
                Console.WriteLine($"{item.GetType().Name} => Nome: {t.Nome}, CPF: {t.Cpf}, RG: {t.Rg}, Endereço: {t.Logradouro.Rua}, Salario; {t.Salario}, Matricula: {t.Matricula}, Função: {t.Funcao}\n");
            }
            else if(item is Cordenador c)
            {
                 Console.WriteLine($"{item.GetType().Name} => Nome: {c.Nome}, CPF: {c.Cpf}, RG: {c.Rg}, Endereço: {c.Logradouro.Rua}, Salario; {c.Salario}, Matricula: {c.Matricula}, Senha do alarme: {c.SenhaAlarme} \n");
            }
        }
    }
    private static void Main(string[] args)
    {
        _ = new Program();
    }
}