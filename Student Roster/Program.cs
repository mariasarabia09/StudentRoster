using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Roster
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static void WriteStudentToFile(Student student)
        {
            using (var writer = new StreamWriter("students.txt", true))
            {
                writer.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", student.FirstName, student.LastName, student.DOB, student.Major, student.StudentId);
            }
        }

        public static List<Student> ReadStudentsFromFile()
        {
            var list = new List<Student>();

            using (var reader = new StreamReader("students.txt"))
            {
                var line = string.Empty;

                while((line = reader.ReadLine()) != null)
                {
                    var split = line.Split('\t');
                    var student = new Student()
                    {
                        FirstName = split[0],
                        LastName = split[1],
                        DOB = split[2],
                        Major = split[3],
                        StudentId = split[4]
                    };

                    list.Add(student);
                }
            }

            return list;
        }
    }
}
