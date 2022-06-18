using HotelReservation_EF.ReservationEntity;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservation_EF
{
    public partial class FoodAndMenu : MetroForm
    {
        BindingList<Reservation> reservations;
        public FoodAndMenu(BindingList<Reservation>  res)
        {
            InitializeComponent();
            reservations = res;
        }

        private void FoodAndMenu_Load(object sender, EventArgs e)
        {
            txtBreakfastQuant.DataBindings.Add("Text", reservations, "BreakFast");
            txtLunchQuant.DataBindings.Add("Text", reservations, "Lunch");
            txtDinnerQuant.DataBindings.Add("Text", reservations, "Dinner");
            checkCleaning.DataBindings.Add("Checked", reservations, "Cleaning");
            checkTowels.DataBindings.Add("Checked", reservations, "Towel");
            checkSSurprise.DataBindings.Add("Checked", reservations, "SSurprise");
            if (int.Parse(txtBreakfastQuant.Text) > 0) { checkBreakfast.Checked = true; } else { checkBreakfast.Checked = false; }
            if (int.Parse(txtLunchQuant.Text) > 0) { checkLunch.Checked = true; } else { checkLunch.Checked = false; }
            if (int.Parse(txtDinnerQuant.Text) > 0) { checkDinner.Checked = true; } else { checkDinner.Checked = false; }
        }

        private void btnFoodAndMenu_Click(object sender, EventArgs e)
        {

            this.Close();
            this.Dispose();
        }
    }
}
