using Models;

namespace Controllers {
    public class Saldo {
        
        public static void store(Models.Saldo saldo)
        {
            Models.Saldo.store(saldo);
        }

        public static List<Models.Saldo> index()
        {
            return Models.Saldo.index();
        }

        public static Models.Saldo show(int id)
        {
            return Models.Saldo.show(id);
        }

        public static void update(int id, Models.Saldo saldo)
        {
            Models.Saldo.update(id, saldo);
        }

        public static void delete(int id)
        {
            Models.Saldo.delete(id);
        }
    }
}