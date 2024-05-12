﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VitalNutri.Models
{
    public class Exercicio
    {
        [Key]
        public int ExercicioId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int? TreinadorPessoalId { get; set; }
        public byte[] Imagem { get; set; }
        [ForeignKey("TreinadorPessoalId")]
        public virtual TreinadorPessoal TreinadorPessoal { get; set; }
        public ICollection<TreinoExercicio> TreinosExercicios { get; set; }
    }
}