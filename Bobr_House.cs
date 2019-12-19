using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_11
{
    class Bobr_House
    {
        public Bobr_House()
        {
            Bobrs = new List<Bobr>();
            Trash = new List<Trash>();
            Bobro_trash = new Dictionary<Trash, Bobr>();
        }

        List<Bobr> Bobrs;
        List<Trash> Trash;
        public Dictionary<Trash, Bobr> Bobro_trash;

        public void BobrAdd(Bobr bobr)
        {
            Bobrs.Add(bobr);
        }

        public void TrashAdd(Trash obj)
        {
            Trash.Add(obj);
        }

        public void GetTrash(Bobr bobr, Trash obj)
        {
            if (Bobro_trash.ContainsKey(obj))
            {
                Console.WriteLine("This object is not available");
            }
            else
            {
                Bobro_trash.Add(obj, bobr);
            }
        }
    }
}
