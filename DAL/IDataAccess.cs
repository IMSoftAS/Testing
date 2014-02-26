using System;

namespace IMS.DAL
{
    public interface IDataAccess
    {
        void DeleteWithId<T>( int id );
        int Insert<T>( T data );
        T SelectWithId<T>( int id );
        void Update<T>( T data );
    }
}
