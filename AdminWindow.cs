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
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("Select * from Matches", conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        conn.Open();
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                dataGridViewMatch.DataSource = dt;

                            }

                        }
                        conn.Close();
                    }
                }
            }
            else
            {
                DateTime dateTime = DateTime.Now;
                String stringDateTime = dateTime.ToString("dd-MM-yyyy HH:mm:ss");

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("Select * from Matches Where (GameDate) >= (@Date)", conn))
                    {
                        cmd.Parameters.AddWithValue("@Date", dateTime);
                        cmd.CommandType = CommandType.Text;
                        conn.Open();
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                dataGridViewMatch.DataSource = dt;

                            }

                        }
                        conn.Close();
                    }
                }
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
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("Select * from Tickets Where (MatchId) >= (@matchId)", conn))
                    {
                        cmd.Parameters.AddWithValue("@matchId", matchId);
                        cmd.CommandType = CommandType.Text;
                        conn.Open();
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                dataGridViewTickets.DataSource = dt;

                            }

                        }
                        conn.Close();
                    }
                }                  
        }

        // Zakładka 'Bielty'
        public void GenerateTicketsForMarch(int matchId, int newmaxtickets)
        {
            List<Tickets> tickets2 = db.Tickets.ToList();


            
                int maxNumberOfticketForMatch = tickets2.Where(c => c.MatchId == matchId).Select(d => d.TicketNumber).DefaultIfEmpty(0).Max();

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

        // Zadkładka 'Users'
        public void GetUsers()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from Users", conn))
                {
                    cmd.CommandType = CommandType.Text;
                    conn.Open();
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            dataGridViewUsers.DataSource = dt;
                        }
                    }
                    conn.Close();
                }
            }
        }

        // Zakładka 'Mecze'
        private void buttonGetMatches_Click(object sender, EventArgs e)
        {

            GetMatches();        
                       
            
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
    }
}
