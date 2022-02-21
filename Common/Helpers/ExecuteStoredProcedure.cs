using FastMember;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Common.Models;
using static Common.Models.GlobalEnum;
using System.Data.Common;
using System.Data.SqlClient;

namespace Common.Helpers
{
    public class ExecuteStoredProcedure
    {
        public class PostgreSQL
        {

            public static BaseResponseApi<T> ExecuteSqlQuery<T>(StoredProcedure spName, object parameter) where T : class, new()
            {

                var responseDto = new BaseResponseApi<T>();

                var sqlQuery = createQuery(spName, parameter);
                var parameters = convertToParamater(parameter);
                var npgSqlcon = new NpgsqlConnection(DatabaseFeatures.GetConn());
                LogManager.LogInfo(requestLog(sqlQuery, parameters, ""));

                using (var cmd = new NpgsqlCommand(sqlQuery, npgSqlcon))
                {
                    try
                    {
                        if (npgSqlcon.State == ConnectionState.Closed)
                        {
                            npgSqlcon.Open();

                            cmd.CommandType = CommandType.Text;
                            foreach (KeyValuePair<string, object> author in parameters)
                            {
                                cmd.Parameters.AddWithValue(author.Key, author.Value);

                            }

                            using (var reader = cmd.ExecuteReader())
                            {
                                responseDto.Status = true;
                                responseDto.Data = convertToObject<T>(reader, sqlQuery, parameters);
                                if (npgSqlcon.State == ConnectionState.Open)
                                {
                                    npgSqlcon.Close();
                                }
                            }
                        }
                        return responseDto;
                    }

                    catch (Exception exp)
                    {
                        responseDto.Status = false;
                        responseDto.StatusMessage = exp.Message.ToString();

                        LogManager.LogError(requestLog(sqlQuery, parameters, exp.Message.ToString()));
                        if (npgSqlcon.State == ConnectionState.Open)
                        {
                            npgSqlcon.Close();
                        }
                        return responseDto;
                    }
                }
            }

            public static BaseResponseApi<T> ExecuteSqlQuery<T, Y>(StoredProcedure spName, object parameter, Y compositeModels) where T : class, new() where Y : class, new()
            {

                var responseDto = new BaseResponseApi<T>();

                var sqlQuery = createQuery(spName, parameter);
                var parameters = convertToParamater(parameter);
                var npgSqlcon = new NpgsqlConnection(DatabaseFeatures.GetConn());
                LogManager.LogInfo(requestLog(sqlQuery, parameters, ""));

                using (var cmd = new NpgsqlCommand(sqlQuery, npgSqlcon))
                {
                    try
                    {
                        if (npgSqlcon.State == ConnectionState.Closed)
                        {
                            npgSqlcon.Open();

                            if (compositeModels != null)
                                mapCompositeTypes(npgSqlcon, compositeModels);

                            cmd.CommandType = CommandType.Text;
                            foreach (KeyValuePair<string, object> author in parameters)
                            {
                                cmd.Parameters.AddWithValue(author.Key, author.Value);

                            }

                            using (var reader = cmd.ExecuteReader())
                            {
                                responseDto.Status = true;
                                responseDto.Data = convertToObject<T>(reader, sqlQuery, parameters);
                                if (npgSqlcon.State == ConnectionState.Open)
                                {
                                    npgSqlcon.Close();
                                }
                            }
                        }
                        return responseDto;
                    }

                    catch (Exception exp)
                    {
                        responseDto.Status = false;
                        responseDto.StatusMessage = exp.Message.ToString();
                        LogManager.LogError(requestLog(sqlQuery, parameters, exp.Message.ToString()));
                        if (npgSqlcon.State == ConnectionState.Open)
                        {
                            npgSqlcon.Close();
                        }
                        return responseDto;
                    }
                }
            }

            private static List<T> convertToObject<T>(DbDataReader rd, string sqlQuery, Dictionary<string, object> parameter) where T : class, new()
            {
                Type type = typeof(T);
                var accessor = TypeAccessor.Create(type);
                var members = accessor.GetMembers();
                var response = new List<T>();
                try
                {
                    while (rd.Read())
                    {
                        var t = new T();
                        for (int i = 0; i < rd.FieldCount; i++)
                        {
                            string fieldName = rd.GetName(i);

                            if (members.Any(m => string.Equals(m.Name, fieldName, StringComparison.OrdinalIgnoreCase)))
                            {
                                accessor[t, fieldName] = convertFromDBVal(rd.GetValue(i));
                            }
                        }
                        response.Add(t);
                    }
                    rd.Close();
                    return response;
                }
                catch (Exception exp)
                {
                    LogManager.LogError(requestLog(sqlQuery, parameter, exp.Message.ToString()));

                    rd.Close();
                    return response;
                }

            }
            private static object convertFromDBVal(object obj)
            {
                if (obj == null || obj == DBNull.Value)
                {

                    return null;

                }
                else
                {
                    return obj;
                }
            }
            private static Dictionary<string, object> convertToParamater<T>(T model) where T : class, new()
            {
                Dictionary<string, object> prm = new Dictionary<string, object>();

                if (model != null)
                {
                    PropertyInfo[] infos = model.GetType().GetProperties();

                    foreach (PropertyInfo info in infos)
                    {
                        if (info.GetValue(model, null) != null)
                            prm.Add(info.Name, info.GetValue(model, null));
                    }
                    return prm;

                }

                return prm;
            }

            private static void mapCompositeTypes<T>(NpgsqlConnection npgSqlcon, T model) where T : class, new()
            {
                if (model != null)
                {
                    PropertyInfo[] infos = model.GetType().GetProperties();
                    foreach (PropertyInfo info in infos)
                    {
                        npgSqlcon.TypeMapper.MapComposite(info.PropertyType, info.GetCustomAttribute<DescriptionAttribute>().Description.ToString());
                    }
                }
            }

            private static string convertToParamaterKey<T>(T model) where T : class, new()
            {
                if (model != null)
                {
                    PropertyInfo[] infos = model.GetType().GetProperties();

                    var prm = new List<string>();

                    foreach (PropertyInfo info in infos)
                    {
                        if (info.GetValue(model, null) != null)
                            prm.Add(":" + info.Name);
                    }
                    var response = string.Join(",", prm.ToArray());

                    return response;
                }

                return "";
            }
            private static string createQuery(StoredProcedure spNames, object parameters)
            {
                var schemas = spNames.GetAttribute<DisplayAttribute>();

                var spName = "\"" + schemas.Name + "\"." + "\"" + spNames.ToString() + "\"";

                return $"Select * From  {spName}({convertToParamaterKey(parameters)});";
            }


        }
        public class Oracle
        {
            public static List<T> ExecuteSqlQuery<T>(StoredProcedure spName, object parameter) where T : class, new()
            {
                var responseDto = new List<T>();
                return responseDto;
            }
        }
        public class MSSql
        {

            public static BaseResponseApi<T> ExecuteSqlQuery<T>(StoredProcedure spName, object parameter) where T : class, new()
            {
                var responseDto = new BaseResponseApi<T>();

                var sqlQuery = createQuery(spName, parameter);
                var parameters = convertToParamater(parameter);
                LogManager.LogInfo(requestLog(sqlQuery, parameters, ""));

                using (SqlConnection msSqlCon = new SqlConnection(DatabaseFeatures.GetConn()))
                {
                    try
                    {
                        if (msSqlCon.State == ConnectionState.Closed)
                        {
                            msSqlCon.Open();

                            SqlCommand cmd = new SqlCommand(spName.ToString(), msSqlCon);
                            cmd.CommandType = CommandType.StoredProcedure;
                            foreach (var p in parameters)
                            {
                                cmd.Parameters.Add(new SqlParameter(p.Key, p.Value));
                            }

                            using (SqlDataReader rdr = cmd.ExecuteReader())
                            {
                                responseDto.Status = true;
                                responseDto.Data = convertToObject<T>(rdr, sqlQuery, parameters);
                                if (msSqlCon.State == ConnectionState.Open)
                                {
                                    msSqlCon.Close();
                                }
                            }
                        }
                        return responseDto;
                    }

                    catch (Exception exp)
                    {
                        responseDto.Status = false;
                        responseDto.StatusMessage = exp.Message.ToString();

                        LogManager.LogError(requestLog(sqlQuery, parameters, exp.Message.ToString()));
                        if (msSqlCon.State == ConnectionState.Open)
                        {
                            msSqlCon.Close();
                        }
                        return responseDto;
                    }
                }
            }

            private static Dictionary<string, object> convertToParamater<T>(T model) where T : class, new()
            {
                Dictionary<string, object> prm = new Dictionary<string, object>();

                if (model != null)
                {
                    PropertyInfo[] infos = model.GetType().GetProperties();

                    foreach (PropertyInfo info in infos)
                    {
                        if (info.GetValue(model, null) != null)
                            prm.Add(info.Name, info.GetValue(model, null));
                    }
                    return prm;
                }
                return prm;
            }

            private static string createQuery(StoredProcedure spNames, object parameters)
            {
                var schemas = spNames.GetAttribute<DisplayAttribute>();

                var spName = "\"" + schemas.Name + "\"." + "\"" + spNames.ToString() + "\"";

                return $"EXEC  {spName}({convertToParamaterKey(parameters)});";
            }

            private static string convertToParamaterKey<T>(T model) where T : class, new()
            {
                if (model != null)
                {
                    PropertyInfo[] infos = model.GetType().GetProperties();

                    var prm = new List<string>();

                    foreach (PropertyInfo info in infos)
                    {
                        if (info.GetValue(model, null) != null)
                            prm.Add(":" + info.Name);
                    }
                    var response = string.Join(",", prm.ToArray());

                    return response;
                }

                return "";
            }
            private static object convertFromDBVal(object obj)
            {
                if (obj == null || obj == DBNull.Value)
                {
                    return null;
                }
                else
                {
                    return obj;
                }
            }
            private static List<T> convertToObject<T>(DbDataReader rd, string sqlQuery, Dictionary<string, object> parameter) where T : class, new()
            {
                Type type = typeof(T);
                var accessor = TypeAccessor.Create(type);
                var members = accessor.GetMembers();
                var response = new List<T>();
                try
                {
                    while (rd.Read())
                    {
                        var t = new T();
                        for (int i = 0; i < rd.FieldCount; i++)
                        {
                            string fieldName = rd.GetName(i);

                            if (members.Any(m => string.Equals(m.Name, fieldName, StringComparison.OrdinalIgnoreCase)))
                            {
                                    var ss = convertFromDBVal(rd.GetValue(i));
                                    accessor[t, fieldName] = ss;
                            }
                        }
                        response.Add(t);
                    }
                    rd.Close();
                    return response;
                }
                catch (Exception exp)
                {
                    LogManager.LogError(requestLog(sqlQuery, parameter, exp.Message.ToString()));

                    rd.Close();
                    return response;
                }

            }
        }
        private static string requestLog(string sqlQuery, Dictionary<string, object> parameters, string exp)
        {

            var queryParameters = "{" + string.Join(",", parameters.Select(kv => kv.Key + "=" + kv.Value).ToArray()) + "}";
            return "SqlQuery : " + sqlQuery + " || " + " Parameters : " + queryParameters + " || " + " Exception : " + exp;
        }
    }
}

