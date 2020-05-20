using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;


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
    }
}
