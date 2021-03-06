namespace DataGridBindingTest.DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Linq;

    public class Entities : DbContext
    {
        // Your context has been configured to use a 'Entities' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'DataGridBingingTest.DbManager.Entities' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Entities' 
        // connection string in the application configuration file.
        public Entities()
            : base("name=Entities")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }



        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Person> Persons { get; set; }
    }
}