using kursova9.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kursova9.Models
{
    public class StudContext: DbContext
    {
        public DbSet <Student> Students { get; set; }
        public StudContext(DbContextOptions<StudContext> options)
        : base(options)
        {
            Database.EnsureCreated();
        }

    }
}
