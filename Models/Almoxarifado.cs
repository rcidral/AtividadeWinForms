using Data;

namespace Models {
    public class Almoxarifado {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Almoxarifado(string nome)
        {
            Nome = nome;
        }
        public static void store(Almoxarifado almoxarifado)
        {
            try {
                using(Context context = new Context()) {
                    context.Almoxarifados.Add(almoxarifado);
                    context.SaveChanges();
                }
            } catch (System.Exception e) {
                throw new Exception(e.Message);
            }
        }
        public static List<Almoxarifado> index()
        {
            try {
                using(Context context = new Context()) {
                    return context.Almoxarifados.ToList();
                }
            } catch (System.Exception e) {
                throw new Exception(e.Message);
            }
        }
        public static Almoxarifado show(int id)
        {
            try {
                using(Context context = new Context()) {
                    return context.Almoxarifados.Find(id);
                }
            } catch (System.Exception e) {
                throw new Exception(e.Message);
            }
        }
        public static void update(int id, Almoxarifado almoxarifado)
        {
            try {
                using(Context context = new Context()) {
                    Almoxarifado almoxarifadoAntigo = context.Almoxarifados.Find(id);
                    almoxarifadoAntigo.Nome = almoxarifado.Nome;
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
                    Almoxarifado almoxarifado = context.Almoxarifados.Find(id);
                    context.Almoxarifados.Remove(almoxarifado);
                    context.SaveChanges();
                }
            } catch (System.Exception e) {
                throw new Exception(e.Message);
            }
        }
    }
}