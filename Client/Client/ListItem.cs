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
        public ListItem()
        {
            InitializeComponent();
        }

        // Event der trigger når man trykker ListItem eller nogen af alle dens underkomponenter
        public event EventHandler<EventArgs> WasClicked;


        private void ListItem_Load(object sender, EventArgs e)
        {
            this.Size = new Size(300, 350);
            //Placerer label i midten af WorkerIDPanel
            int x = (WorkerIDPanel.Size.Width - WorkerIDInput.Size.Width) / 2;
            WorkerIDInput.Location = new Point(x, WorkerIDInput.Location.Y);
            //Placerer PictureBox i midten af HeaderPanel
            pictureBox1.Location = new Point((HeaderPanel.Size.Width /2) - (pictureBox1.Size.Width / 2), (HeaderPanel.Size.Height / 2 + (WorkerIDInput.Height / 2)) - (pictureBox1.Size.Height / 2));

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
        private string _lastLog;
        private Image _picture;


        [Category("Custom Properties")]
        public string EmployeeName
        {
            get { return _name; }
            set { _name = value; NameInput.Text = value; }
        }

        [Category("Custom Properties")]
        public int WorkerID
        {
            get { return _workerID; }
            set { _workerID = value; WorkerIDInput.Text = ("ID#" + value.ToString()); }
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


        #endregion

        private bool _selected;
        public bool Selected
        {
            get { return _selected; }
            set { _selected = value; this.BorderStyle = Selected ? BorderStyle.Fixed3D : BorderStyle.FixedSingle; this.BackColor = Selected ? SystemColors.Highlight : SystemColors.ControlLight; }
        }

    }
}
