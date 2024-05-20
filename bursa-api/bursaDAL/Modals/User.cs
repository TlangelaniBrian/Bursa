using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace bursaDAL.Modals
{
    public readonly record struct UserId(Guid Value)
    {
        public static UserId Empty => new(Guid.Empty);
        public static UserId NewUserId() => new(Guid.NewGuid());
        public static UserId ParseUserId(string id) => new(Guid.Parse(id));
    }
    public class User
    {
        [Key]
        public UserId Id { get; set; } = UserId.Empty;
        [Display(Name = "Role")]
        public RoleId RoleId { get; set; } = RoleId.Empty;

        [ForeignKey("RoleId")]
        public virtual Role? Role { get; set; }

        [MaxLength(50)]
        [Display(Name = "ID Number")]
        public required string IdNumber { get; set; }
        public string? PersonnelId { get; set; }
        public bool IsActive { get; set; }
        public required string Name { get; set; }
        public required string Surname { get; set; }
        public required string PhoneNumber { get; set; }
        public string Email { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public string? HashIDNumber { get; set; }
        public string? SaltIDNumber { get; set; }


    }
}
