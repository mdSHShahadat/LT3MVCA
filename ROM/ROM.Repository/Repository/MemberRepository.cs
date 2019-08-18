using ROM.DatabaseContext.DatabaseContext;
using ROM.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROM.Repository.Repository
{
    public class MemberRepository
    {
        ROMdbContext db = new ROMdbContext();
        public bool Add(Member member)
        {
            int isExecuted = 0;

            db.Members.Add(member);
            isExecuted = db.SaveChanges();

            if (isExecuted > 0)
            {
                return true;
            }

            return false;
        }
    }
}
