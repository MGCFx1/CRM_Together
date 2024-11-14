using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_system
{
    public partial class Admins_Dashboard : Form
    {
        public Admins_Dashboard()
        {
            InitializeComponent();
        }
        bool menuExpand = false;


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menuContainer.Height += 10;
                if(menuContainer.Height >= 126)
                {

                    eventsTransition.Stop();
                    menuExpand = true;
                }
                else
                {
                    menuContainer.Height -= 10;
                    if(menuContainer.Height <= 40)
                    {
                        eventsTransition.Stop();
                        menuExpand = false;
                    }
                }

            }

        }

        private void Admins_Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void eventsMenu_Click(object sender, EventArgs e)
        {
            eventsTransition.Start();
        }
    }
}
