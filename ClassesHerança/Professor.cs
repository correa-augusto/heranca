namespace ClassesHerança
//AUGUSTO DOS SANTOS CORREA
{
    public class Professor : Funcionario
    {
        public int Registro { get; set; }
        public string Titulacao { get; set; }
        public string Area { get; set; }

        // Construtor com parâmetros opcionais
        public Professor(string nome = "", string cpf = "", string rg = "", Endereco? logradouro = null, decimal salario = 0, int registro = 0, string titulacao = "", string area = "", string matricula = "") : base(nome, cpf, rg, salario, logradouro, matricula)
        {
            Registro = registro;
            Titulacao = titulacao;
            Area = area;
        }

        // implementa membro abstrato herdado "Pessoa.RetornarDados()
       public override List<(string campo, string valor)> RetornarDados()
       {
            // cria uma lista de tuplas com os dados do aluno, utilizando variavel temporaria embutida para criar a lista de tuplas
             return new List<(string campo, string valor)>
            {
                ("Nome", Nome), ("Cpf", Cpf), ("Rg", Rg), ("Rua", Logradouro.Rua),
                ("Numero", Logradouro.Numero.ToString()), ("Bairro", Logradouro.Bairro), ("Cidade", Logradouro.Cidade),
                ("Estado", Logradouro.Estado), ("Cep", Logradouro.Cep.ToString()),
                ("Salário", Salario.ToString()), ("Matricula", Matricula.ToString()),
                ("Titulacao", Titulacao), ("Area", Area)
            };
        }
        public override string ToString()
        {
            return $"{Nome}, {Titulacao}, {Matricula}\n";
        }
    }
}