﻿using SQLite;

namespace listaCompras.Models
{
    public class Produto
    {
        [PrimaryKey, AutoIncrement] 
        public int Id { get; set; }
        public string descricao { get; set; }
        public double Quantidade {  get; set; }
        public double Preço { get; set; }
    }   
}
