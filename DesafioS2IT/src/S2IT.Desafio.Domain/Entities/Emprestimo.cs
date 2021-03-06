﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2IT.Desafio.Domain.Entities
{
    [Table("EMPRESTIMO")]
    public class Emprestimo
    {
        [Column("IDEMPRESTIMO")]
        public long IdEmprestimo { get; set; }

        [Column("IDAMIGO")]
        public long IdAmigo { get; set; }

        [Column("IDJOGO")]
        public long IdJogo { get; set; }

        [Column("IDUSUARIO")]
        public long IdUsuario { get; set; }

        /// <summary>
        /// 1 - Emprestado
        /// 2 - Devolvido
        /// </summary>
        [Column("IDSTATUSEMPRESTIMO")]
        public long IdStatusEmprestimo { get; set; }

        [Column("DATAEMPRESTIMO")]
        public DateTime DataEmprestimo { get; set; }

        [Column("DATADEVOLUCAO")]
        public Nullable<DateTime> DataDevolucao { get; set; }

        [Column("DATAMODIFICACAO")]
        public DateTime DataModificacao { get; set; }

        public virtual StatusEmprestimo StatusEmprestimo { get; set; }

        public virtual Usuario Usuario { get; set; }

        public virtual Amigo Amigo { get; set; }

        public virtual Jogo Jogo { get; set; }
    }
}
