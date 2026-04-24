using System;
using System.Drawing;
using System.Windows.Forms;

namespace StudentProfileForm
{
    public partial class Form1 : Form
    {
        // ── GLOBAL VARIABLES (class-level scope) ────────────────────────────
        private int profilesProcessed = 0;

        public Form1()
        {
            InitializeComponent();
        }

        // ════════════════════════════════════════════════════════════════════
        //  FORM LOAD
        // ════════════════════════════════════════════════════════════════════
        private void Form1_Load(object sender, EventArgs e)
        {
            // Set up form appearance on load
            this.Text = "Student Profile Processor";
            btnProcess.Text = "Process";
            lblOutput.Text = "Fill in all fields and click Process.";

            // Add placeholder-style labels next to each textbox
            // (Labels were added in designer; here we just set form title)
        }

        // ════════════════════════════════════════════════════════════════════
        //  TEXT CHANGED EVENTS  (clear output when user edits fields)
        // ════════════════════════════════════════════════════════════════════
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // txtName changed — clear result
            lblOutput.ForeColor = Color.Black;
            lblOutput.Text = "Fill in all fields and click Process.";
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            // txtAge changed — clear result
            lblOutput.ForeColor = Color.Black;
            lblOutput.Text = "Fill in all fields and click Process.";
        }

        private void txtMarks_TextChanged(object sender, EventArgs e)
        {
            // txtMarks changed — clear result
            lblOutput.ForeColor = Color.Black;
            lblOutput.Text = "Fill in all fields and click Process.";
        }

        // ════════════════════════════════════════════════════════════════════
        //  LABEL CLICK  (clicking the output label resets it)
        // ════════════════════════════════════════════════════════════════════
        private void lblOutput_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "Fill in all fields and click Process.";
            lblOutput.ForeColor = Color.Black;
        }

        // ════════════════════════════════════════════════════════════════════
        //  BUTTON CLICK — main logic
        // ════════════════════════════════════════════════════════════════════
        private void btnProcess_Click(object sender, EventArgs e)
        {
            // ── Local variables ──────────────────────────────────────────────
            string name;
            int age;
            int marks;

            // ── Validate Name ────────────────────────────────────────────────
            name = txtName.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                ShowError("Please enter a student name.");
                txtName.Focus();
                return;
            }

            // ── Validate Age  (type casting: string → int) ───────────────────
            if (!int.TryParse(txtAge.Text.Trim(), out age) || age < 1 || age > 120)
            {
                ShowError("Please enter a valid age (1 – 120).");
                txtAge.Clear();
                txtAge.Focus();
                return;
            }

            // ── Validate Marks (type casting: string → int) ──────────────────
            if (!int.TryParse(txtMarks.Text.Trim(), out marks) || marks < 0 || marks > 100)
            {
                ShowError("Please enter valid marks (0 – 100).");
                txtMarks.Clear();
                txtMarks.Focus();
                return;
            }

            // ── Call overloaded method ───────────────────────────────────────
            // Uses the two-parameter overload so both versions are called
            string readiness = CalculateReadiness(marks, age);

            // ── Increment global counter (increment operator) ────────────────
            profilesProcessed++;

            // ── Build and display output ─────────────────────────────────────
            string result = BuildProfile(name, age, marks, readiness);
            lblOutput.Text = result;
            lblOutput.ForeColor = GetStatusColor(marks);
        }

        // ════════════════════════════════════════════════════════════════════
        //  METHODS
        // ════════════════════════════════════════════════════════════════════

        /// <summary>Overload 1 — readiness based on marks only.</summary>
        private string CalculateReadiness(int marks)
        {
            if (marks >= 75) return "High";
            else if (marks >= 50) return "Medium";
            else return "Low";
        }

        /// <summary>Overload 2 — readiness based on marks AND age.</summary>
        private string CalculateReadiness(int marks, int age)
        {
            if (marks >= 75 && age >= 18) return "High";
            else if (marks >= 50) return "Medium";
            else return "Low";
        }

        /// <summary>Builds the formatted profile string for lblOutput.</summary>
        private string BuildProfile(string name, int age, int marks, string readiness)
        {
            // Expression: pass/fail using relational operator >=
            string status = marks >= 50 ? "PASS" : "FAIL";

            return $"Student Profile\r\n" +
                   $"────────────────────\r\n" +
                   $"Name      : {name}\r\n" +
                   $"Age       : {age}\r\n" +
                   $"Marks     : {marks}%\r\n" +
                   $"Status    : {status}\r\n" +
                   $"Readiness : {readiness}\r\n" +
                   $"────────────────────\r\n" +
                   $"Profiles processed: {profilesProcessed}";
        }

        /// <summary>Returns a colour for the label based on the mark.</summary>
        private Color GetStatusColor(int marks)
        {
            if (marks >= 75) return Color.Green;
            if (marks >= 50) return Color.DarkOrange;
            return Color.Red;
        }

        /// <summary>Helper — shows a warning MessageBox.</summary>
        private void ShowError(string message)
        {
            MessageBox.Show(message, "Input Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}