using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using F20ST4PRJ4Gr1SysModel;


namespace F20ST4PRJ4Gr1LoacalDB.Data
{
    public class LocalMeasurmentDBContext : DbContext
    {
        public DbSet<PatientMeasurement> PatientMeasurements { get; set; }
        public DbSet<ECGMeasurement> ECGMeasurements { get; set; }
        public DbSet<ECGLead> ECGLeads { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=LocalPatientDbV1.db", x => x.MigrationsAssembly("LocDBMigration"));
    }
   
}
