using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Oefening2
{
    internal class Dierklasse
    {
        public int Gewicht { get; set; }

        private string Uitspraak { get; set; }

       

        protected Dierklasse()
        {
            this.Gewicht = 0;
            Uitspraak = "";

        }



        public string Zegt(string uitspraak)
        {
            this.Uitspraak = uitspraak;
            return uitspraak;
        }
    }

    internal class Koe : Dierklasse
    {
        public SoundPlayer KoeGeluid = new SoundPlayer(@"C:\Users\krist\source\repos\Opdracht2\Oefening1\bin\Debug\cow-moo1.wav");
        public Koe(int gewicht)
        {
            base.Gewicht = gewicht;
        }

        public string GeluidMaken()
        {
            KoeGeluid.Play();
            return base.Zegt("boe");
        }

        public override string ToString()
        {
            return "Gewicht: " + Gewicht + "kg Uitspraak: " + GeluidMaken();
        }
    }

    internal class Slang : Dierklasse
    {
        public SoundPlayer SlangGeluid = new SoundPlayer(@"C:\Users\krist\source\repos\Opdracht2\Oefening1\bin\Debug\snake_hissing.wav");
        public Slang(int gewicht)
        {
            base.Gewicht = gewicht;
        }

        public string GeluidMaken()
        {
            SlangGeluid.Play();
            return base.Zegt("ssj");
        }

        public override string ToString()
        {
            return "Gewicht: " + Gewicht + "kg Uitspraak: " + GeluidMaken();
        }
    }

    internal class Varken : Dierklasse
    {
        public SoundPlayer VarkenGeluid = new SoundPlayer(@"C:\Users\krist\source\repos\Opdracht2\Oefening1\bin\Debug\pig-2.wav");
        public Varken(int gewicht)
        {
            base.Gewicht = gewicht;
        }

        public string GeluidMaken()
        {
            VarkenGeluid.Play();
            return base.Zegt("groink");


        }

        public override string ToString()
        {
            return "Gewicht: " + Gewicht + "kg Uitspraak: " + GeluidMaken();
        }
    }
}
