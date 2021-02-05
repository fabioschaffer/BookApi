using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Book.Controllers {

    [ApiController]
    [Route("[controller]")]
    public class PingDbController : ControllerBase {

        private readonly IConfiguration cfg;

        public PingDbController(IConfiguration cfg) => this.cfg = cfg;

        [HttpGet]
        public string Get() {
            try {
                //Exemplo para obter chave filha.
                //string emailPwd = cfg.GetValue<string>("Email:EmailAddress");

                //O Ip da connection string é do WSL, que é onde o Docker está rodando, pois o sql está rodando dentro de um container.
                string sqlCnn = cfg.GetValue<string>("DbConnection");
                using SqlConnection cnn = new SqlConnection(sqlCnn);
                cnn.Open();
                cnn.Close();
                return "OK";
            } catch (System.Exception ex) {
                return ex.Message;
            }
        }
    }
}