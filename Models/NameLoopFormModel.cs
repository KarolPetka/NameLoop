using System.ComponentModel.DataAnnotations;
namespace Lab3_test3.Models
{
    public class NameLoopFormModel
    {
        [Display(Name = "Imię")]
        [Required]
        public string Name { get; set; }
        [Display(Name = "Ilość pętli")]
        public int LoopAmount { get; set; }
    }
}
