using HotelReservation_EF.ReservationEntity;
using MetroFramework.Forms;
using Microsoft.EntityFrameworkCore;
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
    public partial class Form1 : MetroForm
    {
        ReservationContext Context;
        BindingSource bindingSource;
        BindingList<Reservation> reservations;

        public Form1()
        {
            InitializeComponent();
            Context = new ReservationContext();
            this.FormClosed += (sender, e) => Context?.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Context.Reservation.Load();
            reservations = Context.Reservation.Local.ToBindingList();
            lstReservations.DataSource = reservations;
            bindingSource = new BindingSource(reservations, "");
            lstReservations.DisplayMember = "DisplayRes";
            lstReservations.ValueMember = "Id";
            txtFName.DataBindings.Add("Text", reservations, "FirstName");
            txtLName.DataBindings.Add("Text", reservations, "LastName");
            txtBirthDay.DataBindings.Add("Text", reservations, "BirthDay");
            txtGender.DataBindings.Add("Text", reservations, "Gender");
            txtPhone.DataBindings.Add("Text", reservations, "PhoneNumber");
            txtEmail.DataBindings.Add("Text", reservations, "EmailAddress");
            txtNoOfGuests.DataBindings.Add("Text", reservations, "NumberGuest");
            txtStreet.DataBindings.Add("Text", reservations, "StreetAddress");
            txtAptNo.DataBindings.Add("Text", reservations, "AptSuite");
            txtCity.DataBindings.Add("Text", reservations, "City");
            txtState.DataBindings.Add("Text", reservations, "State");
            txtZipcode.DataBindings.Add("Text", reservations, "ZipCode");
            txtRoomType.DataBindings.Add("Text", reservations, "RoomType");
            txtFloor.DataBindings.Add("Text", reservations, "RoomFloor");
            txtRoomNo.DataBindings.Add("Text", reservations, "RoomNumber");
            txtEntryDate.DataBindings.Add("Text", reservations, "ArrivalTime");
            txtDepartureDate.DataBindings.Add("Text", reservations, "LeavingTime");
            checkBoxCheckIn.DataBindings.Add("Checked", reservations, "CheckIn");
            checkBoxFoodSupplyStat.DataBindings.Add("Checked", reservations, "SupplyStatus");

            srchDataGridView.DataSource = reservations;

            rsrvDataGridView.DataSource = reservations;

           
            rsrvDataGridView.Columns["Id"].ReadOnly = true;

            bindingSource.AddingNew += (sender, e) => e.NewObject = new Reservation() { FirstName = "", LastName = "", BirthDay = "", Gender = "", PhoneNumber = "", EmailAddress = "", NumberGuest = 0, StreetAddress = "", AptSuite = "", City = "", State = "", ZipCode = "", RoomType = "", RoomFloor = "", RoomNumber = "", TotalBill = 0, PaymentType = "", CardType = "", CardNumber = "", CardExp = "", CardCvc = "", ArrivalTime = new DateTime(2000, 1, 1), LeavingTime = new DateTime(2000, 1, 1), CheckIn = false, BreakFast = 0, Lunch = 0, Dinner = 0, Cleaning = false, Towel = false, SSurprise = false, SupplyStatus = false, FoodBill = 0 };
            roomOccupiedListBox.DataSource = reservations.Where(x => x.CheckIn == true).ToList();
            roomReservedListBox.DataSource = reservations.Where(x => x.CheckIn == false).ToList();
            roomOccupiedListBox.DisplayMember = "DisplayOccupiedLst";
            roomOccupiedListBox.ValueMember = "Id";
            roomReservedListBox.DisplayMember = "DisplayReservedLst";
            roomReservedListBox.ValueMember = "Id";
        }

        private void btnFoodAndMenu_Click(object sender, EventArgs e)
        {
            FoodAndMenu foodAndMenufrm = new FoodAndMenu(reservations);
            foodAndMenufrm.Show();
            foodAndMenufrm.Focus();
        }

        private void btnFinalizeBill_Click(object sender, EventArgs e)
        {
            FinalizeBill finalizeBillfrm = new FinalizeBill(reservations);
            finalizeBillfrm.Show();
            finalizeBillfrm.Focus();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            bindingSource.AddingNew += (sender, e) => e.NewObject = new Reservation() { FirstName = "", LastName = "", BirthDay = "", Gender = "", PhoneNumber = "", EmailAddress = "", NumberGuest = 0, StreetAddress = "", AptSuite = "", City = "", State = "", ZipCode = "", RoomType = "", RoomFloor = "", RoomNumber = "", TotalBill = 0, PaymentType = "", CardType = "", CardNumber = "", CardExp = "", CardCvc = "123", ArrivalTime = new DateTime(2000, 1, 1), LeavingTime = new DateTime(2000, 1, 1), CheckIn = false, BreakFast = 0, Lunch = 0, Dinner = 0, Cleaning = false, Towel = false, SSurprise = false, SupplyStatus = false, FoodBill = 0 };
            bindingSource.AddNew();

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Context.SaveChanges();
            lstReservations.DataSource = null;
            lstReservations.DataSource = reservations;
            lstReservations.DisplayMember = "DisplayRes";
            lstReservations.ValueMember = "Id";
            roomOccupiedListBox.DataSource = null;
            roomReservedListBox.DataSource = null;
            roomOccupiedListBox.DataSource = reservations.Where(x => x.CheckIn == true).ToList();
            roomReservedListBox.DataSource = reservations.Where(x => x.CheckIn == false).ToList();
            roomOccupiedListBox.DisplayMember = "DisplayOccupiedLst";
            roomOccupiedListBox.ValueMember = "Id";
            roomReservedListBox.DisplayMember = "DisplayReservedLst";
            roomReservedListBox.ValueMember = "Id";
            rsrvDataGridView.Refresh();


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bindingSource.Remove(lstReservations.SelectedItem);
            Context.SaveChanges();
            lstReservations.DataSource = null;
            lstReservations.DataSource = reservations;
            lstReservations.DisplayMember = "DisplayRes";
            lstReservations.ValueMember = "Id";
            roomOccupiedListBox.DataSource = null;
            roomReservedListBox.DataSource = null;
            roomOccupiedListBox.DataSource = reservations.Where(x => x.CheckIn == true).ToList();
            roomReservedListBox.DataSource = reservations.Where(x => x.CheckIn == false).ToList();
            roomOccupiedListBox.DisplayMember = "DisplayOccupiedLst";
            roomOccupiedListBox.ValueMember = "Id";
            roomReservedListBox.DisplayMember = "DisplayReservedLst";
            roomReservedListBox.ValueMember = "Id";
            rsrvDataGridView.Refresh();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Context.SaveChanges();
            lstReservations.DataSource = null;
            lstReservations.DataSource = reservations;
            lstReservations.DisplayMember = "DisplayRes";
            lstReservations.ValueMember = "Id";
            roomOccupiedListBox.DataSource = null;
            roomReservedListBox.DataSource = null;
            roomOccupiedListBox.DataSource = reservations.Where(x => x.CheckIn == true).ToList();
            roomReservedListBox.DataSource = reservations.Where(x => x.CheckIn == false).ToList();
            roomOccupiedListBox.DisplayMember = "DisplayOccupiedLst";
            roomOccupiedListBox.ValueMember = "Id";
            roomReservedListBox.DisplayMember = "DisplayReservedLst";
            roomReservedListBox.ValueMember = "Id";
            rsrvDataGridView.Refresh();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtSearch.Text))
            {

                srchDataGridView.DataSource = null;
                this.srchDataGridView.DataSource =reservations;
            }
            else
            {

                var filteredData = reservations
                    .Where(x => (x.FirstName.ToLower()).Contains((this.txtSearch.Text).Trim().ToLower()));
                //reservations.Where(x => EF.Functions.Like(x.FirstName, $"%{(txtSearch.Text).Trim()}%")).ToList();
                this.srchDataGridView.DataSource = null;
                this.srchDataGridView.DataSource = filteredData.ToList();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rsrvDataGridView.EndEdit();
            Context.SaveChanges();
            rsrvDataGridView.Refresh();
        }
    }
}
