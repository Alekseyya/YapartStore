using System.Collections;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using YapartStore.BL.Entities;
using YapartStore.DL.Entities;

namespace YapartStore.BL.Helpers
{
    public static class MapperExtensions
    {
        public static IMappingExpression<TSource, TDestination> IgnoreAllNonExisting<TSource, TDestination>(this IMappingExpression<TSource, TDestination> expression)
        {
            var sourceType = typeof(TSource);
            //var destinationType = typeof(TDestination);
            //var existingMaps = Mapper.Configuration.GetAllTypeMaps().First(x => x.SourceType.Equals(sourceType)
                                                                               // && x.DestinationType.Equals(destinationType));
            foreach (var property in sourceType.GetProperties())
            {
                if (typeof(ICollection<Product>).IsAssignableFrom(property.PropertyType))
                {
                    
                }
                //expression.ForMember(property, opt => opt.Ignore());
            }
            return expression;
        }
    }
}
