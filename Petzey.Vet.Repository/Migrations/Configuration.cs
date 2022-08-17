namespace Petzey.Vet.Repository.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Petzey.Vet.Repository.VetContext1>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Petzey.Vet.Repository.VetContext1 context)
        {
            context.Vets.AddOrUpdate(
                x => x.VetName,
                new Model.Vets
                {
                    VetName = "Doc1",
                    NPINum = 9991,
                    Speciality = "Speciality1",
                    ContactInfo = new Model.VetContactInfo
                    {
                        ClinicAddress = "Address1",
                        EmailId = "doc1@domain.com",
                        PhoneNum = "9999999991"
                    }
                },
                new Model.Vets
                {
                    VetName = "Doc2",
                    NPINum = 9992,
                    Speciality = "Speciality2",
                    ContactInfo = new Model.VetContactInfo
                    {
                        ClinicAddress = "Address2",
                        EmailId = "doc2@domain.com",
                        PhoneNum = "9999999992"
                    }
                },
                new Model.Vets
                {
                    VetName = "Doc3",
                    NPINum = 9993,
                    Speciality = "Speciality3",
                    ContactInfo = new Model.VetContactInfo
                    {
                        ClinicAddress = "Address3",
                        EmailId = "doc3@domain.com",
                        PhoneNum = "9999999993"
                    }
                },
                new Model.Vets
                {
                    VetName = "Doc4",
                    NPINum = 9994,
                    Speciality = "Speciality4",
                    ContactInfo = new Model.VetContactInfo
                    {
                        ClinicAddress = "Address4",
                        EmailId = "doc4@domain.com",
                        PhoneNum = "9999999994"
                    }
                },
                new Model.Vets
                {
                    VetName = "Doc5",
                    NPINum = 9995,
                    Speciality = "Speciality5",
                    ContactInfo = new Model.VetContactInfo
                    {
                        ClinicAddress = "Address5",
                        EmailId = "doc5@domain.com",
                        PhoneNum = "9999999995"
                    }
                }
            );
        }
    }
}
