using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсач3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int movesNumber4x4 = 0;
        int labelIndex4x4 = 0;

        private void mixButtons4x4()
        {
            List<int> labelList4x4 = new List<int>();

            Random random = new Random();
            foreach (Button btn in this.panel1.Controls)
            {
                while (labelList4x4.Contains(labelIndex4x4))
                    labelIndex4x4 = random.Next(16);

                btn.Text = (labelIndex4x4 == 0) ? "" : labelIndex4x4 + "";
                btn.BackColor = (btn.Text == "") ? Color.White : Color.FromKnownColor(KnownColor.ControlLight);
                labelList4x4.Add(labelIndex4x4);
            }

            movesNumber4x4 = 0;
            label1.Text = $"Кількість кроків: {movesNumber4x4}";
        }

        private void swapLabel4x4(Object sendler, EventArgs e)
        {
            Button btn = (Button)sendler;
            if (btn.Text == "")
                return;

            Button writeBtn = null;
            foreach (Button bt in this.panel1.Controls)
            {
                if (bt.Text == "")
                {
                    writeBtn = bt;
                    break;
                }
            }

            if (btn.TabIndex == (writeBtn.TabIndex - 1) ||
               btn.TabIndex == (writeBtn.TabIndex - 4) ||
               btn.TabIndex == (writeBtn.TabIndex + 1) ||
               btn.TabIndex == (writeBtn.TabIndex + 4))
            {
                writeBtn.BackColor = Color.FromKnownColor(KnownColor.ControlLight);
                btn.BackColor = Color.White;
                writeBtn.Text = btn.Text;
                btn.Text = "";
                movesNumber4x4++;
                label1.Text = $"Кількість кроків: {movesNumber4x4}";
            }

            finish4x4();
        }

        private void finish4x4()
        {
            var buttons = new[] { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11,button12,button13,button14,button15,button16 };

            for (int i = 0; i < buttons.Length; i++)
            {

                if (i != buttons.Length - 1)
                {
                    if (buttons[i].Text == "")
                        return;
                    if (int.Parse(buttons[i].Text) != i + 1)
                        return;
                }
            }
            MessageBox.Show($"Вітаю! Ваша кількість кроків:{movesNumber4x4}");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mixButtons4x4();
            mixButtons3x3();
            mixButtons5x5();
        }
        
        int movesNumber3x3 = 0;
        int labelIndex3x3 = 0;

        private void mixButtons3x3()
        {
            List<int> labelList3x3 = new List<int>();

            Random rand = new Random();
            foreach (System.Windows.Forms.Button btn in this.panel2.Controls)
            {
                while (labelList3x3.Contains(labelIndex3x3))
                    labelIndex3x3 = rand.Next(9);

                btn.Text = (labelIndex3x3 == 0) ? "" : labelIndex3x3 + "";
                btn.BackColor = (btn.Text == "") ? Color.White : Color.FromKnownColor(KnownColor.ControlLight);
                labelList3x3.Add(labelIndex3x3);
            }

            movesNumber3x3 = 0;
            label2.Text = "Кількість кроків: " + movesNumber3x3;
        }

        private void swapLabel3x3(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            if (btn.Text == "")
                return;

            System.Windows.Forms.Button whiteBtn = null;
            foreach (System.Windows.Forms.Button bt in this.panel2.Controls)
            {
                if (bt.Text == "")
                {
                    whiteBtn = bt;
                    break;
                }
            }
            if (btn.TabIndex == (whiteBtn.TabIndex - 1) ||
                btn.TabIndex == (whiteBtn.TabIndex - 3) ||
                btn.TabIndex == (whiteBtn.TabIndex + 1) ||
                btn.TabIndex == (whiteBtn.TabIndex + 3))
            {
                whiteBtn.BackColor = Color.FromKnownColor(KnownColor.ControlLight);
                btn.BackColor = Color.White;
                whiteBtn.Text = btn.Text;
                btn.Text = "";
                movesNumber3x3++;
                label2.Text = "Кількість кроків: " + movesNumber3x3;
            }

            finish3x3();
        }

        private void finish3x3()
        {
            var buttons = new[] { button17, button18, button19, button20, button21, button22, button23, button24, button25};

            for (int i = 0; i < buttons.Length; i++)
            {
                
                if (i != buttons.Length - 1)
                {
                    if (buttons[i].Text == "")
                        return;
                    if (int.Parse(buttons[i].Text) != i + 1)
                        return;
                }
            }
            MessageBox.Show($"Вітаю! Ваша кількість кроків:{movesNumber3x3}");
        }

        int movesNumber5x5 = 0;
        int labelIndex5x5 = 0;

        private void mixButtons5x5()
        {
            List<int> labelList5x5 = new List<int>();

            Random random = new Random();
            foreach (Button btn in this.panel3.Controls)
            {
                while (labelList5x5.Contains(labelIndex5x5))
                    labelIndex5x5 = random.Next(25);
                btn.Text = (labelIndex5x5 == 0) ? "" : labelIndex5x5 + "";
                btn.BackColor = (btn.Text == "") ? Color.White : Color.FromKnownColor(KnownColor.ControlLight);
                labelList5x5.Add(labelIndex5x5);
            }
            movesNumber5x5 = 0;
            label3.Text = $"Кількість кроків: {movesNumber5x5}";

        }
        private void swapLabel5x5(Object sendler, EventArgs e)
        {
            Button btn = (Button)sendler;
            if (btn.Text == "")
                return;

            Button writeBtn = null;
            foreach (Button bt in this.panel3.Controls)
            {
                if (bt.Text == "")
                {
                    writeBtn = bt;
                    break;
                }
            }

            if (btn.TabIndex == (writeBtn.TabIndex - 1)||
               btn.TabIndex == (writeBtn.TabIndex - 5)||
               btn.TabIndex == (writeBtn.TabIndex + 1) ||
               btn.TabIndex == (writeBtn.TabIndex + 5))
            {
                writeBtn.BackColor = Color.FromKnownColor(KnownColor.ControlLight);
                btn.BackColor = Color.White;
                writeBtn.Text = btn.Text;
                btn.Text = "";
                movesNumber5x5++;
                label3.Text = $"Кількість кроків: {movesNumber5x5}";
            }

            finish5x5();
        }

        private void finish5x5()
        {
            var buttons = new[] { button26, button27, button28, button29, button30, button31, button32, button33, button34,button35,button36,button37,button38,button39,button40,button41,button42,button43,button44,button45,button46,button47,button48,button49,button50 };

            for (int i = 0; i < buttons.Length; i++)
            {

                if (i != buttons.Length - 1)
                {
                    if (buttons[i].Text == "")
                        return;
                    if (int.Parse(buttons[i].Text) != i + 1)
                        return;
                }
            }
            MessageBox.Show($"Вітаю! Ваша кількість кроків:{movesNumber5x5}");
        }

        private void rules_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("У кожній клітині, крім правої нижньої, знаходиться фішка з одним з перших 15 натуральних чисел. " +
              "За один хід можна у вільну клітину зсунути фішку з будь-якої сусідньої за горизонталлю або вертикаллю клітини. " +
              "Розмістити фішки так, щоб їх номери збільшувалися при переході від лівого верхнього кута поля зліва направо, зверху вниз..\n" +
              "Можливе переміщення квадратиків: вгору, вниз, вправо або вліво та лище на порожній квадратик");
        }

        private void help_Click_1(object sender, EventArgs e)
        {

            MessageBox.Show("Натисніть на кнопку, яка знаходиться або знизу, або зверху, або з правого, чи лівого боку для перемішення. " +
               "Натискаючи, Ви маєте скласти послідовність. ");
        }

        private void exit_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = false;
            label1.Visible = false;
            panel2.Visible = false;
            label2.Visible = false;
            panel3.Visible = false;
            label3.Visible = false;
            pictureBox1.Visible = true;
            label4.Visible = true;
            button51.Visible = false;
        }

        private void game3_Click_1(object sender, EventArgs e)
        {
            mixButtons3x3();
            panel1.Visible = false;
            label1.Visible = false;
            panel2.Visible = true;
            label2.Visible = true;
            panel3.Visible = false;
            label3.Visible = false;
            pictureBox1.Visible = false;
            label4.Visible = false;
            button51.Visible = true;
        }

        private void game4_Click_1(object sender, EventArgs e)
        {
            mixButtons4x4();
            panel1.Visible = true;
            label1.Visible = true;
            panel2.Visible = false;
            label2.Visible = false;
            panel3.Visible = false;
            label3.Visible = false;
            pictureBox1.Visible = false;
            label4.Visible = false;
            button51.Visible = true;
        }

        private void game5_Click_1(object sender, EventArgs e)
        {
            mixButtons5x5();
            panel1.Visible = false;
            label1.Visible = false;
            panel2.Visible = false;
            label2.Visible = false;
            panel3.Visible = true;
            label3.Visible = true;
            pictureBox1.Visible = false;
            label4.Visible = false;
            button51.Visible = true;
        }

        private void button51_Click(object sender, EventArgs e)
        {
            mixButtons3x3();
            mixButtons4x4();
            mixButtons5x5();
        }
    }  
}
