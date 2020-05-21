using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using PovezavaBaza.Models;


/* za dejansko komunikacijo s serverjem*/

namespace PovezavaBaza
{
    public class DataAccess
    {
        public List<Person> GetPeople()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {
                var output = connection.Query<Person>($"select * from dbo.Sif_Delavci").ToList();
                return output;
            }
        }

        public List<Person> GetPeopleWithID(string nazdel)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {
                var output = connection.Query<Person>($"select * from dbo.Sif_Delavci where nazdel = '{ nazdel }'").ToList();

                return output;
            }
        }

        public List<NalogGlava> NalogGlava()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {
                var output = connection.Query<NalogGlava>($"select * from dbo.Nalog_Glava").ToList();
                return output;
            }
        }

        public List<NalogPostavke> NalogPostavke()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {
                var output = connection.Query<NalogPostavke>($"select * from dbo.Nalog_POstavke").ToList();
                return output;
            }
        }

        public List<SifraArtikli> SifraArtikli()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {
                var output = connection.Query<SifraArtikli>($"select * from dbo.Sif_Artikli").ToList();
                return output;
            }
        }
        public List<TehnoloskiPostopkiPOS> TehnoloskiPostopkiPOS()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {
                var output = connection.Query<TehnoloskiPostopkiPOS>($"select * from dbo.TEHNOLOSKI_POSTOPKI_POS").ToList();
                return output;
            }
        }


        public List<TehnoloskiPostopki> TehnoloskiPostopki()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {
                var output = connection.Query<TehnoloskiPostopki>($"select * from dbo.TEHNOLOSKI_POSTOPKI").ToList();
                return output;
            }
        }

        /*    private static void BasicRead()
            {
                using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
                {
                    string sql = "select * from dbo.Person";

                    var people = cnn.Query<PersonModel>(sql);

                    foreach (var person in people)
                    {
                        Console.WriteLine($"{ person.FirstName } { person.LastName }");
                    }
                }
            }
        */
        /*  private static void BasicWithoutModel()
            {
                using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
                {
                    string sql = "select * from dbo.Person";

                    var people = cnn.Query(sql);

                    foreach (var person in people)
                    {
                        Console.WriteLine($"{ person.FirstName } { person.LastName }");
                    }
                }
            }
        */

       /* public string ReadWithParameters(string STEVILKA) //branje podatkov glede na stevilo naloga iz baze nalog_glava
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {
                var p = new DynamicParameters();
                p.Add("@STEVILKA", STEVILKA);

                string sql = "select sTRANKA from dbo.Nalog_Glava where STEVILKA = @STEVILKA";

                var nalog_glava = connection.Query(sql, p); //brez nalogpostavke

                string a = "";

                foreach (var nalog in nalog_glava)
                {
                    a = nalog.sTRANKA + a;
                }

                return a;
            }
        }*/

        public void SifraBlaga(string Stevilka)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {

                var p = new
                {
                    STEVILKA = Stevilka
                };

                string sql = @"SELECT nal_gl.*, nal_pos.*
                               FROM dbo.Nalog_Glava nal_gl
                               LEFT JOIN dbo.Nalog_POstavke nal_pos
                                    ON  nal_gl.STEVILKA = nal_pos.STEVILKA
                               WHERE nal_gl.STEVILKA = @STEVILKA";

                var nalog = connection.Query(sql, p);
                

            
            }
        }
    }
}

