using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Test.Models
{
    public partial class AdminWindow : Form
    {
        DataBaseContext db = new DataBaseContext();
        Match match = new Match();
        Tickets tickets = new Tickets();

        //string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Test.Models.DataBaseContext;Integrated Security=True;Connect Timeout=30";
        string connectionString = ConfigurationManager.ConnectionStrings["BiletyContext"].ToString();


        public AdminWindow()
        {
            InitializeComponent();
            //this.DataBindMatch();
        }

        // Zakładka 'Mecze'
        public void GetMatches()
        {
            if (checkBoxFutreMatches.Checked == false)
            {
                    var matches = db.Match
                    .Select(m => new
                    {
                        MatchNumber = m.Id,
                        HomeTeam = m.HomeTeam,
                        GuestTeam = m.GuestTeam,
                        MatchDate = m.GameDate,
                        TypeOfEvent = m.TypeOfEvent,
                        TotalNumberOfTicketsForMatch = db.Tickets.Count(t => t.MatchId == m.Id),
                        AvailableTickets = db.Tickets.Where(c => c.IsSold == false).Count(t => t.MatchId == m.Id)

                    });


                dataGridViewMatch.DataSource = matches.ToList();

                //dodanie własnych nazwy 

                dataGridViewMatch.Columns["MatchNumber"].HeaderText = "Match Number";
                dataGridViewMatch.Columns["HomeTeam"].HeaderText = "Home Team";
                dataGridViewMatch.Columns["GuestTeam"].HeaderText = "Guest Team";
                dataGridViewMatch.Columns["MatchDate"].HeaderText = "GameDate";
                dataGridViewMatch.Columns["TypeOfEvent"].HeaderText = "Type of event";
                dataGridViewMatch.Columns["TotalNumberOfTicketsForMatch"].HeaderText = "Total Number of tickets for this match";
                dataGridViewMatch.Columns["AvailableTickets"].HeaderText = "Number of available tickets for this match";
            }
            else
            {
                DateTime dateTime = DateTime.Now;               

                var matches = db.Match
                  .Where(m => m.GameDate > dateTime)  
                  .Select(m => new
                  {
                      MatchNumber = m.Id,
                      HomeTeam = m.HomeTeam,
                      GuestTeam = m.GuestTeam,
                      MatchDate = m.GameDate,
                      TypeOfEvent = m.TypeOfEvent,
                      TotalNumberOfTicketsForMatch = db.Tickets.Count(t => t.MatchId == m.Id),
                      AvailableTickets = db.Tickets.Where(c => c.IsSold == false).Count(t => t.MatchId == m.Id)
                  });


                dataGridViewMatch.DataSource = matches.ToList();

                dataGridViewMatch.Columns["MatchNumber"].HeaderText = "Match Number";
                dataGridViewMatch.Columns["HomeTeam"].HeaderText = "Home Team";
                dataGridViewMatch.Columns["GuestTeam"].HeaderText = "Guest Team";
                dataGridViewMatch.Columns["MatchDate"].HeaderText = "GameDate";
                dataGridViewMatch.Columns["TypeOfEvent"].HeaderText = "Type of event";
                dataGridViewMatch.Columns["TotalNumberOfTicketsForMatch"].HeaderText = "Total Number of tickets for this match";
                dataGridViewMatch.Columns["AvailableTickets"].HeaderText = "Number of available tickets for this match";
            }
        }

        // Zakładka 'Zaplanuj mecz'
        public void CreateMatch(string homeTeam, string guestTeamm, DateTime dateTime, string typeOfEvent)
        {
            Match findSameMatch = db.Match
                .Where(x => x.HomeTeam == homeTeam)
                .Where(x => x.GuestTeam == guestTeamm)
                .Where(x => x.GameDate == dateTime).SingleOrDefault();
            

            if (findSameMatch == null)
            {
                match.HomeTeam = textCreateMatchHomeTeam.Text;
                match.GuestTeam = textCreateMatchGuestTeam.Text;
                match.GameDate = dateTimeCreateMatch.Value.Date + dateTimeCreateMatchTime.Value.TimeOfDay;
                match.TypeOfEvent = textCreateMatchTypeOfEvent.Text;


                db.Match.Add(match);

                int a = db.SaveChanges();
                if (a > 0)
                {
                    MessageBox.Show("You created a match");
                }
                else
                {
                    MessageBox.Show("Something went wrong");
                }
            }
            else
            {
                MessageBox.Show("You cannot creat same matches twice");
            }
                


           
            
        }
        // Zakładka 'Update match'
        public void GetMatch(int matchId)
        {
            
            match = db.Match.Find(matchId);

            if (match != null)
            {
                textUpdateHomeTeam.Text = match.HomeTeam;
                textUpdateGuestTeam.Text = match.GuestTeam;
                dateUpdateDate.Text = match.GameDate.ToShortDateString();
                dateUpdateTime.Text = match.GameDate.TimeOfDay.ToString();                
                textUpdateTypeOfEvent.Text = match.TypeOfEvent.ToString();
            }
            else
            {
                MessageBox.Show("Incorrect match id");
            }
            
          
        }

        

        // Zakładka 'Update match'
        public void UpdateMatch(int matchId)
        {
            
            match = db.Match.Find(matchId);

            if (match != null)
            {
                match.HomeTeam = textUpdateHomeTeam.Text;
                match.GuestTeam = textUpdateGuestTeam.Text;
                match.GameDate = dateUpdateDate.Value.Date + dateUpdateTime.Value.TimeOfDay;                
                match.TypeOfEvent = textUpdateTypeOfEvent.Text;

                db.Match.AddOrUpdate(match);
                int a = db.SaveChanges();
                if (a > 0)
                {
                    MessageBox.Show("Match updated");
                }
                else
                {
                    MessageBox.Show("Something went wrong");
                }
            }
            else
            {
                MessageBox.Show("Incorrect match id");
            }            
            
        }

        // Zakładka 'Bilety'
        public void GetTicketsForMatch(int matchId)
        {
            
            var tickets = db.Tickets.Where(t => t.MatchId == matchId)
                .Select(t => new
                {
                    
                    TicketNumber = t.TicketNumber,
                    MatchId = t.MatchId,
                    IsSold = t.IsSold,
                    UserId = t.UserId,
                    FullName = t.FullName

                }).ToList();

            dataGridViewTickets.DataSource = tickets;

            dataGridViewTickets.Columns["TicketNumber"].HeaderText = "Ticket number";
            dataGridViewTickets.Columns["MatchId"].HeaderText = "Match number";
            dataGridViewTickets.Columns["IsSold"].HeaderText = "Is ticket sold?";
            dataGridViewTickets.Columns["UserId"].HeaderText = "User number";
            dataGridViewTickets.Columns["FullName"].HeaderText = "User full name";
            

        }

        // Zakładka 'Bielty'
        public void GenerateTicketsForMarch(int matchId, int newmaxtickets)
        {
            List<Tickets> tickets2 = db.Tickets.ToList();


            
            int maxNumberOfticketForMatch = tickets2.Where(c => c.MatchId == matchId).Select(d => d.TicketNumber).DefaultIfEmpty(0).Max();

            try
            {
                for (int i = 1; i <= Convert.ToInt16(numericTicketsMatchNumberOfTickets.Value); i++)
                {
                    tickets.IsSold = false;
                    tickets.MatchId = matchId;
                    tickets.TicketNumber = Convert.ToInt16(maxNumberOfticketForMatch) + i;
                    tickets.FullName = "";
                    tickets.UserId = null;


                    db.Tickets.Add(tickets);

                    int a = db.SaveChanges();
                    if (a > 0)
                    {
                        MessageBox.Show("You created a ticket");
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong");
                    }
                }
            }
            catch (DbEntityValidationException eve)
            {
                foreach (var exe in eve.EntityValidationErrors)
                {
                    foreach (var ex in exe.ValidationErrors)
                        MessageBox.Show(ex.ErrorMessage);
                }      
                throw;
            }   
        }

        // Zadkładka 'Users'
        public void GetUsers()
        {            
            var getUsers = db.Users.Select(u => new
            {
                Id = u.Id,
                FirstName = u.FirstName,
                LastName = u.LastName
            }).ToList();
            dataGridViewUsers.DataSource = getUsers;

            dataGridViewUsers.Columns["Id"].HeaderText = "User number";
            dataGridViewUsers.Columns["FirstName"].HeaderText = "First name";
            dataGridViewUsers.Columns["LastName"].HeaderText = "Last name";
        }
        
        // Zakładka 'Mecze'
        private void buttonGetMatches_Click(object sender, EventArgs e)
        {
            GetMatches();  
        }

        private void GetUserTickets(int userId)
        {
           
            var getUserTickets = (from u in db.UserTickets
                                 join m in db.Match
                                 on u.MatchId equals m.Id
                                 where u.UserId == userId
                                 select new
                                 {
                                     m.GameDate,
                                     m.HomeTeam,
                                     m.GuestTeam,
                                     u.TicketNumber
                                 }).ToList();

            dataGridViewUsersUserTicket.DataSource = getUserTickets;

            dataGridViewUsersUserTicket.Columns["GameDate"].HeaderText = "Game date";
            dataGridViewUsersUserTicket.Columns["HomeTeam"].HeaderText = "Home team";
            dataGridViewUsersUserTicket.Columns["GuestTeam"].HeaderText = "Guest team";
            dataGridViewUsersUserTicket.Columns["TicketNumber"].HeaderText = "Ticket number";
        }

        // Zakładka 'Update match'
        private void buttonUpdateUpdate_Click(object sender, EventArgs e)
        {
            UpdateMatch(Convert.ToInt16(numericUpdateMatchId.Text));
        }

        // Zakładka 'Bilety'
        private void buttonTicketsGetMatchInfo_Click(object sender, EventArgs e)
        {
            GetTicketsForMatch(Convert.ToInt16(numericTickersMatchId.Text));
        }
        // Zakładka 'Bilety'
        private void buttonTicketsCreate_Click(object sender, EventArgs e)
        {
            GenerateTicketsForMarch(Convert.ToInt16(numericTickersMatchId.Text), Convert.ToInt16(numericTicketsMatchNumberOfTickets.Value));
        }

        // Zakładka 'Zaplanuj mecz'
        private void buttonCreateMatchCreate_Click(object sender, EventArgs e)
        {
            CreateMatch(textCreateMatchHomeTeam.Text, textCreateMatchGuestTeam.Text
                , dateTimeCreateMatch.Value.Date + dateTimeCreateMatchTime.Value.TimeOfDay, textCreateMatchTypeOfEvent.Text);
        }

        // Zakładka 'Users'
        private void buttonUsersGetUsers_Click(object sender, EventArgs e)
        {
            GetUsers();
        }

        private void buttonUpdateGetMatchInfo_Click(object sender, EventArgs e)
        {
            GetMatch(Convert.ToInt16(numericUpdateMatchId.Value));
        }
 
        private void dataGridViewUsers_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                int selectedUserId = Convert.ToInt16(dataGridViewUsers.SelectedRows[0].Cells["Id"].Value);
                GetUserTickets(selectedUserId);
            }
        }

        private void dataGridViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedUserId = Convert.ToInt16(dataGridViewUsers.Rows[dataGridViewUsers.CurrentCell.RowIndex].Cells["Id"].Value.ToString());
            GetUserTickets(selectedUserId);

        }
    }
}
