namespace Models
{
    public class Venda
    {
        public int CODIGOVENDA { get; set; }
        public int CODUSUARIO { get; set; }
        public int CODVENDEDOR { get; set; }
        public int CODCLIENTE { get; set; }
        public int CODFORMAPGTO { get; set; }
        public DateTime EMISSAO { get; set; }
        public DateTime DATA_FATURAMENTO { get; set; }
        public DateTime DATA_CANCELAMENTO { get; set; }
        public string OBSERVACAO { get; set; }
        public double TOTALVENDA { get; set; }
        public double TOTALLIQ { get; set; }
        public double DESCONTO { get; set; }
        public bool ATIVO { get; set; }
        public bool O_V { get; set; }
    }
}
