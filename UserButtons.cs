using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_management
{
    public partial class UserButtons : PictureBox
    {
        public UserButtons()
        {
            InitializeComponent();
        }
        public Image NormalImage{get;set;}
        public Image HoverImage { get; set; }

        private void UserButtons_MouseHover(object sender, EventArgs e)
        {
            this.Image = HoverImage;
        }

        private void UserButtons_MouseLeave(object sender, EventArgs e)
        {
            this.Image = NormalImage;
        }
    }
}
