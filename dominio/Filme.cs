
namespace dominio
{   
    public class Filme
    {
        public int CodigoFilme{ get; set; }
        public string Titulo{ get; set; }
        public int Ano{ get; set; }
        //public Artista artista { get; set; } //isso se chama AGREGAÇÃO
        //public Participacao participacao { get; set; } //isso se chama AGREGAÇÃO

        /// <summary>
        /// Sobrecarga do método FILME
        /// </summary>
        public Filme() { }
        /// <summary>
        /// Método que declara as variáveis que definem o FILME
        /// </summary>
        /// <param name="codigofilme">Código do artista</param>
        /// <param name="titulo">nome do artista</param>
        /// <param name="ano">cachê do artista</param>
        public Filme(int codigofilme, string titulo, int ano)
        {
            this.CodigoFilme = codigofilme;
            this.Titulo = titulo;
            this.Ano = ano;
        }
        /// <summary>
        /// Eu acho que transforma as 3 variáveis de entrada numa string única, pra caber em lista
        /// </summary>
        /// <returns>Retorna as 3 variáveis que definem FILME numa string única</returns>
        public override string ToString()
        {
            return CodigoFilme + ", " + Titulo + ", ano: " + Ano.ToString("F2");
        }







        /// <summary>
        /// Calcula o custo total do filme, somando o custo de cada participação
        /// </summary>
        /// <returns>retorna o custo total do filme</returns>
        public double custoTotal(int Participacoes, double Custo){

            double custototal = Participacoes * Custo;

            return custototal;
            
        }
    }
}