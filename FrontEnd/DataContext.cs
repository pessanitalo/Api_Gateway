﻿using Microsoft.EntityFrameworkCore;
namespace FrontEnd
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
     
    }
}
