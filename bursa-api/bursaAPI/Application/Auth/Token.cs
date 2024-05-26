namespace bursaAPI.Application.Auth
{

    public class Token
    {
        public required string JwtToken { get; set; }
        public DateTime JwtTokenExpiryDate { get; set; }
        public required string JwtRefreshToken { get; set; }
        public DateTime JwtRefreshExpiryDate { get; set; }

    }
}
