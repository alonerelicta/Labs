
using LabaInformationTechologics.Bd;
using Microsoft.EntityFrameworkCore;
using LabaInformationTechologics.Mappers;
using LabaInformationTechologics.Controllers;
using System.Data;
namespace LabaInformationTechologics.Configurations
{
    public class Configuration
    {
        private const String Host = "(localdb)\\MSSQLLocalDB";
        private const String DataBase = "DataUser";
        private const String Port = "8070";
        private const String User = "user";
        private const String Password = "12345";
        private BD ConfigureBd()
        {
            
            var options = new DbContextOptionsBuilder<BD>()
                .UseSqlServer($"Server={Host};Database=example;Trusted_Connection=True;");
            return new BD(options.Options);
        }
        public Mapper<Tsource, TDestination> configureMapper<Tsource, TDestination>()
        {
            return new Mapper<Tsource, TDestination>();
        }
        public ControllerUser ConfigureControllerUser()
        {
            return new ControllerUser(ConfigureBd());
        }
    
    }
}
