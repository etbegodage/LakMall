using LakMall.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LakMall.DAL
{
   public partial class AppDbContext : DbContext
    {
        private readonly IHttpContextAccessor _httpContextAccessor; 
        public AppDbContext(DbContextOptions<AppDbContext> options,IHttpContextAccessor httpContextAccessor) : base(options)
        {
            _httpContextAccessor = httpContextAccessor;

        
        }
        public DbSet<ItemCategory> ItemCategory { get; set; }
    }
}
