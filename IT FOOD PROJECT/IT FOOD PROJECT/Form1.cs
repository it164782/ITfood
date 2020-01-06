using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT_FOOD_PROJECT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SidePanel.Height = HomePageButton.Height;
            SidePanel.Top = HomePageButton.Top;
        }

        private void HomePageButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = HomePageButton.Height;
            SidePanel.Top = HomePageButton.Top;
        }

        private void ShopsButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = ShopsButton.Height;
            SidePanel.Top = ShopsButton.Top;
        }

        private void AdressButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = AdressButton.Height;
            SidePanel.Top = AdressButton.Top;
        }

        private void OrderHistoryButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = OrderHistoryButton.Height;
            SidePanel.Top = OrderHistoryButton.Top;
        }

        private void PaymentWayButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = PaymentWayButton.Height;
            SidePanel.Top = PaymentWayButton.Top;
        }

        private void FavButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = FavButton.Height;
            SidePanel.Top = FavButton.Top;
        }

        private void RatingsButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = RatingsButton.Height;
            SidePanel.Top = RatingsButton.Top;
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
