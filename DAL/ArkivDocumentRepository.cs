using IMS.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Insight.Database;
using System.Configuration;

namespace IMS.DAL
{
    public class ArkivDocumentRepository : IRepository<ArkivDocument>
    {
        public ArkivDocument Select( int id ) {
            using ( SqlConnection conn = new SqlConnection( ConfigurationManager.ConnectionStrings["IMSArkiv"].ConnectionString ) ) {
                return conn.Query<ArkivDocument>( "ims_DocumentsSelect", new { DocumentId = id } ).FirstOrDefault();
            }
        }

        public int Insert( ArkivDocument doc ) {
            using ( SqlConnection conn = new SqlConnection( ConfigurationManager.ConnectionStrings["IMSArkiv"].ConnectionString ) ) {
                return conn.Insert( "ims_DocumentsInsert", doc ).DocumentId;
            }
        }

        public void Update( ArkivDocument doc ) {
            using ( SqlConnection conn = new SqlConnection( ConfigurationManager.ConnectionStrings["IMSArkiv"].ConnectionString ) ) {
                conn.Query<ArkivDocument>( "ims_DocumentsUpdate", doc ).FirstOrDefault();
            }
        }

        public void Delete( int id ) {
            using ( SqlConnection conn = new SqlConnection( ConfigurationManager.ConnectionStrings["IMSArkiv"].ConnectionString ) ) {
                conn.Query( "ims_DocumentsDelete", id );
            }
        }
    }
}
