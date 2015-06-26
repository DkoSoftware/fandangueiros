using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;

namespace DkoSoftware.Fandangueiros.DAO.Helpers
{
    public class List
    {
        #region [ Convertions ]
     
        public static DataTable ListToDataTable<T>(List<T> list)
        {
            DataTable dt = new DataTable();

            foreach (PropertyInfo info in typeof(T).GetProperties())
            {
                Type tipo = info.PropertyType;

                if (tipo.IsGenericType && tipo.GetGenericTypeDefinition() == typeof(Nullable<>))
                    tipo = Nullable.GetUnderlyingType(tipo);

                dt.Columns.Add(new DataColumn(info.Name, tipo));
            }

            foreach (T t in list)
            {
                DataRow row = dt.NewRow();

                foreach (PropertyInfo info in typeof(T).GetProperties())
                {
                    object value = info.GetValue(t, null);

                    if (value != null)
                    {
                        row[info.Name] = value;
                    }
                    else
                    {
                        row[info.Name] = DBNull.Value;
                    }
                }

                dt.Rows.Add(row);
            }

            return dt;
        }

        public static List<T> DataTableToList<T>(DataTable dt)
        {
            var columnNames = dt.Columns.Cast<DataColumn>()
                .Select(c => c.ColumnName)
                .ToList();

            var properties = typeof(T).GetProperties();

            return dt.AsEnumerable().Select(row =>
            {
                var objT = Activator.CreateInstance<T>();

                foreach (var pro in properties)
                {
                    if (columnNames.Contains(pro.Name))
                        pro.SetValue(objT, row[pro.Name], null);
                }

                return objT;

            }).ToList();
        }

        #endregion
    }
}
