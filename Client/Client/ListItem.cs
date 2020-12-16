using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace Client
{
    public partial class ListItem : UserControl
    {
        public ListItem(string employeeName, int workerID, string role)
        {
            InitializeComponent();

            EmployeeName = employeeName;
            WorkerID = workerID;
            Role = role;
            //LastLog = lastlog;
        }
        public ListItem()
        {
            InitializeComponent();
        }

        // Event der trigger når man trykker ListItem eller nogen af alle dens underkomponenter
        public event EventHandler<EventArgs> WasClicked;


        private void ListItem_Load(object sender, EventArgs e)
        {
            this.Size = new Size(320, 260);
            int x;
            //Placerer label i midten af WorkerIDPanel
            x = (headerPanel.Size.Width / 2) - (workerIDLabel.Size.Width / 2);
            //workerIDLabel.Location = new Point(x, workerIDLabel.Location.Y);
            //Placerer PictureBox i midten af HeaderPanel

            //Tilføjer mouseclick
            this.MouseClick += Control_MouseClick;
            RegisterMouseClickForChildren(Controls);
        }


        //Tilføjer mouse click til ListItem og alle dens underelementer rekursivt
        private void RegisterMouseClickForChildren(ControlCollection controls)
        {
            foreach(Control control in controls)
            {
                control.MouseClick += Control_MouseClick;
                if (control.HasChildren)
                {
                    RegisterMouseClickForChildren(control.Controls);
                }
            }
        }


        //Det der sker ved et mouse click
        private void Control_MouseClick(object sender, MouseEventArgs e)
        {
            bool isAlreadySelected = Selected;
            var wasClicked = WasClicked;
            if (wasClicked != null)
            {
                WasClicked(this, EventArgs.Empty);
            }
            
            if (isAlreadySelected)
            {
                Selected = false;
            }
            else
            {
                Selected = true;
            }
        }

        #region Properties

        private string _name;
        private int _workerID;
        private string _role;
        //private string _lastLog;
        private bool _selected;

        public string EmployeeName
        {
            get { return _name; }
            set { _name = value; employeeNameLabel.Text = _name; }
        }
        public int WorkerID
        {
            get { return _workerID; }
            set { _workerID = value; workerIDLabel.Text = (value.ToString()); }
        }
        public string Role
        {
            get { return _role; }
            set { _role = value; employeeRoleLabel.Text = value; }
        }
        
        public bool Selected
        {
            get { return _selected; }
            set { _selected = value; this.BorderStyle = Selected ? BorderStyle.Fixed3D : BorderStyle.FixedSingle; this.BackColor = Selected ? SystemColors.Highlight : Color.FromArgb(51, 51, 51); }
        }

        #endregion
    }
}
