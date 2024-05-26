using bursaAPI.Repository;
using bursaDAL.Modals;

namespace bursaAPI.Application.Admin
{
    public class SystemUser
    {
        private readonly IBursaService _dbService;

        public SystemUser(IBursaService bursaService)
        {
            _dbService = bursaService;
        }

        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public string IdNumber { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }

        public int CreateNewUser(SystemUser user)
        {
            var newUser = new User
            {
                IdNumber = "9302275544089",
                Name = user.Name,
                Surname = user.Surname,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                DateOfBirth = new DateTime(1993, 02, 27),


            };
            return _dbService.AddStudentUser(newUser).Result;
        }
    }
}
