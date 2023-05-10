﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichadeEmpregado
{
    internal class Empregado
    {
        private String nome="";
        private int idade;
        public Empregado() {
            nome = "";
            idade = 0;
        }
        public Empregado(String nome, int idade) { 
            this.nome = nome;
            this.idade = idade;
        }

        public string Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }
    }
}
