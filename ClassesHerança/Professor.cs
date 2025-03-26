namespace ClassesHerança;
public class Professor : Funcionario // herança, Professor é uma subclasse de Pessoa que é uma subclasse de Object
{
public int Registro { get; set; }
public string Titulacao { get; set; }
public string Area { get; set; }
// construtor com parâmetros opcionais
// construtor com parâmetros opcionais e uso de construtor da classe base
public Professor(string nome = "", string cpf = "", string rg = "", Endereco? logradouro = null, int salario=0, int registro =
0, string titulacao = "", string area = "") : base(nome, cpf, rg, salario, logradouro)
{
Registro = registro;
Titulacao = titulacao;
Area = area;
}
}