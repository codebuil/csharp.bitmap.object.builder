using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        Boolean bb=false;
        Boolean bb1 = false;
        int x = 0;
        int y = 0;
        int w = 0;
        int h = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int x=0;
            int y = 0;
            byte[] b;
            String gs="";
            button1.Text= "loading wait...";
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            pictureBox1.Load();
            Bitmap image1 = new Bitmap(openFileDialog1.FileName, true);
            

            gs = "" ;
            Application.DoEvents();
  
            button1.Text = "open bitmap";
        }

        private void pictureBox1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Point mouseDownLocation = new Point(e.X, e.Y);
            Boolean nn = false;
            switch (e.Button)
            {
                case MouseButtons.Left:
                    nn = true;
                    if (!bb)
                    {
                        bb = true;
                        x = e.X;
                        y = e.Y;
                    }
                    break;
                case MouseButtons.Right:
                  
                    break;
                case MouseButtons.Middle:
                    
                    break;
                case MouseButtons.XButton1:
                    
                    break;
                case MouseButtons.XButton2:
                    
                    break;
                case MouseButtons.None:
                default:
                    break;
            }
            if (!nn && bb) {
                bb = false;
                textBox1.Text = textBox1.Text + "controls( control ," + x.ToString() + " , " + y.ToString() + " , " + e.X.ToString() + " , " + e.Y.ToString() + " );";


            }
        }
    }
}