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
    public class DataAccess
    {
        public ArkivDocument[] TestDataAccess()
        {
            return getData<ArkivDocument>( "SELECT DocumentId, Deleted, CreatedById, ResponsibleId, ProcessedById, StatusId, Description, Note, Format, TypeId, DirectionId, Title, DocumentFrom, PaperDocument, PaperDocumentPlacement, DateDocumentDated, DateSentRecived, DateArchived, DateCreated, DateAnswerDue, DateArchiveDue, SenderRecipientId, SenderRecipientNo, SenderRecipientRef, CustomerNumber, AutoExpireEnabled, AutoExpireDate, CustomText, CustomList, CustomDate, ArkivId, ItemTypeId, LockedByUserId, ResponsibleType, VersionNumber, CurrentVersion, DocumentInfo, NoExport, AnswerCreated, TemplateName FROM Documents" );
        }

        private T[] getData<T>( string query ) {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();

            T[] result;
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["IMSArkiv"].ConnectionString))
            {
                result = conn.QuerySql<T>( query ).ToArray();
            }

            sw.Stop();
            Console.WriteLine( "{0, -30}{1,5}ms", "Fetch from DB:", sw.ElapsedMilliseconds.ToString() );

            return result;
        }
    }
}
