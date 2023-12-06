namespace D14
{
    public partial class main : MetroFramework.Forms.MetroForm
    {
        public main()
        {
            InitializeComponent();
        }
        #region Form Load
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #endregion
        #region Minimize
        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion
        #region Close
        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
        #region Help
        private void button1_Click(object sender, EventArgs e)
        {
            String message = "Join The Discord For Help";
            string title = "Department 14";
            MessageBox.Show(message, title);
        }
        #endregion
    }
}