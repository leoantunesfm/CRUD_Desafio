using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace CRUD_Desafio
{
    class Repository
    {
        public static SqlConnection SqlConnection { get; set; } = new SqlConnection(@"Data Source=LEANDRO-DELLG3;Initial Catalog=DESAFIO;User Id=usr_adm;Password=Abc123;");
    }
}
