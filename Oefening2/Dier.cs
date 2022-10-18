using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Oefening2
{

        internal abstract class Dier
        {
            public int Gewicht { get; set; }

            private string Uitspraak { get; set; }

            private string Geluid { get; set; }

            protected Dier()
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

        internal class Koe : Dier
        {
            public SoundPlayer boe = new SoundPlayer(@"C:\Users\llabe\desktop\visual studio\Opdracht2v2\Oefening1\bin\Debug\cow-moo1.wav");
            public Koe(int gewicht)
            {
                base.Gewicht = gewicht;
            }

            public string spreek()
            {

                boe.Play();
                return base.Zegt("boe");
            }

            public override string ToString()
            {
                return "Gewicht: " + Gewicht + "kg Uitspraak: " + spreek();
            }
        }

        internal class Slang : Dier
        {
            public SoundPlayer ssj = new SoundPlayer(@"C:\Users\llabe\desktop\visual studio\Opdracht2v2\Oefening1\bin\Debug\snake_hissing.wav");
            public Slang(int gewicht)
            {
                base.Gewicht = gewicht;
            }

            public string spreek()
            {

                ssj.Play();
                return base.Zegt("ssj");
            }

            public override string ToString()
            {
                return "Gewicht: " + Gewicht + "kg Uitspraak: " + spreek();
            }
        }

        internal class Varken : Dier
        {
            public SoundPlayer groink = new SoundPlayer(@"C:\Users\llabe\desktop\visual studio\Opdracht2v2\Oefening1\bin\Debug\pig-2.wav");
            public Varken(int gewicht)
            {
                base.Gewicht = gewicht;
            }

            public string spreek()
            {

                groink.Play();
                return base.Zegt("groink");


            }

            public override string ToString()
            {
                return "Gewicht: " + Gewicht + "kg Uitspraak: " + spreek();
            }
        }


    }
