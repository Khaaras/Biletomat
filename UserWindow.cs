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
            
            var upcommingMatches = db.Match.Where(m => m.GameDate > dateTimeNow).ToList();
            dataGridViewUpcomming.DataSource = upcommingMatches;

            dataGridViewUpcomming.Columns["Id"].HeaderText = "Match number";
            dataGridViewUpcomming.Columns["HomeTeam"].HeaderText = "Home team";
            dataGridViewUpcomming.Columns["GuestTeam"].HeaderText = "Guest team";
            dataGridViewUpcomming.Columns["GameDate"].HeaderText = "Date";
            dataGridViewUpcomming.Columns["TypeOfEvent"].HeaderText = "Type of event";
        }

        // 
        public void GetMatchBasedOnFilters(string homeTeam, string guestTeam)
        {
            DateTime dateTimeNow = DateTime.Now;
           
            var getMatchBassedOnFilters = db.Match.Where(m => m.GameDate > dateTimeNow)
                .Where(t => t.HomeTeam.Contains(homeTeam))
                .Where(c => c.GuestTeam.Contains(guestTeam))
                .ToList();
            dataGridViewUpcomming.DataSource = getMatchBassedOnFilters;

            dataGridViewUpcomming.Columns["Id"].HeaderText = "Match number";
            dataGridViewUpcomming.Columns["HomeTeam"].HeaderText = "Home team";
            dataGridViewUpcomming.Columns["GuestTeam"].HeaderText = "Guest team";
            dataGridViewUpcomming.Columns["GameDate"].HeaderText = "Date";
            dataGridViewUpcomming.Columns["TypeOfEvent"].HeaderText = "Type of event";
        }

        private void GetAvailableTickets()
        {
            DateTime dateTimeNow = DateTime.Now;
                       
            var getAvailableTickets = (from m in db.Match
                                       join t in db.Tickets
                                       on m.Id equals t.MatchId
                                       where t.IsSold == false
                                       select new
                                       {
                                           m.Id,
                                           m.HomeTeam,
                                           m.GuestTeam,
                                           m.GameDate,
                                           t.TicketNumber

                                       }).ToList();
            dataGridBuyAvailableTickets.DataSource = getAvailableTickets;

            dataGridBuyAvailableTickets.Columns["Id"].HeaderText = "Match number";
            dataGridBuyAvailableTickets.Columns["HomeTeam"].HeaderText = "Home team";
            dataGridBuyAvailableTickets.Columns["GuestTeam"].HeaderText = "Guest team";
            dataGridBuyAvailableTickets.Columns["GameDate"].HeaderText = "Date";
            dataGridBuyAvailableTickets.Columns["TicketNumber"].HeaderText = "Ticket number";
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
            
            var getMyTickets = (from u in db.UserTickets
                                join m in db.Match
                                on u.MatchId equals m.Id
                                where u.UserId == loggedUserId
                                select new
                                {
                                    m.GameDate,
                                    m.HomeTeam,
                                    m.GuestTeam,
                                    u.TicketNumber
                                }).ToList();

            dataGridViewUserMyTickets.DataSource = getMyTickets;

            dataGridViewUserMyTickets.Columns["GameDate"].HeaderText = "Game date";
            dataGridViewUserMyTickets.Columns["HomeTeam"].HeaderText = "Home team";
            dataGridViewUserMyTickets.Columns["GuestTeam"].HeaderText = "Guest team";
            dataGridViewUserMyTickets.Columns["TicketNumber"].HeaderText = "Ticket number";
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
            GetAvailableTickets();
        }

        private void buttonUserGetMyTickets_Click(object sender, EventArgs e)
        {
            GetMyTickets();
        }
    }
}
