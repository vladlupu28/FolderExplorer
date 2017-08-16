using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    [Serializable]
    public class FisierVideo : IComparable, ICloneable
    {
        
        private String cale;

        public String Cale
        {
            get { return cale; }
            set { cale = value; }
        }

        private String nume;

        public String Nume
        {
            get { return nume; }
            set { nume = value; }
        }

        private String gen;

        public String Gen
        {
            get { return gen; }
            set { gen = value; }
        }

        private float rating;

        public float Rating
        {
            get { return rating; }
            set { rating = value; }
        }
        private float durata;

        public float Durata
        {
            get { return durata; }
            set { durata = value; }
        }
        public FisierVideo()
        {
            cale = "nedefinit";
            nume = "nedefinit";
            gen = "nedefinit";
            rating = 0;
            durata = 0;
        }
        public FisierVideo(String cale, String nume, String gen, float rating, float durata)
        {
            this.cale = cale;
            this.nume = nume;
            this.gen = gen;
            this.rating = rating;
            this.durata = durata;
        }
        public String info()
        {
            String aux = (this.nume + " " + this.gen + " " + this.rating + " " + this.durata + ";");
            return aux;
        }
    
    public int CompareTo(object obj)
        {
            if (obj is FisierVideo)
            {
                FisierVideo tmp = (FisierVideo)obj;

                if (this.rating == tmp.rating)
                {
                    return 0;
                }
                else if (this.rating > tmp.rating)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                throw new Exception("Nu e obiect casetaVideo");
            }
        }

        public object Clone()
        {
            FisierVideo tmp = new FisierVideo(this.Cale,  this.Nume, this.Gen, this.rating, this.Durata );
            return tmp;
        }
        private FisierVideo[] vectorVideo;
        public FisierVideo this[int index]
        {
            get { return vectorVideo[index];  }
            set { vectorVideo[index] = value; }
        }
        public static FisierVideo operator +(FisierVideo[] d, FisierVideo f)
        {
            return d[d.Length] = f;
        }
        public static bool operator < (FisierVideo f, FisierVideo f1)
        {
            return f.Rating < f1.Rating;
        }
        public static bool operator > (FisierVideo f, FisierVideo f1)
        {
            return f.Rating > f1.Rating;
        }
    }
}
