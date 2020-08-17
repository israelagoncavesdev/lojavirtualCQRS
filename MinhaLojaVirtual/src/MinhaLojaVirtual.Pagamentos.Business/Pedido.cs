﻿using System;
using System.Collections.Generic;

namespace MinhaLojaVirtual.Pagamentos.Business
{
    public class Pedido
    {
        public Guid Id { get; set; }
        public decimal Valor { get; set; }
        public List<Produto> Produtos { get; set; }
    }
}