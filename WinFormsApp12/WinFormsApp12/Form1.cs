namespace WinFormsApp12
{
    public partial class Form1 : Form
    {
        private Class1 class1;
        public Form1()
        {
            InitializeComponent();
            class1= new Class1();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = this.textBox1.Text;
            int year = int.Parse(this.textBox2.Text);
            double grade = double.Parse(this.textBox3.Text);

            Student students = new Student(name, year, grade);
            this.class1.addStudent(students);

            label1.Text = this.class1.ShowStudent();
            label16.Text = this.class1.ShowAllAge().ToString();
            this.class1.SetGrade();
            this.labelMaxGrade.Text = this.class1.ShowMaxGrade().ToString();
            this.labelMinGrade.Text = this.class1.ShowMinGrade().ToString();
            this.labelNameMaxGrade.Text = this.class1.ShowMaxGradeName();
            this.labelNameMinGrade.Text = this.class1.ShowMinGradeName();
        }
    }
}