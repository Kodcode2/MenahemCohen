﻿using Microsoft.EntityFrameworkCore;

namespace AgentsRest.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }



    }
}
