using DesafioStefanini.Data;
using DesafioStefanini.DTO;
using DesafioStefanini.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DesafioStefanini.Services;

public class PedidosService
{
    private readonly DesafioStefaniniContext _context;
    

    public PedidosService(DesafioStefaniniContext context)
    {
        _context = context;
        
    }

    // GET: api/Pedidos
    [HttpGet]
    public async Task<ActionResult<IEnumerable<PedidoDTO>>> GetPedido()
    {
        var pedidos = await _context.Pedido
            .Include(p => p.ItensPedido)
            .ToListAsync();
        
        var produtos = await _context.Produto.ToListAsync(); 

        return pedidos.Select(p => new PedidoDTO
        {
            Id = p.Id,
            NomeCliente = p.NomeCliente,
            EmailCliente = p.EmailCliente,
            Pago = p.Pago, 
            ItensPedido = p.ItensPedido.Select(ip => new ItensPedidoDTO
            {
                Id = ip.Id,
                IdProduto = ip.ProdutoId,
                NomeProduto = produtos.First(prod => prod.Id == ip.ProdutoId).NomeProduto,
                ValorUnitario = produtos.First(prod => prod.Id == ip.ProdutoId).Valor,
                Quantidade = ip.Quantidade
            }).ToList()
        }).ToList();
    }
}