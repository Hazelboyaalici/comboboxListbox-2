using System.Reflection.Emit;

namespace comboboxListbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Ad�n�z: "+textBox1.Text +" "+ "Soyad�n�z: " + textBox2.Text + " " + "Mesle�iniz: " + textBox3.Text + " " + "Ya��n�z: " + textBox4.Text);
        }
    }
}