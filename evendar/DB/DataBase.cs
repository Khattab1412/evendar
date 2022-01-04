using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace evendar.DB
{
    internal class DataBase
    {
        public static string connetionString = "Data Source=.;Initial Catalog=EvendarDb;Integrated Security=True";
        public static SqlConnection cn = new SqlConnection(connetionString);


        public static DataTable ExecuteQuery(string query, params SqlParameter[] arr)
        {
            cn.Open();

            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddRange(arr);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();    
            da.Fill(dt);
            cn.Close();
            return dt;
        }

        public static void Execute(string query, params SqlParameter[] arr)
        {
            cn.Open();

            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddRange(arr);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public static bool checkUsername(string username)
        {
            return ExecuteQuery("checkUsername", new SqlParameter("@username", username)).Rows.Count > 0;
        }

        public static string[] getUsername1()
        {
            int s = getPublicEventsCount();
            string[] vs = new string[s];
            int i=0;
                string query = "Select name from Events Where type=1";
                SqlCommand cmd = new SqlCommand(query, cn);
                cn.Open();
                SqlDataReader read = cmd.ExecuteReader();           
                    while (read.Read())
                    {
                        vs[i]= read["name"].ToString(); 
                        i++;
                    }
                    cn.Close();         
            return vs;
        }

        public static string[] getUserEvents(string username)
        {
            int s = getUserEventsCount(username);
            string[] vs = new string[s];
            int i = 0;
            string query = "Select name from Events";
            SqlCommand cmd = new SqlCommand(query, cn);
            cn.Open();
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                vs[i] = read["name"].ToString();
                i++;
            }
            cn.Close();
            return vs;
        }

        public static string[] interestedInEvent()
        {
            int s = getPublicEventsCount();
            string[] vs = new string[s];
            int i = 0;
            string query = "Select interestedIn from Events Where type=1";
            SqlCommand cmd = new SqlCommand(query, cn);
            cn.Open();
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                vs[i] = read["interestedIn"].ToString();
                i++;
            }
            cn.Close();
            return vs;
        }
        public static string[] SearchEvents(string eventName)
        {
            int s = getPublicEventsCount();
            string[] vs = new string[s];
            int i = 0;
            string query = "Select name from Events Where name='"+ eventName + "'";
            SqlCommand cmd = new SqlCommand(query, cn);
            cn.Open();
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                vs[i] = read["name"].ToString();
                i++;
            }
            cn.Close();
            return vs;
        }
        public static string[] SearchEventOwner(string eventName)
        {
            int s = getPublicEventsCount();
            string[] vs = new string[s];
            int i = 0;
            string query = "Select accuserName from Events Where name='" + eventName + "'";
            SqlCommand cmd = new SqlCommand(query, cn);
            cn.Open();
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                vs[i] = read["accuserName"].ToString();
                i++;
            }
            cn.Close();
            return vs;
        }
        public static string[] eventsByInterest(string username)
        {
            int s = eventsByInterestcount(username);
            string[] vs = new string[s];
            int i = 0;
            string query = "SELECT name from Events INNER JOIN interstedIn ON Events.category = interstedIn.interestName where interstedIn.accUser='"+ username + "'";
            SqlCommand cmd = new SqlCommand(query, cn);
            cn.Open();
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                vs[i] = read["name"].ToString();
                i++;
            }
            cn.Close();
            return vs;
        }
        public static string[] interestedInEventByInterest(string username)
        {
            int s = eventsByInterestcount(username);
            string[] vs = new string[s];
            int i = 0;
            string query = "SELECT interestedIn from Events INNER JOIN interstedIn ON Events.category = interstedIn.interestName where interstedIn.accUser='" + username + "'";
            SqlCommand cmd = new SqlCommand(query, cn);
            cn.Open();
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                vs[i] = read["interestedIn"].ToString();
                i++;
            }
            cn.Close();
            return vs;
          
        }
        public static string[] CategoryByInterest(string username)
                {
                    int s = eventsByInterestcount(username);
                    string[] vs = new string[s];
                    int i = 0;
                    string query = "SELECT category from Events INNER JOIN interstedIn ON Events.category = interstedIn.interestName where interstedIn.accUser='" + username + "'";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cn.Open();
                    SqlDataReader read = cmd.ExecuteReader();
                    while (read.Read())
                    {
                        vs[i] = read["category"].ToString();
                        i++;
                    }
                    cn.Close();
                    return vs;
                   }
        public static string[] SearchEventNumber(string eventName)
        {
            int s = getPublicEventsCount();
            string[] vs = new string[s];
            int i = 0;
            string query = "Select interestedIn from Events Where name='" + eventName + "'";
            SqlCommand cmd = new SqlCommand(query, cn);
            cn.Open();
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                vs[i] = read["interestedIn"].ToString();
                i++;
            }
            cn.Close();
            return vs;
        }
        public static string[] SearchEventCategory(string eventName)
        {
            int s = getPublicEventsCount();
            string[] vs = new string[s];
            int i = 0;
            string query = "Select Category from Events Where name='" + eventName + "'";
            SqlCommand cmd = new SqlCommand(query, cn);
            cn.Open();
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                vs[i] = read["Category"].ToString();
                i++;
            }
            cn.Close();
            return vs;
        }
        public static string[] getDescription(string eventName)
        {
            int s = getPublicEventsCount();
            string[] vs = new string[s];
            int i = 0;
            string query = "Select description from Events Where name='" + eventName + "'";
            SqlCommand cmd = new SqlCommand(query, cn);
            cn.Open();
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                vs[i] = read["description"].ToString();
                i++;
            }
            cn.Close();
            return vs;
        }
        public static string[] getPublicCategory()
        {
            int s = getPublicEventsCount();
            string[] vs = new string[s];
            int i = 0;
            string query = "Select Category from Events Where type=1";
            SqlCommand cmd = new SqlCommand(query, cn);
            cn.Open();
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                vs[i] = read["Category"].ToString();
                i++;
            }
            cn.Close();
            return vs;
        }
        public static string[] getEventsByCategory(string Category)
        {
            int s = getPublicEventsCount();
            string[] vs = new string[s];
            int i = 0;
            string query = "Select name from Events Where Category='" +Category+ "'";
            SqlCommand cmd = new SqlCommand(query, cn);
            cn.Open();
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                vs[i] = read["name"].ToString();
                i++;
            }
            cn.Close();
            return vs;
        }
        public static string getUsername(string email)
        {
            return ExecuteQuery("getUsername", new SqlParameter("@email", email)).Rows[0][0].ToString();
        }
        public static int getPublicEventsCount()
        {      
            return int.Parse(ExecuteQuery("getPublicEventsCount").Rows[0][0].ToString());
        }
        public static int getUserEventsCount(string username)
        {      
            return int.Parse(ExecuteQuery("getUserEventsCount", new SqlParameter("@username", username)).Rows[0][0].ToString());
        }
        public static int getPublicEventsCategoryCount(string category)
        {
            return int.Parse(ExecuteQuery("getPublicEventsCategoryCount",
                new SqlParameter("@category",category)).Rows[0][0].ToString());
        }
        public static int eventsByInterestcount(string username)
        {
            return int.Parse(ExecuteQuery("eventsByInterestcount",
                new SqlParameter("@username",username)).Rows[0][0].ToString());
        }
        public static string[] SearchEventNumberByCats(string Category)
        {
            int s = getPublicEventsCount();
            string[] vs = new string[s];
            int i = 0;
            string query = "Select interestedIn from Events Where category='" + Category + "'";
            SqlCommand cmd = new SqlCommand(query, cn);
            cn.Open();
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                vs[i] = read["interestedIn"].ToString();
                i++;
            }
            cn.Close();
            return vs;
        }
        public static string getEmail(string username)
        {
            return ExecuteQuery("getEmail", new SqlParameter("@username", username)).Rows[0][0].ToString();
        }

        public static bool checkEmail(string email)
        {
            return  ExecuteQuery("checkEmail", new SqlParameter("@email", email)).Rows.Count>0;           
        }

        public static string login(string username, string password)
        {
             return ExecuteQuery("login", new SqlParameter("@username", username),
                 new SqlParameter("@password", password)).Rows[0][0].ToString();         
        }
        public static string StartDate(string eventName)
        {
            return ExecuteQuery("StartDate", new SqlParameter("@name", eventName)).Rows[0][0].ToString();
        }
        public static string EndDate(string eventName)
        {
            return ExecuteQuery("EndDate", new SqlParameter("@name", eventName)).Rows[0][0].ToString();
        }
        public static string StartTime(string eventName)
        {
            return ExecuteQuery("StartTime", new SqlParameter("@name", eventName)).Rows[0][0].ToString();
        }
        public static string EndTime(string eventName)
        {
            return ExecuteQuery("EndTime", new SqlParameter("@name", eventName)).Rows[0][0].ToString();
        }
        public static string Location(string eventName)
        {
            return ExecuteQuery("Location", new SqlParameter("@name", eventName)).Rows[0][0].ToString();
        }
        
        public static void register(string username, string password, string name, string email)
        {
            Execute("createAccount", new SqlParameter("@username", username),
                new SqlParameter("@password", password),
                new SqlParameter("@email", email),
                new SqlParameter("@name", name));
        }
        public static void changePass(string email, string password)
        {
            Execute("changePassword", new SqlParameter("@email", email),
                new SqlParameter("@password", password));
        }

        public static void changeEmail(string username, string newEmail)
        {
            Execute("changeEmail", new SqlParameter("@username", username),
                new SqlParameter("@email", newEmail));
        }
        public static void addEvent(string description,DateTime startDate,DateTime endDate,string name,string location,bool type,DateTime startTime,DateTime endTime,string accuserName, string category)
        {
            Execute("addEvent",
                new SqlParameter("@description", description),
                new SqlParameter("@startDate", startDate),
                new SqlParameter("@endDate", endDate),
                new SqlParameter("@name", name),
                new SqlParameter("@location", location),
                new SqlParameter("@type", type),
                new SqlParameter("@startTime", startTime),
                new SqlParameter("@endTime", endTime),
                new SqlParameter("@accuserName", accuserName),
                new SqlParameter("@category", category));
        }
        public static void addCategory(string eventName,string Category)
        {
            Execute("addCategory", new SqlParameter("@eventName", eventName),
                new SqlParameter("@Category", Category));
        }
        public static bool checkInterest(string username ,string interest)
        {
            return ExecuteQuery("checkInterest", new SqlParameter("@username", username),
                new SqlParameter("@interest", interest)).Rows.Count > 0;
        }
        public static void addInterest(string username, string interest)
        {
            Execute("addInterest", new SqlParameter("@username", username),
            new SqlParameter("@interest", interest));
        }
        public static void deleteInterest(string username, string interest)
        {
            Execute("deleteInterest", new SqlParameter("@username", username),
            new SqlParameter("@interest", interest));
        }
        public static void addInterestInEvent(string eventName)
        {
            
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = new SqlConnection("Data Source=.;Initial Catalog=EvendarDb;Integrated Security=True");
            string s = ExecuteQuery("EventInterestedin", new SqlParameter("@name", eventName)).Rows[0][0].ToString();
       
            int k = int.Parse(s);
            k++;
            cmd.Connection.Open();
            cmd.CommandText = "Update Events set interestedIn='" + k + "' where name='" + eventName + "' ";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public static string removeEventInterestedin(string eventName)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = new SqlConnection("Data Source=.;Initial Catalog=EvendarDb;Integrated Security=True");
            string s = ExecuteQuery("EventInterestedin", new SqlParameter("@name", eventName)).Rows[0][0].ToString();
            cmd.Connection.Open();
            int k=int.Parse(s);
            --k;
            cmd.CommandText = "Update Events set interestedIn='" + k + "' where name='" + eventName + "' ";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return k.ToString();           
        }

        

    }
}
