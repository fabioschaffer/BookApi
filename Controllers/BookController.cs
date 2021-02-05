using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Book.Controllers {

    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase {

        private readonly IConfiguration cfg;

        public BookController(IConfiguration cfg) => this.cfg = cfg;

        [HttpGet]
        public IEnumerable<Book> Get() {

            //Exemplo para obter chave filha.
            //string emailPwd = cfg.GetValue<string>("Email:EmailAddress");

            //O Ip da connection string é do WSL, que é onde o Docker está rodando, pois o sql está rodando dentro de um container.
            string sqlCnn = cfg.GetValue<string>("DbConnection");
            string sql = "SELECT * FROM Book";
            using SqlConnection connection = new SqlConnection(sqlCnn);
            List<Book> books = connection.Query<Book>(sql).ToList();
            books.GetHashCode();
            return books.ToArray();
        }
    }
}