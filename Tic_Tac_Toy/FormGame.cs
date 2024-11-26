using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toy
{
    public partial class FormGame : Form
    {
        static int n = 3;
        int turn = 1;
        int[,] field = new int[n, n];

        void ShowField()
        {
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    string temp = "";
                    switch(field[row, col])
                    { 
                        case 1: temp = "x"; break; 
                        case 2: temp = "o"; break;
                    }
                    dataGridViewGame.Rows[row].Cells[col].Value = temp;
                }
            }
        }

        public FormGame()
        {
            InitializeComponent();
        }

        private void FormGame_Load(object sender, EventArgs e)
        {
            dataGridViewGame.Rows.Add(3);
        }

        private void dataGridViewGame_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            field[e.RowIndex, e.ColumnIndex] = turn;
            turn = turn % 2 + 1;
            ShowField();
            //dataGridViewGame[e.ColumnIndex, e.RowIndex].Value = "0";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            field = new int[n, n];
            ShowField();
        }
    }
}
