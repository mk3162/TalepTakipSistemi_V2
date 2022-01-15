using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Models;
using static Common.Models.GlobalEnum;

namespace Common.Services.Interface
{
    public interface IDBService
    {
        BaseResponseApi<T> ExecuteSqlQuery<T>(StoredProcedure spName, object parameter) where T : class, new();
        BaseResponseApi<T> ExecuteSqlQuery<T>(StoredProcedure spName) where T : class, new();
    }
}
