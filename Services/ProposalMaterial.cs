using System.ComponentModel.DataAnnotations;

namespace BlazorAppTest.Services
{
    public class ProposalMaterial
    {
        [Required]
        [MaxLength(10)]
        public int ID { get; set; }

        [Required]
        [MaxLength(60)]
        public string Status { get; set; }

        [Required]
        [MaxLength(60)]
        public string TextStatus { get; set; }

        [Required]
        [MaxLength(60)]
        public string Name_Material { get; set; }

        [Required]
        [MaxLength(10)]
        public string Cod_Material { get; set; }

        [Required]
        [MaxLength(60)]
        public int Count { get; set; }

        [Required]
        [MaxLength(60)]
        public string Comment { get; set; }

        [Required]
        [MaxLength(10)]
        public int ProposalId { get; set; }
    }
}
