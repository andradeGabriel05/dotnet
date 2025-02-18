namespace DesafioStefanini.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string NomeProduto { get; set; }
        public int Valor { get; set; }

        public Produto()
        {
            
        }

        public Produto(string nomeProduto, int valor)
        {
            NomeProduto = nomeProduto;
            Valor = valor;
        }
    }

}

