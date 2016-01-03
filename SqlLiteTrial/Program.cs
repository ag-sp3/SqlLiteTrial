using System;
using System.Linq;

namespace SqlLiteTrial
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new TestDBEntities())
            {
                var result = from r in context.Roles
                             join rg in context.RoleGroups
                             on r.RoleGroupID equals rg.RoleGroupID
                             select new { RoleName = r.RoleName, RoleGroup = rg.RoleGroupName };

                result.ToList().ForEach(i => Console.WriteLine("{0}: {1}", i.RoleName, i.RoleGroup));
                
            }

            Console.ReadLine();

        }
    }
}
