using System;
using System.Drawing;
using System.Windows.Forms;

namespace WFOmok
{
    public partial class WFOmok : Form
    {
        private OmokBoard board;
        private const int BoardSize = 15;
        private const int CellSize = 40;
        private const int Margin = 20;

        public WFOmok()
        {
           

            this.ClientSize = new Size(Margin * 2 + CellSize * BoardSize, Margin * 2 + CellSize * BoardSize);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Text = "윈폼 오목 게임";

            board = new OmokBoard(BoardSize);

            this.Paint += GameForm_Paint;
            this.MouseClick += GameForm_MouseClick;
        }

        private void GameForm_Paint(object sender, PaintEventArgs e)
        {
            board.DrawBoard(e.Graphics, CellSize, Margin);
            board.DrawStones(e.Graphics, CellSize, Margin);
        }

        private void GameForm_MouseClick(object sender, MouseEventArgs e)
        {
            int x = (e.X - Margin + CellSize / 2) / CellSize;
            int y = (e.Y - Margin + CellSize / 2) / CellSize;

            if (x < 0 || x >= BoardSize || y < 0 || y >= BoardSize)
                return;

            if (board.PlaceStone(x, y))
            {
                Invalidate(); // 다시 그리기
                if (board.CheckWin(x, y))
                {
                    string winner = board.CurrentTurn == OmokBoard.Stone.Black ? "백" : "흑";
                    MessageBox.Show($"{winner} 승리!");
                    board.Reset();
                    Invalidate();
                }
            }
        }
    }
}
