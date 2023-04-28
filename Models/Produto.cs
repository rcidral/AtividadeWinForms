using Data;

namespace Models {
    public class Produto {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
        public static void store(Produto produto)
        {
            try {
                using(Context context = new Context()) {
                    context.Produtos.Add(produto);
                    context.SaveChanges();
                }
            } catch (System.Exception e) {
                throw new Exception(e.Message);
            }
        }
        public static List<Produto> index()
        {
            try {
                using(Context context = new Context()) {
                    return context.Produtos.ToList();
                }
            } catch (System.Exception e) {
                throw new Exception(e.Message);
            }
        }
        public static Produto show(int id)
        {
            try {
                using(Context context = new Context()) {
                    return context.Produtos.Find(id);
                }
            } catch (System.Exception e) {
                throw new Exception(e.Message);
            }
        }

        public static void update(int id, Produto produto)
        {
            try {
                using(Context context = new Context()) {
                    Produto produtoAntigo = context.Produtos.Find(id);
                    produtoAntigo.Nome = produto.Nome;
                    produtoAntigo.Preco = produto.Preco;
                    context.SaveChanges();
                }
            } catch (System.Exception e) {
                throw new Exception(e.Message);
            }
        }
        public static void delete(int id)
        {
            try {
                using(Context context = new Context()) {
                    Produto produto = context.Produtos.Find(id);
                    context.Produtos.Remove(produto);
                    context.SaveChanges();
                }
            } catch (System.Exception e) {
                throw new Exception(e.Message);
            }
        }
    }
}