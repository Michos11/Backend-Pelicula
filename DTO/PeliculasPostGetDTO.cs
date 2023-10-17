using PeliculasAPI.Entidades;

namespace PeliculasAPI.DTO
{
    public class PeliculasPostGetDTO
    {
        public List<GeneroDTO> Generos { get; set; }
        public List<CineDTO> Cines { get; set; }
    }
}
