using Modelos.DAL;

namespace Controllers
{
    public class ContextoSingleton
    {
        private static Contexto instancia;

        public static Contexto Instancia
        {
            get
            {
                if (instancia == null)
                    instancia = new Contexto();

                return instancia;
            }

        }

        private ContextoSingleton()
        {

        }


    }
}
