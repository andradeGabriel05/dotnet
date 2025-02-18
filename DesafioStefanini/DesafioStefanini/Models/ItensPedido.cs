namespace DesafioStefanini.Models
{
    public class ItensPedido
    {
        public int Id { get; set; }
        
        public int PedidoId { get; set; }
        
        public int ProdutoId { get; set; } 
        // public Produto Produto { get; set; }
        
        public int Quantidade { get; set; }

        public ItensPedido()
        {
        }

        public ItensPedido(int pedidoId, int produtoId, int quantidade)
        {
            PedidoId = pedidoId;
            ProdutoId = produtoId;
            Quantidade = quantidade;
        }
    }   
}
