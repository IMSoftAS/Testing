using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using Insight.Database;
using Model;

namespace IMS.DAL
{
    public class DataAccess
    {
        public IList<ArkivDocument> TestDataAccess()
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["IMSArkiv"].ConnectionString))
            {
                //conn.Open();
                IList<ArkivDocument> result = conn.QuerySql<ArkivDocument>("SELECT CreatedById, Description, Note, TypeId, Title, DateCreated FROM Documents");
                return result;
            }
        }
    }
}
