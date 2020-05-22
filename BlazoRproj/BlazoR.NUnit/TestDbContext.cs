using BlazoR.Data;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using System;
using System.Data.Common;

namespace BlazoR.NUnit
{
    public class TestDbContext
    {
        private static readonly object _lock = new object();
        private static bool _databaseInitialized;

        public TestDbContext()
        {

            Connection = new NpgsqlConnection(@"Host=ec2-54-217-236-206.eu-west-1.compute.amazonaws.com;Port=5432;Database=d6amrjod5an38g;Username=xqpilshjqposzr;Password=22d4ff56d4aa0ecd45d05b3cde1c65237bd2215f2456ca295fde618f78943109;sslmode=Require;Trust Server Certificate=true");
            //Seed();
            //Connection.Open();
        }

        public DbConnection Connection { get; }

        public ApplicationDbContext CreateContext(DbTransaction transaction = null)
        {
            var context = new ApplicationDbContext(new DbContextOptionsBuilder<ApplicationDbContext>().UseNpgsql(Connection).Options);

            if (transaction != null)
            {
                context.Database.UseTransaction(transaction);
            }

            return context;
        }

        private void Seed()
        {
            lock (_lock)
            {
                if (!_databaseInitialized)
                {
                    using (var context = CreateContext())
                    {
                        context.Database.EnsureDeleted();
                        context.Database.EnsureCreated();



                        context.SaveChanges();
                    }

                    _databaseInitialized = true;
                }
            }
        }

        public void Dispose() => Connection.Dispose();
    }
}
