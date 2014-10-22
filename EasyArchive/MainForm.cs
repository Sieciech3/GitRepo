using EasyArchive.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyArchive
{
    public partial class MainForm : Form
    {
        ActivityLogger _activityLogger;

        public MainForm()
        {
            InitializeComponent();

            MessageBox.Show("Welcome");
            _activityLogger = new ActivityLogger(new LabelDisplay(lblStatus));
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            _activityLogger.Show("btnAdd Click");

            if (string.IsNullOrEmpty(txtLogin.Text))
            {
                MessageBox.Show("Login is required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!IsLoginUnique())
            {
                MessageBox.Show("Given login isn't unique", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            /*
             * 
             *    TODO 
             * 
             * 
             */
        }

        private bool IsLoginUnique()
        {
             // some code

             return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _activityLogger.Show("btnCancel Click");
            this.Close();
        }
    }
}
