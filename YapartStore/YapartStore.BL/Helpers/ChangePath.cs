using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapartStore.BL.Entities;

namespace YapartStore.BL.Helpers
{
    public static class ChangePath
    {
        public static List<TSource> ChangePathImage<TSource>(this List<TSource> source)
        {
            try
            {
                Type type = typeof(TSource);
                dynamic list = null;
                if (type == typeof(ModelDTO))
                    list = (IList<ModelDTO>)source;
                if (type == typeof(MarkDTO))
                    list = (IList<MarkDTO>)source;
                if (type == typeof(ModificationDTO))
                    list = (IList<ModificationDTO>)source;

                if (list != null)
                    foreach (var item in list)
                    {
                        if (item.PicturePath != null)
                        {
                            item.PicturePath = item.PicturePath.Substring(item.PicturePath.IndexOf(@"\Cont"),
                                    item.PicturePath.Length - item.PicturePath.IndexOf(@"\Cont"))
                                .Replace("\\", "/");
                        }
                    }

                return source;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static ModelDTO ChangePathImage(this ModelDTO item)
        {
            try
            {
                item.PicturePath = item.PicturePath.Substring(item.PicturePath.IndexOf(@"\Cont"),
                                 item.PicturePath.Length - item.PicturePath.IndexOf(@"\Cont"))
                             .Replace("\\", "/");
                return item;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
