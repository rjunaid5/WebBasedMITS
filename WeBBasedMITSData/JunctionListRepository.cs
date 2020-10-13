using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeBBasedMITSData
{
    public class JunctionListRepository : GenericRepository<JunctionList>
    {
        public readonly MITSDatabaseEntities mITSDatabaseEntities = new MITSDatabaseEntities();
        public IQueryable<JunctionList> GetJunctionLists()
        {

            var query = (from junction in mITSDatabaseEntities.JunctionLists
                         join states in mITSDatabaseEntities.States on junction.StateId equals states.Id
                         select new  { junction, State = states.Name }).ToList();
            List<JunctionList> junctionsList1;

            var list = from junction in table
                        select junction;
            
            return (list);
        }

        public IEnumerable<JunctionList> GetFiveJunctions()
        {

            var list = (from five_employees in table
                        orderby five_employees.JunctionId
                        select five_employees).Take(5);
            return (list.ToList());
        }
    }
}
