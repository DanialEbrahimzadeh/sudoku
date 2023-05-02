using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sudoku
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Solve_Click(object sender, EventArgs e)
        {
            table answer = new table();
            if(Enter_data.Checked)
            {
                if (System.Convert.ToInt16(textBox00.Text, 10) > 0 && System.Convert.ToInt16(textBox00.Text, 10) < 10)
                    answer.dan[0, 0].data = System.Convert.ToInt16(textBox00.Text, 10);
                else
                    answer.dan[0, 0].data = 0;
                /////
                if (System.Convert.ToInt16(textBox01.Text, 10) > 0 && System.Convert.ToInt16(textBox01.Text, 10) < 10)
                    answer.dan[0, 1].data = System.Convert.ToInt16(textBox01.Text, 10);
                else
                    answer.dan[0, 1].data = 0;
                /////
                if (System.Convert.ToInt16(textBox02.Text, 10) > 0 && System.Convert.ToInt16(textBox02.Text, 10) < 10)
                    answer.dan[0, 2].data = System.Convert.ToInt16(textBox02.Text, 10);
                else
                    answer.dan[0, 2].data = 0;
                /////
                if (System.Convert.ToInt16(textBox03.Text, 10) > 0 && System.Convert.ToInt16(textBox03.Text, 10) < 10)
                    answer.dan[0, 3].data = System.Convert.ToInt16(textBox03.Text, 10);
                else
                    answer.dan[0, 3].data = 0;
                /////
                if (System.Convert.ToInt16(textBox04.Text, 10) > 0 && System.Convert.ToInt16(textBox04.Text, 10) < 10)
                    answer.dan[0, 4].data = System.Convert.ToInt16(textBox04.Text, 10);
                else
                    answer.dan[0, 4].data = 0;
                /////
                if (System.Convert.ToInt16(textBox05.Text, 10) > 0 && System.Convert.ToInt16(textBox05.Text, 10) < 10)
                    answer.dan[0, 5].data = System.Convert.ToInt16(textBox05.Text, 10);
                else
                    answer.dan[0, 5].data = 0;
                /////
                if (System.Convert.ToInt16(textBox06.Text, 10) > 0 && System.Convert.ToInt16(textBox06.Text, 10) < 10)
                    answer.dan[0, 6].data = System.Convert.ToInt16(textBox06.Text, 10);
                else
                    answer.dan[0, 6].data = 0;
                /////
                if (System.Convert.ToInt16(textBox07.Text, 10) > 0 && System.Convert.ToInt16(textBox07.Text, 10) < 10)
                    answer.dan[0, 7].data = System.Convert.ToInt16(textBox07.Text, 10);
                else
                    answer.dan[0, 7].data = 0;
                /////
                if (System.Convert.ToInt16(textBox08.Text, 10) > 0 && System.Convert.ToInt16(textBox08.Text, 10) < 10)
                    answer.dan[0, 8].data = System.Convert.ToInt16(textBox08.Text, 10);
                else
                    answer.dan[0, 8].data = 0;
                /////
                if (System.Convert.ToInt16(textBox10.Text, 10) > 0 && System.Convert.ToInt16(textBox10.Text, 10) < 10)
                    answer.dan[1, 0].data = System.Convert.ToInt16(textBox10.Text, 10);
                else
                    answer.dan[1, 0].data = 0;
                /////
                if (System.Convert.ToInt16(textBox11.Text, 10) > 0 && System.Convert.ToInt16(textBox11.Text, 10) < 10)
                    answer.dan[1, 1].data = System.Convert.ToInt16(textBox11.Text, 10);
                else
                    answer.dan[1, 1].data = 0;
                /////
                if (System.Convert.ToInt16(textBox12.Text, 10) > 0 && System.Convert.ToInt16(textBox12.Text, 10) < 10)
                    answer.dan[1, 2].data = System.Convert.ToInt16(textBox12.Text, 10);
                else
                    answer.dan[1, 2].data = 0;
                /////
                if (System.Convert.ToInt16(textBox13.Text, 10) > 0 && System.Convert.ToInt16(textBox13.Text, 10) < 10)
                    answer.dan[1, 3].data = System.Convert.ToInt16(textBox13.Text, 10);
                else
                    answer.dan[1, 3].data = 0;
                /////
                if (System.Convert.ToInt16(textBox14.Text, 10) > 0 && System.Convert.ToInt16(textBox14.Text, 10) < 10)
                    answer.dan[1, 4].data = System.Convert.ToInt16(textBox14.Text, 10);
                else
                    answer.dan[1, 4].data = 0;
                /////
                if (System.Convert.ToInt16(textBox15.Text, 10) > 0 && System.Convert.ToInt16(textBox15.Text, 10) < 10)
                    answer.dan[1, 5].data = System.Convert.ToInt16(textBox15.Text, 10);
                else
                    answer.dan[1, 5].data = 0;
                /////
                if (System.Convert.ToInt16(textBox16.Text, 10) > 0 && System.Convert.ToInt16(textBox16.Text, 10) < 10)
                    answer.dan[1, 6].data = System.Convert.ToInt16(textBox16.Text, 10);
                else
                    answer.dan[1, 6].data = 0;
                /////
                if (System.Convert.ToInt16(textBox17.Text, 10) > 0 && System.Convert.ToInt16(textBox17.Text, 10) < 10)
                    answer.dan[1, 7].data = System.Convert.ToInt16(textBox17.Text, 10);
                else
                    answer.dan[1, 7].data = 0;
                /////
                if (System.Convert.ToInt16(textBox18.Text, 10) > 0 && System.Convert.ToInt16(textBox18.Text, 10) < 10)
                    answer.dan[1, 8].data = System.Convert.ToInt16(textBox18.Text, 10);
                else
                    answer.dan[1, 8].data = 0;
                /////
                if (System.Convert.ToInt16(textBox20.Text, 10) > 0 && System.Convert.ToInt16(textBox20.Text, 10) < 10)
                    answer.dan[2, 0].data = System.Convert.ToInt16(textBox20.Text, 10);
                else
                    answer.dan[2, 0].data = 0;
                /////
                if (System.Convert.ToInt16(textBox21.Text, 10) > 0 && System.Convert.ToInt16(textBox21.Text, 10) < 10)
                    answer.dan[2, 1].data = System.Convert.ToInt16(textBox21.Text, 10);
                else
                    answer.dan[2, 1].data = 0;
                /////
                if (System.Convert.ToInt16(textBox22.Text, 10) > 0 && System.Convert.ToInt16(textBox22.Text, 10) < 10)
                    answer.dan[2, 2].data = System.Convert.ToInt16(textBox22.Text, 10);
                else
                    answer.dan[2, 2].data = 0;
                /////
                if (System.Convert.ToInt16(textBox23.Text, 10) > 0 && System.Convert.ToInt16(textBox23.Text, 10) < 10)
                    answer.dan[2, 3].data = System.Convert.ToInt16(textBox23.Text, 10);
                else
                    answer.dan[2, 3].data = 0;
                /////
                if (System.Convert.ToInt16(textBox24.Text, 10) > 0 && System.Convert.ToInt16(textBox24.Text, 10) < 10)
                    answer.dan[2, 4].data = System.Convert.ToInt16(textBox24.Text, 10);
                else
                    answer.dan[2, 4].data = 0;
                /////
                if (System.Convert.ToInt16(textBox25.Text, 10) > 0 && System.Convert.ToInt16(textBox25.Text, 10) < 10)
                    answer.dan[2, 5].data = System.Convert.ToInt16(textBox25.Text, 10);
                else
                    answer.dan[2, 5].data = 0;
                /////
                if (System.Convert.ToInt16(textBox26.Text, 10) > 0 && System.Convert.ToInt16(textBox26.Text, 10) < 10)
                    answer.dan[2, 6].data = System.Convert.ToInt16(textBox26.Text, 10);
                else
                    answer.dan[2, 6].data = 0;
                /////
                if (System.Convert.ToInt16(textBox27.Text, 10) > 0 && System.Convert.ToInt16(textBox27.Text, 10) < 10)
                    answer.dan[2, 7].data = System.Convert.ToInt16(textBox27.Text, 10);
                else
                    answer.dan[2, 7].data = 0;
                /////
                if (System.Convert.ToInt16(textBox28.Text, 10) > 0 && System.Convert.ToInt16(textBox28.Text, 10) < 10)
                    answer.dan[2, 8].data = System.Convert.ToInt16(textBox28.Text, 10);
                else
                    answer.dan[2, 8].data = 0;
                /////
                if (System.Convert.ToInt16(textBox30.Text, 10) > 0 && System.Convert.ToInt16(textBox30.Text, 10) < 10)
                    answer.dan[3, 0].data = System.Convert.ToInt16(textBox30.Text, 10);
                else
                    answer.dan[3, 0].data = 0;
                /////
                if (System.Convert.ToInt16(textBox31.Text, 10) > 0 && System.Convert.ToInt16(textBox31.Text, 10) < 10)
                    answer.dan[3, 1].data = System.Convert.ToInt16(textBox31.Text, 10);
                else
                    answer.dan[3, 1].data = 0;
                /////
                if (System.Convert.ToInt16(textBox32.Text, 10) > 0 && System.Convert.ToInt16(textBox32.Text, 10) < 10)
                    answer.dan[3, 2].data = System.Convert.ToInt16(textBox32.Text, 10);
                else
                    answer.dan[3, 2].data = 0;
                /////
                if (System.Convert.ToInt16(textBox33.Text, 10) > 0 && System.Convert.ToInt16(textBox33.Text, 10) < 10)
                    answer.dan[3, 3].data = System.Convert.ToInt16(textBox33.Text, 10);
                else
                    answer.dan[3, 3].data = 0;
                /////
                if (System.Convert.ToInt16(textBox34.Text, 10) > 0 && System.Convert.ToInt16(textBox34.Text, 10) < 10)
                    answer.dan[3, 4].data = System.Convert.ToInt16(textBox34.Text, 10);
                else
                    answer.dan[3, 4].data = 0;
                /////
                if (System.Convert.ToInt16(textBox35.Text, 10) > 0 && System.Convert.ToInt16(textBox35.Text, 10) < 10)
                    answer.dan[3, 5].data = System.Convert.ToInt16(textBox35.Text, 10);
                else
                    answer.dan[3, 5].data = 0;
                /////
                if (System.Convert.ToInt16(textBox36.Text, 10) > 0 && System.Convert.ToInt16(textBox36.Text, 10) < 10)
                    answer.dan[3, 6].data = System.Convert.ToInt16(textBox36.Text, 10);
                else
                    answer.dan[3, 6].data = 0;
                /////
                if (System.Convert.ToInt16(textBox37.Text, 10) > 0 && System.Convert.ToInt16(textBox37.Text, 10) < 10)
                    answer.dan[3, 7].data = System.Convert.ToInt16(textBox37.Text, 10);
                else
                    answer.dan[3, 7].data = 0;
                /////
                if (System.Convert.ToInt16(textBox38.Text, 10) > 0 && System.Convert.ToInt16(textBox38.Text, 10) < 10)
                    answer.dan[3, 8].data = System.Convert.ToInt16(textBox38.Text, 10);
                else
                    answer.dan[3, 8].data = 0;
                /////
                if (System.Convert.ToInt16(textBox40.Text, 10) > 0 && System.Convert.ToInt16(textBox40.Text, 10) < 10)
                    answer.dan[4, 0].data = System.Convert.ToInt16(textBox40.Text, 10);
                else
                    answer.dan[4, 0].data = 0;
                /////
                if (System.Convert.ToInt16(textBox41.Text, 10) > 0 && System.Convert.ToInt16(textBox41.Text, 10) < 10)
                    answer.dan[4, 1].data = System.Convert.ToInt16(textBox41.Text, 10);
                else
                    answer.dan[4, 1].data = 0;
                /////
                if (System.Convert.ToInt16(textBox42.Text, 10) > 0 && System.Convert.ToInt16(textBox42.Text, 10) < 10)
                    answer.dan[4, 2].data = System.Convert.ToInt16(textBox42.Text, 10);
                else
                    answer.dan[4, 2].data = 0;
                /////
                if (System.Convert.ToInt16(textBox43.Text, 10) > 0 && System.Convert.ToInt16(textBox43.Text, 10) < 10)
                    answer.dan[4, 3].data = System.Convert.ToInt16(textBox43.Text, 10);
                else
                    answer.dan[4, 3].data = 0;
                /////
                if (System.Convert.ToInt16(textBox44.Text, 10) > 0 && System.Convert.ToInt16(textBox44.Text, 10) < 10)
                    answer.dan[4, 4].data = System.Convert.ToInt16(textBox44.Text, 10);
                else
                    answer.dan[4, 4].data = 0;
                /////
                if (System.Convert.ToInt16(textBox45.Text, 10) > 0 && System.Convert.ToInt16(textBox45.Text, 10) < 10)
                    answer.dan[4, 5].data = System.Convert.ToInt16(textBox45.Text, 10);
                else
                    answer.dan[4, 5].data = 0;
                /////
                if (System.Convert.ToInt16(textBox46.Text, 10) > 0 && System.Convert.ToInt16(textBox46.Text, 10) < 10)
                    answer.dan[4, 6].data = System.Convert.ToInt16(textBox46.Text, 10);
                else
                    answer.dan[4, 6].data = 0;
                /////
                if (System.Convert.ToInt16(textBox47.Text, 10) > 0 && System.Convert.ToInt16(textBox47.Text, 10) < 10)
                    answer.dan[4, 7].data = System.Convert.ToInt16(textBox47.Text, 10);
                else
                    answer.dan[4, 7].data = 0;
                /////
                if (System.Convert.ToInt16(textBox48.Text, 10) > 0 && System.Convert.ToInt16(textBox48.Text, 10) < 10)
                    answer.dan[4, 8].data = System.Convert.ToInt16(textBox48.Text, 10);
                else
                    answer.dan[4, 8].data = 0;
                /////
                if (System.Convert.ToInt16(textBox50.Text, 10) > 0 && System.Convert.ToInt16(textBox50.Text, 10) < 10)
                    answer.dan[5, 0].data = System.Convert.ToInt16(textBox50.Text, 10);
                else
                    answer.dan[5, 0].data = 0;
                /////
                if (System.Convert.ToInt16(textBox51.Text, 10) > 0 && System.Convert.ToInt16(textBox51.Text, 10) < 10)
                    answer.dan[5, 1].data = System.Convert.ToInt16(textBox51.Text, 10);
                else
                    answer.dan[5, 1].data = 0;
                /////
                if (System.Convert.ToInt16(textBox52.Text, 10) > 0 && System.Convert.ToInt16(textBox52.Text, 10) < 10)
                    answer.dan[5, 2].data = System.Convert.ToInt16(textBox52.Text, 10);
                else
                    answer.dan[5, 2].data = 0;
                /////
                if (System.Convert.ToInt16(textBox53.Text, 10) > 0 && System.Convert.ToInt16(textBox53.Text, 10) < 10)
                    answer.dan[5, 3].data = System.Convert.ToInt16(textBox53.Text, 10);
                else
                    answer.dan[5, 3].data = 0;
                /////
                if (System.Convert.ToInt16(textBox54.Text, 10) > 0 && System.Convert.ToInt16(textBox54.Text, 10) < 10)
                    answer.dan[5, 4].data = System.Convert.ToInt16(textBox54.Text, 10);
                else
                    answer.dan[5, 4].data = 0;
                /////
                if (System.Convert.ToInt16(textBox55.Text, 10) > 0 && System.Convert.ToInt16(textBox55.Text, 10) < 10)
                    answer.dan[5, 5].data = System.Convert.ToInt16(textBox55.Text, 10);
                else
                    answer.dan[5, 5].data = 0;
                /////
                if (System.Convert.ToInt16(textBox56.Text, 10) > 0 && System.Convert.ToInt16(textBox56.Text, 10) < 10)
                    answer.dan[5, 6].data = System.Convert.ToInt16(textBox56.Text, 10);
                else
                    answer.dan[5, 6].data = 0;
                /////
                if (System.Convert.ToInt16(textBox57.Text, 10) > 0 && System.Convert.ToInt16(textBox57.Text, 10) < 10)
                    answer.dan[5, 7].data = System.Convert.ToInt16(textBox57.Text, 10);
                else
                    answer.dan[5, 7].data = 0;
                /////
                if (System.Convert.ToInt16(textBox58.Text, 10) > 0 && System.Convert.ToInt16(textBox58.Text, 10) < 10)
                    answer.dan[5, 8].data = System.Convert.ToInt16(textBox58.Text, 10);
                else
                    answer.dan[5, 8].data = 0;
                /////
                if (System.Convert.ToInt16(textBox60.Text, 10) > 0 && System.Convert.ToInt16(textBox60.Text, 10) < 10)
                    answer.dan[6, 0].data = System.Convert.ToInt16(textBox60.Text, 10);
                else
                    answer.dan[6, 0].data = 0;
                /////
                if (System.Convert.ToInt16(textBox61.Text, 10) > 0 && System.Convert.ToInt16(textBox61.Text, 10) < 10)
                    answer.dan[6, 1].data = System.Convert.ToInt16(textBox61.Text, 10);
                else
                    answer.dan[6, 1].data = 0;
                /////
                if (System.Convert.ToInt16(textBox62.Text, 10) > 0 && System.Convert.ToInt16(textBox62.Text, 10) < 10)
                    answer.dan[6, 2].data = System.Convert.ToInt16(textBox62.Text, 10);
                else
                    answer.dan[6, 2].data = 0;
                /////
                if (System.Convert.ToInt16(textBox63.Text, 10) > 0 && System.Convert.ToInt16(textBox63.Text, 10) < 10)
                    answer.dan[6, 3].data = System.Convert.ToInt16(textBox63.Text, 10);
                else
                    answer.dan[6, 3].data = 0;
                /////
                if (System.Convert.ToInt16(textBox64.Text, 10) > 0 && System.Convert.ToInt16(textBox64.Text, 10) < 10)
                    answer.dan[6, 4].data = System.Convert.ToInt16(textBox64.Text, 10);
                else
                    answer.dan[6, 4].data = 0;
                /////
                if (System.Convert.ToInt16(textBox65.Text, 10) > 0 && System.Convert.ToInt16(textBox65.Text, 10) < 10)
                    answer.dan[6, 5].data = System.Convert.ToInt16(textBox65.Text, 10);
                else
                    answer.dan[6, 5].data = 0;
                /////
                if (System.Convert.ToInt16(textBox66.Text, 10) > 0 && System.Convert.ToInt16(textBox66.Text, 10) < 10)
                    answer.dan[6, 6].data = System.Convert.ToInt16(textBox66.Text, 10);
                else
                    answer.dan[6, 6].data = 0;
                /////
                if (System.Convert.ToInt16(textBox67.Text, 10) > 0 && System.Convert.ToInt16(textBox67.Text, 10) < 10)
                    answer.dan[6, 7].data = System.Convert.ToInt16(textBox67.Text, 10);
                else
                    answer.dan[6, 7].data = 0;
                /////
                if (System.Convert.ToInt16(textBox68.Text, 10) > 0 && System.Convert.ToInt16(textBox68.Text, 10) < 10)
                    answer.dan[6, 8].data = System.Convert.ToInt16(textBox68.Text, 10);
                else
                    answer.dan[6, 8].data = 0;
                /////
                if (System.Convert.ToInt16(textBox70.Text, 10) > 0 && System.Convert.ToInt16(textBox70.Text, 10) < 10)
                    answer.dan[7, 0].data = System.Convert.ToInt16(textBox70.Text, 10);
                else
                    answer.dan[7, 0].data = 0;
                /////
                if (System.Convert.ToInt16(textBox71.Text, 10) > 0 && System.Convert.ToInt16(textBox71.Text, 10) < 10)
                    answer.dan[7, 1].data = System.Convert.ToInt16(textBox71.Text, 10);
                else
                    answer.dan[7, 1].data = 0;
                /////
                if (System.Convert.ToInt16(textBox72.Text, 10) > 0 && System.Convert.ToInt16(textBox72.Text, 10) < 10)
                    answer.dan[7, 2].data = System.Convert.ToInt16(textBox72.Text, 10);
                else
                    answer.dan[7, 2].data = 0;
                /////
                if (System.Convert.ToInt16(textBox73.Text, 10) > 0 && System.Convert.ToInt16(textBox73.Text, 10) < 10)
                    answer.dan[7, 3].data = System.Convert.ToInt16(textBox73.Text, 10);
                else
                    answer.dan[7, 3].data = 0;
                /////
                if (System.Convert.ToInt16(textBox74.Text, 10) > 0 && System.Convert.ToInt16(textBox74.Text, 10) < 10)
                    answer.dan[7, 4].data = System.Convert.ToInt16(textBox74.Text, 10);
                else
                    answer.dan[7, 4].data = 0;
                /////
                if (System.Convert.ToInt16(textBox75.Text, 10) > 0 && System.Convert.ToInt16(textBox75.Text, 10) < 10)
                    answer.dan[7, 5].data = System.Convert.ToInt16(textBox75.Text, 10);
                else
                    answer.dan[7, 5].data = 0;
                /////
                if (System.Convert.ToInt16(textBox76.Text, 10) > 0 && System.Convert.ToInt16(textBox76.Text, 10) < 10)
                    answer.dan[7, 6].data = System.Convert.ToInt16(textBox76.Text, 10);
                else
                    answer.dan[7, 6].data = 0;
                /////
                if (System.Convert.ToInt16(textBox77.Text, 10) > 0 && System.Convert.ToInt16(textBox77.Text, 10) < 10)
                    answer.dan[7, 7].data = System.Convert.ToInt16(textBox77.Text, 10);
                else
                    answer.dan[7, 7].data = 0;
                /////
                if (System.Convert.ToInt16(textBox78.Text, 10) > 0 && System.Convert.ToInt16(textBox78.Text, 10) < 10)
                    answer.dan[7, 8].data = System.Convert.ToInt16(textBox78.Text, 10);
                else
                    answer.dan[7, 8].data = 0;
                /////
                if (System.Convert.ToInt16(textBox80.Text, 10) > 0 && System.Convert.ToInt16(textBox80.Text, 10) < 10)
                    answer.dan[8, 0].data = System.Convert.ToInt16(textBox80.Text, 10);
                else
                    answer.dan[8, 0].data = 0;
                /////
                if (System.Convert.ToInt16(textBox81.Text, 10) > 0 && System.Convert.ToInt16(textBox81.Text, 10) < 10)
                    answer.dan[8, 1].data = System.Convert.ToInt16(textBox81.Text, 10);
                else
                    answer.dan[8, 1].data = 0;
                /////
                if (System.Convert.ToInt16(textBox82.Text, 10) > 0 && System.Convert.ToInt16(textBox82.Text, 10) < 10)
                    answer.dan[8, 2].data = System.Convert.ToInt16(textBox82.Text, 10);
                else
                    answer.dan[8, 2].data = 0;
                /////
                if (System.Convert.ToInt16(textBox83.Text, 10) > 0 && System.Convert.ToInt16(textBox83.Text, 10) < 10)
                    answer.dan[8, 3].data = System.Convert.ToInt16(textBox83.Text, 10);
                else
                    answer.dan[8, 3].data = 0;
                /////
                if (System.Convert.ToInt16(textBox84.Text, 10) > 0 && System.Convert.ToInt16(textBox84.Text, 10) < 10)
                    answer.dan[8, 4].data = System.Convert.ToInt16(textBox84.Text, 10);
                else
                    answer.dan[8, 4].data = 0;
                /////
                if (System.Convert.ToInt16(textBox85.Text, 10) > 0 && System.Convert.ToInt16(textBox85.Text, 10) < 10)
                    answer.dan[8, 5].data = System.Convert.ToInt16(textBox85.Text, 10);
                else
                    answer.dan[8, 5].data = 0;
                /////
                if (System.Convert.ToInt16(textBox86.Text, 10) > 0 && System.Convert.ToInt16(textBox86.Text, 10) < 10)
                    answer.dan[8, 6].data = System.Convert.ToInt16(textBox86.Text, 10);
                else
                    answer.dan[8, 6].data = 0;
                /////
                if (System.Convert.ToInt16(textBox87.Text, 10) > 0 && System.Convert.ToInt16(textBox87.Text, 10) < 10)
                    answer.dan[8, 7].data = System.Convert.ToInt16(textBox87.Text, 10);
                else
                    answer.dan[8, 7].data = 0;
                /////
                if (System.Convert.ToInt16(textBox88.Text, 10) > 0 && System.Convert.ToInt16(textBox88.Text, 10) < 10)
                    answer.dan[8, 8].data = System.Convert.ToInt16(textBox88.Text, 10);
                else
                    answer.dan[8, 8].data = 0;
                /////
                answer = answer.solve();
                if (System.Convert.ToInt16(textBox00.Text, 10) < 1 && System.Convert.ToInt16(textBox00.Text, 10) > 9)
                {
                    textBox00.Text = answer.dan[0, 0].data.ToString();
                    textBox00.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox01.Text, 10) < 1 && System.Convert.ToInt16(textBox01.Text, 10) > 9)
                {
                    textBox01.Text = answer.dan[0, 1].data.ToString();
                    textBox01.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox02.Text, 10) < 1 && System.Convert.ToInt16(textBox02.Text, 10) > 9)
                {
                    textBox02.Text = answer.dan[0, 2].data.ToString();
                    textBox02.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox03.Text, 10) < 1 && System.Convert.ToInt16(textBox03.Text, 10) > 9)
                {
                    textBox03.Text = answer.dan[0, 3].data.ToString();
                    textBox03.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox04.Text, 10) < 1 && System.Convert.ToInt16(textBox04.Text, 10) > 9)
                {
                    textBox04.Text = answer.dan[0, 4].data.ToString();
                    textBox04.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox05.Text, 10) < 1 && System.Convert.ToInt16(textBox05.Text, 10) > 9)
                {
                    textBox05.Text = answer.dan[0, 5].data.ToString();
                    textBox05.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox06.Text, 10) < 1 && System.Convert.ToInt16(textBox06.Text, 10) > 9)
                {
                    textBox06.Text = answer.dan[0, 6].data.ToString();
                    textBox06.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox07.Text, 10) < 1 && System.Convert.ToInt16(textBox07.Text, 10) > 9)
                {
                    textBox07.Text = answer.dan[0, 7].data.ToString();
                    textBox07.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox08.Text, 10) < 1 && System.Convert.ToInt16(textBox08.Text, 10) > 9)
                {
                    textBox08.Text = answer.dan[0, 8].data.ToString();
                    textBox08.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox10.Text, 10) < 1 && System.Convert.ToInt16(textBox10.Text, 10) > 9)
                {
                    textBox10.Text = answer.dan[1, 0].data.ToString();
                    textBox10.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox11.Text, 10) < 1 && System.Convert.ToInt16(textBox11.Text, 10) > 9)
                {
                    textBox11.Text = answer.dan[1, 1].data.ToString();
                    textBox11.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox12.Text, 10) < 1 && System.Convert.ToInt16(textBox12.Text, 10) > 9)
                {
                    textBox12.Text = answer.dan[1, 2].data.ToString();
                    textBox12.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox13.Text, 10) < 1 && System.Convert.ToInt16(textBox13.Text, 10) > 9)
                {
                    textBox13.Text = answer.dan[1, 3].data.ToString();
                    textBox13.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox14.Text, 10) < 1 && System.Convert.ToInt16(textBox14.Text, 10) > 9)
                {
                    textBox14.Text = answer.dan[1, 4].data.ToString();
                    textBox14.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox15.Text, 10) < 1 && System.Convert.ToInt16(textBox15.Text, 10) > 9)
                {
                    textBox15.Text = answer.dan[1, 5].data.ToString();
                    textBox15.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox16.Text, 10) < 1 && System.Convert.ToInt16(textBox16.Text, 10) > 9)
                {
                    textBox16.Text = answer.dan[1, 6].data.ToString();
                    textBox16.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox17.Text, 10) < 1 && System.Convert.ToInt16(textBox17.Text, 10) > 9)
                {
                    textBox17.Text = answer.dan[1, 7].data.ToString();
                    textBox17.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox18.Text, 10) < 1 && System.Convert.ToInt16(textBox18.Text, 10) > 9)
                {
                    textBox18.Text = answer.dan[1, 8].data.ToString();
                    textBox18.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox20.Text, 10) < 1 && System.Convert.ToInt16(textBox20.Text, 10) > 9)
                {
                    textBox20.Text = answer.dan[2, 0].data.ToString();
                    textBox20.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox21.Text, 10) < 1 && System.Convert.ToInt16(textBox21.Text, 10) > 9)
                {
                    textBox21.Text = answer.dan[2, 1].data.ToString();
                    textBox21.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox22.Text, 10) < 1 && System.Convert.ToInt16(textBox22.Text, 10) > 9)
                {
                    textBox22.Text = answer.dan[2, 2].data.ToString();
                    textBox22.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox23.Text, 10) < 1 && System.Convert.ToInt16(textBox23.Text, 10) > 9)
                {
                    textBox23.Text = answer.dan[2, 3].data.ToString();
                    textBox23.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox24.Text, 10) < 1 && System.Convert.ToInt16(textBox24.Text, 10) > 9)
                {
                    textBox24.Text = answer.dan[2, 4].data.ToString();
                    textBox24.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox25.Text, 10) < 1 && System.Convert.ToInt16(textBox25.Text, 10) > 9)
                {
                    textBox25.Text = answer.dan[2, 5].data.ToString();
                    textBox25.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox26.Text, 10) < 1 && System.Convert.ToInt16(textBox26.Text, 10) > 9)
                {
                    textBox26.Text = answer.dan[2, 6].data.ToString();
                    textBox26.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox27.Text, 10) < 1 && System.Convert.ToInt16(textBox27.Text, 10) > 9)
                {
                    textBox27.Text = answer.dan[2, 7].data.ToString();
                    textBox27.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox28.Text, 10) < 1 && System.Convert.ToInt16(textBox28.Text, 10) > 9)
                {
                    textBox28.Text = answer.dan[2, 8].data.ToString();
                    textBox28.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox30.Text, 10) < 1 && System.Convert.ToInt16(textBox30.Text, 10) > 9)
                {
                    textBox30.Text = answer.dan[3, 0].data.ToString();
                    textBox30.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox31.Text, 10) < 1 && System.Convert.ToInt16(textBox31.Text, 10) > 9)
                {
                    textBox31.Text = answer.dan[3, 1].data.ToString();
                    textBox31.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox32.Text, 10) < 1 && System.Convert.ToInt16(textBox32.Text, 10) > 9)
                {
                    textBox32.Text = answer.dan[3, 2].data.ToString();
                    textBox32.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox33.Text, 10) < 1 && System.Convert.ToInt16(textBox33.Text, 10) > 9)
                {
                    textBox33.Text = answer.dan[3, 3].data.ToString();
                    textBox33.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox34.Text, 10) < 1 && System.Convert.ToInt16(textBox34.Text, 10) > 9)
                {
                    textBox34.Text = answer.dan[3, 4].data.ToString();
                    textBox34.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox35.Text, 10) < 1 && System.Convert.ToInt16(textBox35.Text, 10) > 9)
                {
                    textBox35.Text = answer.dan[3, 5].data.ToString();
                    textBox35.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox36.Text, 10) < 1 && System.Convert.ToInt16(textBox36.Text, 10) > 9)
                {
                    textBox36.Text = answer.dan[3, 6].data.ToString();
                    textBox36.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox37.Text, 10) < 1 && System.Convert.ToInt16(textBox37.Text, 10) > 9)
                {
                    textBox37.Text = answer.dan[3, 7].data.ToString();
                    textBox37.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox38.Text, 10) < 1 && System.Convert.ToInt16(textBox38.Text, 10) > 9)
                {
                    textBox38.Text = answer.dan[3, 8].data.ToString();
                    textBox38.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox40.Text, 10) < 1 && System.Convert.ToInt16(textBox40.Text, 10) > 9)
                {
                    textBox40.Text = answer.dan[4, 0].data.ToString();
                    textBox40.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox41.Text, 10) < 1 && System.Convert.ToInt16(textBox41.Text, 10) > 9)
                {
                    textBox41.Text = answer.dan[4, 1].data.ToString();
                    textBox41.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox42.Text, 10) < 1 && System.Convert.ToInt16(textBox42.Text, 10) > 9)
                {
                    textBox42.Text = answer.dan[4, 2].data.ToString();
                    textBox42.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox43.Text, 10) < 1 && System.Convert.ToInt16(textBox43.Text, 10) > 9)
                {
                    textBox43.Text = answer.dan[4, 3].data.ToString();
                    textBox43.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox44.Text, 10) < 1 && System.Convert.ToInt16(textBox44.Text, 10) > 9)
                {
                    textBox44.Text = answer.dan[4, 4].data.ToString();
                    textBox44.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox45.Text, 10) < 1 && System.Convert.ToInt16(textBox45.Text, 10) > 9)
                {
                    textBox45.Text = answer.dan[4, 5].data.ToString();
                    textBox45.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox46.Text, 10) < 1 && System.Convert.ToInt16(textBox46.Text, 10) > 9)
                {
                    textBox46.Text = answer.dan[4, 6].data.ToString();
                    textBox46.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox47.Text, 10) < 1 && System.Convert.ToInt16(textBox47.Text, 10) > 9)
                {
                    textBox47.Text = answer.dan[4, 7].data.ToString();
                    textBox47.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox48.Text, 10) < 1 && System.Convert.ToInt16(textBox48.Text, 10) > 9)
                {
                    textBox48.Text = answer.dan[4, 8].data.ToString();
                    textBox48.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox50.Text, 10) < 1 && System.Convert.ToInt16(textBox50.Text, 10) > 9)
                {
                    textBox50.Text = answer.dan[5, 0].data.ToString();
                    textBox50.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox51.Text, 10) < 1 && System.Convert.ToInt16(textBox51.Text, 10) > 9)
                {
                    textBox51.Text = answer.dan[5, 1].data.ToString();
                    textBox51.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox52.Text, 10) < 1 && System.Convert.ToInt16(textBox52.Text, 10) > 9)
                {
                    textBox52.Text = answer.dan[5, 2].data.ToString();
                    textBox52.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox53.Text, 10) < 1 && System.Convert.ToInt16(textBox53.Text, 10) > 9)
                {
                    textBox53.Text = answer.dan[5, 3].data.ToString();
                    textBox53.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox54.Text, 10) < 1 && System.Convert.ToInt16(textBox54.Text, 10) > 9)
                {
                    textBox54.Text = answer.dan[5, 4].data.ToString();
                    textBox54.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox55.Text, 10) < 1 && System.Convert.ToInt16(textBox55.Text, 10) > 9)
                {
                    textBox55.Text = answer.dan[5, 5].data.ToString();
                    textBox55.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox56.Text, 10) < 1 && System.Convert.ToInt16(textBox56.Text, 10) > 9)
                {
                    textBox56.Text = answer.dan[5, 6].data.ToString();
                    textBox56.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox57.Text, 10) < 1 && System.Convert.ToInt16(textBox57.Text, 10) > 9)
                {
                    textBox57.Text = answer.dan[5, 7].data.ToString();
                    textBox57.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox58.Text, 10) < 1 && System.Convert.ToInt16(textBox58.Text, 10) > 9)
                {
                    textBox58.Text = answer.dan[5, 8].data.ToString();
                    textBox58.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox60.Text, 10) < 1 && System.Convert.ToInt16(textBox60.Text, 10) > 9)
                {
                    textBox60.Text = answer.dan[6, 0].data.ToString();
                    textBox60.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox61.Text, 10) < 1 && System.Convert.ToInt16(textBox61.Text, 10) > 9)
                {
                    textBox61.Text = answer.dan[6, 1].data.ToString();
                    textBox61.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox62.Text, 10) < 1 && System.Convert.ToInt16(textBox62.Text, 10) > 9)
                {
                    textBox62.Text = answer.dan[6, 2].data.ToString();
                    textBox62.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox63.Text, 10) < 1 && System.Convert.ToInt16(textBox63.Text, 10) > 9)
                {
                    textBox63.Text = answer.dan[6, 3].data.ToString();
                    textBox63.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox64.Text, 10) < 1 && System.Convert.ToInt16(textBox64.Text, 10) > 9)
                {
                    textBox64.Text = answer.dan[6, 4].data.ToString();
                    textBox64.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox65.Text, 10) < 1 && System.Convert.ToInt16(textBox65.Text, 10) > 9)
                {
                    textBox65.Text = answer.dan[6, 5].data.ToString();
                    textBox65.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox66.Text, 10) < 1 && System.Convert.ToInt16(textBox66.Text, 10) > 9)
                {
                    textBox66.Text = answer.dan[6, 6].data.ToString();
                    textBox66.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox67.Text, 10) < 1 && System.Convert.ToInt16(textBox67.Text, 10) > 9)
                {
                    textBox67.Text = answer.dan[6, 7].data.ToString();
                    textBox67.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox68.Text, 10) < 1 && System.Convert.ToInt16(textBox68.Text, 10) > 9)
                {
                    textBox68.Text = answer.dan[6, 8].data.ToString();
                    textBox68.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox70.Text, 10) < 1 && System.Convert.ToInt16(textBox70.Text, 10) > 9)
                {
                    textBox70.Text = answer.dan[7, 0].data.ToString();
                    textBox70.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox71.Text, 10) < 1 && System.Convert.ToInt16(textBox71.Text, 10) > 9)
                {
                    textBox71.Text = answer.dan[7, 1].data.ToString();
                    textBox71.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox72.Text, 10) < 1 && System.Convert.ToInt16(textBox72.Text, 10) > 9)
                {
                    textBox72.Text = answer.dan[7, 2].data.ToString();
                    textBox72.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox73.Text, 10) < 1 && System.Convert.ToInt16(textBox73.Text, 10) > 9)
                {
                    textBox73.Text = answer.dan[7, 3].data.ToString();
                    textBox73.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox74.Text, 10) < 1 && System.Convert.ToInt16(textBox74.Text, 10) > 9)
                {
                    textBox74.Text = answer.dan[7, 4].data.ToString();
                    textBox74.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox75.Text, 10) < 1 && System.Convert.ToInt16(textBox75.Text, 10) > 9)
                {
                    textBox75.Text = answer.dan[7, 5].data.ToString();
                    textBox75.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox76.Text, 10) < 1 && System.Convert.ToInt16(textBox76.Text, 10) > 9)
                {
                    textBox76.Text = answer.dan[7, 6].data.ToString();
                    textBox76.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox77.Text, 10) < 1 && System.Convert.ToInt16(textBox77.Text, 10) > 9)
                {
                    textBox77.Text = answer.dan[7, 7].data.ToString();
                    textBox77.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox78.Text, 10) < 1 && System.Convert.ToInt16(textBox78.Text, 10) > 9)
                {
                    textBox78.Text = answer.dan[7, 8].data.ToString();
                    textBox78.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox80.Text, 10) < 1 && System.Convert.ToInt16(textBox80.Text, 10) > 9)
                {
                    textBox80.Text = answer.dan[8, 0].data.ToString();
                    textBox80.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox81.Text, 10) < 1 && System.Convert.ToInt16(textBox81.Text, 10) > 9)
                {
                    textBox81.Text = answer.dan[8, 1].data.ToString();
                    textBox81.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox82.Text, 10) < 1 && System.Convert.ToInt16(textBox82.Text, 10) > 9)
                {
                    textBox82.Text = answer.dan[8, 2].data.ToString();
                    textBox82.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox83.Text, 10) < 1 && System.Convert.ToInt16(textBox83.Text, 10) > 9)
                {
                    textBox83.Text = answer.dan[8, 3].data.ToString();
                    textBox83.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox84.Text, 10) < 1 && System.Convert.ToInt16(textBox84.Text, 10) > 9)
                {
                    textBox84.Text = answer.dan[8, 4].data.ToString();
                    textBox84.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox85.Text, 10) < 1 && System.Convert.ToInt16(textBox85.Text, 10) > 9)
                {
                    textBox85.Text = answer.dan[8, 5].data.ToString();
                    textBox85.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox86.Text, 10) < 1 && System.Convert.ToInt16(textBox86.Text, 10) > 9)
                {
                    textBox86.Text = answer.dan[8, 6].data.ToString();
                    textBox86.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox87.Text, 10) < 1 && System.Convert.ToInt16(textBox87.Text, 10) > 9)
                {
                    textBox87.Text = answer.dan[8, 7].data.ToString();
                    textBox87.ForeColor = Color.Blue;
                }
                if (System.Convert.ToInt16(textBox88.Text, 10) < 1 && System.Convert.ToInt16(textBox88.Text, 10) > 9)
                {
                    textBox88.Text = answer.dan[8, 8].data.ToString();
                    textBox88.ForeColor = Color.Blue;
                }
            }
        }
    }
}
