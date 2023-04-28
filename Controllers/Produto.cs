using Models;

namespace Controllers {
    public class Produto {
        
        public static void store(Models.Produto produto)
        {
            Models.Produto.store(produto);
        }

        public static List<Models.Produto> index()
        {
            return Models.Produto.index();
        }

        public static Models.Produto show(int id)
        {
            return Models.Produto.show(id);
        }

        public static void update(int id, Models.Produto produto)
        {
            Models.Produto.update(id, produto);
        }

        public static void delete(int id)
        {
            Models.Produto.delete(id);
        }
    }
}