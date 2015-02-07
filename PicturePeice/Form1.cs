using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicturePeice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //nowettiki toluq resim
        private Bitmap FullPicture = null;
        //doska tegliki
        private Bitmap Background = null;
        //Doska
        private Bitmap Board = null; 
        // parchilar
        private List<Peice> Peices = null;
        // Parhilarning chongluqi (sukutte asan halet)
        private int TargetSize = 100;
        // Parchilarni qoyudighan katekchilerning sani we chongluqi
        private int NumRows, NumCols, RowHgt, ColWid;
        // ishletkuchi tartip yotkewatqan parche
        private Peice MovingPeice = null;
        private Point MovingPoint;
        // oyun ayaghlashqanda 
        private bool GameOver = true;
        // Chekinish
        private void Exit_ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Open_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofdPicture.ShowDialog() == DialogResult.OK)
            {
                LoadPicture(ofdPicture.FileName);
            }
        }
        // Resimni yuklesh
        private void LoadPicture(string filename)
        {
            try
            {
                // Tallighan resimni yukleymiz
                using (Bitmap bm = new Bitmap(ofdPicture.FileName))
                {
                    FullPicture = new Bitmap(bm.Width, bm.Height);
                    using (Graphics gr = Graphics.FromImage(FullPicture))
                    {
                        gr.DrawImage(bm, 0, 0, bm.Width, bm.Height);
                    }
                }
                // Doska we tegliki
                Background = new Bitmap(FullPicture.Width, FullPicture.Height);
                Board = new Bitmap(FullPicture.Width, FullPicture.Height);
                picPuzzle.Size = FullPicture.Size;
                picPuzzle.Image = Board;
                this.ClientSize = new Size(picPuzzle.Right + picPuzzle.Left, picPuzzle.Bottom + picPuzzle.Left);
                //Yengi oyunni bashlash
                StartGame();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // Yengi oyunni bashlash
        private void StartGame()
        {
            if (FullPicture == null) return;
            GameOver = false;
            // Herbir parchining chongluqini hisablash
            NumRows = FullPicture.Height / TargetSize;
            RowHgt = FullPicture.Height / NumRows;
            NumCols = FullPicture.Width / TargetSize;
            ColWid = FullPicture.Width / NumCols;
            // Yukligen resimni parchilargha aylandurush
            Random rand = new Random();
            Peices = new List<Peice>();
            for (int row = 0; row < NumRows; row++)
            {
                int hgt = RowHgt;
                if (row == NumRows - 1) hgt = FullPicture.Height - row * RowHgt;
                for (int col = 0; col < NumCols; col++)
                {
                    int wid = ColWid;
                    if (col == NumCols - 1) wid = FullPicture.Width - col * ColWid;
                    Rectangle rect = new Rectangle(col * ColWid, row * RowHgt, wid, hgt);
                    Peice new_peice = new Peice(FullPicture, rect);
                    // parchilarning deslepki ornini ixtiyariy belgilesh
                    new_peice.CurrentLocation = new Rectangle(
                        rand.Next(0,FullPicture.Width-wid),rand.Next(0,FullPicture.Height-hgt),wid,hgt
                        );
                    Peices.Add(new_peice);
                }
            }
            //Teglik sizish
            MakeBackground();
            // Doskini hasillash
            DrawBoard();
        }

        private void DrawBoard()
        {
            using (Graphics gr = Graphics.FromImage(Board))
            {
                // Teglikni qayta tertiplesh
                gr.DrawImage(Background, 0, 0, Background.Width, Background.Height);
                // Yotkewatqan parchilarni sizish 
                if (MovingPeice != null)
                {
                    gr.DrawImage(FullPicture, MovingPeice.CurrentLocation, MovingPeice.HomeLocation, GraphicsUnit.Pixel);
                    using (Pen blue_pen = new Pen(Color.Blue, 4))
                    {
                        gr.DrawRectangle(blue_pen, MovingPeice.CurrentLocation);
                    }
                }
            }
            picPuzzle.Visible = true;
            picPuzzle.Refresh();
        }
        // Yotkeshke bolidighan parchilar yoq waqittiki teglik
        private void MakeBackground()
        {
            using (Graphics gr = Graphics.FromImage(Background))
            {
                MakeBackgroundOnGraphics(gr);
            }
        }
        // Dayirige mashlashturush
        private void MakeBackground(Rectangle rect)
        {
            using (Graphics gr = Graphics.FromImage(Background))
            {
                gr.SetClip(rect);
                MakeBackgroundOnGraphics(gr);
            }
        }
        private void MakeBackgroundOnGraphics(Graphics gr)
        {
            // Tazlash
            gr.Clear(picPuzzle.BackColor);
            // Teglik ustige katekche sizish
            DrawGrid(gr);
            //Parchilarn sizish
            DrawPeices(gr);
            picPuzzle.Visible = true;
            picPuzzle.Refresh();
        }

        private void DrawPeices(Graphics gr)
        {
            using (Pen white_pen = new Pen(Color.White, 3))
            {
                using (Pen black_pen = new Pen(Color.Black, 3))
                {
                    foreach (Peice peice in Peices)
                    {
                        // Yotkewatqan parchini sizmaymiz
                        if (peice != MovingPeice)
                        {
                            gr.DrawImage(FullPicture, peice.CurrentLocation, peice.HomeLocation, GraphicsUnit.Pixel);
                            if (!GameOver)
                            {
                                if (peice.IsHome())
                                {
                                    // qoyulghan parchining girwikini aq rengge almashturimiz
                                    gr.DrawRectangle(white_pen, peice.CurrentLocation);
                                }
                                else
                                {
                                    // qoyulghan parchining girwikini qara rengge almashturimiz
                                    gr.DrawRectangle(black_pen, peice.CurrentLocation);
                                }
                            }
                        }
                    }
                }
            }
        }
        // Teglik ustige katekche sizish
        private void DrawGrid(Graphics gr)
        {
            using (Pen thick_pen = new Pen(Color.DarkGray, 4))
            {
                for (int y = 0; y <= FullPicture.Height; y += RowHgt)
                {
                    gr.DrawLine(thick_pen, 0, y, FullPicture.Width, y);
                }
                gr.DrawLine(thick_pen, 0, FullPicture.Height, FullPicture.Width, FullPicture.Height);

                for (int x = 0; x <= FullPicture.Width; x += ColWid)
                {
                    gr.DrawLine(thick_pen, x, 0, x, FullPicture.Height);
                }
                gr.DrawLine(thick_pen, FullPicture.Width, 0, FullPicture.Width, FullPicture.Height);
            }
        }
        //Parchilar bolmighan chaghdiki teglikni muqumlashturush
        private void RemoveMovingPeiceFromBackground()
        {
            if (MovingPeice == null) return;
            using (Graphics gr = Graphics.FromImage(Background))
            {
                gr.SetClip(MovingPeice.CurrentLocation);
                // Bu dayirige ramka sizish
                DrawGrid(gr);
                // Parchilarni sizish
                DrawPeices(gr);
            }
            picPuzzle.Visible = true;
            picPuzzle.Refresh();
        }

        private void picPuzzle_MouseDown(object sender, MouseEventArgs e)
        {
            
            MovingPeice = null;
            foreach (Peice peice in Peices)
            {
                if (!peice.IsHome() && peice.Contains(e.Location))
                    MovingPeice = peice;
            }
            if (MovingPeice == null) return;

            // Bu orunni saqlash
            MovingPoint = e.Location;

            // Move it to the top of the stack.
            Peices.Remove(MovingPeice);
            Peices.Add(MovingPeice);

            // yotkiliwatqan parchilarning teglikini qayta sizish
            Rectangle rect = MovingPeice.CurrentLocation;
            rect.Inflate(4, 4);
            MakeBackground(rect);
            DrawBoard();
        }

        private void picPuzzle_MouseMove(object sender, MouseEventArgs e)
        {
            if (MovingPeice == null) return;
            // parchilarni yotkesh
            int dx = e.X - MovingPoint.X;
            int dy = e.Y - MovingPoint.Y;
            MovingPeice.CurrentLocation.X += dx;
            MovingPeice.CurrentLocation.Y += dy;
            // yengi mawus ornini saqlash
            MovingPoint = e.Location;
            // qayta sizish
            DrawBoard();
        }

        private void picPuzzle_MouseUp(object sender, MouseEventArgs e)
        {
            if (MovingPeice == null) return;
            // parchilar toghra ornidimu yoq?
            if (MovingPeice.SnapToHome())
            {
                Peices.Remove(MovingPeice);
                Peices.Reverse();
                Peices.Add(MovingPeice);
                Peices.Reverse();
                // oyun ayaghlashtim yoq?
                GameOver = true;
                foreach (Peice peice in Peices)
                {
                    if (!peice.IsHome())
                    {
                        GameOver = false;
                        break;
                    }
                }
            }
            // yotkleme parchilarning ornini elish
            Rectangle rect = MovingPeice.CurrentLocation;
            rect.Inflate(4, 4);
            //parchini yotkeshni toxtitish
            MovingPeice = null;
            // yotkelgen parche teglikini qayta sisizish
            if (GameOver)
            {
                MakeBackground();
            }
            else
            {
                MakeBackground(rect);
            }
            DrawBoard();
        }
        private void mnuOptionsLevel_Click(object sender, EventArgs e)
        {
            // Tallanghan yaki tallanmighan tizimlik
            ToolStripMenuItem mnu = sender as ToolStripMenuItem;
            Easy_F5ToolStripMenuItem.Checked = (mnu == Easy_F5ToolStripMenuItem);
            Medimum_F6ToolStripMenuItem.Checked = (mnu == Medimum_F6ToolStripMenuItem);
            Hard_F7ToolStripMenuItem.Checked = (mnu == Hard_F7ToolStripMenuItem);

            // Tallanghan qeyinliq derijisini elish
            TargetSize = int.Parse((string)mnu.Tag);

            // Yengi oyunni bashlash
            StartGame();
        }
        
    }
}
