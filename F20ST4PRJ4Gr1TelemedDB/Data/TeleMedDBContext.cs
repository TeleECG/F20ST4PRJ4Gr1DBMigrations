using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using F20ST4PRJ4Gr1SysModel;


namespace F20ST4PRJ4Gr1TelemedDB.Data
{
    public class TeleMedDb : DbContext
    {
        public DbSet<PatientMeasurement> PatientMeasurements { get; set; } // En liste af patients - den modsvarer tabellen i databasen. 
        public DbSet<ECGMeasurement> ECGMeasurements { get; set; } // En liste af ECGMeasurements - den modsvarer tabellen i databasen.
        public DbSet<ECGLead> ECGLeads { get; set; } // En liste af ECGLeads - den modsvarer tabellen i databasen.

        private const String _database = "F20ST4PRJ4TMDBjrt";

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Data Source=st-i4dab.uni.au.dk; Initial Catalog=" + _database + "; " +
                                 "Persist Security Info=True; User ID=" + _database + "; Password=" + _database + "",
                                 x => x.MigrationsAssembly("TeleMedDBMigration"));
        } // 
    }
}
