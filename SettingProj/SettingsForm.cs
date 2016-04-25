using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SettingProj
{
    public partial class SettingsForm : DevExpress.XtraEditors.XtraForm
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void usersGridControl_DoubleClick(object sender, EventArgs e)
        {
            (new UserEditForm()).ShowDialog();
        }

        private void aaddTesteeButton_Click(object sender, EventArgs e)
        {
            (new UserEditForm()).ShowDialog();
        }
    }
}
