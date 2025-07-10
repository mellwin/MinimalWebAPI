using WebAPI.Dtos;

namespace WebAPI.Services
{
    public interface IAccountService
    {
        public Task<ReadAccountDto> CreateAsync(CreateAccountDto accountDto);
        public Task<List<ReadAccountDto>> GetAllAsync();
        public Task<ReadAccountDto> GetByIdAccountAsync(Guid id);
        public Task<ReadAccountDto> DeleteByIdAccountAsync(Guid id);
        public Task<ReadAccountDto> UpdateByIdAccountAsync(Guid id, UpdateAccountDto accountDto);
    }
}