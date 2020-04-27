using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Estoque.Utilitario
{
    public class CollectionHelper
    {
        private CollectionHelper()
        {

        }

        public static DataTable ConvertTo<T>(IList<T> list)
        {
            DataTable table = CreateTable<T>();
            Type entityType = typeof(T);
            PropertyDescriptorCollection prop = TypeDescriptor.GetProperties(entityType);

            foreach(T item in list)
            {
                DataRow dr = table.NewRow();
                foreach(PropertyDescriptor p in prop)
                {
                    dr[p.Name] = p.GetValue(item);
                }
                table.Rows.Add(dr);
            }
            return table;
        }

        public static DataTable CreateTable<T>()
        {
            Type type = typeof(T);
            DataTable t = new DataTable(type.Name);
            PropertyDescriptorCollection p = TypeDescriptor.GetProperties(type);

            foreach(PropertyDescriptor prop in p)
            {
                t.Columns.Add(prop.Name, prop.PropertyType);
            }

            return t;
        }

    }
}
