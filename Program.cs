using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Bobr bobr = new Bobr();
            Bobr bobr2 = new Bobr();
            bobr.Name = "Vasia";
            bobr2.Name = "Vasia";
            Bobr_House bobr_House = new Bobr_House();
            Trash trash = new Trash("Hello World!");
            Trash trash2 = new Trash("Vasia Negodiay");

            bobr_House.BobrAdd(bobr);
            bobr_House.TrashAdd(trash);
            bobr_House.TrashAdd(trash2);

            bobr_House.GetTrash(bobr, trash);
            bobr_House.GetTrash(bobr, trash2);
            bobr_House.GetTrash(bobr2, trash2);

            foreach(var pair in bobr_House.Bobro_trash)
            {
                Console.WriteLine($"Value: {pair.Key.Value},  Owner: {pair.Value.Name}");
            }

            Console.ReadKey();
        }
    }
}
