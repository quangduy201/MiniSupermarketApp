﻿using BachHoaXanh.User_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BachHoaXanh
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            Homepage homepage = new Homepage();
            addUserControl(homepage);
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            Homepage homepage = new Homepage();
            addUserControl(homepage);
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            SaleControl saleControl = new SaleControl();
            addUserControl(saleControl);
        }

        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            WareHouseControl wareHouse = new WareHouseControl();
            addUserControl(wareHouse);
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            StatisticsControl statisticControl = new StatisticsControl();
            addUserControl(statisticControl);
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            DiscountControl discount = new DiscountControl();
            addUserControl(discount);
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            BillControl billControl = new BillControl();
            addUserControl(billControl);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ExportControl exportControl = new ExportControl();
            addUserControl(exportControl);
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            ImportControl importControl = new ImportControl();
            addUserControl(importControl);
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ProductControl productControl = new ProductControl();
            addUserControl(productControl);
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            CategoryControl categoryControl = new CategoryControl();
            addUserControl(categoryControl);
        }

        private void btnBrand_Click(object sender, EventArgs e)
        {
            BrandControl brandControl = new BrandControl();
            addUserControl(brandControl);
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            SupplierControl supplierControl = new SupplierControl();
            addUserControl(supplierControl);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            CustomerControl customerControl = new CustomerControl();
            addUserControl(customerControl);
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            StaffControl staffControl = new StaffControl();
            addUserControl(staffControl);
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            AccountControl accountControl = new AccountControl();
            addUserControl(accountControl);
        }

        private void btnDecentralization_Click(object sender, EventArgs e)
        {
            DecentralizationControl decentralizationControl = new DecentralizationControl();
            addUserControl(decentralizationControl);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
