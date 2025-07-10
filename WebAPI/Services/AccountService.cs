using WebAPI.Data;
using WebAPI.Dtos;

namespace WebAPI.Services
{
    public class AccountService : IAccountService
    {
        private readonly ApplicationDataContext _context;

        public AccountService(ApplicationDataContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public Task<ReadAccountDto> CreateAsync(CreateAccountDto accountDto)
        {
            throw new NotImplementedException();
        }

        public Task<ReadAccountDto> DeleteByIdAccountAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ReadAccountDto>> GetAccountDtoAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ReadAccountDto> GetByIdAccountAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ReadAccountDto> UpdateByIdAccountAsync(Guid id, UpdateAccountDto accountDto)
        {
            throw new NotImplementedException();
        }
    }
}
