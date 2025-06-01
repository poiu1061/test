using System.Drawing;

namespace WFOmok
{
    public class OmokBoard
    {
        public enum Stone { None = 0, Black = 1, White = 2 }

        private Stone[,] board;
        private int size;
        public Stone CurrentTurn { get; private set; }

        public OmokBoard(int size)
        {
            this.size = size;
            board = new Stone[size, size];
            CurrentTurn = Stone.Black;
        }

        public bool PlaceStone(int x, int y)
        {
            if (board[x, y] != Stone.None)
                return false;

            board[x, y] = CurrentTurn;
            CurrentTurn = (CurrentTurn == Stone.Black) ? Stone.White : Stone.Black;
            return true;
        }

        public void Reset()
        {
            board = new Stone[size, size];
            CurrentTurn = Stone.Black;
        }

        public void DrawBoard(Graphics g, int cellSize, int margin)
        {
            Pen pen = new Pen(Color.Black, 2);
            int boardLength = cellSize * (size - 1) + margin * 2;

            // 바깥 테두리
            g.DrawRectangle(pen, margin, margin, cellSize * (size - 1), cellSize * (size - 1));

            // 내부 줄
            for (int i = 0; i < size; i++)
            {
                int linePos = margin + i * cellSize;
                // 세로선
                g.DrawLine(pen, linePos, margin, linePos, margin + cellSize * (size - 1));
                // 가로선
                g.DrawLine(pen, margin, linePos, margin + cellSize * (size - 1), linePos);
            }
        }

        public void DrawStones(Graphics g, int cellSize, int margin)
        {
            int stoneSize = (int)(cellSize * 0.8);
            int offset = stoneSize / 2;

            for (int x = 0; x < size; x++)
            {
                for (int y = 0; y < size; y++)
                {
                    if (board[x, y] == Stone.None) continue;

                    Brush brush = (board[x, y] == Stone.Black) ? Brushes.Black : Brushes.White;
                    int drawX = margin + x * cellSize - offset;
                    int drawY = margin + y * cellSize - offset;
                    g.FillEllipse(brush, drawX, drawY, stoneSize, stoneSize);
                    g.DrawEllipse(Pens.Black, drawX, drawY, stoneSize, stoneSize);
                }
            }
        }

        public bool CheckWin(int x, int y)
        {
            Stone color = board[x, y];
            if (color == Stone.None)
                return false;

            // 4방향 확인 (가로, 세로, 대각선 두 개)
            int[][] directions = new int[][]
            {
                new int[]{1,0}, new int[]{0,1}, new int[]{1,1}, new int[]{1,-1}
            };

            foreach (var d in directions)
            {
                int count = 1;
                count += CountDirection(x, y, d[0], d[1], color);
                count += CountDirection(x, y, -d[0], -d[1], color);
                if (count >= 5)
                    return true;
            }
            return false;
        }

        private int CountDirection(int x, int y, int dx, int dy, Stone color)
        {
            int count = 0;
            int nx = x + dx;
            int ny = y + dy;
            while (nx >= 0 && ny >= 0 && nx < size && ny < size && board[nx, ny] == color)
            {
                count++;
                nx += dx;
                ny += dy;
            }
            return count;
        }
    }
}
