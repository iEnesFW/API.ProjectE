public interface IAuthService
{
    Task<string> LoginAsync(LoginDto loginDto);
    Task RegisterAsync(RegisterDto registerDto);
}
