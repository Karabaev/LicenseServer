namespace Model.Repository
{
    using System.Data.Entity;
    using Model.Entity;
    using Model.Entity.Base;

    public class DataBaseContext : DbContext
    {
        public DbSet<ActivatedLicens> ActivatedLicenses { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<License> Licenses { get; set; }
        public DbSet<LicenseType> LicenseTypes { get; set; }
        public DbSet<Owner> Owners { get; set; }
    }
}
