using System;
using System.Linq;

namespace SqlLiteTrial
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new TMCMeetingsEntities())
            {
                var roletaker =(from rtk in context.MeetingRoleTakers
                                join u in context.Users
                                on rtk.UserID equals u.UserID
                                join r in context.MeetingRoles
                                on rtk.RoleID equals r.RoleID
                                join m in context.Meetings
                                on rtk.MeetingID equals m.MeetingID
                                where r.RoleID == 4 //Table Topics Evaluator
                                select new
                                {
                                    Meeting_Nth = m.Nth,
                                    Role = r.RoleName,
                                    RoleTaker = u.DisplayName
                                }).FirstOrDefault();


                Console.WriteLine("The " + roletaker.Role + " of " + 
                    roletaker.Meeting_Nth + " Meeting is " + roletaker.RoleTaker + ".");
            }

                Console.ReadLine();

        }
    }
}
