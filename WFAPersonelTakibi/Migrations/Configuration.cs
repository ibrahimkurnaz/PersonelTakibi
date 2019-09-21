namespace WFAPersonelTakibi.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WFAPersonelTakibi.Model1>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(WFAPersonelTakibi.Model1 context)
        {
           
        }
    }
}
