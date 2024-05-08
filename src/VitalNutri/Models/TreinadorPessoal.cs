﻿using Microsoft.AspNetCore.Identity;

namespace VitalNutri.Models
{
    public class TreinadorPessoal
    {
        // Propriedades
        public int Id { get; set; }
        public string NumeroRegistro { get; set; }
        public string Especializacao { get; set; }
        public int UsuarioId { get; set; }

        // Relacionamentos
        public Usuario Usuario { get; set; }
        public ICollection<PlanoTreino> PlanosTreino { get; set; }
        public ICollection<ClienteTreinadorPessoal> ClientesTreinadoresPessoais { get; set; }
    }
}
