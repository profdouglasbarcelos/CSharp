using System;

namespace Aula2806_CrudMVVM.Models
{
    public enum EstadoCivil
    {
        Solteiro,
        Casado,
        Divorciado,
        Viuvo
    }

    public enum Sexo
    {
        Masculino,
        Feminino
    }

    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public Sexo Sexo { get; set; }
        public EstadoCivil EstadoCivil { get; set; }
        public DateTime DataAdmissao { get; set; }
    }

}