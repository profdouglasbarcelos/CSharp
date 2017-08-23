using Aula1003_Camadas.Models;

namespace Aula1003_Camadas.Controllers
{
    public class CarroController
    {
        public bool SalvarCarro(Carro c)
        {
            if(string.IsNullOrEmpty(c.Nome))
                return false;
            else
            {
                if(c.Ano <= 0)
                {
                    return false;
                }
                else
                {
                    // salvar o objeto no banco
                    return true;
                }
            }
        }
    }
}
