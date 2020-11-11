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
    public partial class SearchWindow : UserControl
    {
        public SearchWindow()
        {
            InitializeComponent();
        }
        private void HideFunc()
        {
            ProductNumBox.Hide();
            ProductNameBox.Hide();
            VolumeBox.Hide();
            ColorBox.Hide();
            WeightBox.Hide();
            amountBox.Hide();
            PrimaryLocationBox.Hide();
            PrimaryColliBox.Hide();
        }
        private void ShowFunc()
        {
            ProductNumBox.Show();
            ProductNameBox.Show();
            VolumeBox.Show();
            ColorBox.Show();
            WeightBox.Show();
            amountBox.Show();
            PrimaryLocationBox.Show();
            PrimaryColliBox.Show();
        }
        private void CheckIfEmptyBox()
        {
            if (PrimaryColliBox.Text == "") { PrimaryColliBox.Text = PrimaryColliLabel.Text; }
            PrimaryColliLabel.Text = PrimaryColliBox.Text;
            if (PrimaryLocationBox.Text == "") { PrimaryLocationBox.Text = PrimaryLocationLabel.Text; }
            PrimaryLocationLabel.Text = PrimaryLocationBox.Text;
            if (ProductNumBox.Text == "") { ProductNumBox.Text = ProductNumLabel.Text; }
            ProductNumLabel.Text = ProductNumBox.Text;
            if (ProductNameBox.Text == "") { ProductNameBox.Text = ProductNameLabel.Text; }
            ProductNameLabel.Text = ProductNameBox.Text;
            if (VolumeBox.Text == "") { VolumeBox.Text = VolumeLabel.Text; }
            VolumeLabel.Text = VolumeBox.Text;
            if (ColorBox.Text == "") { ColorBox.Text = ColorLabel.Text; }
            ColorLabel.Text = ColorBox.Text;
            if (WeightBox.Text == "") { WeightBox.Text = WeightLabel.Text; }
            WeightLabel.Text = WeightBox.Text;
            if (amountBox.Text == "") { amountBox.Text = AmountLabel.Text; }
            AmountLabel.Text = amountBox.Text;
        }

        private void SearchWindow_Load(object sender, EventArgs e)
        {
            SaveButton.Hide();
            HideFunc();
            
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            SaveButton.Show();
            EditButton.Hide();
            ShowFunc();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            EditButton.Show();
            SaveButton.Hide();
            HideFunc();
            CheckIfEmptyBox();
        }
    }
}
