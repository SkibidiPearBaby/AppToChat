using AppToChat.Shared.Dto;
using FluentResults;

namespace AppToChat.Infrastructure.Service.User;

public interface IUserRepository
{
    public Task<Result<bool>> Login(LoginDto loginDto);
    public Task<Result<bool>> Register(RegisterDto registerDto);

}