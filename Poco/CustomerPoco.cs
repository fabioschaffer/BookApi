namespace Book.Poco {

    //Exemplo classe POCO. É uma classe simples, contém somente as propriedades.
    //Pode ser utilizada, por exemplo, para mapear um objeto de banco para a aplicação.
    //Pode ser utilizada pelo Dapper, que necessita de um objeto para popular.
    public class CustomerPoco {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
