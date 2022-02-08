using Construtores.Models;

namespace Construtores
{
    internal class Program
    {
        public delegate void Operacao(int x, int y);

        static void Main(string[] args)
        {
            Matematica m = new(10, 20);
            m.Somar();

            //Operacao op = new(Calculadora.Somar);
            //op += Calculadora.Subtrair;
            //op.Invoke(12, 10);
            //op(12, 10);

           

            //const double pi = 3.14;
            //Console.WriteLine(pi);

            //Data data = new()
            //{
                //data.SetMes(20);
                //Mes = 20
            //};
            //Console.WriteLine(data.Mes);

            //data.ApresetarMes();
            //Log log = Log.GetInstance();

            //log.PropriedadeLog = "Teste instância";

            //Log log2 = Log.GetInstance();
            //Console.WriteLine(log2.PropriedadeLog);

            //Pessoa p1 = new("Marcelo", "Lopes");
            //p1.Apresentar();

            //Aluno p1 = new("Marcelo", "Lopes", "Teste");
            //p1.Apresentar();
        }
    }
}