using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visit
{
    public class VisitProperties
    {
        public Guid Id { get; set; }

        public DateTime EntryTime { get; set; }

        public DateTime ExitTime { get; set; }

        public string FullName { get; set; }

        public string VisitCause { get; set; }

        public string NumberIdentity { get; set; }

        public VisitProperties()
        {
            Id = Guid.NewGuid();
        }
    }
}
