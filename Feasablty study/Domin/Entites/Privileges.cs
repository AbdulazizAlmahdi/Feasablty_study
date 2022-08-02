using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Feasablty_study.Models
{
    public class Privileges
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]  
        [StringLength(50)]
        public string Name { get; set; }
        public string Description { get; set; }
        
    }
}
