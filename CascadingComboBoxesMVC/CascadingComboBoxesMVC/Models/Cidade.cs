namespace CascadingComboBoxesMVC.Models
{
    public class Cidade
    {
        public int CidadeID { get; set; }

        public string Nome { get; set; }

        public int EstadoID { get; set; }

        public virtual Estado _Estado { get; set; }

    }
}
