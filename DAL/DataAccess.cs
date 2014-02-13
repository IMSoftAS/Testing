using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using Insight.Database;
using IMS.Model;

namespace IMS.DAL
{
    public class DataAccess : IDataAccess
    {
        public ArkivDocument[] GetArkivDocuments(int i) {
            return getData<ArkivDocument>( "SELECT TOP "+i.ToString()+" * FROM Documents" );
        }

        private T[] getData<T>( string query ) {
            T[] result;
            using ( SqlConnection conn = new SqlConnection( ConfigurationManager.ConnectionStrings["IMSArkiv"].ConnectionString ) ) {
                result = conn.QuerySql<T>( query ).ToArray();
            }
            return result;
        }
    }
}
