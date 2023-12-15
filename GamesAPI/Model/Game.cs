using System.ComponentModel.DataAnnotations;

namespace GamesAPI.Model
{
    public class Game
    {
        public int GameID { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        [Required]
        public DateTime DateCreated { get; set; }

        [Required]
        [StringLength(100)]
        public string Genre { get; set; }

        [StringLength(300)]
        public string Description { get; set; }

        [Required]
        public bool Active { get; set; }
    }
}
