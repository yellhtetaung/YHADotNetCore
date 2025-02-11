using System.Data;
using System.Data.SqlClient;
using YHADotNetCore.ConsoleApp;

//SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder();
//stringBuilder.DataSource = "DESKTOP-0RPA0T5";
//stringBuilder.InitialCatalog = "DotNetTrainingBatch4";
//stringBuilder.UserID = "sa";
//stringBuilder.Password = "Yehtetaung@2481998";

//SqlConnection connection = new SqlConnection(stringBuilder.ConnectionString);
//connection.Open();
//Console.WriteLine("Connection open.");

//string query = "SELECT * FROM Tbl_Blog";
//SqlCommand cmd = new SqlCommand(query, connection);
//SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
//DataTable dt = new DataTable();
//sqlDataAdapter.Fill(dt);

//connection.Close();
//Console.WriteLine("Connection close.");

//// dataset => datatable
//// datatable => datarow
//// datarow => datacolumn

//foreach (DataRow dr in dt.Rows)
//{
//    Console.WriteLine("Blog Id => " + dr["BlogId"]);
//    Console.WriteLine("Blog Title => " + dr["BlogTitle"]);
//    Console.WriteLine("Blog Author => " + dr["BlogAuthor"]);
//    Console.WriteLine("Blog Content => " + dr["BlogContent"]);
//    Console.WriteLine("---------------------------------------");
//}

// Ado.Net Read
// CRUD

AdoDotNetExample adoDotNetExample = new AdoDotNetExample();
adoDotNetExample.Read();
//adoDotNetExample.Create("title", "author", "content");

Console.ReadKey();