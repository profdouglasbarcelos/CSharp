namespace Modelos
{
    public class Atividade
    {
        public int AtividadeID { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public bool Ativo { get; set; }

        public int CategoriaID { get; set; }

        public int UsuarioID { get; set; }

    }
}
