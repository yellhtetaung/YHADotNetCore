using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace YHADotNetCore.ConsoleApp
{
    internal class DapperExample
    {
        public void Run()
        {
            //Read();
            //Edit(1);
            //Edit(20);
            //Create("Title Test", "Author Test", "Content Test");
            //Update(14, "Test Title", "Test Author", "Test Content");
            Delete(14);
        }

        public void Read()
        {
            using IDbConnection db = new SqlConnection(ConnectionStrings.SqlConnectionStringBuilder.ConnectionString);
            List<BlogDto> lst = db.Query<BlogDto>("SELECT * FROM Tbl_Blog").ToList();

            foreach (BlogDto blog in lst)
            {
                Console.WriteLine(blog.BlogId);
                Console.WriteLine(blog.BlogTitle);
                Console.WriteLine(blog.BlogAuthor);
                Console.WriteLine(blog.BlogContent);
                Console.WriteLine("-------------------------------");
            }
        }

        public void Edit(int id)
        {
            using IDbConnection db = new SqlConnection(ConnectionStrings.SqlConnectionStringBuilder.ConnectionString);
            var blog = db.Query<BlogDto>("SELECT * FROM Tbl_Blog WHERE BlogId=@BlogId", new BlogDto { BlogId = id }).FirstOrDefault();

            if (blog is null)
            {
                Console.WriteLine("No data found.");
                return;
            }

            Console.WriteLine(blog.BlogId);
            Console.WriteLine(blog.BlogTitle);
            Console.WriteLine(blog.BlogAuthor);
            Console.WriteLine(blog.BlogContent);
            Console.WriteLine("-------------------------------");
        }

        public void Create(string title, string author, string content)
        {
            var item = new BlogDto
            {
                BlogTitle = title,
                BlogAuthor = author,
                BlogContent = content
            };

            using IDbConnection db = new SqlConnection(ConnectionStrings.SqlConnectionStringBuilder.ConnectionString);
            string query = @"INSERT INTO [dbo].[Tbl_Blog]
                           ([BlogTitle]
                           ,[BlogAuthor]
                           ,[BlogContent])
                            VALUES
                               (@BlogTitle
		                       ,@BlogAuthor
		                       ,@BlogContent)";
            int result = db.Execute(query, item);

            string message = result > 0 ? "Saving Successful." : "Saving Failed";
            Console.WriteLine(message);
        }

        public void Update(int id, string title, string author, string content)
        {
            var item = new BlogDto
            {
                BlogId = id,
                BlogTitle = title,
                BlogAuthor = author,
                BlogContent = content
            };

            using IDbConnection db = new SqlConnection(ConnectionStrings.SqlConnectionStringBuilder.ConnectionString);
            string query = @"UPDATE [dbo].[Tbl_Blog]
                            SET [BlogTitle] = @BlogTitle
                            ,[BlogAuthor] = @BlogAuthor
                            ,[BlogContent] = @BlogContent
                            WHERE BlogId = @BlogId";
            int result = db.Execute(query, item);

            string message = result > 0 ? "Updating Successful." : "Updating Failed";
            Console.WriteLine(message);
        }

        public void Delete (int id)
        {
            using IDbConnection db = new SqlConnection(ConnectionStrings.SqlConnectionStringBuilder.ConnectionString);
            int result = db.Execute("DELETE FROM Tbl_Blog WHERE BlogId=@BlogId", new BlogDto { BlogId = id });

            string message = result > 0 ? "Deleting Successful." : "Deleting Failed.";
            Console.WriteLine(message);
        }
    }
}
