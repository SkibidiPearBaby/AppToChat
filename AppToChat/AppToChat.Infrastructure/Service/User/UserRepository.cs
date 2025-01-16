using AppToChat.Shared.Dto;
using FluentResults;

namespace AppToChat.Infrastructure.Service.User;

public class UserRepository : IUserRepository
{
    public Task<Result<bool>> Login(LoginDto loginDto)
    {
        //TODO: login functionality
        return null;
    }

    public Task<Result<bool>> Register(RegisterDto registerDto)
    {
        //TODO: register functionality
        return null;
    }
}