using ejercicio01.entities;
using Newtonsoft.Json;

namespace ejercicio01.other_functions;

public class DataPersistence
{
    private static string carpetaJson = "json";
    private static string archivoJson = Path.Combine(carpetaJson, "notas.json");

    //private static string archivoJson = "notas.json";
    public static void SaveData(List<Estudiante> lstListado)
    {
        if (!Directory.Exists(carpetaJson))
            {
                Directory.CreateDirectory(carpetaJson);
            }
        string json = JsonConvert.SerializeObject(lstListado, Formatting.Indented);
        File.WriteAllText(archivoJson, json);
    }
    public static List<Estudiante> LoadData()
    {
        if (File.Exists(archivoJson))
        {
            string json = File.ReadAllText(archivoJson);
            return JsonConvert.DeserializeObject<List<Estudiante>>(json) ?? new List<Estudiante>();
        }
        else
        {
            return new List<Estudiante>();
        }
    }
}
