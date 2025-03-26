namespace ClassesHerança;
public class Aluno : Pessoa // herança, Aluno é uma subclasse de Pessoa que é uma subclasse de Object
{
public int Matricula { get; set; }
public Curso CursoAluno { get; set; } // uso de delegação
// construtor com parâmetros opcionais
// construtor com parâmetros opcionais e uso de construtor da classe base
public Aluno(string nome = "", string cpf = "", string rg = "", Endereco? logradouro = null, int
matricula = 0, Curso? cursoAluno = null) : base(nome, cpf, rg, logradouro)
{
// os atributos da classe base são herdados e inicializados pelo construtor da classe base
// atributos específicos da classe derivada
Matricula = matricula;
CursoAluno = cursoAluno ?? new Curso();
}
}