using System;
using System.Windows.Forms;
using Tours.ImpRepositories;
using Tours.Repositories;
using Serilog;

namespace Tours
{
    public partial class FormAuth : Form
    {
        string Login = "", Password = "";
        private readonly ToursContext db;
        IBookingRepository bookingRep;

        public FormAuth()
        {
            InitializeComponent();

            var log = new LoggerConfiguration()
                .WriteTo.File("LogFileAuth.txt")
                .CreateLogger();

            db = new ToursContext(ConfigManager.GetConnectionString(AccessLevel.Manager));
            bookingRep = new BookingRepository(db, log);
        }

        private void ArichTextBoxLogin_TextChanged(object sender, EventArgs e)
        {
            Login = ArichTextBoxLogin.Text;
        }

        private void ArichTextBoxPass_TextChanged(object sender, EventArgs e)
        {
            Password = ArichTextBoxPass.Text;
        }

        private void AbuttonAuth_Click(object sender, EventArgs e)
        {
            Booking user = bookingRep.GetUserByLP(Login, Password);
            if (user != null)
            {
                int accessLvl = (int)user.Accesslevel;
                int userID = user.Customer;
                Form1 userForm = new Form1((AccessLevel)accessLvl, userID);
                userForm.Show();
            }
            else
            {
                MessageBox.Show("Проверьте логин и пароль");
            }
        }

        private void AlinkLabelGuest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 guestForm = new Form1(AccessLevel.Guest);
            guestForm.Show();
        }
    }
}
