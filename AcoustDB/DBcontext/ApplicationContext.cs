using AcoustDB.DBcontext.ModeCreate._1;
using AcoustDB.DBcontext.ModeCreate._3;
using DBcontext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Npgsql.EntityFrameworkCore.PostgreSQL;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace AcoustDB.DBcontext
{
    public class ApplicationContext : DbContext
    {
        public DbSet<AllStageObj> AllStageObj { get; set; }
        public DbSet<StageManufact> StageManufact { get; set; }
        public DbSet<ObjMPK> ObjMPK { get; set; }
        public DbSet<QualityPassport> QualityPassport { get; set; }
        public DbSet<TableBasicInfoMPK> TableBasicInfoMPK { get; set; }
        public DbSet<TableTechnCharcsMPK> TableTechnCharcsMPK { get; set; }
        public DbSet<MarkMPK> MarkMPK { get; set; }
        public DbSet<TableParticleShape> TableParticleShape { get; set; }
        public DbSet<ParticleShape> ParticleShape { get; set; }
        public DbSet<IdParticleShapeMPK> IdParticleShapeMPK { get; set; }
        public DbSet<TableChemicalComposit> TableChemicalComposit { get; set; }
        public DbSet<IdChemicalCompositMPK> IdChemicalCompositMPK { get; set; }
        public DbSet<ObjModePLV> ObjModePLV { get; set; }
        public DbSet<TableGenInforModesPLV> TableGenInforModesPLV { get; set; }
        public DbSet<TableTechnModesPLV> TableTechnModesPLV { get; set; }
        public DbSet<ObjHeatModes> ObjHeatModes { get; set; }
        public DbSet<IdDataHeatModes> IdDataHeatModes { get; set; }
        public DbSet<TableDataHeatModes> TableDataHeatModes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=NikiectDB; Username = postgres; Password=Nikago2280.;Include Error Detail=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

        }
    }
}
