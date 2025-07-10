using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WebAPI.Data;
using WebAPI.Dtos;

namespace WebAPI.Services
{
    public class AccountService : IAccountService
    {
        private readonly ApplicationDataContext _context;
        private readonly IMapper _mapper;

        public AccountService(ApplicationDataContext context, IMapper mapper)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public Task<ReadAccountDto> CreateAsync(CreateAccountDto accountDto)
        {
            throw new NotImplementedException();
        }

        public Task<ReadAccountDto> DeleteByIdAccountAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ReadAccountDto>> GetAllAsync()
        {
            var accounts = await _context.Accounts.ToListAsync();
            return _mapper.Map<List<ReadAccountDto>>(accounts);
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
