using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Data.SqlClient;

namespace WebApp.Controllers
{

    public class Masina
    {
        //stiu ca nu trebuie sa fie publice
        public int anFab;
        public string model;
        public string numar;
        public Masina(string numar, string model, int anFabricatie)
        {
            this.numar = numar;
            this.model = model;
            this.anFab = anFabricatie;
        }
    }

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public void adaugaMasina(string numar, string model, int an)
        {
            
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = "Data Source=INTERN3\\SQLEXPRESS;Initial Catalog=Masini;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                conn.Open();
                SqlCommand command1 = new SqlCommand(@"SELECT * FROM [dbo].[Masini] 
                                                    WHERE Numar = @vvvv", conn);
                command1.Parameters.Add(new SqlParameter("vvvv", numar));
                

                using (SqlDataReader dataread = command1.ExecuteReader())
                {
                    if (!(dataread.HasRows))
                    {
                        conn.Close();
                        conn.Open();
                        SqlCommand command = new SqlCommand(@"INSERT INTO [dbo].[Masini] (Numar, Model, AnFabricatie)
                                                            VALUES (@v1, @v2, @v3)", conn);
                        command.Parameters.Add(new SqlParameter("v1", numar));
                        command.Parameters.Add(new SqlParameter("v2", model));
                        command.Parameters.Add(new SqlParameter("v3", an));
                        command.ExecuteNonQuery();
                    }
                    else
                    {
                        conn.Close();
                        conn.Open();
                        SqlCommand command = new SqlCommand(@"UPDATE [dbo].[Masini]
                                                            SET Model = @v2, AnFabricatie = @v3
                                                            WHERE Numar = @vvvv", conn);
                        command.Parameters.Add(new SqlParameter("vvvv", numar));
                        command.Parameters.Add(new SqlParameter("v2", model));
                        command.Parameters.Add(new SqlParameter("v3", an));
                        command.ExecuteNonQuery();
                    }
                }
                conn.Close();
            }
        }
        public IActionResult getMasiniTable()
        {
            using (SqlConnection conn = new SqlConnection()) {
                conn.ConnectionString = "Data Source=INTERN3\\SQLEXPRESS;Initial Catalog=Masini;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                conn.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[Masini]", conn);

                IList<Masina> ilist = new List<Masina>();

                using (SqlDataReader dataread = command.ExecuteReader())
                {
                    while (dataread.Read())
                    {
                        ilist.Add(new Masina(dataread[1].ToString(), dataread[3].ToString(), int.Parse((dataread[2].ToString()))));
                    }
                }

                conn.Close();
                ViewData["masini"] = ilist;

                return View();
            }
        }
        enum Action{
            nothing = 0,
            apply = 1,
            delete = 2
        }
        public IActionResult masiniEditabile(string numar, string model, int am, int action = 0)
        {
            switch (action)
            {
                case 0:
                    break;
                case 1:

                    break;
                case 2:

                    break;
            }
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = "Data Source=INTERN3\\SQLEXPRESS;Initial Catalog=Masini;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                conn.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[Masini]", conn);

                IList<Masina> ilist = new List<Masina>();

                using (SqlDataReader dataread = command.ExecuteReader())
                {
                    while (dataread.Read())
                    {
                        ilist.Add(new Masina(dataread[1].ToString(), dataread[3].ToString(), int.Parse((dataread[2].ToString()))));
                    }
                }

                conn.Close();
                ViewData["masini"] = ilist;

                return View();
            }
        }
    }
}
