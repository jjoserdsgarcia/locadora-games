namespace ProjetoWindowsForms___Senac
{
    public class Game
    {
        private static int contador = 1;
        public int Id { get; set; }
        public string Titulo {  get; set; }
        public string Plataforma { get; set; }
        public string Genero { get; set; }
        public decimal Valor { get; set; }
        public  int Ano { get; set; }

        public Game()
        {
            Id = contador;
            contador++;
        }
    }
}
