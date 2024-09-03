using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFCoreApp.Data;
using EFCoreApp.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void insertBtn_Click(object sender, EventArgs e)
        {
            using (var context = new ApplicationDbContext())
            {
                await context.Database.EnsureCreatedAsync();
            }

            using (var context = new ApplicationDbContext())
            {
                var person = new Person()
                {
                    FirstName = firstNameTxtbox.Text,
                    LastName = lastNameTxtbox.Text,
                    Email = emailTxtbox.Text,
                    PhoneNumber = phoneNumberTxtbox.Text,
                    Address = addressTxtbox.Text,
                };

                var corporate = new Corporate()
                {
                    JobTitle = jobTitleTxtbox.Text,
                    Education = educationTxtbox.Text,
                    Experience = Convert.ToInt32(experienceTxtbox.Text),
                    Salary = Convert.ToInt64(salaryTxtbox.Text)
                };

                context.personContext.Add(person);
                context.corporateContext.Add(corporate);

                await context.SaveChangesAsync();

                MessageBox.Show("Successfully Inserted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
        }
    }
}
