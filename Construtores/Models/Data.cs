namespace Construtores.Models
{
    internal class Data
    {
        private int mes;
        private bool mesValido;

        public int GetMes()
        {
            return mes;
        }

        public void SetMes(int mes)
        {
            if(mes > 0 && mes <= 12)
            {
                this.mes = mes;
                mesValido = true;
            }
        }

        //Propriedade
        public int Mes 
        { 
            get {
                return mes;
            }  

            set
            {
                if(value > 0 && value <= 12)
                {
                    mes = value;
                    mesValido = true;
                }              
            } 
        }

        public void ApresetarMes()
        {
            if (mesValido)
            {
                Console.WriteLine(mes);
            }
            else
            {
                Console.WriteLine("Mês inválido.");
            }
        }
    }
}
