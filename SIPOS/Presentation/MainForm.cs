using Microsoft.Extensions.DependencyInjection;
using SIPOS.Presentation.Goods;
using SIPOS.Presentation.Security;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SIPOS.Presentation
{
    public partial class MainForm : Form
    {
        //private readonly ServiceCollection services;
        private readonly FormUserManagement formUserManagement;
        private readonly FormSupplier formSupplier;
        private readonly FormProduct formProduct;

        public MainForm(
            IServiceCollection services, 
            FormUserManagement formUserManagement,
            FormSupplier formSupplier,
            FormProduct formProduct
            )
        {
            this.services = services;
            this.formUserManagement = formUserManagement;
            this.formSupplier = formSupplier;
            this.formProduct = formProduct;
            //this.services = services;

            InitializeComponent();
            //Estas lineas eliminan los parpadeos del formulario o controles en la interfaz grafica (Pero no en un 100%)
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void OpenFormAsChild<ChildForm>(ChildForm formUserManagement) where ChildForm : Form
        {
            //Busca en la colecion el formulario
            Form formulario = FormsPanel.Controls.OfType<ChildForm>().FirstOrDefault();
                                                                                  
            //si el formulario/instancia no existe
            if (formulario is null)
            { 
                formulario = formUserManagement;
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                FormsPanel.Controls.Add(formulario);
                FormsPanel.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
                formulario.Show();
            }
        }

        #region Form functions
        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private readonly IServiceCollection services;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.ContainerPanel.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        private void PbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Capturar posicion y tamaño antes de maximizar para restaurar
        int lx, ly;
        int sw, sh;

        private void PbRestart_Click(object sender, EventArgs e)
        {
            PbMax.Visible = true;
            PbRestart.Visible = false;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }

        private void PbMax_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            PbMax.Visible = false;
            PbRestart.Visible = true;

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void PbMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Arrastrar el formulario
        private void TopMenu_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion

        private void BtnProducto_Click(object sender, EventArgs e)
        {
            OpenFormAsChild(formProduct);
        }

        private void BtnSupplier_Click(object sender, EventArgs e)
        {
            OpenFormAsChild(formSupplier);
        }

        private void BtnUsermanagement_Click(object sender, EventArgs e)
        {
            OpenFormAsChild(formUserManagement);
        }
    }
}
