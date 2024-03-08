namespace Registration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string Name = (txtName).Text;
            string Paternalsuname = (txtPaternal).Text;
            string Maternalsuname = (txtMaternal).Text;
            string DateTime = (dateTimePicker).Text;
            string Registration = (txtRegistration).Text;
            string Career = (txtcareer).Text;
            string Avarage = (numericUpDown).Text;


            Student student = new Student(Name, Paternalsuname, Maternalsuname, DateTime, Registration, Career, Avarage);
            label8.Text = student.ToString();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
