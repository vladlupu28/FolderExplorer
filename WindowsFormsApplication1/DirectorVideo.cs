using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    [Serializable]
    public class DirectorVideo: IFilme
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private String nume_parinte;

        public String Nume_parinte
        {
            get { return nume_parinte; }
            set { nume_parinte = value; }
        }
        private List<FisierVideo> fisiere;

        public List<FisierVideo> Fisiere
        {
            get { return fisiere; }
            set { fisiere = value; }
        }
        private String nume;

        public String Nume
        {
            get { return nume; }
            set { nume = value; }
        }
        public DirectorVideo()
        {
            id = -1;
            nume_parinte = null;
            nume = "Director Nou";
            fisiere = new List<FisierVideo>();
        }
        public DirectorVideo(int id, String nume, String numed)
        {
            this.id = id;
            this.nume_parinte = nume;
            this.nume = numed;
            this.fisiere = new List<FisierVideo>();
        }
        public DirectorVideo(int id, String nume )
        {
            this.id = id;
            this.nume_parinte = "nedefinit";
            this.nume = nume;
            this.fisiere = new List<FisierVideo>();
        }
        public void AddFilm(FisierVideo x)
        {
            this.fisiere.Add(x);
        }
        public String info()
        {
            String aux = (""+this.nume+"\n");
            foreach (FisierVideo x in this.fisiere)
            {
                aux = (aux + "\n" + x.info());
            }
            return aux;
        }


        public String AfisareFilme()
        {
            String aux = ("");
            foreach (FisierVideo fis in this.fisiere)
            {
                aux = (aux + " " + fis.Nume);
            }
            return aux;
        }
    }
}
