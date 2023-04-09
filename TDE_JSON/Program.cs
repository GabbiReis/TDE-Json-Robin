using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TDE_JSON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var musica = new List<Musica>
            {
                new Musica {Titulo="Dizeres", Artista="Lourena, Sant", Genero="Rap", DataLancamento="28 de setembro de 2018"},
                new Musica {Titulo="Dengo", Artista="ANAVITÓRIA", Genero="Mpb", DataLancamento="02 de setembro de 2016"},
                new Musica {Titulo="Ninguém me Ensinou", Artista="Lagum", Genero="Pop Rock", DataLancamento="23 de agosto de 2019"},                
                new Musica {Titulo="Vampiro", Artista="Matuê, Teto e WIU", Genero="Trap/Rap", DataLancamento="24 de setembro de 2021"},
            };


            var json = JsonConvert.SerializeObject(musica);
            File.WriteAllText("musica.json", json);


            json = File.ReadAllText("musica.json");
            var informaoes = JsonConvert.DeserializeObject<List<Musica>>(json);

            foreach (var musicas in informaoes)
            {
                Console.WriteLine(musicas);
            }

            Console.ReadLine();
        }
    }
}
