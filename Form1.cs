using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06._09._2023_Шахматная_доска
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
            Paint += Form1_Paint1;
        }

        private void Form1_Paint1(object sender, PaintEventArgs e) {
            Graphics g = CreateGraphics();

            int x = 10, y = 30;
            SolidBrush brush_1 = new SolidBrush(Color.Black);
            SolidBrush brush_2 = new SolidBrush(Color.White);
            SolidBrush brush;

            for (int j = 0; j < 6; j++) {
                for (int i = 0; i < 3; i++) {
                    g.FillRectangle(brush_1, x, y, 30, 30);
                    x += 30;
                    g.FillRectangle(brush_2, x, y, 30, 30);
                    x += 30;
                }
                y += 30;
                x = 10;
                brush = brush_1;
                brush_1 = brush_2;
                brush_2 = brush;
            }

            Graphics gr = CreateGraphics();
            SolidBrush br_ellipse = new SolidBrush(Color.Red);
            int n = 14;
            
            for(int i = 0; i < 6; i++) {
                gr.FillEllipse(br_ellipse, n, 34, 20, 20);
                n += 30;
            }
            n = 14;
            for (int i = 0; i < 6; i++) {
                gr.FillEllipse(br_ellipse, n, 184, 20, 20);
                n += 30;
            }

            g.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
