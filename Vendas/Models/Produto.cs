namespace Models
{
    public class Produto
    {
        public int ID { get; set; }
        public int CODUSUARIO { get; set; }
        public int CODCATEGORIA { get; set; }
        public string DESCRICAO { get; set; }
        public double PCO_COMPRA { get; set; }
        public double PCO_VENDA { get; set; }
        public int ESTOQUE { get; set; }
        public bool ATIVO { get; set; }
    }
}
