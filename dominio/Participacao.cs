
namespace dominio
{   
    public class Participacao
    {
        public double Desconto{ get; set; }
        public Artista Art { get; set; } //isso se chama AGREGAÇÃO
        public Filme Film { get; set; } //isso se chama AGREGAÇÃO
        
        public Participacao(double desconto, Artista artista, Filme filme) {
            this.Desconto = desconto;
            this.Art = artista;
            this.Film = filme;
        }

        //Acho que aqui, para conseguir usar o CACHÊ do artista eu tenho que 
        //pegar a lista de Artistas do Program.cs, cadastrada através da
        //classe Artista, e desconverter de string para double.
        public double Custo(double desconto, double cache){
            this.Desconto = desconto;
            this.Art.Cache = cache;
            double custoParticipacao = cache - desconto;
            return custoParticipacao;
        }

        public override string ToString()
        {
            return "Desconto: " 
                + desconto.ToString("F2") 
                + ", Custo: " 
                + Custo().ToString("F2");
        }
    }
}
