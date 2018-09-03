namespace Model.Repository
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Data.Entity;
    using System.Collections.Generic;
    using Model.Entity;
    using Model.Entity.Base;

    public class LicenseRepository
    {
        private DataBaseContext db;
        private DbSet<License> licenses;

        public LicenseRepository()
        {
            db = new DataBaseContext();
            licenses = db.Licenses;
        }

        public bool Add(License license)
        {
            if(license == null || licenses.Add(license) == null || db.SaveChanges() != 1)
            {
                return false;
            }

            return true;
        }

        public bool Rewrite(License to, License from)
        {
            if(to == null || from == null || !to.Rewrite(from) || db.SaveChanges() != 1)
            {
                return false;
            }

            return true;
        }

        public bool Rewrite(int toID, License from)
        {
            var toLic = licenses.Where(l => l.ID == toID).FirstOrDefault();
            if (toLic == null || from == null || !toLic.Rewrite(from) || db.SaveChanges() != 1)
            {
                return false;
            }

            return true;
        }

        public bool Remove(License license)
        {
            if (license == null || licenses.Remove(license) == null || db.SaveChanges() != 1)
            {
                return false;
            }

            return true;
        }

        public bool Remove(int id)
        {
            if (licenses.Remove(licenses.Where(l => l.ID == id).FirstOrDefault()) == null || db.SaveChanges() != 1)
            {
                return false;
            }

            return true;
        }

        public License Get(int id)
        {
            return licenses.Where(l => l.ID == id).FirstOrDefault();
        }

        public List<License> Get(Expression<Func<License, bool>> predicate)
        {
            return licenses.Where(predicate).ToList();
        }

        public List<License> Get()
        {
            return licenses.ToList();
        }
    }
}
