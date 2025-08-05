namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private Button currentButton;

        public Form1()
        {
            InitializeComponent();

            // Add hover effects and design enhancements
            SetButtonStyle(btnNavigateToCodera);
            SetButtonStyle(btnGilles);
            SetButtonStyle(btnMongado);
        }

        private void SetButtonStyle(Button button)
        {
            // This helps with creating the transition effect
            button.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 80, 105);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    // Deactivate previous button
                    DisableButton();

                    // Highlight the selected button
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.FromArgb(70, 80, 105);
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular, GraphicsUnit.Point);
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelSideMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(45, 52, 70);
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
                }
            }
        }

        private void GoToForm2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

            // Create an instance of Form2
            Codera form2 = new Codera();

            // Show Form2
            form2.Show();

            // Optionally, hide Form1
            // this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Check if the clicked item is the "Go to Codera" menu item
            if (e.ClickedItem.Name == "goToForm2ToolStripMenuItem")
            {
                GoToForm2_Click(btnNavigateToCodera, e);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGilles_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

            // Create an instance of the Gilles form
            Gilles gillesForm = new Gilles();

            // Show the Gilles form
            gillesForm.Show();
        }

        private void btnMongado_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

            // Create an instance of the Mongado form
            Mongado mongadoForm = new Mongado();

            // Show the Mongado form
            mongadoForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();

        }
    }
}
