namespace DateTimePicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GetDifference();
        }
        private int _day, _month, _year;
        private bool _flag = true;
        private TimeSpan _diff;

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            GetDifference();
        }

       private void GetDifference()
        {
            _diff = dateTimePicker2.Value - dateTimePicker1.Value;
            label1.Text = "Difference between dates are: " + Math.Abs(_diff.Days);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            _flag = int.TryParse(textBox2.Text, out _month);
            if (!_flag)
            {
                MessageBox.Show("¬ведите правильную дату");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            _flag = int.TryParse(textBox3.Text, out _year);
            if (!_flag)
            {
                MessageBox.Show("¬ведите правильную дату");
            }
            monthCalendar1.SetDate(new DateTime());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
     
            _flag = int.TryParse(textBox1.Text, out _day);
            if (!_flag) 
            {
                MessageBox.Show("¬ведите правильную дату");
            }
            
        }

    }
}