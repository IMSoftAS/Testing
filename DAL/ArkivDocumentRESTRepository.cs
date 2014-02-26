using IMS.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.DAL
{
    public class ArkivDocumentRESTRepository : RESTRepositoryBase, IRepository<ArkivDocument>
    {
        public ArkivDocumentRESTRepository() : base() {}

        public ArkivDocument Select( int id ) {
            return Get<ArkivDocument>( "/Documents?id=" + id.ToString() );
        }

        public int Insert( ArkivDocument doc ) {
            return Post<ArkivDocument, int>( "/Documents/", doc );
        }

        public void Update( ArkivDocument doc ) {
            Put<ArkivDocument, int>( "/Documents/" + doc.DocumentId.ToString(), doc );
        }

        public void Delete( int Id ) {
            throw new NotImplementedException();
        }
    }
}
