using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public UserId Id { get; set; } = UserId.Empty;
        [Display(Name = "Role")]
        public RoleId RoleId { get; set; } = RoleId.Empty;

        [ForeignKey("RoleId")]
        public virtual Role? Role { get; set; }

        [MaxLength(50)]
        [Display(Name = "ID Number")]
        public required string IdNumber { get; set; }
        [MaxLength(100)]
        public string? PersonnelId { get; set; }
        public bool IsActive { get; set; }
        [MaxLength(300)]
        public required string Name { get; set; }
        [MaxLength(300)]
        public required string Surname { get; set; }
        [MaxLength(30)]
        public required string PhoneNumber { get; set; }
        [MaxLength(150)]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        [MaxLength(500)]
        public string? HashIdNumber { get; set; }
        [MaxLength(500)]
        public string? SaltIdNumber { get; set; }
    }
}
