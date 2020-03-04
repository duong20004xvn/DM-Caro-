using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM_Caro_
{
    class OCo
    {
        // Khai báo kích thước ô cờ
        public const int _chieurong = 25;
        public const int _chieucao = 25;

        // Khai báo  dòng, cột
        private int _dong;
        public int Dong
        {
            get { return _dong; }
            set { _dong = value; }
        }

        private int _cot;
        public int Cot
        {
            get { return _cot; }
            set { _cot = value; }
        }

        // Lưu lại vị trí của ô cờ
        private Point _vitri; // bấm Ctrl + R, E để Tạo Property nhanh
        public Point Vitri
        {
            get { return _vitri; }
            set { _vitri = value; }
        }

        // Kẻ sở hữu quân cờ
        // 0: không ai cả
        // 1: người 1
        // 2: người 2
        private int _sohuu;
        public int Sohuu
        {
            get { return _sohuu; }
            set { _sohuu = value; }
        }

        public OCo()
        {
 
        }

        // Khởi tạo 4 tham số cho 1 ô cờ
        public OCo(int dong, int cot, Point vitri, int sohuu)
        {
            this._dong = dong;
            this._cot = cot;
            this._vitri = vitri;
            this._sohuu = sohuu;
        }

    }
}
