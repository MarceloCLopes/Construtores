namespace Construtores.Models
{
    internal class Pessoa
    {
        private readonly string nome = "David";
        private readonly string sobrenome;

        //Construtor padrão
        public Pessoa()
        {
            nome = string.Empty;
            sobrenome = string.Empty;
        }

        //Construtor com parâmetros
        public Pessoa(string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            //Console.WriteLine("Construtor classe pessoa!");
        }

        //Método
        public void Apresentar() => Console.WriteLine($"Olá, meu nome é: {nome} {sobrenome}");
    }
}
