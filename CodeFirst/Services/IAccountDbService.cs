using Cwiczenia9.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cwiczenia9.Services;

public interface IAccountDbService
{
    object LoginUser(LoginRequest request);
    object CreateUser(LoginRequest request);
    object RefreshToken();
}