using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using Insight.Database;
using IMS.Model;
using System.Reflection;
using Ninject;

namespace IMS.DAL
{
    public class DataAccess : IMS.DAL.IDataAccess
    {
        public DataAccess( Dictionary<Type, Type> repositoryMap ) {
            _repositoryMap = repositoryMap;
        }

        public int  Insert<T>( T data )       { return callMethod<T, int>( "insert",       data ); }
        public T    SelectWithId<T>( int id ) { return callMethod<T, T>  ( "selectWithId", id ); }
        public void Update<T>( T data )       {        callMethod<T, int>( "update",       data ); }
        public void DeleteWithId<T>( int id ) {        callMethod<T, int>( "deleteWithId", id ); }

        private Dictionary<Type, Type> _repositoryMap;

        private V callMethod<T, V>( string name, params object[] parameters ) {
            MethodInfo method = typeof( DataAccess ).GetMethod( name, BindingFlags.NonPublic | BindingFlags.Instance );
            MethodInfo generic = method.MakeGenericMethod( typeof( T ), _repositoryMap[typeof( T )] );
            return (V)generic.Invoke( this, parameters );
        }

        private int insert<T, V>( T data ) where V : IRepository<T>, new() {
            var repo = new V();
            return repo.Insert( data );
        }

        private int update<T, V>( T data ) where V : IRepository<T>, new() {
            var repo = new V();
            repo.Update( data );
            return 0;
        }

        private T selectWithId<T, V>( int id ) where V : IRepository<T>, new() {
            var repo = new V();
            return repo.Select( id );
        }

        private int deleteWithId<T, V>( int id ) where V : IRepository<T>, new() {
            var repo = new V();
            repo.Delete( id );
            return 0;
        }
    }
}
