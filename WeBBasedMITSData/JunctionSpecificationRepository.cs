using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeBBasedMITSData
{
    public class JunctionSpecificationRepository
    {
        public readonly MITSDatabaseEntities mITSDatabaseEntities = new MITSDatabaseEntities();
        JunctionSpecificationRepository specificationRepository = new JunctionSpecificationRepository();
    }
}
