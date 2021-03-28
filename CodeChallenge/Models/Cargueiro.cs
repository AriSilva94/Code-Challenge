using System;
using System.ComponentModel.DataAnnotations;

namespace CodeChallenge.Models
{
    public class Cargueiro
    {
        public int Id { get; set; }
        public int Tipo { get; set; }
        public DateTime Retorno { get; set; }

        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:hh\\:mm}")]
        //[RegularExpression(@"((([0-1][0-9])|(2[0-3]))(:[0-5][0-9])(:[0-5][0-9])?)", ErrorMessage = "Time must be between 00:00 to 23:59")]
        public DateTime Saida { get; set; }
        public double? Quantidade { get; set; }
        public string TipoMinerio { get; set; }

        public Cargueiro()
        {}

        public Cargueiro(int id, int tipo, DateTime retorno, DateTime saida, double? quantidade, string tipoMinerio)
        {
            Id = id;
            Tipo = tipo;
            Retorno = retorno;
            Saida = saida;
            Quantidade = quantidade;
            TipoMinerio = tipoMinerio;
        }
    }
}
