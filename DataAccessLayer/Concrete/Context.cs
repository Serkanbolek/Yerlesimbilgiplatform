using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context: DbContext
    {
        public DbSet<Province> Provinces  { get; set; }
        public DbSet<User> Users  { get; set; }
        public DbSet<Street> Streets  { get; set; }
        public DbSet<Point> Points  { get; set; }
        public DbSet<Neighbourhood> Neighbourhoods  { get; set; }
        public DbSet<District> Districts  { get; set; }
        public DbSet<Comment> Comments  { get; set; }
        public DbSet<BuildingNumber> BuildingNumbers  { get; set; }
        public DbSet<Apartmentnumber> Apartmentnumbers  { get; set; }
    }
}
