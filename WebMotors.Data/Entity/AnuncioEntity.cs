using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebMotors.Data.Entity
{
    public class AnuncioEntity
    {
        [Key, Column("anuncio_id"), Required]
        public int AnuncioId { get; set; }

        [MaxLength(45), Column("marca"), Required]
        public string Marca { get; set; }

        [MaxLength(45), Column("modelo"), Required]
        public string Modelo { get; set; }

        [MaxLength(45), Column("versao"), Required]
        public string Versao { get; set; }

        [Column("ano"), Required]
        public int Ano { get; set; }

        [Column("quilometragem"), Required]
        public int Quilometragem { get; set; }

        [Column("observacao"), Required]
        public string Observacao { get; set; }
    }
}
