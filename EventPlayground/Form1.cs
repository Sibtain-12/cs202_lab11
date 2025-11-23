using System;
using System.Drawing;
using System.Windows.Forms;

namespace EventPlayground
{
    public partial class Form1 : Form
    {
        // Custom delegate types (not using only built‑in EventHandler)
        public delegate void ColorChangedEventHandler(object sender, ColorEventArgs e);
        public delegate void TextChangedEventHandler(object sender, EventArgs e);

        // Custom events
        public event ColorChangedEventHandler ColorChangedEvent;
        public event TextChangedEventHandler TextChangedEvent;

        public Form1()
        {
            InitializeComponent();

            // Initial label text
            lblDisplay.Text = "Welcome to Events Lab";

            // Populate ComboBox if not done in designer
            if (cmbColors.Items.Count == 0)
            {
                cmbColors.Items.AddRange(new object[] { "Red", "Green", "Blue" });
                cmbColors.SelectedIndex = 0;
            }

            // Subscribe custom event handlers (multicast for ColorChangedEvent)
            ColorChangedEvent += UpdateLabelColor;    // Subscriber 1
            ColorChangedEvent += ShowNotification;    // Subscriber 2
            TextChangedEvent += UpdateLabelText;     // Single subscriber

            // Only use Click to fire custom events (logic is in custom events)
            btnChangeColor.Click += BtnChangeColor_Click;
            btnChangeText.Click += BtnChangeText_Click;
        }

        // Publisher: fires ColorChangedEvent based on ComboBox selection
        private void BtnChangeColor_Click(object sender, EventArgs e)
        {
            string selectedName = cmbColors.SelectedItem?.ToString();
            if (string.IsNullOrWhiteSpace(selectedName))
                return;

            Color clr = Color.Black;

            switch (selectedName)
            {
                case "Red":
                    clr = Color.Red;
                    break;
                case "Green":
                    clr = Color.Green;
                    break;
                case "Blue":
                    clr = Color.Blue;
                    break;
            }

            // Raise custom event with ColorEventArgs
            ColorChangedEvent?.Invoke(
                this,
                new ColorEventArgs(selectedName, clr)
            );
        }

        // Publisher: fires TextChangedEvent to show current date/time
        private void BtnChangeText_Click(object sender, EventArgs e)
        {
            TextChangedEvent?.Invoke(this, EventArgs.Empty);
        }

        // Subscriber 1 for ColorChangedEvent – changes label colour
        private void UpdateLabelColor(object sender, ColorEventArgs e)
        {
            lblDisplay.ForeColor = e.SelectedColor;
        }

        // Subscriber 2 for ColorChangedEvent – shows a notification
        private void ShowNotification(object sender, ColorEventArgs e)
        {
            MessageBox.Show(
                $"Color changed to {e.ColorName}",
                "Color Notification",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        // Subscriber for TextChangedEvent – updates label text to current date/time
        private void UpdateLabelText(object sender, EventArgs e)
        {
            lblDisplay.Text = DateTime.Now.ToString("F");
        }
    }
}
