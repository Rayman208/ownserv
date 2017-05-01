using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using System.Net;

namespace Licey
{
    static class ServAPI
    {
        private static string link = "http://raymna208.000webhostapp.com/";

        private static string ExecuteCommand(string command, string parameters = null)
        {
            WebClient client = new WebClient();

            string url = String.Format("{0}?command={1}&parameters={2}",link,command,parameters);

            return client.DownloadString(url);
        }

        public static List<Student> StudentsSelectAll()
        {
            string command = "students.select.all";

            string result = ExecuteCommand(command);

            List<Student> students = JsonConvert.DeserializeObject<List<Student>>(result);

            return students;
        }

        public static void StudentsDeleteById(string id)
        {
            string command = "students.delete.byid";
            string parameters = id;

            ExecuteCommand(command, parameters);
        }

        public static void StudentsInsertNewStudent(Student student)
        {
            string command = "students.insert.newstudent";
            string parameters = JsonConvert.SerializeObject(student);

            ExecuteCommand(command, parameters);
        }
    }
}
