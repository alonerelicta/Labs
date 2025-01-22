using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaInformationTechologics.Mappers
{
    public class Mapper<TSource, TDestination>
    {
        public TSource Map(TDestination destination)
        {
            var source = Activator.CreateInstance<TSource>();
            Map<TDestination, TSource>(destination, source);
            return source;
        }
        public TDestination Map(TSource source)
        {
            var destination = Activator.CreateInstance<TDestination>();
            Map<TSource,TDestination>(source, destination);
            return destination;
        }

        public void Map<TFrom,TDo>(TFrom source,  TDo destination) {
            var sourceProperties = typeof(TFrom).GetProperties();
            var destinationProperties = typeof(TDo).GetProperties();
            foreach (var property in sourceProperties)
            { 
                var nextProperty = destinationProperties.FirstOrDefault(p=>p.Name == property.Name );
                if(nextProperty != null && nextProperty.CanWrite && nextProperty.CanRead)
                {
                    nextProperty.SetValue(destination, property.GetValue(source));
                }
            }
        }
    }
}
