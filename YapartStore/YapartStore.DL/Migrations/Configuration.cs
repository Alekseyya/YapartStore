namespace YapartStore.DL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using YapartStore.DL.Entities;

    internal sealed class Configuration : DbMigrationsConfiguration<YapartStore.DL.Context.YapartStoreContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(YapartStore.DL.Context.YapartStoreContext context)
        {
            context.Products.AddOrUpdate(
                new Product
                {
                    Article = "CR-K016",
                    Descriptions = "����������� ��������� ������ ������ Mazda 121 87-96 // DEMIO DW3/DW5 1998",
                    BrandId = 1,
                    CategoryId = 1,
                    Price = (decimal)11.47
                },
                new Product
                {
                    Article = "SB4900",
                    Descriptions = "������ ������������� �������� �������� Isuzu Trooper 92-Opel",
                    BrandId = 2,
                    CategoryId = 2,
                    Price = (decimal)34.2
                },
                new Product()
                {
                    Article = "SB4903",
                    Descriptions = "������ ������������� ������ �������� Isuzu Trooper 92-Opel",
                    BrandId = 3,
                    CategoryId = 3,
                    Price = (decimal)45.6
                });

            context.Brands.AddOrUpdate(
                new Brand { Name = "Car-Dex" },
                new Brand { Name = "ISUZU" },
                new Brand { Name = "SKF"},
                new Brand { Name = "CTR"});

            context.Sections.AddOrUpdate(
                new Section { Name = "COMMA - ����� � ��������� ��������" },
                new Section { Name = "����������" },
                new Section { Name = "�������" },
                new Section { Name = "��������", GroupId = 2 },
                new Section { Name = "����� �������������", GroupId = 1 });

            context.Groups.AddOrUpdate(
                new Group { Name = "�������������" },
                new Group { Name = "��� ��������" },
                new Group { Name = "������ ����������" });

            context.Categories.AddOrUpdate(
                new Category { Name = "����������� ������"},
                new Category { Name = "������ �������������" },
                new Category { Name = "��������� ������� ������" },
                new Category { Name = "���� �������������" },
                new Category { Name = "���������� �������" },
                new Category { Name = "���� �������" },
                new Category { Name = "����� ������"});
        }
    }
}
