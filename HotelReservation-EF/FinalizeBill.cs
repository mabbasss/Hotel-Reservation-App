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
    public partial class FinalizeBill : MetroForm
    {
        BindingList<Reservation> reservations;
        public FinalizeBill(BindingList<Reservation> res)
        {
            InitializeComponent();
            reservations = res;
        }

        private void FinalizeBill_Load(object sender, EventArgs e)
        {
            lblFoodBill.DataBindings.Add("Text", reservations, "FoodBill");
            lblTotal.DataBindings.Add("Text", reservations, "TotalBill");
            txtPaymentType.DataBindings.Add("Text", reservations, "PaymentType");
            txtCardNo.DataBindings.Add("Text", reservations, "CardNumber");
            txtCardExp.DataBindings.Add("Text", reservations, "CardExp");
            txtCVC.DataBindings.Add("Text", reservations, "CardCvc");
            lblCurrentBill.DataBindings.Add("Text", reservations, "FoodBill");
            lblTax.Text = Math.Round(double.Parse(lblTotal.Text) * 0.14).ToString();
        }

        private void btnDoneBill_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
