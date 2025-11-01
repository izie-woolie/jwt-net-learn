namespace JwtAuthLearn.Models
{
    public class RefrestTokenRequestDto
    {
        public Guid UserId { get; set; }
        public required string RefreshToken { get; set; }
    }
}
