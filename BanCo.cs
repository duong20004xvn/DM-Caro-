using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM_Caro_
{
    class BanCo
    {
        // Khai báo số dòng cột của bàn cờ
        private int _sodong;
        public int Sodong
        {
            get { return _sodong; }
            set { _sodong = value; }
        }
        private int _socot;
        public int Socot
        {
            get { return _socot; }
            set { _socot = value; }
        }

        public BanCo()
        {
            _sodong = 0;
            _socot = 0;
        }

        public BanCo(int sodong, int socot)
        {
            _sodong = sodong;
            _socot = socot;
        }

        public void VeBanCo(Graphics g)
        {
            // Vẽ chiều dọc
            for (int i = 0; i <= _socot; i++)
            {
                g.DrawLine(CaroChess.pen, i * OCo._chieurong, 0, i * OCo._chieurong, _sodong * OCo._chieucao);
            }

            // Vẽ theo chiều ngang
            for (int j = 0; j <= _sodong; j++)
            {
                g.DrawLine(CaroChess.pen, 0, j * OCo._chieucao, _socot * OCo._chieurong, j * OCo._chieucao);
            }
        }

        // Vẽ quân cờ
        public void VeQuanCo(Graphics g, Point point, SolidBrush sb)
        {
            g.FillEllipse(sb, point.X + 2, point.Y + 2, OCo._chieurong - 4, OCo._chieucao - 4);
        }

        // Xóa quân cờ bằng cách vẽ đè lên quân cờ vừa xóa 1 ô
        public void XoaQuanCo(Graphics g, Point point, SolidBrush sb)
        {
            g.FillRectangle(sb, point.X + 1, point.Y + 1, OCo._chieurong - 2, OCo._chieucao - 2);
        }


    }
}
