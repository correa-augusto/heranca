using System.Reflection.Metadata;
using ClassesHerança;
//AUGUSTO DOS SANTOS CORREA
internal class Program
{
    Program()
    {
        List<Pessoa> pessoas = new List<Pessoa>();
        

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("========== Cadastro dos alunos ==========\n");

            string nome = LerEntradaObrigatoria("Nome: ");
            string cpf = LerEntradaObrigatoria("Cpf: ");
            string rg = LerEntradaObrigatoria("Rg: ");
            string rua = LerEntradaObrigatoria("Rua: ");
            string numero = LerNumeroObrigatorio("Numero: ").ToString();
            string bairro = LerEntradaObrigatoria("Bairro: ");
            string cidade = LerEntradaObrigatoria("Cidade: ");
            string estado = LerEntradaObrigatoria("Estado: ");
            string cep = LerEntradaObrigatoria("Cep: ");
            string matricula = LerNumeroObrigatorio("Matrícula: ").ToString();
            string nomeCurso = LerEntradaObrigatoria("Curso: ");

            Console.WriteLine("========== Cadastro dos alunos ==========\n");

            Curso curso = new Curso(nomeCurso);

            Endereco endereco = new Endereco(rua, int.Parse(numero), bairro, cidade, estado, cep);

            Aluno aluno = new Aluno(nome, cpf, rg, endereco, int.Parse(matricula), curso);
            pessoas.Add(aluno);
        }

        for (int i = 0; i < 2; i++)
        {
               Console.WriteLine("========== Cadastro dos Professores ==========\n");

            string nome = LerEntradaObrigatoria("Nome: ");
            string cpf = LerEntradaObrigatoria("Cpf: ");
            string rg = LerEntradaObrigatoria("Rg: ");
            string rua = LerEntradaObrigatoria("Rua: ");
            string numero = LerNumeroObrigatorio("Numero: ").ToString();
            string bairro = LerEntradaObrigatoria("Bairro: ");
            string cidade = LerEntradaObrigatoria("Cidade: ");
            string estado = LerEntradaObrigatoria("Estado: ");
            string cep = LerEntradaObrigatoria("Cep: ");
            string salario = LerDecimalObrigatorio("Salario: ").ToString();
            string registro = LerNumeroObrigatorio("Registro: ").ToString();
            string titulacao = LerEntradaObrigatoria("Titulação: ");
            string area = LerEntradaObrigatoria("Area: ");

            Console.WriteLine("========== Cadastro dos Professores  ==========\n");

             Endereco endereco = new Endereco(rua, int.Parse(numero), bairro, cidade, estado, cep);
             Professor professor = new Professor(nome, cpf, rg, endereco, decimal.Parse(salario), int.Parse(registro), titulacao, area);
             pessoas.Add(professor);
        }

        for (int i = 0; i < 1; i++)
        {
               Console.WriteLine("========== Cadastro coordenador ==========\n");

            string nome = LerEntradaObrigatoria("Nome: ");
            string cpf = LerEntradaObrigatoria("Cpf: ");
            string rg = LerEntradaObrigatoria("Rg: ");
            string matricula = LerEntradaObrigatoria("Matrícula: ");
            string salario = LerDecimalObrigatorio("Salario: ").ToString();
            string rua = LerEntradaObrigatoria("Rua: ");
            string numero = LerNumeroObrigatorio("Numero: ").ToString();
            string bairro = LerEntradaObrigatoria("Bairro: ");
            string cidade = LerEntradaObrigatoria("Cidade: ");
            string estado = LerEntradaObrigatoria("Estado: ");
            string cep = LerEntradaObrigatoria("Cep: ");
            string senhaAlarme = LerEntradaObrigatoria("Senha do alarme: ");

            Console.WriteLine("========== Cadastro coordenador ==========\n");

             Endereco endereco = new Endereco(rua, int.Parse(numero), bairro, cidade, estado, cep);
             Cordenador cordenador = new Cordenador(nome, cpf, rg, matricula, decimal.Parse(salario), endereco, senhaAlarme);
             pessoas.Add(cordenador);
        }

        for (int i = 0; i < 2; i++)
        {
               Console.WriteLine("========== Cadastro dos tecnicos ==========\n");

            string nome = LerEntradaObrigatoria("Nome: ");
            string cpf = LerEntradaObrigatoria("Cpf: ");
            string rg = LerEntradaObrigatoria("Rg: ");
            string rua = LerEntradaObrigatoria("Rua: ");
            string numero = LerNumeroObrigatorio("Numero: ").ToString();
            string bairro = LerEntradaObrigatoria("Bairro: ");
            string cidade = LerEntradaObrigatoria("Cidade: ");
            string estado = LerEntradaObrigatoria("Estado: ");
            string cep = LerEntradaObrigatoria("Cep: ");
            string salario = LerDecimalObrigatorio("Salario: ").ToString();
             string funcao = LerEntradaObrigatoria("Função: ");

            Console.WriteLine("========== Cadastro dos tecnicos ==========\n");

             Endereco endereco = new Endereco(rua, int.Parse(numero), bairro, cidade, estado, cep);
             Tecnico tecnico = new Tecnico(nome, cpf, rg, endereco, decimal.Parse(salario), funcao);
             pessoas.Add(tecnico);
        }
        

        foreach (var item in pessoas)
        {
            Console.Write($"{item.GetType().Name} => ");
            foreach (var (campo, valor) in item.RetornarDados())
            {
                Console.Write($"{campo}: {valor}, ");
            }
            Console.WriteLine("");
        }
    }
    

    static string LerEntradaObrigatoria(string mensagem)
    {
        string entrada;
        do
        {
            Console.Write(mensagem);
            entrada = Console.ReadLine()?.Trim();
            if (string.IsNullOrEmpty(entrada))
            {
                Console.WriteLine("Campo não pode ser vazio");
            }
        } while (string.IsNullOrEmpty(entrada));

        return entrada;
    }


    static int LerNumeroObrigatorio(string mensagem)
    {
        int numero;
        string entrada;
        do
        {
            Console.Write(mensagem);
            entrada = Console.ReadLine()?.Trim();

            if (string.IsNullOrEmpty(entrada) || !int.TryParse(entrada, out numero))
            {
                Console.WriteLine("Erro: Digite um número válido.");
            }
        } while (string.IsNullOrEmpty(entrada) || !int.TryParse(entrada, out numero));

        return numero;
    }

    static decimal LerDecimalObrigatorio(string mensagem)
{
    decimal numero;
    string entrada;
    do
    {
        Console.Write(mensagem);
        entrada = Console.ReadLine()?.Trim();

        if (string.IsNullOrEmpty(entrada) || !decimal.TryParse(entrada, out numero))
        {
            Console.WriteLine("Erro: Digite um número decimal válido (ex: 123.45).");
        }
    } while (string.IsNullOrEmpty(entrada) || !decimal.TryParse(entrada, out numero));

    return numero;
}
    private static void Main(string[] args)
    {
        _ = new Program();
    }
}