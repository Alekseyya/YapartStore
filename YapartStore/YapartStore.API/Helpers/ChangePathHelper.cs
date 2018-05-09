

using System;
using System.Collections.Generic;
using YapartStore.BL.Entities;

namespace YapartStore.API.Helpers
{
    public static class ChangePathHelper
    {
        public static IList<TSource> ChangePath<TSource>(this IList<TSource> source)
        {
            try
            {
                if (typeof(TSource).Equals(typeof(ProductDTO)))
                {
                    foreach (var product in (IList<ProductDTO>)source)
                    {
                        foreach (var picture in product.Pictures)
                        {
                            picture.Path = picture.Path.Substring(picture.Path.IndexOf(@"\Cont"), picture.Path.Length - picture.Path.IndexOf(@"\Cont"))
                                .Replace("\\", "/");
                        }
                    }
                    return source;
                }

                return null;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}