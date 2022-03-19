﻿using ProjectBlue_01;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopForms
{
    public partial class Administrator : Form
    {
        private LogIn logIn;
        private Expenses expenses;
        private EmployeeEdit employeeEdit;
        private Salaries salaries;  
        private MenuGrv menu;
        public Administrator()

        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Salaries_Click(object sender, EventArgs e)
        {
            salaries = new Salaries();
            salaries.ShowDialog();
        }
        

        private void ExpensesButton_Click(object sender, EventArgs e)
        {
            expenses = new Expenses();
            expenses.ShowDialog();
        }

        private void EmployeeEdit_Click(object sender, EventArgs e)
        {
            employeeEdit = new EmployeeEdit();
            employeeEdit.ShowDialog();
        }

        private void MenuEdit_Click(object sender, EventArgs e)
        {
            menu = new MenuGrv();
            menu.ShowDialog();
        }
    }
}

