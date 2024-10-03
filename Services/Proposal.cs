using System.ComponentModel.DataAnnotations;

namespace BlazorAppTest.Services
{
    public class Proposal
    {
        [Required]
        [MaxLength(10)]
        public int ID { get; set; }

        [Required]
        [MaxLength(10)]
        public int Application_Num { get; set; }

        [Required]
        [MaxLength(60)]
        public DateTime Date_Creation { get; set; }

        [Required]
        [MaxLength(60)]
        public string FullNumber { get; set; }
        
        [Required]
        [MaxLength(60)]
        public string Status { get; set; }

        [Required]
        [MaxLength(60)]
        public string TextStatus { get; set; }

        [Required]
        [MaxLength(60)]
        public string Division { get; set; }

        [Required]
        [MaxLength(60)]
        public string Avtor { get; set; }
    }

}
