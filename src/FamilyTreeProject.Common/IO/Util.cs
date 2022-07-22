using System;
using System.Collections.Generic;
using System.Linq;
using FamilyTreeProject.Common.DataModels;

namespace FamilyTreeProject.Data.Common
{
    public static class Util
    {
        public static string MapId<TModel>(int? idToMap, IList<TModel> list) where TModel : UniqueModel
        {
            string fieldToUpdate = String.Empty;

            if (idToMap.HasValue)
            {
                TModel map = list.FirstOrDefault(r => r.Id == idToMap);
                if (map != null)
                {
                    fieldToUpdate = map.UniqueId;
                }
            }
            return fieldToUpdate;
        }

    }
}