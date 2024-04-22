using YHADotNetCore.ConsoleApp;

Console.WriteLine("Hello, World");

//SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder();
//stringBuilder.DataSource = "localhost";
//stringBuilder.InitialCatalog = "DotNetTrainingBatch4";
//stringBuilder.UserID = "sa";
//stringBuilder.Password = "sasa@123";

//SqlConnection connection = new SqlConnection(stringBuilder.ConnectionString);

//connection.Open();
//Console.WriteLine("Connection open.");

//string query = "select * from tbl_blog";
//SqlCommand cmd = new SqlCommand(query, connection);
//SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
//DataTable dt = new DataTable();
//sqlDataAdapter.Fill(dt);

//connection.Close();
//Console.WriteLine("Connection close.");

//foreach (DataRow dr in dt.Rows)
//{
//    Console.WriteLine("Blog Id => " + dr["BlogId"]);
//    Console.WriteLine("Blog Title => " + dr["BlogTitle"]);
//    Console.WriteLine("Blog Author => " + dr["BlogAuthor"]);
//    Console.WriteLine("Blog Content => " + dr["BlogContent"]);
//    Console.WriteLine("------------------------------------");
//}

// Ado.Net Read
// CRUD

AdoDotNetExample adoDotNetExample = new AdoDotNetExample();
//adoDotNetExample.Read();
//adoDotNetExample.Create("title", "author", "content");
//adoDotNetExample.Update(12, "test title", "test author", "test content");
//adoDotNetExample.Delete(11);
adoDotNetExample.Edit(30);
adoDotNetExample.Edit(9);


Console.ReadKey();