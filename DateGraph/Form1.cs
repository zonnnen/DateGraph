using Microsoft.CSharp.RuntimeBinder;

namespace DateGraph
{
    public partial class MainForm : Form
    {
        Date date = new Date();

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void GenerateDateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DateBox.Text == "") DateBox.Text = "1";
                if (MonthBox.Text == "") MonthBox.Text = "1";
                if (YearBox.Text == "") YearBox.Text = "2024";
                Date b1 = new Date(byte.Parse(DateBox.Text), byte.Parse(MonthBox.Text), int.Parse(YearBox.Text));
                date = b1;
                DateLabel.Text = date.GetDate;
            }
            catch (ArgumentException exp)
            {
                MessageBox.Show(exp.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Укажите положительное число или число поменьше.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PlusDateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DateBox.Text == "") DateBox.Text = "0";
                if (MonthBox.Text == "") MonthBox.Text = "0";
                if (YearBox.Text == "") YearBox.Text = "0";
                date.PlusDate(uint.Parse(DateBox.Text), uint.Parse(MonthBox.Text), uint.Parse(YearBox.Text));
                DateLabel.Text = date.GetDate;
            }
            catch (OverflowException)
            {
                MessageBox.Show("Укажите положительное число.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
