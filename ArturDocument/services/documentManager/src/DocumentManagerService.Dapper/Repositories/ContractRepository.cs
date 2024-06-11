using DocumentManagerService.DDD;
using DocumentManagerService.Domain;

namespace DocumentManagerService.Dapper
{
    public class ContractRepository :
        DapperRepository<Contract, int>,
        IContractRepository
    {
        public ContractRepository(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        public override Task<Contract> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public override Task<List<Contract>> GetListAsync()
        {
            throw new NotImplementedException();
        }
    }
}
