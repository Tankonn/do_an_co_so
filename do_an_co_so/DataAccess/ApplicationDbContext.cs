﻿using do_an_co_so.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.General;

namespace do_an_co_so.DataAccess
{
    public class ApplicationDbContext : Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }
        public DbSet<Tour> Tours { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<KhachSan> Khachsans { get; set; }
        public DbSet<PhuongThucThanhToan> Phuongthucthanhtoans { get; set; }
        public DbSet<DatTour> DatTours { get; set; }

    }

}
