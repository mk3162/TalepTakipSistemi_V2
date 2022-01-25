using Common.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Web.Context;
using Web.Entities;

namespace Web.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly DatabaseContext _context;
        public DepartmentController(DatabaseContext context)
        {
            _context = context;
        }

        public IActionResult Index(int siraNo=1)
        {
            return View(_context.Departmanlar.Where(x => x.SirketSiraNo==siraNo).ToList());
        }

        //try
        //{

        //    using (SqlConnection connection = new SqlConnection("Server=MERTCANU\\MURATKA; Database=TTSYENI; Trusted_Connection=true;"))
        //    {
        //        connection.Open();

        //        SqlCommand cmd = new SqlCommand(GlobalEnum.StoredProcedure.DepartmanlarListesi.ToString(), connection)
        //        {
        //            CommandType = CommandType.StoredProcedure,
        //        };

        //        SqlParameter param = new SqlParameter()
        //        {
        //            ParameterName = "@SirketSiraNo",
        //            SqlDbType = SqlDbType.Int,
        //            Direction=ParameterDirection.Output
        //        };
        //        cmd.Parameters.Add(param);

        //        SqlDataReader dr = cmd.ExecuteReader();
        //        while (dr.Read())
        //        {

        //        }
        //    }
        //    return View(_context.Departmanlar.FromSqlRaw(GlobalEnum.StoredProcedure.DepartmanlarListesi.ToString()).ToList());
        //}
        //catch (Exception ex)
        //{
        //    throw new Exception(ex.Message);
        //}

    }
}
