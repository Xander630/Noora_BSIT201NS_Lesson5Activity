using System;
using System.Drawing;
using System.Windows.Forms;

namespace PayrollApp;

public class PayslipForm : Form
{

    private Label lblCompanyValue;
    private Label lblEmployeeCodeValue;
    private Label lblEmployeeNameValue;
    private Label lblDepartmentValue;
    private Label lblCutOffValue;
    private Label lblPayPeriodValue;


    private Label lblBasicDaysValue;
    private Label lblBasicTaxableValue;
    private Label lblOvertimeDaysValue;
    private Label lblOvertimeTaxableValue;
    private Label lblHonorDaysValue;
    private Label lblHonorTaxableValue;

    private Label lblWithholdingTaxValue;
    private Label lblSSSValue;
    private Label lblHDMFValue;
    private Label lblPhilHealthValue;
    private Label lblSSSWispValue;
    private Label lblSSSLoanValue;
    private Label lblPagIbigLoanValue;
    private Label lblFacultySavingsValue;
    private Label lblSalaryLoanValue;
    private Label lblOtherLoansValue;


    private Label lblSummaryGrossValue;
    private Label lblSummaryDeductionsValue;
    private Label lblNetPayValue;

    public PayslipForm(
        string employeeNumber, string firstName, string middleName, string surname,
        string civilStatus, string dependents, string paydate, string employeeStatus, string designation,
        decimal basicRate, decimal basicHours, decimal basicIncome,
        decimal honorRate, decimal honorHours, decimal honorIncome,
        decimal otherRate, decimal otherHours, decimal otherIncome,
        decimal grossIncome, decimal netIncome,
        decimal sss, decimal philHealth, decimal pagIbig, decimal incomeTax,
        decimal sssLoan, decimal pagIbigLoan, decimal facultySavings, decimal salaryLoan, decimal otherLoans,
        decimal totalDeductions)
    {
        InitializeComponent();

      
        lblCompanyValue.Text = "Lyceum of the Philippines University Cavite";
        lblEmployeeCodeValue.Text = employeeNumber;
        lblEmployeeNameValue.Text = $"{firstName} {middleName} {surname}";
        lblDepartmentValue.Text = designation;
        lblCutOffValue.Text = paydate;
        lblPayPeriodValue.Text = paydate;

  
        lblBasicDaysValue.Text = basicHours.ToString("N2");
        lblBasicTaxableValue.Text = basicIncome.ToString("N2");
        lblOvertimeDaysValue.Text = otherHours.ToString("N2");
        lblOvertimeTaxableValue.Text = otherIncome.ToString("N2");
        lblHonorDaysValue.Text = honorHours.ToString("N2");
        lblHonorTaxableValue.Text = honorIncome.ToString("N2");

        lblWithholdingTaxValue.Text = incomeTax.ToString("N2");
        lblSSSValue.Text = sss.ToString("N2");
        lblHDMFValue.Text = pagIbig.ToString("N2");
        lblPhilHealthValue.Text = philHealth.ToString("N2");
        lblSSSWispValue.Text = "0.00";
        lblSSSLoanValue.Text = sssLoan.ToString("N2");
        lblPagIbigLoanValue.Text = pagIbigLoan.ToString("N2");
        lblFacultySavingsValue.Text = facultySavings.ToString("N2");
        lblSalaryLoanValue.Text = salaryLoan.ToString("N2");
        lblOtherLoansValue.Text = otherLoans.ToString("N2");

  
        lblSummaryGrossValue.Text = grossIncome.ToString("N2");
        lblSummaryDeductionsValue.Text = totalDeductions.ToString("N2");
        lblNetPayValue.Text = netIncome.ToString("N2");
    }

    private void InitializeComponent()
    {
        Text = "Payslip Report - SE-RI'S CHOICE PAYROLL";
        ClientSize = new Size(1100, 650);
        StartPosition = FormStartPosition.CenterScreen;
        BackColor = Color.White;

        var mainPanel = new Panel
        {
            Dock = DockStyle.Fill,
            BackColor = Color.White,
            Padding = new Padding(20)
        };

        Controls.Add(mainPanel);

        var infoTable = new TableLayoutPanel
        {
            ColumnCount = 4,
            RowCount = 4,
            Dock = DockStyle.Top,
            Height = 130,
            CellBorderStyle = TableLayoutPanelCellBorderStyle.Single
        };
        infoTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
        infoTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30));
        infoTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
        infoTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30));

        Label MakeHeader(string text)
        {
            return new Label
            {
                Text = text,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(4, 0, 0, 0)
            };
        }

        Label MakeValueLabel(out Label field)
        {
            field = new Label
            {
                Font = new Font("Segoe UI", 9F, FontStyle.Regular),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(4, 0, 0, 0)
            };
            return field;
        }

        infoTable.Controls.Add(MakeHeader("Company:"), 0, 0);
        infoTable.Controls.Add(MakeValueLabel(out lblCompanyValue), 1, 0);
        infoTable.Controls.Add(MakeHeader("Department:"), 2, 0);
        infoTable.Controls.Add(MakeValueLabel(out lblDepartmentValue), 3, 0);

        infoTable.Controls.Add(MakeHeader("Employee Code:"), 0, 1);
        infoTable.Controls.Add(MakeValueLabel(out lblEmployeeCodeValue), 1, 1);
        infoTable.Controls.Add(MakeHeader("Cut-Off:"), 2, 1);
        infoTable.Controls.Add(MakeValueLabel(out lblCutOffValue), 3, 1);

        infoTable.Controls.Add(MakeHeader("Employee Name:"), 0, 2);
        infoTable.Controls.Add(MakeValueLabel(out lblEmployeeNameValue), 1, 2);
        infoTable.Controls.Add(MakeHeader("Pay Period:"), 2, 2);
        infoTable.Controls.Add(MakeValueLabel(out lblPayPeriodValue), 3, 2);

        
        var headerStrip = new TableLayoutPanel
        {
            ColumnCount = 3,
            Dock = DockStyle.Top,
            Height = 30,
            Margin = new Padding(0, 10, 0, 0)
        };
        headerStrip.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45));
        headerStrip.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30));
        headerStrip.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));

        Label MakeGreyHeader(string text, ContentAlignment align)
        {
            return new Label
            {
                Text = text,
                BackColor = Color.FromArgb(220, 220, 220),
                Dock = DockStyle.Fill,
                TextAlign = align,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold)
            };
        }

        headerStrip.Controls.Add(MakeGreyHeader("EARNINGS", ContentAlignment.MiddleCenter), 0, 0);
        headerStrip.Controls.Add(MakeGreyHeader("DEDUCTIONS", ContentAlignment.MiddleCenter), 1, 0);
        headerStrip.Controls.Add(MakeGreyHeader("OVERTIME & NIGHT DIFFERENTIAL", ContentAlignment.MiddleCenter), 2, 0);

       
        var middlePanel = new TableLayoutPanel
        {
            ColumnCount = 3,
            RowCount = 1,
            Dock = DockStyle.Top,
            Height = 300
        };
        middlePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45));
        middlePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30));
        middlePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));

        
        var earningsTable = new TableLayoutPanel
        {
            ColumnCount = 4,
            Dock = DockStyle.Fill,
            CellBorderStyle = TableLayoutPanelCellBorderStyle.Single
        };
        earningsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40)); 
        earningsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20)); 
        earningsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20)); 
        earningsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20)); 

        void AddEarningsHeaderRow()
        {
            earningsTable.Controls.Add(MakeHeader(string.Empty), 0, 0);
            earningsTable.Controls.Add(MakeHeader("Day/Hrs"), 1, 0);
            earningsTable.Controls.Add(MakeHeader("Taxable"), 2, 0);
            earningsTable.Controls.Add(MakeHeader("Non Taxable"), 3, 0);
        }

        Label MakeRowText(string text)
        {
            return new Label
            {
                Text = text,
                Font = new Font("Segoe UI", 9F, FontStyle.Regular),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(4, 0, 0, 0)
            };
        }

        Label MakeRightValue(out Label field)
        {
            field = new Label
            {
                Font = new Font("Segoe UI", 9F, FontStyle.Regular),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleRight,
                Padding = new Padding(0, 0, 4, 0)
            };
            return field;
        }

        AddEarningsHeaderRow();
        int r = 1;

        earningsTable.RowStyles.Clear();
        for (int i = 0; i < 8; i++)
        {
            earningsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 24));
        }

        earningsTable.Controls.Add(MakeRowText("Basic Pay"), 0, r);
        earningsTable.Controls.Add(MakeRightValue(out lblBasicDaysValue), 1, r);
        earningsTable.Controls.Add(MakeRightValue(out lblBasicTaxableValue), 2, r);
        earningsTable.Controls.Add(new Label(), 3, r);
        r++;

        earningsTable.Controls.Add(MakeRowText("Overtime"), 0, r);
        earningsTable.Controls.Add(MakeRightValue(out lblOvertimeDaysValue), 1, r);
        earningsTable.Controls.Add(MakeRightValue(out lblOvertimeTaxableValue), 2, r);
        earningsTable.Controls.Add(new Label(), 3, r);
        r++;

        earningsTable.Controls.Add(MakeRowText("Honorarium"), 0, r);
        earningsTable.Controls.Add(MakeRightValue(out lblHonorDaysValue), 1, r);
        earningsTable.Controls.Add(MakeRightValue(out lblHonorTaxableValue), 2, r);
        earningsTable.Controls.Add(new Label(), 3, r);
        r++;

        earningsTable.Controls.Add(MakeRowText("Honorarium Adjustment"), 0, r);
        earningsTable.Controls.Add(new Label(), 1, r);
        earningsTable.Controls.Add(MakeRightValue(out _), 2, r);
        earningsTable.Controls.Add(new Label(), 3, r);
        r++;

        earningsTable.Controls.Add(MakeRowText("Substitution (LAB)"), 0, r);
        earningsTable.Controls.Add(new Label(), 1, r);
        earningsTable.Controls.Add(MakeRightValue(out _), 2, r);
        earningsTable.Controls.Add(new Label(), 3, r);
        r++;

        earningsTable.Controls.Add(MakeRowText("Tardy"), 0, r);
        earningsTable.Controls.Add(new Label(), 1, r);
        earningsTable.Controls.Add(MakeRightValue(out _), 2, r);
        earningsTable.Controls.Add(new Label(), 3, r);
        r++;

      
        var deductionsTable = new TableLayoutPanel
        {
            ColumnCount = 2,
            RowCount = 11, 
            Dock = DockStyle.Fill,
            CellBorderStyle = TableLayoutPanelCellBorderStyle.Single
        };

        deductionsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65));
        deductionsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35));

        Label MakeDedRow(string text, out Label valueLabel)
        {
            var lblText = MakeRowText(text);
            valueLabel = new Label
            {
                Font = new Font("Segoe UI", 9F, FontStyle.Regular),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleRight,
                Padding = new Padding(0, 0, 4, 0)
            };
            return lblText;
        }

        int dr = 0;
        deductionsTable.RowStyles.Clear();

        for (int i = 0; i < 11; i++)
        {
            deductionsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 24));
        }

        deductionsTable.Controls.Add(MakeDedRow("Withholding Tax", out lblWithholdingTaxValue), 0, dr);
        deductionsTable.Controls.Add(lblWithholdingTaxValue, 1, dr++);

        deductionsTable.Controls.Add(MakeDedRow("SSS - Contribution", out lblSSSValue), 0, dr);
        deductionsTable.Controls.Add(lblSSSValue, 1, dr++);

        deductionsTable.Controls.Add(MakeDedRow("HDMF - Contribution", out lblHDMFValue), 0, dr);
        deductionsTable.Controls.Add(lblHDMFValue, 1, dr++);

        deductionsTable.Controls.Add(MakeDedRow("PhilHealth - Contribution", out lblPhilHealthValue), 0, dr);
        deductionsTable.Controls.Add(lblPhilHealthValue, 1, dr++);

        deductionsTable.Controls.Add(MakeDedRow("SSS WISP - Contribution", out lblSSSWispValue), 0, dr);
        deductionsTable.Controls.Add(lblSSSWispValue, 1, dr++);

        deductionsTable.Controls.Add(MakeDedRow("SSS Loan", out lblSSSLoanValue), 0, dr);
        deductionsTable.Controls.Add(lblSSSLoanValue, 1, dr++);

        deductionsTable.Controls.Add(MakeDedRow("Pag-IBIG Loan", out lblPagIbigLoanValue), 0, dr);
        deductionsTable.Controls.Add(lblPagIbigLoanValue, 1, dr++);

        deductionsTable.Controls.Add(MakeDedRow("Faculty Savings Deposit", out lblFacultySavingsValue), 0, dr);
        deductionsTable.Controls.Add(lblFacultySavingsValue, 1, dr++);

        deductionsTable.Controls.Add(MakeDedRow("Salary Loan", out lblSalaryLoanValue), 0, dr);
        deductionsTable.Controls.Add(lblSalaryLoanValue, 1, dr++);

        deductionsTable.Controls.Add(MakeDedRow("Other Loans", out lblOtherLoansValue), 0, dr);
        deductionsTable.Controls.Add(lblOtherLoansValue, 1, dr++);

     
        middlePanel.Controls.Add(earningsTable, 0, 0);
        middlePanel.Controls.Add(deductionsTable, 1, 0);

        var overtimePanel = new Panel { Dock = DockStyle.Fill };
        middlePanel.Controls.Add(overtimePanel, 2, 0);


        var bottomPanel = new TableLayoutPanel
        {
            ColumnCount = 4,
            Dock = DockStyle.Bottom,
            Height = 80,
            Margin = new Padding(0, 20, 0, 0) // moved lower
        };

                bottomPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15));
                bottomPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35));
                bottomPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));
                bottomPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));

                bottomPanel.Controls.Add(MakeHeader("EARNINGS"), 0, 0);
                bottomPanel.Controls.Add(new Label(), 1, 0);
                bottomPanel.Controls.Add(MakeHeader("DEDUCTIONS"), 2, 0);
                bottomPanel.Controls.Add(new Label(), 3, 0);

                bottomPanel.Controls.Add(MakeHeader("GROSS EARNINGS"), 0, 1);
                bottomPanel.Controls.Add(MakeRightValue(out lblSummaryGrossValue), 1, 1);
                bottomPanel.Controls.Add(MakeHeader("DEDUCTIONS"), 2, 1);
                bottomPanel.Controls.Add(MakeRightValue(out lblSummaryDeductionsValue), 3, 1);

                bottomPanel.Controls.Add(MakeHeader("NET PAY"), 2, 2);
                bottomPanel.Controls.Add(MakeRightValue(out lblNetPayValue), 3, 2);

          
                mainPanel.Controls.Add(bottomPanel);
                mainPanel.Controls.Add(middlePanel);
                mainPanel.Controls.Add(headerStrip);
                mainPanel.Controls.Add(infoTable);
    }
}

