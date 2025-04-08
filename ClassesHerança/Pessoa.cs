using System.Security.Cryptography.X509Certificates;

namespace ClassesHerança;
//AUGUSTO DOS SANTOS CORREA
public abstract class Pessoa
{
public string Nome { get; set; }
public string Cpf { get; set; }
public string Rg { get; set; }
public Endereco Logradouro { get; set; } // uso de delegação
// construtor com parâmetros opcionais
public Pessoa(string nome = "", string cpf = "", string rg = "", Endereco? logradouro = null)
{
Nome = nome;
Cpf = cpf;
Rg = rg;
Logradouro = logradouro ?? new Endereco();
}

// método abstrato, não tem implementação, deve ser implementado nas classes derivadas
public abstract List<(string campo,string valor)> RetornarDados();


    public override string ToString()
    {
        return $"{GetType().Name} => Nome: {Nome}, CPF: {Cpf}, RG: {Rg}, Endereço: {Logradouro.Rua}\n";
    }

}