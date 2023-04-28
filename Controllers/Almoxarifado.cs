using Models;

namespace Controllers {
    public class Almoxarifado {
        
        public static void store(Models.Almoxarifado almoxarifado)
        {
            Models.Almoxarifado.store(almoxarifado);
        }

        public static List<Models.Almoxarifado> index()
        {
            return Models.Almoxarifado.index();
        }

        public static Models.Almoxarifado show(int id)
        {
            return Models.Almoxarifado.show(id);
        }


        public static void update(int id, Models.Almoxarifado almoxarifado)
        {
            Models.Almoxarifado.update(id, almoxarifado);
        }

        public static void delete(int id)
        {
            Models.Almoxarifado.delete(id);
        }
    }
}