namespace DesafioStefanini.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public string NomeCliente { get; set; }
        public string EmailCliente { get; set; }
        public DateTime DataCriacao { get; set; }
        public bool Pago { get; set; }
        
        public ICollection<ItensPedido> ItensPedido { get; set; } = new List<ItensPedido>();

    }
}
