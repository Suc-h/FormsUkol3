using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 form2;
        ListBox listboxik;
        Button tlacitko;
        private void Form1_Load(object sender, EventArgs e)
        {
            listboxik = new ListBox();
            listboxik.Size=new Size(300, 400);
            listboxik.Location = new Point(1, 11);
            this.Controls.Add(listboxik);




            tlacitko = new Button();
            tlacitko.Text = "Zapiš";
            tlacitko.Location = new Point(518, 12);
            tlacitko.Size = new Size(270, 426);
            tlacitko.Click += tlacitko_Click;
            this.Controls.Add(tlacitko);

        }

        private void tlacitko_Click(object sender, EventArgs e)
        {
            form2 = new Form2();

            Button button1 = new Button();
            Button button2 = new Button();
            TextBox textBox = new TextBox();

            button1.DialogResult = DialogResult.OK;
            button2.DialogResult = DialogResult.Cancel;

            button1.Location = new Point(40, 189);
            button1.Size = new Size(75, 23);
            button1.Text = "Ulož";
            button2.Location = new Point(148, 188);
            button2.Size = new Size(75, 23);
            button2.Text = "Zruš";
            textBox.Location = new Point(49, 40);
            textBox.Size = new Size(188, 22);

            form2.Controls.Add(textBox);

            form2.Controls.Add(button1);
            form2.Controls.Add(button2);
            form2.Activate();
            textBox.Focus();
            form2.ActiveControl = textBox;
            form2.AcceptButton = button1;
            //form2.key


            if (form2.ShowDialog() == DialogResult.OK)
            {
                if(listboxik.Items.Count>=11)
                {
                    MessageBox.Show("Plný Listbox!");
                }
                else
                {
                    listboxik.Items.Add(textBox.Text);
                }

            }
        }
    }
    public partial class Form2 : Form
    {
        public Form2()
        {
           //InitializeComponent();
        }

    }
}
