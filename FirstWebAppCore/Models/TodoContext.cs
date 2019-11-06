using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebAppCore.Models
{
    public class TodoContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {

        }

        public DbSet<TodoItems> TodoItems { get; set; }
    }
}
