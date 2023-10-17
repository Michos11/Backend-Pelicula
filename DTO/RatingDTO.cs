using System.ComponentModel.DataAnnotations;

namespace PeliculasAPI.DTO
{
    public class RatingDTO
    {
        public int PeliculaId { get; set; }
        [Range(1, 5)]
        public int Puntuacion {  get; set; }
    }
}
