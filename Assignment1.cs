using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace FootBallLeague
{
    public class FootBallLeagueData
    {
        static void Main(String[] args)
        {
            Connection();
        }
        static void Connection()
        {
                //String cs = "Data Source =LAPTOP-MF7II6FH; Initial Catalog=Sample;Integrated Security=True";
                SqlConnection con=new SqlConnection("Data Source=.;Initial Catalog=Sample;Integrated Security=True");


                //SqlCommand com = new SqlCommand("select *from FootBallLeague1",con);
                 
                // Retreiving all winning Team Names
                   SqlCommand com = new SqlCommand("select WinningTeam from FootBallLeague1  where Status='Win' ", con);

                // Create view Match_View to display the teams whose status is draw
                // SqlCommand com = new SqlCommand("select *from Match_View",con);

                // Retreive the details of the all matches in which Japan played
                // SqlCommand com = new SqlCommand("select *from FootBallLeague1 where TeamName1 = 'Japan' or TeamName2 = 'Japan' ", con);
                
                con.Open();
                Console.WriteLine("Connected..........");
                SqlDataReader dr = com.ExecuteReader();
                Console.WriteLine("Now Data is available to read..........");

               /*while (dr.Read())
                {
                    Console.WriteLine("MatchId=" + dr[0]+"  " + "TeamName1=" + dr[1] + "  " + "TeamName2="+dr[2] + "  " + "Status="+dr[3] + "  " + "WinningTeam="+dr[4] + "  " + "Points="+dr[5]);
                }*/

              /*while(dr.Read())
                {
                    Console.WriteLine("TeamName1=" + dr["TeamName1"] + "  " + "TeamName2=" + dr["TeamName2"]);
                }*/

              /*while(dr.Read())
                {
                    Console.WriteLine("TeamName1=" + dr["TeamName1"] + "  " + "TeamName2=" + dr["TeamName2"]);
                }*/

               while (dr.Read())
               {
                 Console.WriteLine("WinningTeam=" + dr["WinningTeam"]);
               }
               Console.ReadKey();
               con.Close();

        }


    }
    

} 