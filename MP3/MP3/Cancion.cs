using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP3
{
    public class Cancion
    {
        public string nombre;
        public string ruta;
        public string artista;
        public string album;
        public string genero;
        public string duracion;
        public string year;
        public Cancion(string v1, string v2,string v3,string v4,string v5,string v6,string v7)
        {
            nombre = v1;
            artista = v7;
            ruta = v2;
            album = v3;
            genero = v4;
            duracion = v5;
            year = v6;

        }
    }
}
