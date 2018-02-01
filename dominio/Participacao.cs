
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
        public double Custo(){
            double desconto = 0;
            double custoParticipacao = Art.Cache - desconto;
            return custoParticipacao;
        }
        public double Custo(double desconto, double cache){
            this.Desconto = desconto;
            this.Art.Cache = cache;
            double custoParticipacao = cache - desconto;
            return custoParticipacao;
        }

        public override string ToString()
        {
            return Art.Name
                + "; Cachê: "
                + Art.Cache
                + "; Desconto: " 
                + Desconto.ToString("F2") 
                + "; Custo: " 
                + Custo().ToString("F2");
        }
    }
}
