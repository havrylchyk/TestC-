using Formationofgroups.Services;
using System;
using System.Windows.Forms;

namespace Formationofgroups.UI
{
    public partial class Form1 : Form
    {
        public StudentService studentService;
        public GroupService groupService;
        public ElectiveCourseService electiveCourseService;

        public Form1()
        {
            InitializeComponent();
            groupService = new GroupService();
            studentService = new StudentService(groupService.GroupList);
            electiveCourseService = new ElectiveCourseService();
            FillGroupDataGridView();
            FillStudentDataGridView();
            FillElectiveCourseDataGridView();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void StudentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
