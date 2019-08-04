using System;
using System.Collections.Generic;
using System.Text;

namespace MathClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Text = Math.PI.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int mutlakDeger = Math.Abs(-45);
            Text = mutlakDeger.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
         
            double deger = Math.Floor(12.98);
            MessageBox.Show(deger.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
            double deger = Math.Ceiling(12.98);
            MessageBox.Show(deger.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
      
            double deger = Math.Round(13.49);
            MessageBox.Show(deger.ToString());


        }

        private void button6_Click(object sender, EventArgs e)
        {
       
            double deger = Math.Truncate(12.98);
            MessageBox.Show(deger.ToString());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int maxsimumdeger = Math.Max(45, 65);
            MessageBox.Show(maxsimumdeger.ToString());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int minimumdeger = Math.Min(45, 65);
            MessageBox.Show(minimumdeger.ToString());
        }

        private void button9_Click(object sender, EventArgs e)
        {
         
            double kuvvet = Math.Pow(3, 4);
            MessageBox.Show(kuvvet.ToString());
        }

        private void button10_Click(object sender, EventArgs e)
        {
       

            double deger = Math.Sqrt(16);
            MessageBox.Show(deger.ToString());
        }

        private void button11_Click(object sender, EventArgs e)
        {
         

            int sonuc = Math.Sign(-25);
            MessageBox.Show(sonuc.ToString());
        }

        private void button12_Click(object sender, EventArgs e)
        {
           

            int birincideger = Convert.ToInt32(textBox1.Text);
            int ikincideger = Convert.ToInt32(textBox2.Text);
            int ucuncudeger = int.Parse(textBox3.Text);

            int mindeger = Math.Min(Math.Min(birincideger, ikincideger), ucuncudeger);

            this.Text = $"En küçük değer {mindeger}";
        }

        private void Form1_Load(object sender, EventArgs e)
}
