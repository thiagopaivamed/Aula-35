﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuitosParaMuitos.Models
{
    public class Trabalho
    {
        public int TrabalhoId { get; set; }

        public string Nome { get; set; }

        public ICollection<EmpregadoTrabalho> EmpregadoTrabalhos { get; set; }
    }
}
