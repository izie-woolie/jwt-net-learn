using JwtAuthLearn.Models;

namespace JwtAuthLearn.Services
{
    public interface IAuthService
    {
        Task<User?> RegisterAsync(UserDto request);
        Task<TokenResponseDto?> LoginAsync(UserDto request);

        Task<TokenResponseDto?> RefreshTokenAsync(RefrestTokenRequestDto request);
    }
}
