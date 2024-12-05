using System;

namespace Notes.Models
{
    internal class About
    {
   
        public string Title => AppInfo.Name;
        public string Version => AppInfo.VersionString;

   
        public string Nombre => "Esteban Galido";  
        public string MoreInfoUrl => "https://github.com/estebangalindo27"; 
        public string Message => "Mi nombre es Esteban, me gusta mucho descansar y ver peliculas.";
    }

    internal static class AppInfo
    {
        public static string Name => "NotasApp";  
        public static string VersionString => "1.0.0";  
    }
}
