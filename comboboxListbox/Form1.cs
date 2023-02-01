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
            listBox1.Items.Add("Adýnýz: "+textBox1.Text +" "+ "Soyadýnýz: " + textBox2.Text + " " + "Mesleðiniz: " + textBox3.Text + " " + "Yaþýnýz: " + textBox4.Text);
        }
    }
}