﻿namespace BlocodeNotasApi.Models.Entities
{
    public class BlocoDeNotas
    {
        public BlocoDeNotas(string? titulo, string? descricao)
        {
            Titulo = titulo;
            Descricao = descricao;
        }
        public string? Titulo { get; private set; }

        public string? Descricao { get; private set; }
    }
}