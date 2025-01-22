using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabaInformationTechologics.Bd;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Options;
using LabaInformationTechologics.Mappers;
using LabaInformationTechologics.Controllers;
namespace LabaInformationTechologics.Configurations
{
    public class Configuration
    {
        private const String Host = "localhost";
        private const String DataBase = "DataUser";
        private const String Port = "8070";
        private const String User = "root";
        private const String Password = "12345";
        private BD ConfigureBd()
        {
            var options = new DbContextOptionsBuilder<BD>()
                .UseMySql($"server={Host};user={User};password={Password};database={DataBase}");
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
