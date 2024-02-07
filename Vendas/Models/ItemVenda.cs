namespace Models
{
    public class ItemVenda
    {
        public int NUMVENDA { get; set; }
        public double UNITARIO { get; set; }
        public int CODUSUARIO { get; set; }
        public int CODPRODUTO { get; set; }
        public int CODVENDEDOR { get; set; }
        public int CODCLIENTE { get; set; }
        public int QUANTIDADE { get; set; }
        public double TOTALVENDA { get; set; }
        public double TOTALLIQ { get; set; }
        public double ITEMDESC { get; set; }
        public string DESCRICAO { get; set; }
        public DateTime DATA_EMISSAO { get; set; }
        public bool O_V { get; set; }
    }
}
