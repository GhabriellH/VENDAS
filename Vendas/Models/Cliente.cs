namespace Models
{
    public class Cliente
    {
        public int ID { get; set; }
        public int CODUSUARIO { get; set; }
        public string NOME { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string ENDERECO { get; set; }
        public string FONE1 { get; set; }
        public string FONE2 { get; set; }
        public DateTime DATA_NASCIMENTO { get; set; }
        public string CEP { get; set; }
        public string CIDADE { get; set; }
        public string ESTADO { get; set; }
        public bool ATIVO { get; set; }
        public string CNPJ { get; set; }
    }
}
