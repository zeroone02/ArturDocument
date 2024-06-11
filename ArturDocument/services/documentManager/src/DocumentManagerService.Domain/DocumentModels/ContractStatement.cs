using DocumentManagerService.DDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManagerService.Domain
{
    public class ContractStatement : Entity<int>
    {
        public ContractStatement(int id, int contractId,int price, string theme)
        {
            Id = id;
            ContractId = contractId;
            Price = price;
            Theme = theme;
        }
        public int ContractId { get; protected set; }
        public int Price { get; protected set; }
        public string Theme { get; protected set; }
    }
}
