namespace DesafioStefanini.DTO;

public class PedidoDTO
{
    public int Id { get; set; }
    public string NomeCliente { get; set; }
    public string EmailCliente { get; set; }
    public bool Pago { get; set; }
    public List<ItensPedidoDTO> ItensPedido { get; set; }
}