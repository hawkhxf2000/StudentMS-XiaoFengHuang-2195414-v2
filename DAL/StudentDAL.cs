using StudentMS_XiaoFengHuang_2195414.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMS_XiaoFengHuang_2195414.DAL
{
    public class StudentDAL
    {
        private static string filePath = Application.StartupPath + @"\Student.dat";
        private static string fileTemp = Application.StartupPath + @"\Temp.dat";

        //save record to file
        public static void Save(Student student)
        {
            StreamWriter sWriter = new StreamWriter(filePath,true);
            sWriter.WriteLine(student.Id + "," + student.FirstName + "," + student.LastName + "," + student.PhoneNumber);
            sWriter.Close();
            MessageBox.Show("Student Data has been saved.");
        }

        //get all student records from file
        public static List<Student> GetAllStudents()
        {
            //step 1: Create a streamReader instance
            StreamReader sReader = new StreamReader(filePath);

            List<Student> students = new List<Student>();
            string? line = sReader.ReadLine();
            while(line != null)
            {
                Student s = new Student();
                string[] fields = line.Split(',');
                s.Id = fields[0];
                s.FirstName = fields[1];
                s.LastName = fields[2];
                s.PhoneNumber = fields[3];
                students.Add(s);
                line = sReader.ReadLine();
            }
            sReader.Close();
            return students;
        }

        public static void Delete(string studentId)
        {
            StreamWriter sw = new StreamWriter(fileTemp, true);
            List<Student> students = GetAllStudents();
            students.ForEach(el =>
            {
                if(el.Id != studentId)
                {
                    sw.WriteLine(el.Id + "," + el.FirstName + "," + el.LastName + "," + el.PhoneNumber);
                }
            });
            sw.Close();
            File.Delete(filePath);
            File.Move(fileTemp, filePath);
        }
        public static void ListStudents(ListView lvwStudent)
        {
            //step 1: Create an object of type StreamReader
            StreamReader sReader = new StreamReader(filePath);
            lvwStudent.Items.Clear();

            // Step 2: Read the file until the end of the file


            string line = sReader.ReadLine();
            while (line != null)
            {
                string[] fields = line.Split(',');
                ListViewItem item = new ListViewItem(fields);
                //item.SubItems.Add(fields[1]);
                //item.SubItems.Add(fields[2]);
                //item.SubItems.Add(fields[3]);
                lvwStudent.Items.Add(item);
                line = sReader.ReadLine();
            }
            sReader.Close();
        }

        public static List<Student> SearchStudents(string id, string firstName, string lastName, string phoneNumber)
        {
            List<Student> studentList = GetAllStudents();
            List<Student> studentsFound = (from student in studentList
                                          where (student.Id == id || student.FirstName == firstName || student.LastName == lastName || student.PhoneNumber == phoneNumber)
                                          select student).ToList();
            return studentsFound;
        }
    }
}
