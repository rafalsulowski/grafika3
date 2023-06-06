namespace LightingVisualization
{
    using System;
    using System.Drawing;
    using System.Drawing.Imaging;
    using Model;
    using System.Windows.Forms;
    using Logic;

    public partial class LightingVisualization : Form
    {
        private PhongOperator phongOperator;
        private Surface surface;
        private Bitmap shadedBitmap;

        private int m_Mode = 0;
        private int m_UpdownCount = 0;
        private int m_LeftRightCount = 0;
        private int m_ForwardBackwardCount = 0;

        public LightingVisualization()
        {
            InitializeComponent();
            shadedBitmap = new Bitmap(500, 500, PixelFormat.Format24bppRgb);

            Graphics g = Graphics.FromImage(shadedBitmap);
            g.Clear(Color.FromArgb(36, 45, 64));
            g.FillEllipse(new SolidBrush(Color.SaddleBrown), 100, 100, 300, 300);
            GraphicIcon.Image = shadedBitmap;

            phongOperator = new PhongOperator();
            surface = new Surface
            {
                Ks = 0.25,    
                Kd = 0.75,
                N = 5
            };
            tbKs.Value = 25;
            tbKd.Value = 75;
            tbN.Value = 5;
            tbIa.Value = 100;
            tbIp.Value = 60000;
            tbKa.Value = 40;
        }

        private void LightingVisualization_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
            KeyUp += LightingVisualization_KeyUp;
        }

        private void SetNewIcon()
        {
            GraphicIcon.Image = phongOperator.PhongAlgorithm(shadedBitmap, surface);
        }

        private void LightingVisualization_KeyUp(object sender, KeyEventArgs e)
        {
            resPos.Enabled = true;

            switch (e.KeyCode)
            {
                case Keys.W:
                    m_UpdownCount++;
                    if (m_LeftRightCount == 0)
                    {
                        posU.Text = "[]"; posD.Text = "[]";
                    }
                    else if (m_UpdownCount > 0)
                        posU.Text = $"[{m_UpdownCount}]";
                    else
                        posD.Text = $"[{Math.Abs(m_UpdownCount)}]";
                    phongOperator.MoveRight();
                    break;
                case Keys.A:
                    m_LeftRightCount--;
                    if (m_LeftRightCount == 0)
                    {
                        posR.Text = "[]"; posL.Text = "[]";
                    }
                    else if (m_LeftRightCount > 0)
                        posR.Text = $"[{m_LeftRightCount}]";
                    else
                        posL.Text = $"[{Math.Abs(m_LeftRightCount)}]";
                    phongOperator.Up();
                    break;
                case Keys.S:
                    m_UpdownCount--;
                    if (m_LeftRightCount == 0)
                    {
                        posU.Text = "[]"; posD.Text = "[]";
                    }
                    else if (m_UpdownCount > 0)
                        posU.Text = $"[{m_UpdownCount}]";
                    else
                        posD.Text = $"[{Math.Abs(m_UpdownCount)}]";
                    phongOperator.MoveLeft();
                    break;
                case Keys.D:
                    m_LeftRightCount++;
                    if (m_LeftRightCount == 0)
                    {
                        posR.Text = "[]"; posL.Text = "[]";
                    }
                    else if (m_LeftRightCount > 0)
                        posR.Text = $"[{m_LeftRightCount}]";
                    else
                        posL.Text = $"[{Math.Abs(m_LeftRightCount)}]";
                    phongOperator.Down();
                    break;
                case Keys.Z:
                    m_ForwardBackwardCount++;
                    if (m_ForwardBackwardCount == 0)
                        posT.Text = "[sfera]";
                    else
                        posT.Text = $"[{m_ForwardBackwardCount}]";
                    phongOperator.Forward();
                    break;
                case Keys.C:
                    m_ForwardBackwardCount--;
                    if (m_ForwardBackwardCount == 0)
                        posT.Text = "[sfera]";
                    else 
                        posT.Text = $"[{m_ForwardBackwardCount}]";
                    phongOperator.Backward();
                    break;
            }
            SetNewIcon();
        }

        private void Mirror_CheckedChanged(object sender, EventArgs e)
        {
            //Symulujemy powierzchnie lustra (metaliczna, lustrzana)
            surface.Ks = 0.25;   tbKs.Value = 25;
            surface.Kd = 0.75;   tbKd.Value = 75;
            surface.N = 5;       tbN.Value = 5;
            SetNewIcon();
            m_Mode = 1;
        }

        private void Intermediate_CheckedChanged(object sender, EventArgs e)
        {
            //Symulujemy powierzchnie przejściową
            surface.Ks = 0.5;   tbKs.Value = 50;
            surface.Kd = 0.5;   tbKd.Value = 50;
            surface.N = 10;     tbN.Value = 10;
            SetNewIcon();
            m_Mode = 2;
        }

        private void Wood_CheckedChanged(object sender, EventArgs e)
        {
            //Symulujemy powierzchnie drewna (matowa)
            surface.Ks = 0.75;  tbKs.Value = 75;
            surface.Kd = 0.30;  tbKd.Value = 30;
            surface.N = 100;    tbN.Value = 100;
            SetNewIcon();
            m_Mode = 3;
        }


        private void resPos_Click(object sender, EventArgs e)
        {
            resPos.Enabled = false;

            phongOperator.Source = new Point3D(0, 0, 200);

            m_UpdownCount = 0;
            m_LeftRightCount = 0;
            m_ForwardBackwardCount = 0;

            posU.Text = "[]";
            posR.Text = "[]";
            posL.Text = "[]";
            posD.Text = "[]";
            posT.Text = "[sfera]";

            SetNewIcon();
        }

        private void resPar_Click(object sender, EventArgs e)
        {
            phongOperator.Ia = 100;
            phongOperator.Ip = 60000;
            phongOperator.Ka = 0.4;

            tbIa.Value = 100;
            tbIp.Value = 60000;
            tbKa.Value = 40;

            switch (m_Mode)
            {
                case 1:
                    Mirror_CheckedChanged(sender, e);
                    break;
                case 2:
                    Intermediate_CheckedChanged(sender, e);
                    break;
                case 3:
                    Wood_CheckedChanged(sender, e);
                    break;
                default:
                    break;
            }
        }

        private void tbKs_ValueChanged(object sender, EventArgs e)
        {
            label8.Text = "Współ. odbicia kierunkowego " + (tbKs.Value / 100.0).ToString() + "/1";
            surface.Ks = tbKs.Value / 100.0;
            SetNewIcon();
        }

        private void tbKd_ValueChanged(object sender, EventArgs e)
        {
            label7.Text = "Współ. odbicia rozproszonego " + (tbKd.Value / 100.0).ToString() + "/1";
            surface.Kd = tbKd.Value / 100.0;
            SetNewIcon();
        }

        private void tbN_ValueChanged(object sender, EventArgs e)
        {
            label6.Text = "Współ. gładkości powierzchni " + (tbN.Value).ToString() + "/100";
            surface.N = tbN.Value;
            SetNewIcon();
        }

        private void tbIa_ValueChanged(object sender, EventArgs e)
        {
            labelIa.Text = "Natężenie światła w otoczeniu obiektu " + (tbIa.Value).ToString() + "/200";
            phongOperator.Ia = tbIa.Value;
            SetNewIcon();
        }

        private void tbIp_ValueChanged(object sender, EventArgs e)
        {
            labelIp.Text = "Natężenie światła punktowego " + (tbIp.Value).ToString() + "/150000";
            phongOperator.Ip = tbIp.Value;
            SetNewIcon();
        }

        private void tbKa_ValueChanged(object sender, EventArgs e)
        {
            labelKa.Text = "Współ. odbicia światła otoczenia " + (tbKa.Value / 100.0).ToString() + "/1";
            phongOperator.Ka = tbKa.Value / 100.0;
            SetNewIcon();
        }
    }
}
