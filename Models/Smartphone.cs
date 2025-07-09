namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        private String Modelo;
        public String ModeloAparelho
        {
            get { return Modelo; }
        }

        private string IMEI;
        public string IMEIAparelho
        {
            get { return IMEI; }
        }
        private int Memoria;
        public int MemoriaAparelho
        {
            get { return Memoria; }
        }


        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            // TODO: Passar os parâmetros do construtor para as propriedades
            Numero = numero;
            this.Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}