using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VehicleValidator.Models;

namespace VehicleValidator.Data
{
    public class VehicleValidatorContext : DbContext
    {
        public VehicleValidatorContext (DbContextOptions<VehicleValidatorContext> options)
            : base(options)
        {
        }

        public DbSet<VehicleValidator.Models.Vehicle> Vehicle { get; set; } = default!;
    }
}
