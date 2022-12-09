using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DotnetRESTAPITodo.Models;

namespace DotnetRESTAPITodo.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<DotnetRESTAPITodo.Models.TodoItem> TodoItem { get; set; } = default!;
    }
}
