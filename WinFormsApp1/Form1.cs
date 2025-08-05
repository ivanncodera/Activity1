using System.Drawing.Drawing2D;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private Button? currentButton;
        private readonly Color sideMenuColor = Color.FromArgb(45, 52, 70);
        private readonly Color buttonHoverColor = Color.FromArgb(70, 80, 105);

        public Form1()
        {
            InitializeComponent();
            InitializeUI();
        }

        private void InitializeUI()
        {
            // Apply styles to navigation buttons
            foreach (Control control in panelSideMenu.Controls)
            {
                if (control is Button button && button != button1) // Exclude back button
                {
                    SetButtonStyle(button);
                }
            }

            // Style the back button separately
            StyleBackButton();

            // Apply visual enhancements
            ApplyRoundedCorners(pictureBox1, 15);
            AddShadowToPanel(panelContent);
        }

        private void StyleBackButton()
        {
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.BackColor = Color.FromArgb(35, 40, 55);
            button1.ForeColor = Color.White;
        }

        private void SetButtonStyle(Button button)
        {
            // Basic button styling
            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.MouseOverBackColor = buttonHoverColor;
            button.TextAlign = ContentAlignment.MiddleCenter;

            // Hover animation
            button.MouseEnter += (s, e) => button.Padding = new Padding(20, 0, 0, 0);
            button.MouseLeave += (s, e) =>
            {
                if (button != currentButton)
                    button.Padding = new Padding(0, 0, 0, 0);
            };
        }

        private void ActivateButton(object? btnSender)
        {
            if (btnSender is not Button clickedButton) return;

            if (currentButton != clickedButton)
            {
                // Reset all buttons
                foreach (Control control in panelSideMenu.Controls)
                {
                    if (control is Button btn && btn != button1)
                    {
                        btn.BackColor = sideMenuColor;
                        btn.ForeColor = Color.White;
                        btn.Font = new Font("Segoe UI", 11F, FontStyle.Regular);
                    }
                }

                // Highlight selected button
                currentButton = clickedButton;
                currentButton.BackColor = buttonHoverColor;
                currentButton.ForeColor = Color.White;
                currentButton.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular);
            }
        }

        private void ApplyRoundedCorners(Control control, int radius)
        {
            using GraphicsPath path = new();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();

            control.Region = new Region(path);
        }

        private void AddShadowToPanel(Panel panel)
        {
            panel.Paint += (sender, e) =>
            {
                Rectangle rect = new(0, 0, panel.Width, panel.Height);
                using LinearGradientBrush brush = new(
                    rect,
                    Color.FromArgb(10, 0, 0, 0),
                    Color.FromArgb(30, 0, 0, 0),
                    LinearGradientMode.Vertical);

                e.Graphics.FillRectangle(brush, rect);
            };
        }

        #region Event Handlers

        private void GoToForm2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            new Codera().Show();
        }

        private void btnGilles_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            new Gilles().Show();
        }

        private void btnMongado_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            new Mongado().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new();
            form2.Show();
            Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Event handler required by designer
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name == "goToForm2ToolStripMenuItem")
            {
                GoToForm2_Click(btnNavigateToCodera, e);
            }
        }

        #endregion

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
