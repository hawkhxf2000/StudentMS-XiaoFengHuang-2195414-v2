using StudentMS_XiaoFengHuang_2195414.BLL;
using StudentMS_XiaoFengHuang_2195414.DAL;

namespace StudentMS_XiaoFengHuang_2195414
{
    public partial class FrmStudentMS : Form
    {
        public FrmStudentMS()
        {
            InitializeComponent();
            ListStudents();
        }
        private void ListStudents()
        {
            List<Student> students = StudentDAL.GetAllStudents();
            students.ForEach(
                el =>
                {
                    ListViewItem item = new ListViewItem(el.Id + "");
                    item.SubItems.Add(el.FirstName);
                    item.SubItems.Add(el.LastName);
                    item.SubItems.Add(el.PhoneNumber);
                    LvwStudent.Items.Add(item);
                }
            );
        }

        private void ClearAll()
        {
            TbxId.Clear();
            TbxFirstName.Clear();
            TbxLastName.Clear();
            MtxPhoneNumber.Clear();
            TbxId.Focus();
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            ListStudents();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string id = TbxId.Text;
            string firstName = TbxFirstName.Text;
            string lastName = TbxLastName.Text;
            string phoneNumber = MtxPhoneNumber.Text;
            Student student = new Student(id, firstName, lastName, phoneNumber);

            StudentDAL.Save(student);
            ListStudents();
            ClearAll();
        }
    }
}