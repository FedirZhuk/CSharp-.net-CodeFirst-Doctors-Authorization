using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using Cwiczenia9.Entities;
using Cwiczenia9.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;

namespace Cwiczenia9.Services;

public class AccountDbService : IAccountDbService
{
    private readonly MedDbContext _dbContext;

    public AccountDbService(MedDbContext context)
    {
        _dbContext = context;
    }
    
    public object LoginUser(LoginRequest request)
    {
        var user = _dbContext.Users.FirstOrDefault(u => u.Login == request.Login);

        if (user != null)
        {
            var hasher = new PasswordHasher<LoginRequest>();
            var result = hasher.VerifyHashedPassword(request, user.Password, request.Password);
            if (result == PasswordVerificationResult.Success)
            {
                var claims = new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.Login),
                    new Claim("Custom", "SomeData"),
                    new Claim(ClaimTypes.Role, "admin")
                };

                var secret = "falsjkdnvihmucsjdnbvldfcsmadjhgnsbdofjfnvbnilfdos;amsfhfblksgbsajhbfdshkbfkhsdbfkdsbfkdshbfhkdsbhkdbfanfjkxbkadnfdjfbnhidsgnsdk";
                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secret));
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var options = new JwtSecurityToken("https://localhost:5174", "https://localhost:5174",
                    claims, expires: DateTime.UtcNow.AddMinutes(5),
                    signingCredentials: creds);

                var refreshToken = GenerateRefreshToken();

                return new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(options),
                    refreshToken
                };
            }
        }

        throw new Exception("Unauthorized");
    }

    public object CreateUser(LoginRequest request)
    {
        var hasher = new PasswordHasher<User>();
        var hashedPassword = hasher.HashPassword(null, request.Password);

        var newUser = new User()
        {
            Login = request.Login,
            Password = hashedPassword
        };

        _dbContext.Users.Add(newUser);
        _dbContext.SaveChanges();
        return hashedPassword;
    }


public object RefreshToken()
    {
        return GenerateRefreshToken();
    }
    
    private string GenerateRefreshToken()
    {
        using (var genNum = RandomNumberGenerator.Create())
        {
            var r = new byte[64];
            genNum.GetBytes(r);
            return Convert.ToBase64String(r);
        }
    }
}