using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class ListItem : UserControl
    {
        public ListItem()
        {
            InitializeComponent();
        }

        private void ListItem_Load(object sender, EventArgs e)
        {

        }
        // hej
        #region Properties

        private string _name;
        private string _workerID;
        private string _role;
        private string _lastLog;
        private Image _picture;

        [Category("Custom Properties")]
        public string EmployeeName
        {
            get { return _name; }
            set { _name = value; NameInput.Text = value; }
        }

        [Category("Custom Properties")]
        public string WorkerID
        {
            get { return _workerID; }
            set { _workerID = value; WorkerIDInput.Text = value; }
        }

        [Category("Custom Properties")]
        public string Role
        {
            get { return _role; }
            set { _role = value; RoleInput.Text = value; }
        }

        [Category("Custom Properties")]
        public string LastLog
        {
            get { return _lastLog; }
            set { _lastLog = value; LastLogInput.Text = value; }
        }

        [Category("Custom Properties")]
        public Image Picture
        {
            get { return _picture; }
            set { _picture = value; pictureBox1.Image = value; }
            }

    }

        #endregion

}
