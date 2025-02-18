using DesafioStefanini.Models;

namespace DesafioStefanini.Data;

public class SeedingService
{
    private readonly DesafioStefaniniContext _context;

    public SeedingService(DesafioStefaniniContext context)
    {
        _context = context;
    }

    public void Seed()
    {
        if (_context.Produto.Any())
        {
            return;
        }

        Produto p1 = new Produto("Computer", 1000);
        Produto p2 = new Produto("Book", 10);
        Produto p3 = new Produto("Water", 1);
        Produto p4 = new Produto("TV", 100);
        Produto p5 = new Produto("Egg", 2);
        Produto p6 = new Produto("TV Plasma", 200);
        Produto p7 = new Produto("Pencil", 1);
        
        _context.Produto.AddRange(p1, p2, p3, p4, p5, p6, p7);
        _context.SaveChanges();
    }
    
}