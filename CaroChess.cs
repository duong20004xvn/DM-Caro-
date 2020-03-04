using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DM_Caro_
{
    // để kiểm tra ai thắng
    public enum KetThuc
    {
        HoaCo,
        Player1,
        Player2,
    }

    class CaroChess
    {
        public static Pen pen;
        public static SolidBrush sbWhite; // Quân trắng
        public static SolidBrush sbBlack; // Quân đen
        public static SolidBrush sbDeepSkyBlue; // màu nền sử dụng trong xóa quân cờ
        // Danh sách các quân cờ đã đánh
        private Stack<OCo> stk_CacNuocDaDi;
        // Danh sách các quân cờ vừa Undo
        private Stack<OCo> stk_CacNuocUndo;
        // Lượt đi
        private int _luotDi;
        // để kiểm tra kẻ thắng
        private KetThuc _kethuc;
        // Kiểm tra Chế độ chơi
        // Player Vs player : 1
        // player vs Computer: 2
        private int _cheDoChoi;

        public int CheDoChoi
        {
            get { return _cheDoChoi; }
            set { _cheDoChoi = value; }
        }

        // Cho phép đánh/ không
        private bool _sanSang;
        public bool SanSang
        {
            get { return _sanSang; }
            set { _sanSang = value; }
        }

        // Khai báo Mảng 2c các Ô cờ
        private OCo[,] _mangOCo;

        private BanCo _banco;
        public CaroChess()
        {
            // Bàn cờ có 20 x 20 ô
            _banco = new BanCo(20, 20);
            // khởi tạo mảng ô cờ
            _mangOCo = new OCo[_banco.Sodong, _banco.Socot];
            // khởi tạo các đối tượng để vẽ
            pen = new Pen(Color.Blue);
            sbWhite = new SolidBrush(Color.White);
            sbBlack = new SolidBrush(Color.Black);
            // khởi tạo cho list các quân đã đánh / undo
            stk_CacNuocDaDi = new Stack<OCo>();
            stk_CacNuocUndo = new Stack<OCo>();
            // Player 1 chơi
            _luotDi = 1;
            // khởi tạo màu nền cho việc xóa quân cờ
            sbDeepSkyBlue = new SolidBrush(Color.DeepSkyBlue);
        }

        // Vẽ bàn cờ
        public void VeBanCo(Graphics g)
        {
            _banco.VeBanCo(g);
        }

        // Khởi tạo mảng các ô cờ
        public void KhoiTaoMangOCo()
        {
            for (int i = 0; i < _banco.Sodong; i++)
            {
                // Do i chạy dọc xuống từng dòng
                // j chạy ngang trên mỗi dòng
                // Nên Point sẽ là (j * Chieurong, i * Chieucao)
                for (int j = 0; j < _banco.Socot; j++)
                {
                    _mangOCo[i, j] = new OCo(i, j, new Point(j * OCo._chieurong, i * OCo._chieucao), 0);
                }
            }
        }

        // Đánh cờ
        public bool DanhCo(int mouseX, int mouseY, Graphics g)
        {
            // Lấy vị trí x hiện tại / độ rộng ra vị trí cột
            // Lấy vị trí y / độ cao ra vị trí dòng
            // Đã test bằng Paint.

            /// Chặn việc vẽ ô cờ ngay đường biên
            /// Tại những vị trí là bội của 25. Ví dụ 25, 50, 75...
            if (mouseX % OCo._chieurong == 0 || mouseY % OCo._chieucao == 0)
                return false; // không đánh cờ          

            int cot = mouseX / OCo._chieurong;
            int dong = mouseY / OCo._chieucao;

            // Nếu 1 ô đã đánh rồi thì không đc phép đánh nữa
            if (_mangOCo[dong, cot].Sohuu != 0)
                return false;

            switch (_luotDi)
            {
                case 1:
                    _mangOCo[dong, cot].Sohuu = 1; // Player 1
                    _banco.VeQuanCo(g, _mangOCo[dong, cot].Vitri, sbBlack); // Quân đen
                    // Sau khi đánh, đổi lại lượt đi
                    _luotDi = 2;
                    break;
                case 2:
                    _mangOCo[dong, cot].Sohuu = 2; // Player 2
                    _banco.VeQuanCo(g, _mangOCo[dong, cot].Vitri, sbWhite); // Quân trắng
                    // Sau khi đánh, đổi lại lượt đi
                    _luotDi = 1;
                    break;
                default:
                    MessageBox.Show("Err!");
                    break;
            }

            // Mỗi lần đánh cờ, sẽ tạo mới danh sách Undo, Khóa không cho người chơi Undo lại.
            stk_CacNuocUndo = new Stack<OCo>();

            // Khởi tạo 1 ô cờ mới để tránh tham chiếu con trỏ cùng vùng nhớ, phát sinh ra các lỗi không mong muốn
            OCo oco = new OCo(_mangOCo[dong, cot].Dong, _mangOCo[dong, cot].Cot, _mangOCo[dong, cot].Vitri, _mangOCo[dong, cot].Sohuu);
            // mỗi lần đánh sẽ lưu lại các nước đã đi
            stk_CacNuocDaDi.Push(_mangOCo[dong, cot]);

            return true;
        }

        // Vẽ lại các quân cờ đã đi giải quyết vấn đề RePaint
        public void VeLaiQuanCo(Graphics g)
        {
            foreach (OCo oco in stk_CacNuocDaDi)
            {
                // nếu Sở hữu là Player 1
                if (oco.Sohuu == 1)
                    _banco.VeQuanCo(g, oco.Vitri, sbBlack);
                else if (oco.Sohuu == 2)
                    _banco.VeQuanCo(g, oco.Vitri, sbWhite);

            }
        }

        // Chế độ new Player vs Player
        public void PlayerVsPlayer(Graphics g)
        {
            _sanSang = true;
            // Xóa đi các nước đã đi trước đó
            stk_CacNuocDaDi = new Stack<OCo>();
            stk_CacNuocUndo = new Stack<OCo>();
            // Khởi tạo lại mảng ô cờ
            KhoiTaoMangOCo();
            // Gán lượt đi
            _luotDi = 1;
            // Gán chế độ chơi
            _cheDoChoi = 1;
            // Vẽ lại bàn cờ
            VeBanCo(g);
        }
        #region Undo - Redo
        // Undo quân cờ
        public void Undo(Graphics g)
        {
            if (stk_CacNuocDaDi.Count != 0) // nếu stack khác rỗng
            {
                // Bỏ nước vừa mới đi đc thêm ở đầu Stack
                OCo oco = stk_CacNuocDaDi.Pop();
                // Đưa vào stack_Undo các nước vừa bỏ ra
                // Phải khởi tạo lại 1 ô cờ mới để tránh việc tham chiếu cùng vùng nhớ
                stk_CacNuocUndo.Push(new OCo(oco.Dong, oco.Cot, oco.Vitri, oco.Sohuu));
                // gán lại sở hữu vừa bỏ ra
                _mangOCo[oco.Dong, oco.Cot].Sohuu = 0;

                // Gán lại lượt đi
                if (_luotDi == 1)
                    _luotDi = 2;
                else
                    _luotDi = 1;

                // Xóa quân cờ bằng cách vẽ đè lại 1 ô cờ tại chính vị trí cần xóa
                _banco.XoaQuanCo(g, oco.Vitri, sbDeepSkyBlue);


            }
        }

        // Redo quân cờ
        public void Redo(Graphics g)
        {
            if (stk_CacNuocUndo.Count != 0) // nếu stack khác rỗng
            {
                // Bỏ nước vừa mới đi đc thêm ở đầu Stack
                OCo oco = stk_CacNuocUndo.Pop();
                // Đưa vào stack_DaDi ôcờ muốn Undo lại
                stk_CacNuocDaDi.Push(new OCo(oco.Dong, oco.Cot, oco.Vitri, oco.Sohuu));
                // gán lại sở hữu chính là sở hữu hiện tại của ô cờ
                _mangOCo[oco.Dong, oco.Cot].Sohuu = oco.Sohuu;
                // Xóa quân cờ bằng cách vẽ đè lại 1 ô cờ tại chính vị trí cần xóa
                // Gán lại lượt đi
                if (_luotDi == 1)
                    _luotDi = 2;
                else
                    _luotDi = 1;

                _banco.VeQuanCo(g, oco.Vitri, oco.Sohuu == 1 ? sbBlack : sbWhite);
            }
        }
        #endregion

        #region Duyệt chiến thắng

        // Kiểm tra kẻ thắng
        public bool KiemTraThang()
        {
            // nếu đã đi full các nước
            if (stk_CacNuocDaDi.Count == _banco.Socot * _banco.Sodong)
            {
                // bị hòa
                _kethuc = KetThuc.HoaCo;
                return true;
            }
            // Xét các trường hợp còn lại
            foreach (OCo oco in stk_CacNuocDaDi)
            {
                // Nếu có kẻ thắng
                if (DuyetDoc(oco.Dong, oco.Cot, oco.Sohuu) || DuyetNgang(oco.Dong, oco.Cot, oco.Sohuu) || DuyetCheoXuoi(oco.Dong, oco.Cot, oco.Sohuu) || DuyetCheoNguoc(oco.Dong, oco.Cot, oco.Sohuu))
                {
                    // kiểm tra người thắng hiện tại
                    _kethuc = (oco.Sohuu == 1 ? KetThuc.Player1 : KetThuc.Player2);
                    return true;
                }
            }

            return false;
        }

        // Duyệt theo chiều dọc
        private bool DuyetDoc(int curDong, int curCot, int curSohuu)
        {
            // do sử dụng mảng, nên chỉ số bắt đầu từ 0 - 19                     
            // nếu bắt đầu đánh vào 4 dòng cuối cùng trong 20 dòng -  tức là đánh là chỉ mục dòng thứ 16
            // => Lúc đó tối đa thì chỉ có 4 quân, mà 4 quân làm sao thắng => false
            if (curDong > _banco.Sodong - 5)
                return false;

            // đếm số quân cờ cùng 1 Kẻ sở hữu
            int dem;

            // Nếu có 4 quân liên tiếp, Tại sao lại là 4: Do quân hiện tại mình đang xét.
            // bước cuối 'dem' tăng 1 đơn vị(5): dem++(xét quân thứ 5)
            for (dem = 1; dem < 5; dem++)
            {
                // nếu chỉ cần 1 ô khác sở hữu hiện tại  => false.
                if (_mangOCo[curDong + dem, curCot].Sohuu != curSohuu)
                    return false;
            }

            // Nếu vòng lặp ở trên chưa bị 'false' => Tức là 5 quân liên tiếp cùng sở hữu
            // Xét CÁC VỊ TRÍ BIÊN:
            // Xét tại dòng 0
            // Hoặc tại chỉ số dòng thứ 15
            if (curDong == 0 || curDong + dem == _banco.Sodong)
                return true;

            // XÉT TẠI CÁC VỊ TRÍ GIỮA BÀN CỜ
            // Nếu không bị chặn ĐẦU TRÊN, ĐẦU DƯỚI. ( Là Ô trống)
            // Do luật: Bị chặn cả 2 đầu sẽ THUA.
            if (_mangOCo[curDong - 1, curCot].Sohuu == 0 || _mangOCo[curDong + dem, curCot].Sohuu == 0)
            {
                // MessageBox.Show("ô đầu: " + _mangOCo[curDong - 1, curCot].Vitri + "ô cuối: " + _mangOCo[curDong + dem, curCot].Vitri);
                return true;
            }
            // Nếu k thỏa các điều kiện trên => false
            return false;
        }

        // Duyệt theo chiều ngang
        private bool DuyetNgang(int curDong, int curCot, int curSohuu)
        {
            if (curCot > _banco.Socot - 5)
                return false;

            // đếm số quân cờ cùng 1 Kẻ sở hữu
            int dem;

            // Nếu có 4 quân liên tiếp, Tại sao lại là 4: Do quân hiện tại mình đang xét.
            // bước cuối 'dem' tăng 1 đơn vị(5): dem++(xét quân thứ 5)
            for (dem = 1; dem < 5; dem++)
            {
                // DUYỆT NGANG : CHẠY THEO CHIỀU NGANG
                // nếu chỉ cần 1 ô khác sở hữu hiện tại  => false.
                if (_mangOCo[curDong, curCot + dem].Sohuu != curSohuu)
                    return false;
            }

            // Nếu vòng lặp ở trên chưa bị 'false' => Tức là 5 quân liên tiếp cùng sở hữu
            // Xét CÁC VỊ TRÍ BIÊN:
            // Xét tại cột 0
            // Hoặc tại chỉ số cột thứ 15
            if (curCot == 0 || curCot + dem == _banco.Socot)
                return true;

            // XÉT TẠI CÁC VỊ TRÍ GIỮA BÀN CỜ
            // Nếu không bị chặn ĐẦU TRÊN, ĐẦU DƯỚI. ( Là Ô trống)
            // Do luật: Bị chặn cả 2 đầu sẽ THUA.
            if (_mangOCo[curDong, curCot - 1].Sohuu == 0 || _mangOCo[curDong, curCot + dem].Sohuu == 0)
            {
                // MessageBox.Show("ô đầu: " + _mangOCo[curDong, curCot - 1].Vitri + "ô cuối: " + _mangOCo[curDong, curCot + dem].Vitri);
                return true;
            }
            // Nếu k thỏa các điều kiện trên => false
            return false;
        }


        // Duyệt CHÉO XUÔI
        private bool DuyetCheoXuoi(int curDong, int curCot, int curSohuu)
        {
            if (curDong > _banco.Sodong - 5 || curCot > _banco.Socot - 5)
                return false;

            // đếm số quân cờ cùng 1 Kẻ sở hữu
            int dem;

            // Nếu có 4 quân liên tiếp, Tại sao lại là 4: Do quân hiện tại mình đang xét.
            // bước cuối 'dem' tăng 1 đơn vị(5): dem++(xét quân thứ 5)
            for (dem = 1; dem < 5; dem++)
            {
                // CHẠY CHÉO, đã TEST

                if (_mangOCo[curDong + dem, curCot + dem].Sohuu != curSohuu)
                    return false;
            }

            // Nếu vòng lặp ở trên chưa bị 'false' => Tức là 5 quân liên tiếp cùng sở hữu
            // Xét CÁC VỊ TRÍ BIÊN(4 trường hợp):
            // CHÉO là tổ hợp của 4 trường hợp: 2 của dòng & 2 của cột

            if (curDong == 0 || curDong + dem == _banco.Sodong || curCot == 0 || curCot + dem == _banco.Socot)
                return true;

            // XÉT TẠI CÁC VỊ TRÍ GIỮA BÀN CỜ
            // Nếu không bị chặn ĐẦU TRÊN, ĐẦU DƯỚI. ( Là Ô trống)
            // Do luật: Bị chặn cả 2 đầu sẽ THUA.
            if (_mangOCo[curDong - 1, curCot - 1].Sohuu == 0 || _mangOCo[curDong + dem, curCot + dem].Sohuu == 0)
            {
                // MessageBox.Show("ô đầu: " + _mangOCo[curDong, curCot - 1].Vitri + "ô cuối: " + _mangOCo[curDong, curCot + dem].Vitri);
                return true;
            }
            // Nếu k thỏa các điều kiện trên => false
            return false;
        }

        // Duyệt CHÉO NGƯỢC
        private bool DuyetCheoNguoc(int curDong, int curCot, int curSohuu)
        {
            // các dòng từ 0 - 3
            // các cột > 15
            if (curDong < 4 || curCot > _banco.Socot - 5)
                return false;

            // đếm số quân cờ cùng 1 Kẻ sở hữu
            int dem;

            // Nếu có 4 quân liên tiếp, Tại sao lại là 4: Do quân hiện tại mình đang xét.
            // bước cuối 'dem' tăng 1 đơn vị(5): dem++(xét quân thứ 5)
            for (dem = 1; dem < 5; dem++)
            {
                // CHẠY CHÉO NGƯỢC LẠI, đã test

                if (_mangOCo[curDong - dem, curCot + dem].Sohuu != curSohuu)
                    return false;
            }

            // Nếu vòng lặp ở trên chưa bị 'false' => Tức là 5 quân liên tiếp cùng sở hữu
            // Xét CÁC VỊ TRÍ BIÊN:

            // Biên trên ở dòng 4 hoặc ở Kế cuối
            if (curDong == 4 || curDong == _banco.Sodong - 1 || curCot == 0 || curCot + dem == _banco.Socot)
                return true;

            // XÉT TẠI CÁC VỊ TRÍ GIỮA BÀN CỜ
            // ĐI CHÉO

            if (_mangOCo[curDong + 1, curCot - 1].Sohuu == 0 || _mangOCo[curDong - dem, curCot + dem].Sohuu == 0)
            {
                return true;
            }
            // Nếu k thỏa các điều kiện trên => false
            return false;
        }

        // Xuất ra các thông báo khi hết game
        public void KetThucTroChoi()
        {
            switch (_kethuc)
            {
                case KetThuc.HoaCo:
                    MessageBox.Show("Hòa rồi!");
                    break;
                case KetThuc.Player1:
                    MessageBox.Show("Player 1 win!");
                    break;
                case KetThuc.Player2:
                    MessageBox.Show("Player 2 win!");
                    break;
                default:
                    MessageBox.Show("Err!");
                    break;
            }
            // gán lại trạng thái sẵn sàng cho ván mới
            _sanSang = false;
        }
        #endregion
    }
}
