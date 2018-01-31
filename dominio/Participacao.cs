
namespace dominio
{   
    public class Participacao
    {
        public double Desconto{ get; set; }
        public Artista artista { get; set; } //isso se chama AGREGAÇÃO
        public Filme filme { get; set; } //isso se chama AGREGAÇÃO
        
        public Participacao(double desconto, Artista artista, Filme filme) {
            this.Desconto = desconto;
            this.artista = artista;
            this.filme = filme;
        }

        //Acho que aqui, para conseguir usar o CACHÊ do artista eu tenho que 
        //pegar a lista de Artistas do Program.cs, cadastrada através da
        //classe Artista, e desconverter de string para double.
        public double Custo(double Desconto, double Cache){
            this.Desconto = Desconto;
            this.artista.Cache = Cache;
            double custoParticipacao =  Cache - Desconto;
            return custoParticipacao;
        }

        public override string ToString()
        {
            return Desconto
                + ", " + artista + ", FIlme: " + filme;
        }
    }
}
