namespace Models
{
    public class FormaPagamento
    {
        public int ID { get; set; }
        public int CODUSUARIO { get; set; }
        public string DESCRICAO { get; set; }
        public bool RECEITADESPESA { get; set; }
        public bool ATIVO { get; set; }
    }
}
