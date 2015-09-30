namespace Pfunware.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Pfunware.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Pfunware.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Pfunware.Models.ApplicationDbContext";
        }

        protected override void Seed(Pfunware.Models.ApplicationDbContext context)
        {
            context.Users.AddOrUpdate(u => u.Id,
                new ApplicationUser
                {
                    Id = "56994456-8614-4cd8-8d0c-22075b951327",
                    UserName = "admin",
                    PasswordHash = "AN8Zk18amGJh5mjxPBTy4lMTWtwHMfgCZwVFXgR6oUhz6lqgiMKRXkvdq9OfKoYUBg==",
                    SecurityStamp = "d43db569-e142-49b9-86cc-576bd9d9546d"
                });

            context.DefinitionViewModels.AddOrUpdate(p => p.DefinitionId,
                new DefinitionViewModel
                {
                    DefinitionId = 1,
                    Order = 1,
                    Category = "Category 1",
                    Technology = "Technology 1",
                    Word = "Word 1",
                    Definition = "Definition 1"
                },
                new DefinitionViewModel
                {
                    DefinitionId = 2,
                    Order = 2,
                    Category = "Category 2",
                    Technology = "Technology 2",
                    Word = "Word 2",
                    Definition = "Definition 2"
                },
                new DefinitionViewModel
                {
                    DefinitionId = 3,
                    Order = 3,
                    Category = "Category 3",
                    Technology = "Technology 3",
                    Word = "Word 3",
                    Definition = "Definition 3"
                }
            );
        }
    }
}
