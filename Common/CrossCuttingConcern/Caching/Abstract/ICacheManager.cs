using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Common.CrossCuttingConcern.Caching.Abstract
{
    interface ICacheManager
    {
        T Get<T>(string key);
        void Add(string key, object data, double CacheTime);
        bool IsAdd(string key);
        void Remove(string key);
        void RemoveByPattern(string pattern);
        void Clear();
    }
}
