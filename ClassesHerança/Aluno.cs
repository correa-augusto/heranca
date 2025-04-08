namespace ClassesHerança
//AUGUSTO DOS SANTOS CORREA
{
    public class Aluno : Pessoa
    {
        public int Matricula { get; set; }
        public Curso CursoAluno { get; set; } // uso de delegação

        // Construtor com parâmetros opcionais
        public Aluno(string nome = "", string cpf = "", string rg = "", Endereco? logradouro = null, int matricula = 0, Curso? cursoAluno = null)
            : base(nome, cpf, rg, logradouro)
        {
            Matricula = matricula;
            CursoAluno = cursoAluno ?? new Curso(); // Se o curso for nulo, inicializa com um novo Curso
        }

        public override List<(string campo, string valor)> RetornarDados()
        {
            return new List<(string campo, string valor)>
            {
               ("Nome", Nome),
               ("Cpf", Cpf),
               ("Rg", Rg),
               ("Rua", Logradouro.Rua),
               ("Numero", Logradouro.Numero.ToString()),
               ("Bairro", Logradouro.Bairro),
               ("Cidade", Logradouro.Cidade),
               ("Estado", Logradouro.Estado),
               ("Cep", Logradouro.Cep.ToString()),
               ("Matricula", Matricula.ToString()),
               ("Curso Aluno", CursoAluno.Descricao)
            };
        }

        public override string ToString()
        {
            return $"{Nome}, {Matricula}, {CursoAluno.Nome},\n";
        }
    }
}