using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DM_Caro_
{
    public partial class frmCaRo : Form
    {

        private CaroChess _caroChess;
        // Khai báo đối tượng Graphics
        private Graphics _grs;

        public frmCaRo()
        {
            InitializeComponent();

            // tao ra 1 thể hiện của caroChess
            _caroChess = new CaroChess();
            // Đối tượng graphics tạo bởi pnlBanCo
            _grs = pnlBanCo.CreateGraphics();
            // Khởi tạo mảng ô cờ
            _caroChess.KhoiTaoMangOCo();
            // Gán sự kiện cho nút PlayerVsPlayer
            btnPvsP.Click += PvsP;
           


            // Chơi mới
            btnChoiMoi.Click += ChoiMoi;

            // Thoát
            exitToolStripMenuItem.Click += Exit_Click;
            btnThoat.Click += Exit_Click;
            
            // Chạy flash
         //   axShockwaveFlash1.Movie = Application.StartupPath + @"\vongquay.swf";
           
        }



        private void tmChayChu_Tick(object sender, EventArgs e)
        {
            lblChuoi.Location = new Point(lblChuoi.Location.X, lblChuoi.Location.Y - 2);
            if (lblChuoi.Location.Y + lblChuoi.Height < 0)
                lblChuoi.Location = new Point(lblChuoi.Location.X, pnlChu.Height);
        }

        private void frmCaRo_Load(object sender, EventArgs e)
        {
            lblChuoi.Text = "Chào mừng đến với trò chơi\nCờ Ca Rô! ";
            tmChayChu.Enabled = true;
            
        }

        // Sử dụng sự kiện Paint để giải quyết vấn để repaint
        private void pnlBanCo_Paint(object sender, PaintEventArgs e)
        {
            _caroChess.VeBanCo(_grs);
            _caroChess.VeLaiQuanCo(_grs);
        }

        // Đánh cờ
        private void pnlBanCo_MouseClick(object sender, MouseEventArgs e)
        {

            // Nếu Trạng thái SẵnSàng = false
            if (!_caroChess.SanSang)
            {               
                return;
            }
       
            // nếu đánh cờ được
            if (_caroChess.DanhCo(e.X, e.Y, _grs))
            {
                // Kiểm tra người thắng
                if (_caroChess.KiemTraThang())
                {
                    // Xuất kết quả của game
                    _caroChess.KetThucTroChoi();
                }
                else // nếu vẫn chưa thắng
                { 
                    {
                        // Kiểm tra người thắng
                        if (_caroChess.KiemTraThang())
                        {
                            // Xuất kết quả của game
                            _caroChess.KetThucTroChoi();
                        }
                    }
                }
            }

        }

        private void pnlBanCo_MouseMove(object sender, MouseEventArgs e)
        {
            lblX_Y.Text = "Dòng: " + e.Y / OCo._chieucao + "," + "Cột: " + e.X / OCo._chieurong;
        }

        // Player vs Player
        private void PvsP(object sender, EventArgs e)
        {
            // Xóa toàn bộ panelBanCo, chỉ giữ lại màu nền
            _grs.Clear(pnlBanCo.BackColor);
            // Gọi đến phương thức bên CaroChess
            _caroChess.PlayerVsPlayer(_grs);
        }
        // Chơi mới
        public void ChoiMoi(object sender, EventArgs e)
        {
            if (_caroChess.CheDoChoi == 1)            
                PvsP(sender, e);            
        }
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Xóa quân cờ vừa đi
            _caroChess.Undo(_grs);
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _caroChess.Redo(_grs);
        }

        // Exit
        public void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void btnNut1_Click(object sender, EventArgs e)
        {
            pnlHinh.Visible = false;
            pnlNut.Visible = false;
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Move form
        bool IsDown = false;
        Point _toadobandau;

       

        private void frmCaro_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsDown == true)
            {
                Point p = new Point();
                p.X = this.Location.X + (e.X - _toadobandau.X);
                p.Y = this.Location.Y + (e.Y - _toadobandau.Y);
                this.Location = p;
            }
        }

        private void frmCaro_MouseUp(object sender, MouseEventArgs e)
        {
            IsDown = false;
        }

        private void frmCaRo_MouseDown(object sender, MouseEventArgs e)
        {
             IsDown = true;
            _toadobandau = new Point(e.X, e.Y);
        }
    }
}
