
namespace dominio
{   
    public class Artista
    {
        public int Codigo{ get; set; }
        public string Name{ get; set; }
        public double Cache{ get; set; }

        /// <summary>
        /// Sobrecarga do método ARTISTA
        /// </summary>
        public Artista(){}
        /// <summary>
        /// Método que declara as variáveis que definem o ARTISTA
        /// </summary>
        /// <param name="codigo">Código do artista</param>
        /// <param name="name">nome do artista</param>
        /// <param name="cache">cachê do artista</param>
        public Artista(int codigo, string name, double cache){
            this.Codigo = codigo;
            this.Name = name;
            this.Cache = cache;
        }
        /// <summary>
        /// Eu acho que transforma as 3 variáveis de entrada numa string única, pra caber em lista
        /// </summary>
        /// <returns>Retorna as 3 variáveis que definem ARTISTA numa string única</returns>
        public override string ToString(){
            return Codigo
                + ", "+ Name + ", cache: " + Cache.ToString("F2");
        }
    }
}
