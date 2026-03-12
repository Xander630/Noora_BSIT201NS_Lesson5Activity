using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PayrollApp;

public partial class Form1 : Form
{

    private TextBox txtBasicRate;
    private TextBox txtBasicHours;
    private TextBox txtBasicIncome;

    private TextBox txtHonorRate;
    private TextBox txtHonorHours;
    private TextBox txtHonorIncome;

    private TextBox txtOtherRate;
    private TextBox txtOtherHours;
    private TextBox txtOtherIncome;

    private TextBox txtGrossIncome;
    private TextBox txtNetIncome;

    private TextBox txtSSS;
    private TextBox txtPhilHealth;
    private TextBox txtPagIbig;
    private TextBox txtIncomeTax;

    private TextBox txtSSSLoan;
    private TextBox txtPagIbigLoan;
    private TextBox txtFacultySavings;
    private TextBox txtSalaryLoan;
    private TextBox txtOtherLoans;

    private TextBox txtTotalDeductions;

    private TextBox txtEmployeeNumber;
    private TextBox txtFirstName;
    private TextBox txtMiddleName;
    private TextBox txtSurname;
    private TextBox txtCivilStatus;
    private TextBox txtQualifiedDependents;
    private TextBox txtDependentsCount;
    private TextBox txtPaydate;
    private TextBox txtEmployeeStatus;
    private TextBox txtDesignation;

    private Button btnGrossIncome;
    private Button btnNetIncome;
    private Button btnSave;
    private Button btnUpdate;
    private Button btnNew;

    public Form1()
    {
        InitializeComponent();
        SetupAvatarPainting();
    }

    private void SetupAvatarPainting()
    {
        var avatarPanel = Controls.Cast<Control>().FirstOrDefault(c => c.Location == new Point(50, 80) && c.Size == new Size(120, 120)) as Panel;
        if (avatarPanel != null)
        {
            avatarPanel.Paint += (s, e) =>
            {
                e.Graphics.FillEllipse(new SolidBrush(Color.FromArgb(100, 100, 100)), 0, 0, 120, 120);
            };
        }
    }

    private decimal GetDecimalFromTextBox(TextBox txt)
    {
        if (decimal.TryParse(txt.Text, out var value))
        {
            return value;
        }

        return 0m;
    }

    private void BtnGrossIncome_Click(object? sender, EventArgs e)
    {
        decimal basicRate = GetDecimalFromTextBox(txtBasicRate);
        decimal basicHours = GetDecimalFromTextBox(txtBasicHours);
        decimal basicIncome = basicRate * basicHours;
        txtBasicIncome.Text = basicIncome.ToString("N2");

        decimal honorRate = GetDecimalFromTextBox(txtHonorRate);
        decimal honorHours = GetDecimalFromTextBox(txtHonorHours);
        decimal honorIncome = honorRate * honorHours;
        txtHonorIncome.Text = honorIncome.ToString("N2");

        decimal otherRate = GetDecimalFromTextBox(txtOtherRate);
        decimal otherHours = GetDecimalFromTextBox(txtOtherHours);
        decimal otherIncome = otherRate * otherHours;
        txtOtherIncome.Text = otherIncome.ToString("N2");

        decimal grossIncome = basicIncome + honorIncome + otherIncome;
        txtGrossIncome.Text = grossIncome.ToString("N2");
    }

    private void BtnNetIncome_Click(object? sender, EventArgs e)
    {
      
        decimal salary = GetDecimalFromTextBox(txtGrossIncome);
        if (salary <= 0)
        {
            MessageBox.Show("Please compute Gross Income first.", "Missing data",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        decimal msc = Math.Min(Math.Max(salary, 5000m), 35000m);
        decimal sss = msc * 0.05m;

      
        decimal philHealthTotal = salary * 0.05m;
    
        if (salary > 100000m)
        {
            philHealthTotal = 100000m * 0.05m;
        }
        decimal philHealthEmployee = philHealthTotal / 2m;

     
        decimal pagIbig;
        if (salary <= 1500m)
        {
            pagIbig = salary * 0.01m;
        }
        else
        {
            decimal baseAmount = Math.Min(salary, 10000m);
            pagIbig = baseAmount * 0.02m;
        }
        if (pagIbig > 200m)
        {
            pagIbig = 200m;
        }

     
        decimal taxableIncome = salary - (sss + philHealthEmployee + pagIbig);

     
        decimal incomeTax;
        if (taxableIncome <= 20833m)
        {
            incomeTax = 0m;
        }
        else if (taxableIncome <= 33333m)
        {
            incomeTax = (taxableIncome - 20833m) * 0.15m;
        }
        else if (taxableIncome <= 66667m)
        {
            incomeTax = 1875m + (taxableIncome - 33333m) * 0.20m;
        }
        else
        {
            
            incomeTax = 8541.8m + (taxableIncome - 66667m) * 0.25m;
        }

        
        txtSSS.Text = sss.ToString("N2");
        txtPhilHealth.Text = philHealthEmployee.ToString("N2");
        txtPagIbig.Text = pagIbig.ToString("N2");
        txtIncomeTax.Text = incomeTax.ToString("N2");

      
        decimal sssLoan = GetDecimalFromTextBox(txtSSSLoan);
        decimal pagIbigLoan = GetDecimalFromTextBox(txtPagIbigLoan);
        decimal facultySavings = GetDecimalFromTextBox(txtFacultySavings);
        decimal salaryLoan = GetDecimalFromTextBox(txtSalaryLoan);
        decimal otherLoans = GetDecimalFromTextBox(txtOtherLoans);

        decimal totalDeductions =
            sss + philHealthEmployee + pagIbig + incomeTax +
            sssLoan + pagIbigLoan + facultySavings + salaryLoan + otherLoans;

        txtTotalDeductions.Text = totalDeductions.ToString("N2");

        decimal netIncome = salary - totalDeductions;
        txtNetIncome.Text = netIncome.ToString("N2");
    }

    private void BtnSave_Click(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtEmployeeNumber.Text))
        {
            MessageBox.Show("Please enter Employee Number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (string.IsNullOrWhiteSpace(txtFirstName.Text))
        {
            MessageBox.Show("Please enter First Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var payslipForm = new PayslipForm(
            txtEmployeeNumber.Text,
            txtFirstName.Text,
            txtMiddleName.Text,
            txtSurname.Text,
            txtCivilStatus.Text,
            txtDependentsCount.Text,
            txtPaydate.Text,
            txtEmployeeStatus.Text,
            txtDesignation.Text,
            GetDecimalFromTextBox(txtBasicRate),
            GetDecimalFromTextBox(txtBasicHours),
            GetDecimalFromTextBox(txtBasicIncome),
            GetDecimalFromTextBox(txtHonorRate),
            GetDecimalFromTextBox(txtHonorHours),
            GetDecimalFromTextBox(txtHonorIncome),
            GetDecimalFromTextBox(txtOtherRate),
            GetDecimalFromTextBox(txtOtherHours),
            GetDecimalFromTextBox(txtOtherIncome),
            GetDecimalFromTextBox(txtGrossIncome),
            GetDecimalFromTextBox(txtNetIncome),
            GetDecimalFromTextBox(txtSSS),
            GetDecimalFromTextBox(txtPhilHealth),
            GetDecimalFromTextBox(txtPagIbig),
            GetDecimalFromTextBox(txtIncomeTax),
            GetDecimalFromTextBox(txtSSSLoan),
            GetDecimalFromTextBox(txtPagIbigLoan),
            GetDecimalFromTextBox(txtFacultySavings),
            GetDecimalFromTextBox(txtSalaryLoan),
            GetDecimalFromTextBox(txtOtherLoans),
            GetDecimalFromTextBox(txtTotalDeductions)
        );

        payslipForm.ShowDialog();
    }

    private void BtnUpdate_Click(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtEmployeeNumber.Text))
        {
            MessageBox.Show("Please enter Employee Number to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        MessageBox.Show("Payroll record updated successfully.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void BtnNew_Click(object? sender, EventArgs e)
    {
        ClearAllTextBoxes(this);
    }

    private void ClearAllTextBoxes(Control parent)
    {
        foreach (Control c in parent.Controls)
        {
            if (c is TextBox tb)
            {
                tb.Clear();
            }

            if (c.HasChildren)
            {
                ClearAllTextBoxes(c);
            }
        }
    }

    private void txtSSS_TextChanged(object sender, EventArgs e)
    {
        
    }

    private void txtPhilHealth_TextChanged(object sender, EventArgs e)
    {
        
    }

    private void txtPagIbig_TextChanged(object sender, EventArgs e)
    {
       
    }

    private void txtIncomeTax_TextChanged(object sender, EventArgs e)
    {
        
    }

    private void NumericOnly_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
        {
            e.Handled = true;
        }

        if (e.KeyChar == '.' && sender is TextBox tb && tb.Text.Contains('.'))
        {
            e.Handled = true;
        }
    }
}
