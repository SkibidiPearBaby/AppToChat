using AppToChat.Infrastructure.Service.User;
using AppToChat.Shared.Dto;
using FluentResults;

namespace AppToChat.Infrastructure.Repository.Account;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    
    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    
    public Task<Result<bool>> Login(LoginDto loginDto)
    {
        //TODO: validation etc.
        return _userRepository.Login(loginDto);
    }

    public Task<Result<bool>> Register(RegisterDto registerDto)
    {
        //TODO: validation etc.
        return _userRepository.Register(registerDto);
    }
}