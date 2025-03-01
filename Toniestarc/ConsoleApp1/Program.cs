//Crear un archivo plano

using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

string path = "C:\\Users\\jorge\\OneDrive\\Desktop\\C#\\Tarea 3\\Toniestarc\\Inventos.txt";

void CrearArchivo()
{

    if (File.Exists(path))
    {
        Console.WriteLine("El archivo ya existe");
    }
    else
    {
        File.Create(path);
        Console.WriteLine("El archivo ´Inventos´ se ha creado");
    }
}

//Agregar texto al archivo plano
void EditarTexto()
{
    string path = "C:\\Users\\jorge\\OneDrive\\Desktop\\C#\\Tarea 3\\Toniestarc\\Inventos.txt";

    string opcion;
    do
    {
        Console.WriteLine("Que desea hacer?");
        Console.WriteLine("1. Agregar texto");
        Console.WriteLine("2. Salir");
        opcion = Console.ReadLine();

        switch (opcion)
        {
            case "1":
                Console.WriteLine("Escriba el invento que desea agregar");
                string invento = Console.ReadLine();
                File.AppendAllText(path, invento + Environment.NewLine);
                Console.WriteLine("Invento agregado correctamente");
                break;

            case "2":
                Console.WriteLine("Saliendo...");
                break;

            default:
                Console.WriteLine("Esa opcion no existe");
                break;
        }
    } while (opcion != "2");
}

//Leer el archivo linea por linea
void LeerArchivo()
{
    string path = "C:\\Users\\jorge\\OneDrive\\Desktop\\C#\\Tarea 3\\Toniestarc\\Inventos.txt";

    try
    {
        if (File.Exists(path))
        {

            string[] lineas = File.ReadAllLines(path);
            foreach (string linea in lineas)
            {
                Console.WriteLine(linea);
            }

        }
        else
        {

            Console.WriteLine("El archivo no existe o hubo algun problema");
        }
    }
    catch (Exception err)
    {
        Console.WriteLine("Yarbis:" + err.Message);
    }
}

//Leer el archivo completo

void LeerArchivoCompleto()
{
    string path = "C:\\Users\\jorge\\OneDrive\\Desktop\\C#\\Tarea 3\\Toniestarc\\Inventos.txt";

    try
    {
        if (File.Exists(path))
        {
            string contenido = File.ReadAllText(path);
            Console.WriteLine("Los inventos agregados son:");
            Console.WriteLine(contenido);
        }
        else
        {
            Console.WriteLine("El archivo no existe o hubo algun problema");
        }
    }
    catch (Exception err)
    {
        Console.WriteLine("Ups, hubo algun problema" + err.Message);
    }
}

//Copiar un archivo

void CopiarArchivo()
{
    string path = "C:\\Users\\jorge\\OneDrive\\Desktop\\C#\\Tarea 3\\Toniestarc\\Inventos.txt";
    string path2 = "C:\\Users\\jorge\\OneDrive\\Desktop\\C#\\Tarea 3\\Toniestarc\\Backup.txt";
    try
    {
        if (File.Exists(path))
        {
            File.Copy(path, path2);
            Console.WriteLine("Archivo copiado correctamente");
        }
        else
        {
            Console.WriteLine("El archivo no existe o hubo algun problema");
        }
    }
    catch (Exception err)
    {
        Console.WriteLine("Hubo algun problema con la accion" + err.Message);
    }
}

//Mover un archivo

void MoverArchivo()
{
    string path = "C:\\Users\\jorge\\OneDrive\\Desktop\\C#\\Tarea 3\\Toniestarc\\Inventos.txt";
    string path2 = "C:\\Users\\jorge\\OneDrive\\Desktop//C#//Tarea 3\\Toniestarc\\Proyectos Clasificados";
    try
    {
        if (File.Exists(path))
        {
            File.Move(path, path2);
            Console.WriteLine("Archivo clasificado movido correctamente");
        }
        else
        {
            Console.WriteLine("El archivo no existe o hubo algun problema");
        }
    }
    catch (Exception err)
    {
        Console.WriteLine("Ups, parece que no era lo suficientemente importante" + err.Message);
    }
}

//Crear una carpeta

void CrearCarpeta()
{
    string path = "C:\\Users\\jorge\\OneDrive\\Desktop\\C#\\Tarea 3\\Toniestarc\\Proyectos secretos";
    try
    {
        if (Directory.Exists(path))
        {
            Console.WriteLine("La carpeta ya existe");
        }
        else
        {
            Directory.CreateDirectory(path);
            Console.WriteLine("La carpeta de pkroyectos secretos se ha creado correctamente");
        }
    }
    catch (Exception err)
    {
        Console.WriteLine("Uy yarbis esto no sirve, " + err.Message);
    }
}

//Eliminar un archivo

void EliminarArchivo()
{
    string path = "C:\\Users\\jorge\\OneDrive\\Desktop\\C#\\Tarea 3\\Toniestarc\\Inventos.txt";
    try
    {
        if (File.Exists(path))
        {
            File.Delete(path);
            Console.WriteLine("Archivo eliminado correctamente");
        }
        else
        {
            Console.WriteLine("El archivo no existe o hubo algun problema");
        }
    }
    catch (Exception err)
    {
        Console.WriteLine("No se puedo completar la taresa, " + err.Message);
    }
}

//Lista de archivos 

void ListarArchivos()
{
    string path = "C:\\Users\\jorge\\OneDrive\\Desktop\\C#\\Tarea 3\\Toniestarc";
    try
    {
        if (Directory.Exists(path))
        {
            string[] archivos = Directory.GetFiles(path);
            Console.WriteLine("Los archivos en la carpeta son:");
            foreach (string archivo in archivos)
            {
                Console.WriteLine(archivo);
            }
        }
        else
        {
            Console.WriteLine("El directorio no existe o hubo algun problema");
        }
    }
    catch (Exception err)
    {
        Console.WriteLine("No se puedo completar la taresa, " + err.Message);
    }
}


//Menu principal
string opcion;
do
    {
        Console.WriteLine("Bienvenido al directorio de archivos de Tony Stark");
        Console.WriteLine("Elija una de las siguientes opciones");
        Console.WriteLine("1. Modificacion de Archivos");
        Console.WriteLine("2. Mostrar los inventos");
        Console.WriteLine("3. Agregar inventos");
        Console.WriteLine("4. Salir");
        opcion = Console.ReadLine();

        switch (opcion)
        {
            case "1":

                Console.WriteLine("Elija una de las siguientes opciones");
                Console.WriteLine("1. Crear archivo");
                Console.WriteLine("2. Editar archivo");
                Console.WriteLine("3. Leer archivo");
                Console.WriteLine("4. Leer archivo completo");
                Console.WriteLine("5. Copiar archivo");
                Console.WriteLine("6. Mover archivo");
                Console.WriteLine("7. Crear carpeta");
                Console.WriteLine("8. Eliminar archivo");
                Console.WriteLine("9. Listar archivos");
                string subOpcion = Console.ReadLine();
                switch (subOpcion)
                {
                    case "1":
                        CrearArchivo();
                        break;
                    case "2":
                        EditarTexto();
                        break;
                    case "3":
                        LeerArchivo();
                        break;
                    case "4":
                        LeerArchivoCompleto();
                        break;
                    case "5":
                        CopiarArchivo();
                        break;
                    case "6":
                        MoverArchivo();
                        break;
                    case "7":
                        CrearCarpeta();
                        break;
                    case "8":
                        EliminarArchivo();
                        break;
                    case "9":
                        ListarArchivos();
                        break;
                    default:
                        Console.WriteLine("Esa opcion no existe");
                        break;
                }
                break;
            case "2":
                LeerArchivoCompleto();
                break;
            case "3":
                EditarTexto();
                break;
            case "4":
                Console.WriteLine("Saliendo...");
                break;
            default:
                Console.WriteLine("Esa opcion no existe");
                break;
        }
        Console.WriteLine("Presione una tecla para continuar");
        Console.ReadKey();
    } while (opcion != "4");


