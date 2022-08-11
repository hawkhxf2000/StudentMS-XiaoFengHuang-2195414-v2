using StudentMS_XiaoFengHuang_2195414.BLL;
using StudentMS_XiaoFengHuang_2195414.DAL;
using System.Text.RegularExpressions;

namespace StudentMS_XiaoFengHuang_2195414
{
    public partial class FrmStudentMS : Form
    {
        public FrmStudentMS()
        {
            InitializeComponent();
            StudentDAL.ListStudents(LvwStudent);
        }

        private void ClearAll()
        {
            TbxId.Clear();
            TbxFirstName.Clear();
            TbxLastName.Clear();
            MtxPhoneNumber.Clear();
        }

        //Verify if all parameters meet the criterias 
        private bool Verify(string id, string firstName, string lastName)
        {
            List<Student> students = StudentDAL.GetAllStudents();
            //Student ID must be 7 digits of number
            if (id.Length != 7 || !id.All(char.IsDigit))
            {
                MessageBox.Show("The studnet ID must be 7 number digits only, please check it again!");
                TbxId.Focus();
                return false;
            }

            //First Name and Last name only be text data type
            if (!firstName.All(Char.IsLetter))
            {
                MessageBox.Show("The first name must be letter only,  please check it again!");
                TbxFirstName.Focus();
                return false;
            }
            if (!lastName.All(Char.IsLetter))
            {
                MessageBox.Show("The last name must be letter only,  please check it again!");
                TbxLastName.Focus();
                return false;
            }
            
            //Student ID should be unique
            foreach (Student student in students)
            {
                if(student.Id == id)
                {
                    MessageBox.Show("The student ID has already existed in the list, please change the ID according to the list below!");
                    TbxId.Focus();
                    return false;
                }
            }
            return true;
        }

        private void ListSearchResult(List<Student> studentsFound)
        {
            LvwStudent.Items.Clear();
            studentsFound.ForEach(el =>
            {
                String[] infoArray = { el.Id, el.FirstName, el.LastName, el.PhoneNumber };
                ListViewItem item = new ListViewItem(infoArray);
                LvwStudent.Items.Add(item);
            });
        }
        private void BtnList_Click(object sender, EventArgs e)
        {
            StudentDAL.ListStudents(LvwStudent);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string id = TbxId.Text;
            string firstName = TbxFirstName.Text;
            string lastName = TbxLastName.Text;
            string phoneNumber = MtxPhoneNumber.Text;
            Student student = new Student(id, firstName, lastName, phoneNumber);

            //verify all information meet the criterias
            if (Verify(id, firstName, lastName))
            {
                StudentDAL.Save(student);
                StudentDAL.ListStudents(LvwStudent);
                ClearAll();
            }  
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //Get parameters and construct a new object of Student
            string id = TbxId.Text;
            string firstName = TbxFirstName.Text;
            string lastName = TbxLastName.Text;
            string phoneNumber = MtxPhoneNumber.Text;
            Student student = new Student(id, firstName, lastName, phoneNumber);

            //verify all information meet the criterias
            if (Verify(id, firstName, lastName))
            {
                StudentDAL.Save(student);
                ClearAll();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        { 
            //Get the Student id from selected item of table
            string id = LvwStudent.SelectedItems[0].Text;
            DialogResult answer = MessageBox.Show("Are you sure to delete the selected record?", "Confirmation",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                StudentDAL.Delete(id);
            }
            StudentDAL.ListStudents(LvwStudent);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Are you sure to exit the application?", "Confirmation",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void FrmStudentMS_Load(object sender, EventArgs e)
        {

        }

        private void LvwStudent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        { 
            //Set default values of different properties for dynamic query
            string id = "";
            string firstName ="";
            string lastName = "";
            string phoneNumber = "";

            //Get the query criteria
            int choice = CbxSearch.SelectedIndex;

            //Set query parameter for dynamic searching function
            switch (choice)
            { 
                //remind user to choose one option
                case -1:
                     MessageBox.Show("Please select at least one search option");
                      break;

                case 0:
                    id = TbxSearch.Text;
                    break;

                 case 1:
                    firstName = TbxSearch.Text;
                    break;

                case 2:
                    lastName = TbxSearch.Text;
                    break;

                case 3:
                    phoneNumber = TbxSearch.Text;
                    //extract all numbers in phonenumer which the user input, and then wrapp it to same format of record
                    string number = Regex.Replace(phoneNumber, @"[^0-9]+", "");
                    phoneNumber ="(" +number.Substring(0,3) + ")" + number.Substring(3,3) +"-" +number.Substring(6,4);
                    break;

                default:
                    break;
            }

            //Get the result of dynamic query
            List<Student> studentsFound = StudentDAL.SearchStudents(id, firstName, lastName, phoneNumber);

            //check if there is no record found
            if (studentsFound.Count == 0)
            {
                MessageBox.Show("There is no student found");
                return;
            }

            //Display the information of the found student on text boxes
            TbxId.Text = studentsFound[0].Id;
            TbxFirstName.Text = studentsFound[0].FirstName;
            TbxLastName.Text = studentsFound[0].LastName;
            MtxPhoneNumber.Text = studentsFound[0].PhoneNumber;

            ListSearchResult(studentsFound);
        }

    }
}