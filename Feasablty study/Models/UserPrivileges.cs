using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Feasablty_study.Models
{
    public class UserPrivileges
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int PrivilegeId { get; set; }
        public int UserId { get; set; }

        public virtual Privileges Privilege { get; set; }
        public virtual User User { get; set; }
    }
}
