using System;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Archivos
{
    public class ArchivoTxt : IArchivos<string>
    {
        public string path;
        public string nombreArchivo;



        public ArchivoTxt()
        {
            path = AppDomain.CurrentDomain.BaseDirectory;

        }

        public void Escribir(string datos, string nombreDeArchivo)
        {
            string nombreArchivo = this.path + nombreDeArchivo + ".txt";
            try
            {
                if (!Directory.Exists(this.path))
                {
                    Directory.CreateDirectory(this.path);
                }

                File.WriteAllText(nombreArchivo, datos);
            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo ubicado en {path}", e);
            }
        }

        public string Leer(string nombre)
        {
            string archivo = string.Empty;
            string informacionRecuperada = string.Empty;
            string nombreArchivo = this.path + nombre + ".txt";

            try
            {
                if (Directory.Exists(path))
                {
                    string[] archivosEnElPath = Directory.GetFiles(path);
                    foreach (string path in archivosEnElPath)
                    {
                        if (path.Contains(nombreArchivo))
                        {
                            archivo = path;
                            break;
                        }
                    }

                    if (archivo != null)
                    {
                        informacionRecuperada = File.ReadAllText(archivo);
                    }
                }

                return informacionRecuperada;
            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo ubicado en {path}", e);
            }

        }
    }
}

