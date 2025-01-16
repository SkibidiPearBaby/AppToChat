using AppToChat.Shared.Dto;
using FluentResults;

namespace AppToChat.Infrastructure.Repository.Account;

public interface IUserService
{
    public Task<Result<bool>> Login(LoginDto loginDto);
    public Task<Result<bool>> Register(RegisterDto registerDto);

}