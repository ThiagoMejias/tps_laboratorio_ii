using System;
using System.IO;
using System.Xml.Serialization;

namespace Entidades.Archivos
{
    public class ClaseSerializadoraXml<T> : IArchivos<T>
    {

        protected string path;

        public ClaseSerializadoraXml()
        {
            path = AppDomain.CurrentDomain.BaseDirectory;

        }

        public void Escribir(T obj, string nombre)
        {
            string nombreArchivo = this.path + nombre + ".xml";
            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                using (StreamWriter streamWriter = new StreamWriter(nombreArchivo))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                    xmlSerializer.Serialize(streamWriter, obj);
                }

            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo ubicado en {this.path}", e);
            }
        }


        public T Leer(string nombre)
        {
            string archivo = string.Empty;
            string nombreArchivo = this.path + nombre + ".xml";
            string informacionRecuperada = string.Empty;
            T obj = default(T);
            try
            {

                if (Directory.Exists(this.path))
                {

                    string[] archivosEnElPath = Directory.GetFiles(this.path);
                    foreach (string path in archivosEnElPath)
                    {
                        if (path.Contains(nombreArchivo))
                        {
                            archivo = nombreArchivo;
                            break;
                        }
                    }

                    if (archivo != null)
                    {
                        using (StreamReader sr = new StreamReader(archivo))
                        {

                            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                            obj = (T)xmlSerializer.Deserialize(sr);

                        }
                    }
                }

                return obj;
            }
            catch (SystemException e)
            {
                throw new SystemException($"Error en el archivo ubicado en {this.path}", e);
            }

        }



    }
}
