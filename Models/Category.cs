using System.Reflection.Metadata.Ecma335;

namespace SiteLanche.Models
{
    public class Category
    {
        public int CategoriaId { get; set; }

        public string CategoriaNome { get; set; }

        public string Descricao { get; set; }


        public List<Lanche> Lanche { get; set; }

    }
}
