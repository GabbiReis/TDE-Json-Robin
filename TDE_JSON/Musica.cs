using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDE_JSON
{
    internal class Musica
    {
        public string Titulo { get; set; }
        public string Artista { get; set; }
        public string Genero { get; set; }
        public string DataLancamento { get; set; }

        public override string ToString()
        {
            return $"Música - Título: {Titulo,-20} Artista: {Artista,-20} Gênero: {Genero,-15} Data de Lançamento: {DataLancamento,-20}";
        }
    }
}
