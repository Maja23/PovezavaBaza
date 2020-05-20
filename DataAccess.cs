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
        public List<Person> GetPeople(string nazdel)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {
                //i wanna ask for my data back 
               // var output = connection.Query<Person>($"select * from dbo.Sif_Delavci where nazdel = '{ nazdel }'").ToList();
                var output = connection.Query<Person>($"select * from dbo.Sif_Delavci").ToList();
                return output;
            }
        }
    }
}
