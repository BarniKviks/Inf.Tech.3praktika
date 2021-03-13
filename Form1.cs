using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3praktika
{
  public partial class Form1 : Form
  {
    private string textBox2_Text;

    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      //получение данных
      double x = Convert.ToDouble(textBox1.Text);
      double y;
      //вывод на экран
      textBox2.Text = "Результат работы программы:" + Environment.NewLine;
      textBox2.Text += "При X = " + textBox1.Text + Environment.NewLine;
      //вычисление y
      if (x < 0) y = -1;
      else if ((x >= 0) && (x < 5)) y = 2 * x;
      else if (x >= 5) y = x;
      else y = 0;
      textBox2.Text += "y = " + Convert.ToString(y) + Environment.NewLine;
    }
  }
}
