using Data;

namespace Models {
    public class Saldo {
        public int Id { get; set; }
        public Produto Produto { get; set; }
        public int ProdutoId { get; set; }
        public Almoxarifado Almoxarifado { get; set; }
        public int AlmoxarifadoId { get; set; }
        public int Quantidade { get; set; }

        public Saldo(int produtoId, int almoxarifadoId, int quantidade)
        {
            ProdutoId = produtoId;
            AlmoxarifadoId = almoxarifadoId;
            Quantidade = quantidade;
        }

        public static void store(Saldo saldo)
        {
            try {
                using(Context context = new Context()) {
                    context.Saldos.Add(saldo);
                    context.SaveChanges();
                }
            } catch (System.Exception e) {
                throw new Exception(e.Message);
            }
        }

        public static List<Saldo> index()
        {
            try {
                using(Context context = new Context()) {
                    return context.Saldos.ToList();
                }
            } catch (System.Exception e) {
                throw new Exception(e.Message);
            }
        }

        public static Saldo show(int id)
        {
            try {
                using(Context context = new Context()) {
                    return context.Saldos.Find(id);
                }
            } catch (System.Exception e) {
                throw new Exception(e.Message);
            }
        }

        public static void update(int id, Saldo saldo)
        {
            try {
                using(Context context = new Context()) {
                    Saldo saldoAntigo = context.Saldos.Find(id);
                    saldoAntigo.ProdutoId = saldo.ProdutoId;
                    saldoAntigo.AlmoxarifadoId = saldo.AlmoxarifadoId;
                    saldoAntigo.Quantidade = saldo.Quantidade;
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
                    Saldo saldo = context.Saldos.Find(id);
                    context.Saldos.Remove(saldo);
                    context.SaveChanges();
                }
            } catch (System.Exception e) {
                throw new Exception(e.Message);
            }
        }
        
    }
}