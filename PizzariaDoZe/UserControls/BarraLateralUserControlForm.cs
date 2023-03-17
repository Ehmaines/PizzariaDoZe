using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaDoZe
{
    public partial class BarraLateralUserControlForm : UserControl
    {
        public BarraLateralUserControlForm()
        {
            InitializeComponent();

            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int arcSize = 26; // tamanho do arco de borda
            Rectangle rect = new Rectangle(0, 0, panelInicio.Width, panelInicio.Height);
            path.AddArc(rect.X, rect.Y, arcSize, arcSize, 180, 90);
            path.AddArc(rect.X + rect.Width - arcSize, rect.Y, arcSize, arcSize, 270, 90);
            path.AddArc(rect.X + rect.Width - arcSize, rect.Y + rect.Height - arcSize, arcSize, arcSize, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - arcSize, arcSize, arcSize, 90, 90);
            panelInicio.Region = new System.Drawing.Region(path);
        }
    }
}
