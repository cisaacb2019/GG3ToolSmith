namespace GG3GrblProbe
{
    public partial class Error : Form
    {
        public string ErrorMessage { get; set; }

        public Error()
        {
            InitializeComponent();
            Load += Error_Load; // Subscribe to the Load event and assign the Error_Load method as the event handler
        }
        private void Error_Load(object sender, EventArgs e)
        {
            ErrorOutput.Text = ErrorMessage; // Display the error message in the ErrorOutput control
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the Error form
        }

        private void Error_Load_1(object sender, EventArgs e)
        {

        }

        private void ErrorOutput_Click(object sender, EventArgs e)
        {

        }
    }
}
