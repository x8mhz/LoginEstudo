using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginExemplo1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        class SeeThroughPanel : Panel
        {
            public SeeThroughPanel()
            {
            }

            protected override CreateParams CreateParams
            {
                get
                {
                    var cp = base.CreateParams;
                    cp.ExStyle |= 0x00000020;
                    return cp;
                }
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                //base.OnPaint(e);
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(50, 0, 0, 0)), this.ClientRectangle);
            }
        }


     }
}
