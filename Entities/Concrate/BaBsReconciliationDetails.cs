using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrate
{
    public class BaBsReconciliationDetails : IEntity
    {
        public int Id { get; set; }
        public int BabsReconciliationId { get; set; }
        public DateTime Date { get; set; }
        public string Decription { get; set; }
        public decimal Amount { get; set; }
    }
}
