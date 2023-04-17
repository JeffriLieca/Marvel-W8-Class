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
using MySql.Data.MySqlClient;

namespace praktikum_W8
{
    public partial class Form1 : Form
    {
        string simpen = "";
        string nyimpen = "";
        int m = 0;
        string connectionstring = "server=localhost;uid=root;pwd=;database=premier_league";
        MySqlConnection mySqlConnection;
        MySqlCommand mySqlCommand;
        MySqlDataAdapter SqlDataAdapter;
        string sqlquery;
        DataTable a1 = new DataTable();
        DataTable a2 = new DataTable();
        DataTable a3 = new DataTable();
        DataTable a4 = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mySqlConnection = new MySqlConnection(connectionstring);
            mySqlConnection.Open();
            sqlquery = "SELECT team_name as `Team Name`, team_id as `Team ID` FROM team;";
            mySqlCommand = new MySqlCommand(sqlquery, mySqlConnection);
            SqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
            SqlDataAdapter.Fill(a1);
            box.DataSource = a1;
            box.DisplayMember = "Team Name";
            box.ValueMember = "Team ID";
        }

        private void teamDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m = 0;
            data2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (m == 0)
            {
                a2 = new DataTable();
                simpen = box.Text.ToString();
                sqlquery = "SELECT player_name as `Player Name`, team_name as `Team Name`, playing_pos as `Player Position`, weight as `Weight`, height as `Height` FROM player p, team t\r\nwhere p.team_id = t.team_id and team_name = " + "\"" + simpen + "\"" + ";";
                mySqlCommand = new MySqlCommand(sqlquery, mySqlConnection);
                SqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
                SqlDataAdapter.Fill(a2);
                data1.DataSource = a2;

                a3 = new DataTable();
                nyimpen = box.SelectedValue.ToString();
                sqlquery = "SELECT manager_name as `Mananger Name`, m.birthdate as `Birth Date`, m.nationality_id as `National ID` FROM manager m, player p\r\nwhere m.manager_id = p.player_id and p.team_id = " + "\"" + nyimpen + "\"" + ";";
                mySqlCommand = new MySqlCommand(sqlquery, mySqlConnection);
                SqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
                SqlDataAdapter.Fill(a3);
                data2.DataSource = a3;
            }
            else if (m == 1)
            {
                a4 = new DataTable();
                nyimpen = box.SelectedValue.ToString();
                sqlquery = $"SELECT t1.team_name as `Home Team`, t2.team_name as `Away Team`, match_date as `Match Date`, goal_home as `Home Goal`, goal_away as `Away Goal`, r.referee_name as `Referee Name` FROM `match` m, referee r, team t1, team t2\r\nwhere m.referee_id = r.referee_id and team_home = t1.team_id and team_away = t2.team_id and t1.team_id = '{nyimpen}';";
                mySqlCommand = new MySqlCommand(sqlquery, mySqlConnection);
                SqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
                SqlDataAdapter.Fill(a4);
                sqlquery = $"SELECT t1.team_name as `Home Team`, t2.team_name as `Away Team`, match_date as `Match Date`, goal_home as `Home Goal`, goal_away as `Away Goal`, r.referee_name as `Referee Name` FROM `match` m, referee r, team t1, team t2\r\nwhere m.referee_id = r.referee_id and team_home = t1.team_id and team_away = t2.team_id and t2.team_id = '{nyimpen}';";
                mySqlCommand = new MySqlCommand(sqlquery, mySqlConnection);
                SqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
                SqlDataAdapter.Fill(a4);
                data1.DataSource = a4;
            }
        }

        private void findMatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            data2.Visible = false;
            m = 1;
        }
    }
}
