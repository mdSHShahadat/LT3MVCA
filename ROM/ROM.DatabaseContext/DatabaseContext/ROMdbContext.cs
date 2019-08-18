using ROM.Models.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ROM.DatabaseContext.DatabaseContext
{
    public class ROMdbContext: DbContext
    {
        public DbSet<Member> Members { get; set; }
    }
}
