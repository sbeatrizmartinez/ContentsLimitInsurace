using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContentsLimitInsurace.Models
{
    public class ContentLimitContext:DbContext
    {
        public ContentLimitContext(DbContextOptions<ContentLimitContext> options) : base(options)
        {
        
        }

        public DbSet<ContentLimit> contents { get; set; }
}
}
