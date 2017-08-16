using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form3 : FormAbstract
    {
        public FisierVideo fv = new FisierVideo();
        public float rating;
        public float time;
        public String nume;
        public Form3()
        {
            InitializeComponent();
        }

        public override void button2_Click(object sender, EventArgs e)
        {
            
            this.DialogResult = DialogResult.Cancel;
            this.Dispose();
        }

        public override void button1_Click(object sender, EventArgs e)
        {
            nume = tbNume.Text;
            rating = float.Parse(tbRating.Text);
            time = float.Parse(tbTime.Text);
           // MessageBox.Show(nume + rating + time);
            this.DialogResult = DialogResult.OK;
            this.Dispose();

        }
        void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            var form = sender as Form3;

            form.FormClosed -= Form3_FormClosed;
            this.DialogResult = DialogResult.Cancel;

            this.Dispose();
        }
    }
}
