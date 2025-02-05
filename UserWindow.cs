using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test.Models;

namespace Test
{
    public partial class UserWindow : Form
    {
        DataBaseContext db = new DataBaseContext();
        Match match = new Match();
        Tickets tickets = new Tickets();
        Users users = new Users();
        UserTickets userTickets = new UserTickets();
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Test.Models.DataBaseContext;Integrated Security=True;Connect Timeout=30";
        int loggedUserId;
        string loggedUserFullName;

        public UserWindow()
        {
            InitializeComponent();
            labelUserId.Text = Login.instance.userId.ToString();
            SetUserIdAndFullName(Convert.ToInt16(labelUserId.Text));
            
        }

        private void SetUserIdAndFullName(int userId)
        {
            List<Users> usersList = db.Users.ToList();
            var loggedUser = usersList.Where(c => c.Id == userId).Single();

            loggedUserId = loggedUser.Id;
            loggedUserFullName = loggedUser.FullName;
        }

        private void GetUpcommingMatches()
        {
            DateTime dateTimeNow = DateTime.Now;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from Matches where (GameDate) >= (@Date)", conn))
                {
                    cmd.Parameters.AddWithValue("@Date", dateTimeNow);
                    cmd.CommandType = CommandType.Text;
                    conn.Open();
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            dataGridViewUpcomming.DataSource = dt;

                        }

                    }
                    conn.Close();
                }
            }
        }

        // 
        public void GetMatchBasedOnFilters(string homeTeam, string guestTeam)
        {
            DateTime dateTimeNow = DateTime.Now;

            //dataGridViewUpcomming.DataSource = null;
            //dataGridViewUpcomming.Rows.Clear();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from Matches " +
                    "where (GameDate) >= (@Date) and (HomeTeam) like @HomeTeam and (GuestTeam) like @GuestTeam", conn))
                {
                    cmd.Parameters.AddWithValue("@Date",  dateTimeNow);
                    cmd.Parameters.AddWithValue("@HomeTeam", "%" + homeTeam + "%");
                    cmd.Parameters.AddWithValue("@GuestTeam", "%" + guestTeam + "%");
                    cmd.CommandType = CommandType.Text;
                    conn.Open();
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            dataGridViewUpcomming.DataSource = dt;

                        }

                    }
                    conn.Close();
                }
            }
        }

        private void GetAvailableTickets()
        {
            DateTime dateTimeNow = DateTime.Now;

            
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("Select match.HomeTeam, match.GuestTeam, match.GameDate, match.Id 'Match number' ,ticket.TicketNumber from Matches as match " +
                    "join Tickets as ticket on match.Id = ticket.MatchId where ticket.IsSold = 0" 
                    , conn))
                {
                    cmd.Parameters.AddWithValue("@Date", dateTimeNow);
                    
                    cmd.CommandType = CommandType.Text;
                    conn.Open();
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            dataGridBuyAvailableTickets.DataSource = dt;

                        }

                    }
                    conn.Close();
                }
            }
        }

        private void BuyTicketForMatch(int matchId, int ticketNumber)
        {
           // List<Tickets> ticketsToCheck = db.Tickets;
            var check = db.Tickets
                .Where(c => c.MatchId == matchId)
                .Where(d => d.TicketNumber == ticketNumber)
                .Where(e => e.IsSold == false)
                .SingleOrDefault();
              

            
            if (check != null) 
            {

                check.IsSold = true;
                check.UserId = loggedUserId;
                check.FullName = loggedUserFullName;
                              
                db.SaveChanges();
                
               
                userTickets.TicketNumber = ticketNumber;
                userTickets.UserId = loggedUserId;
                userTickets.MatchId = matchId;               
                db.UserTickets.Add(userTickets);
                db.SaveChanges();

                MessageBox.Show($"Brawo ! Kupiłeś bilet o numerze {ticketNumber} na mecz o numerze {matchId}");
            }
            else
            {
                MessageBox.Show("Either ticket number is already sold or match number/ticket number are incorrect. " +
                    "Please check again list of available tickets");
            }
        }

        private void GetMyTickets()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("Select match.GameDate, match.HomeTeam, match.GuestTeam, uticket.TicketNumber from " +
                    "UserTickets as uticket " +
                    "Join Matches as match on uticket.MatchId = match.Id " +
                    "where uticket.UserId = @userId"
                    , conn))
                {
                    cmd.Parameters.AddWithValue("@userId", Convert.ToInt16(Login.instance.userId));

                    cmd.CommandType = CommandType.Text;
                    conn.Open();
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            dataGridViewUserMyTickets.DataSource = dt;

                        }

                    }
                    conn.Close();
                }
            }
        }
        // zakładka 'Users'
        private void buttonUpcomming_Click(object sender, EventArgs e)
        {
            GetUpcommingMatches();
        }

        // zakładka 'Users'
        private void buttonUserGetMatchFilter_Click(object sender, EventArgs e)
        {
            GetMatchBasedOnFilters(textUserFilterHomeTeam.Text, textUserFilterGuestTeam.Text);
        }

        // Zakładka 'Users'
        private void buttonGetAvailableTickets_Click(object sender, EventArgs e)
        {
            GetAvailableTickets();
        }

        private void buttonBuyTicket_Click(object sender, EventArgs e)
        {
            BuyTicketForMatch(Convert.ToInt16(numericBuyMatchId.Value), Convert.ToInt16(numericBuyTicketNumber.Value));
        }

        private void buttonUserGetMyTickets_Click(object sender, EventArgs e)
        {
            GetMyTickets();
        }
    }
}
