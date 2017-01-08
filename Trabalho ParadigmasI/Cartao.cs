﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_ParadigmasI
{
    class Cartao
    {
        private List<float> movimentos;
        public List<float> Movimentos
        {
            get { return movimentos; }
            set { movimentos = value; }
        }

        private float saldo;
        public float Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        private List<Artigo> listaComprasCartao;
        public List<Artigo> ListaComprasCartao
        {
            get { return listaComprasCartao; }
            set { listaComprasCartao = value; }
        }

        private int pontos;
        public int Pontos
        {
            get { return pontos; }
            set { pontos = value; }
        }


    }
}