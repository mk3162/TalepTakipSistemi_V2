using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Helpers;
using Common.Models;
using Common.Services.Interface;
using static Common.Models.GlobalEnum;

namespace Common.Services.Implementation
{
    public class DBService : IDBService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T">Response Model Tipi</typeparam>
        /// <param name="spName">Stored Procedure ismi</param>
        /// <param name="parameter">Call edilecek Stored Procedure için gerekli olan parametreler</param>
        /// <returns>Request gelen T modeli  response olarak döndürür</returns>

        public BaseResponseApi<T> ExecuteSqlQuery<T>(StoredProcedure spName, object parameter) where T : class, new()
        {

            //var type = DbModelType.PostreSQL;
            //var type = DbModelType.Oracle;
            var type = DbModelType.MSSql;
            switch (type)
            {
                //case DbModelType.PostreSQL:
                //    return ExecuteStoredProcedure.PostgreSQL.ExecuteSqlQuery<T>(spName, parameter);
                //case DbModelType.Oracle:
                //    return ExecuteStoredProcedure.Oracle.ExecuteSqlQuery<T>(spName, parameter);
                case DbModelType.MSSql:
                    return ExecuteStoredProcedure.MSSql.ExecuteSqlQuery<T>(spName, parameter);
                default:
                    return new BaseResponseApi<T>();
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T">Response Model Tipi</typeparam>
        /// <param name="spName">Stored Procedure ismi</param>
        /// <returns>Request gelen T modeli  response olarak döndürür</returns>

        public BaseResponseApi<T> ExecuteSqlQuery<T>(StoredProcedure spName) where T : class, new()
        {

            var type = DbModelType.PostreSQL;
            //var type = DbModelType.Oracle;
            //var type = DbModelType.MSSql;
            switch (type)
            {
                case DbModelType.PostreSQL:
                    return ExecuteStoredProcedure.PostgreSQL.ExecuteSqlQuery<T>(spName, null);
                //case DbModelType.Oracle:
                //    return ExecuteStoredProcedure.Oracle.ExecuteSqlQuery<T>(spName, parameter);
                //case DbModelType.MSSql:
                //    return ExecuteStoredProcedure.MSSql.ExecuteSqlQuery<T>(spName, parameter);
                default:
                    return new BaseResponseApi<T>();

            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T">Response Model Tipi</typeparam>
        /// <param name="spName">Stored Procedure ismi</param>
        /// <param name="parameter">Call edilecek Stored Procedure için gerekli olan parametreler</param>
        /// <param name="compositeModels">Map edilmesi gereken composite type'ları tutar</param>
        /// <returns>Request gelen T modeli  response olarak döndürür</returns>

        public BaseResponseApi<T> ExecuteSqlQuery<T, Y>(StoredProcedure spName, object parameter, Y compositeModels) where T : class, new() where Y : class, new()
        {
            var type = DbModelType.PostreSQL;
            //var type = DbModelType.Oracle;
            //var type = DbModelType.MSSql;
            switch (type)
            {
                case DbModelType.PostreSQL:
                    return ExecuteStoredProcedure.PostgreSQL.ExecuteSqlQuery<T, Y>(spName, parameter, compositeModels);
                //case DbModelType.Oracle:
                //    return ExecuteStoredProcedure.Oracle.ExecuteSqlQuery<T>(spName, parameter);
                //case DbModelType.MSSql:
                //    return ExecuteStoredProcedure.MSSql.ExecuteSqlQuery<T>(spName, parameter);
                default:
                    return new BaseResponseApi<T>();

            }
        }
    }
}
