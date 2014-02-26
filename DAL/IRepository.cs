using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.DAL
{
    public interface IRepository<V>
    {
        V Select( int id );
        int Insert( V doc );
        void Update( V doc );
        void Delete( int id );
    }
}
