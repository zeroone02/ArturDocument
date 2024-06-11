using Dapper;
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

        public override async Task<Contract> GetAsync(int id)
        {
            var contract = await FindAsync(id);

            if (contract == null)
            {
                throw new Exception($"contract с id='{id}' не найден");
            }

            return contract;
        }

        public override Task<List<Contract>> GetListAsync()
        {
            throw new NotImplementedException();
        }
        private async Task<Contract> FindAsync(int id)
        {
            var db = await GetDbConnectionAsync();

            var queryResult = await db.QueryAsync($"""
                SELECT c."Id",
                    c."Name",
                    c."Subject"
                FROM
                    "Contracts"
                WHERE 
                    c."Id" = @Id;
                """, new { Id = id});

            var data = queryResult
                .Select(x => new
                {
                    x.Id,
                    x.Name,
                    x.Subject
                }).FirstOrDefault();

            if (data == null)
            {
                return null;
            }
            var contract = new Contract(data.Id, data.Name, data.Subject);
            return contract;
        }
    }
}
