namespace Modelos
{
    public class Atividade
    {
        public int AtividadeID { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public int CategoriaID { get; set; }

        public virtual Categoria _Categoria { get; set; }

        public int UsuarioID { get; set; }

        public virtual Usuario _Usuario { get; set; }

    }
}
