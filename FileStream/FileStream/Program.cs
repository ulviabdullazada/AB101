using FileStream.Models;
using Newtonsoft.Json;
using System.IO;
using System.Text.Json.Serialization;

namespace FileStream
{
    internal class Program
    {
        static string path = @"C:\Users\Ülvi\Desktop\AB101\FileStream\FileStream\Files";
        static void Main(string[] args)
        {
            #region File, Directory
            ////path = Path.Combine(path,"AB101Test","test.txt");
            //if (!Directory.Exists(Path.Combine(path,"AB101Test")))
            //{
            //    Directory.CreateDirectory(Path.Combine(path, "AB101Test"));
            //}
            //File.Move(Path.Combine(path,"Salam.txt"), Path.Combine(path, "AB101Test","test.txt"), true);
            //File.Create(Path.Combine(path, "AB101Test", "test.txt"));
            #endregion
            #region StreamReader, StreamWriter
            //using (StreamWriter sw = new StreamWriter(Path.Combine(path, "AB101Test", "test.txt"),true))
            //{
            //    sw.Write("Senan");
            //}
            //using (StreamReader sr = new StreamReader(Path.Combine(path, "AB101Test", "test.txt")))
            //{
            //    Console.WriteLine(sr);
            //}
            #endregion
            #region Serialization
            //path = Path.Combine(path, "musics.json");
            //List<Music> musicsFromJson = Helper.JsonToObject<List<Music>>(path);
            //foreach (var m in musicsFromJson)
            //{
            //    Console.WriteLine(m.Id);
            //}
            #endregion
            Add(new Music { Name="Sway", ArtistName="Micheal Bubble",TimeWithSecond = 400});
            Add(new Music { Name="Bottle", ArtistName="Jim Croce",TimeWithSecond = 70});
        }
        static void Add(Music music)
        {
            List<Music> musicsFromJson = Helper.JsonToObject<List<Music>>(Path.Combine(path, "musics.json"));
            if (!musicsFromJson.Contains(music))
            {
                musicsFromJson.Add(music);
            }
            Helper.SaveAsJson(musicsFromJson, Path.Combine(path, "musics.json"));
        }
    }
}