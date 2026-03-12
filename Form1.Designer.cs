namespace PayrollApp;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    // Label declarations for designer
    private Label lblTitle;
    private Label lblEmpInfo;
    private Panel pnlAvatar;
    private Label lblEmpNumber;
    private Label lblFirstName;
    private Label lblMiddleName;
    private Label lblSurname;
    private Label lblCivilStatus;
    private Label lblQualifiedDependents;
    private Label lblDependentsCount;
    private Label lblPaydate;
    private Label lblEmployeeStatus;
    private Label lblDesignation;
    private Label lblBasicInc;
    private Label lblBasicRate;
    private Label lblBasicHours;
    private Label lblBasicIncome;
    private Label lblHonorInc;
    private Label lblHonorRate;
    private Label lblHonorHours;
    private Label lblHonorIncome;
    private Label lblOtherInc;
    private Label lblOtherRate;
    private Label lblOtherHours;
    private Label lblOtherIncome;
    private Label lblSummaryInc;
    private Label lblGrossIncomeLbl;
    private Label lblNetIncomeLbl;
    private Label lblRegDed;
    private Label lblSSS;
    private Label lblPhilHealth;
    private Label lblPagIbig;
    private Label lblIncomeTax;
    private Label lblOtherDed;
    private Label lblSSSLoan;
    private Label lblPagIbigLoan;
    private Label lblFacultySavings;
    private Label lblSalaryLoan;
    private Label lblOtherLoans;
    private Label lblDedSummary;
    private Label lblTotalDeductionsLbl;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        lblTitle = new Label();
        lblEmpInfo = new Label();
        pnlAvatar = new Panel();
        lblEmpNumber = new Label();
        txtEmployeeNumber = new TextBox();
        lblFirstName = new Label();
        txtFirstName = new TextBox();
        lblMiddleName = new Label();
        txtMiddleName = new TextBox();
        lblSurname = new Label();
        txtSurname = new TextBox();
        lblCivilStatus = new Label();
        txtCivilStatus = new TextBox();
        lblQualifiedDependents = new Label();
        txtQualifiedDependents = new TextBox();
        lblDependentsCount = new Label();
        txtDependentsCount = new TextBox();
        lblPaydate = new Label();
        txtPaydate = new TextBox();
        lblEmployeeStatus = new Label();
        txtEmployeeStatus = new TextBox();
        lblDesignation = new Label();
        txtDesignation = new TextBox();
        lblBasicInc = new Label();
        lblBasicRate = new Label();
        txtBasicRate = new TextBox();
        lblBasicHours = new Label();
        txtBasicHours = new TextBox();
        lblBasicIncome = new Label();
        txtBasicIncome = new TextBox();
        lblHonorInc = new Label();
        lblHonorRate = new Label();
        txtHonorRate = new TextBox();
        lblHonorHours = new Label();
        txtHonorHours = new TextBox();
        lblHonorIncome = new Label();
        txtHonorIncome = new TextBox();
        lblOtherInc = new Label();
        lblOtherRate = new Label();
        txtOtherRate = new TextBox();
        lblOtherHours = new Label();
        txtOtherHours = new TextBox();
        lblOtherIncome = new Label();
        txtOtherIncome = new TextBox();
        lblSummaryInc = new Label();
        lblGrossIncomeLbl = new Label();
        txtGrossIncome = new TextBox();
        lblNetIncomeLbl = new Label();
        txtNetIncome = new TextBox();
        lblRegDed = new Label();
        lblSSS = new Label();
        txtSSS = new TextBox();
        lblPhilHealth = new Label();
        txtPhilHealth = new TextBox();
        lblPagIbig = new Label();
        txtPagIbig = new TextBox();
        lblIncomeTax = new Label();
        txtIncomeTax = new TextBox();
        lblOtherDed = new Label();
        lblSSSLoan = new Label();
        txtSSSLoan = new TextBox();
        lblPagIbigLoan = new Label();
        txtPagIbigLoan = new TextBox();
        lblFacultySavings = new Label();
        txtFacultySavings = new TextBox();
        lblSalaryLoan = new Label();
        txtSalaryLoan = new TextBox();
        lblOtherLoans = new Label();
        txtOtherLoans = new TextBox();
        lblDedSummary = new Label();
        lblTotalDeductionsLbl = new Label();
        txtTotalDeductions = new TextBox();
        btnGrossIncome = new Button();
        btnNetIncome = new Button();
        btnSave = new Button();
        btnUpdate = new Button();
        btnNew = new Button();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
        lblTitle.Location = new Point(450, 15);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(331, 29);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "SE-RI'S CHOICE PAYROLL";
        // 
        // lblEmpInfo
        // 
        lblEmpInfo.AutoSize = true;
        lblEmpInfo.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
        lblEmpInfo.Location = new Point(30, 50);
        lblEmpInfo.Name = "lblEmpInfo";
        lblEmpInfo.Size = new Size(200, 18);
        lblEmpInfo.TabIndex = 1;
        lblEmpInfo.Text = "EMPLOYEE BASIC INFO:";
        // 
        // pnlAvatar
        // 
        pnlAvatar.Location = new Point(50, 80);
        pnlAvatar.Name = "pnlAvatar";
        pnlAvatar.Size = new Size(120, 120);
        pnlAvatar.TabIndex = 2;
        // 
        // lblEmpNumber
        // 
        lblEmpNumber.AutoSize = true;
        lblEmpNumber.Font = new Font("Microsoft Sans Serif", 9F);
        lblEmpNumber.Location = new Point(190, 75);
        lblEmpNumber.Name = "lblEmpNumber";
        lblEmpNumber.Size = new Size(113, 15);
        lblEmpNumber.TabIndex = 3;
        lblEmpNumber.Text = "Employee Number:";
        // 
        // txtEmployeeNumber
        // 
        txtEmployeeNumber.Location = new Point(310, 73);
        txtEmployeeNumber.Name = "txtEmployeeNumber";
        txtEmployeeNumber.Size = new Size(130, 23);
        txtEmployeeNumber.TabIndex = 4;
        // 
        // lblFirstName
        // 
        lblFirstName.AutoSize = true;
        lblFirstName.Font = new Font("Microsoft Sans Serif", 9F);
        lblFirstName.Location = new Point(190, 105);
        lblFirstName.Name = "lblFirstName";
        lblFirstName.Size = new Size(70, 15);
        lblFirstName.TabIndex = 5;
        lblFirstName.Text = "First Name:";
        // 
        // txtFirstName
        // 
        txtFirstName.Location = new Point(310, 103);
        txtFirstName.Name = "txtFirstName";
        txtFirstName.Size = new Size(130, 23);
        txtFirstName.TabIndex = 6;
        // 
        // lblMiddleName
        // 
        lblMiddleName.AutoSize = true;
        lblMiddleName.Font = new Font("Microsoft Sans Serif", 9F);
        lblMiddleName.Location = new Point(190, 135);
        lblMiddleName.Name = "lblMiddleName";
        lblMiddleName.Size = new Size(85, 15);
        lblMiddleName.TabIndex = 7;
        lblMiddleName.Text = "Middle Name:";
        // 
        // txtMiddleName
        // 
        txtMiddleName.Location = new Point(310, 133);
        txtMiddleName.Name = "txtMiddleName";
        txtMiddleName.Size = new Size(130, 23);
        txtMiddleName.TabIndex = 8;
        // 
        // lblSurname
        // 
        lblSurname.AutoSize = true;
        lblSurname.Font = new Font("Microsoft Sans Serif", 9F);
        lblSurname.Location = new Point(190, 165);
        lblSurname.Name = "lblSurname";
        lblSurname.Size = new Size(61, 15);
        lblSurname.TabIndex = 9;
        lblSurname.Text = "Surname:";
        // 
        // txtSurname
        // 
        txtSurname.Location = new Point(310, 163);
        txtSurname.Name = "txtSurname";
        txtSurname.Size = new Size(130, 23);
        txtSurname.TabIndex = 10;
        // 
        // lblCivilStatus
        // 
        lblCivilStatus.AutoSize = true;
        lblCivilStatus.Font = new Font("Microsoft Sans Serif", 9F);
        lblCivilStatus.Location = new Point(520, 75);
        lblCivilStatus.Name = "lblCivilStatus";
        lblCivilStatus.Size = new Size(69, 15);
        lblCivilStatus.TabIndex = 11;
        lblCivilStatus.Text = "Civil Status:";
        // 
        // txtCivilStatus
        // 
        txtCivilStatus.Location = new Point(620, 73);
        txtCivilStatus.Name = "txtCivilStatus";
        txtCivilStatus.Size = new Size(130, 23);
        txtCivilStatus.TabIndex = 12;
        // 
        // lblQualifiedDependents
        // 
        lblQualifiedDependents.AutoSize = true;
        lblQualifiedDependents.Font = new Font("Microsoft Sans Serif", 9F);
        lblQualifiedDependents.Location = new Point(520, 105);
        lblQualifiedDependents.Name = "lblQualifiedDependents";
        lblQualifiedDependents.Size = new Size(129, 15);
        lblQualifiedDependents.TabIndex = 13;
        lblQualifiedDependents.Text = "Qualified Dependents:";
        // 
        // txtQualifiedDependents
        // 
        txtQualifiedDependents.Location = new Point(651, 105);
        txtQualifiedDependents.Name = "txtQualifiedDependents";
        txtQualifiedDependents.Size = new Size(130, 23);
        txtQualifiedDependents.TabIndex = 14;
        // 
        // lblDependentsCount
        // 
        lblDependentsCount.AutoSize = true;
        lblDependentsCount.Font = new Font("Microsoft Sans Serif", 9F);
        lblDependentsCount.Location = new Point(520, 135);
        lblDependentsCount.Name = "lblDependentsCount";
        lblDependentsCount.Size = new Size(109, 15);
        lblDependentsCount.TabIndex = 15;
        lblDependentsCount.Text = "No of Dependents:";
        // 
        // txtDependentsCount
        // 
        txtDependentsCount.Location = new Point(635, 133);
        txtDependentsCount.Name = "txtDependentsCount";
        txtDependentsCount.Size = new Size(130, 23);
        txtDependentsCount.TabIndex = 16;
        // 
        // lblPaydate
        // 
        lblPaydate.AutoSize = true;
        lblPaydate.Font = new Font("Microsoft Sans Serif", 9F);
        lblPaydate.Location = new Point(520, 165);
        lblPaydate.Name = "lblPaydate";
        lblPaydate.Size = new Size(57, 15);
        lblPaydate.TabIndex = 17;
        lblPaydate.Text = "Pay date:";
        // 
        // txtPaydate
        // 
        txtPaydate.Location = new Point(620, 163);
        txtPaydate.Name = "txtPaydate";
        txtPaydate.Size = new Size(130, 23);
        txtPaydate.TabIndex = 18;
        // 
        // lblEmployeeStatus
        // 
        lblEmployeeStatus.AutoSize = true;
        lblEmployeeStatus.Font = new Font("Microsoft Sans Serif", 9F);
        lblEmployeeStatus.Location = new Point(800, 75);
        lblEmployeeStatus.Name = "lblEmployeeStatus";
        lblEmployeeStatus.Size = new Size(102, 15);
        lblEmployeeStatus.TabIndex = 19;
        lblEmployeeStatus.Text = "Employee Status:";
        // 
        // txtEmployeeStatus
        // 
        txtEmployeeStatus.Location = new Point(900, 73);
        txtEmployeeStatus.Name = "txtEmployeeStatus";
        txtEmployeeStatus.Size = new Size(130, 23);
        txtEmployeeStatus.TabIndex = 20;
        // 
        // lblDesignation
        // 
        lblDesignation.AutoSize = true;
        lblDesignation.Font = new Font("Microsoft Sans Serif", 9F);
        lblDesignation.Location = new Point(800, 105);
        lblDesignation.Name = "lblDesignation";
        lblDesignation.Size = new Size(76, 15);
        lblDesignation.TabIndex = 21;
        lblDesignation.Text = "Designation:";
        // 
        // txtDesignation
        // 
        txtDesignation.Location = new Point(900, 103);
        txtDesignation.Name = "txtDesignation";
        txtDesignation.Size = new Size(130, 23);
        txtDesignation.TabIndex = 22;
        // 
        // lblBasicInc
        // 
        lblBasicInc.AutoSize = true;
        lblBasicInc.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
        lblBasicInc.Location = new Point(30, 220);
        lblBasicInc.Name = "lblBasicInc";
        lblBasicInc.Size = new Size(121, 17);
        lblBasicInc.TabIndex = 23;
        lblBasicInc.Text = "BASIC INCOME:";
        // 
        // lblBasicRate
        // 
        lblBasicRate.AutoSize = true;
        lblBasicRate.Font = new Font("Microsoft Sans Serif", 9F);
        lblBasicRate.Location = new Point(30, 254);
        lblBasicRate.Name = "lblBasicRate";
        lblBasicRate.Size = new Size(72, 15);
        lblBasicRate.TabIndex = 24;
        lblBasicRate.Text = "Rate / Hour:";
        // 
        // txtBasicRate
        // 
        txtBasicRate.Location = new Point(180, 250);
        txtBasicRate.Name = "txtBasicRate";
        txtBasicRate.Size = new Size(100, 23);
        txtBasicRate.TabIndex = 25;
        // 
        // lblBasicHours
        // 
        lblBasicHours.AutoSize = true;
        lblBasicHours.Font = new Font("Microsoft Sans Serif", 9F);
        lblBasicHours.Location = new Point(30, 282);
        lblBasicHours.Name = "lblBasicHours";
        lblBasicHours.Size = new Size(123, 15);
        lblBasicHours.TabIndex = 26;
        lblBasicHours.Text = "No. of Hours / Cut Off:";
        // 
        // txtBasicHours
        // 
        txtBasicHours.Location = new Point(180, 278);
        txtBasicHours.Name = "txtBasicHours";
        txtBasicHours.Size = new Size(100, 23);
        txtBasicHours.TabIndex = 27;
        // 
        // lblBasicIncome
        // 
        lblBasicIncome.AutoSize = true;
        lblBasicIncome.Font = new Font("Microsoft Sans Serif", 9F);
        lblBasicIncome.Location = new Point(30, 310);
        lblBasicIncome.Name = "lblBasicIncome";
        lblBasicIncome.Size = new Size(96, 15);
        lblBasicIncome.TabIndex = 28;
        lblBasicIncome.Text = "Income / Cut Off:";
        // 
        // txtBasicIncome
        // 
        txtBasicIncome.Location = new Point(180, 306);
        txtBasicIncome.Name = "txtBasicIncome";
        txtBasicIncome.ReadOnly = true;
        txtBasicIncome.Size = new Size(100, 23);
        txtBasicIncome.TabIndex = 29;
        // 
        // lblHonorInc
        // 
        lblHonorInc.AutoSize = true;
        lblHonorInc.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
        lblHonorInc.Location = new Point(30, 350);
        lblHonorInc.Name = "lblHonorInc";
        lblHonorInc.Size = new Size(182, 17);
        lblHonorInc.TabIndex = 30;
        lblHonorInc.Text = "HONORARIUM INCOME:";
        // 
        // lblHonorRate
        // 
        lblHonorRate.AutoSize = true;
        lblHonorRate.Font = new Font("Microsoft Sans Serif", 9F);
        lblHonorRate.Location = new Point(30, 384);
        lblHonorRate.Name = "lblHonorRate";
        lblHonorRate.Size = new Size(72, 15);
        lblHonorRate.TabIndex = 31;
        lblHonorRate.Text = "Rate / Hour:";
        // 
        // txtHonorRate
        // 
        txtHonorRate.Location = new Point(180, 380);
        txtHonorRate.Name = "txtHonorRate";
        txtHonorRate.Size = new Size(100, 23);
        txtHonorRate.TabIndex = 32;
        // 
        // lblHonorHours
        // 
        lblHonorHours.AutoSize = true;
        lblHonorHours.Font = new Font("Microsoft Sans Serif", 9F);
        lblHonorHours.Location = new Point(30, 412);
        lblHonorHours.Name = "lblHonorHours";
        lblHonorHours.Size = new Size(123, 15);
        lblHonorHours.TabIndex = 33;
        lblHonorHours.Text = "No. of Hours / Cut Off:";
        // 
        // txtHonorHours
        // 
        txtHonorHours.Location = new Point(180, 408);
        txtHonorHours.Name = "txtHonorHours";
        txtHonorHours.Size = new Size(100, 23);
        txtHonorHours.TabIndex = 34;
        // 
        // lblHonorIncome
        // 
        lblHonorIncome.AutoSize = true;
        lblHonorIncome.Font = new Font("Microsoft Sans Serif", 9F);
        lblHonorIncome.Location = new Point(30, 440);
        lblHonorIncome.Name = "lblHonorIncome";
        lblHonorIncome.Size = new Size(96, 15);
        lblHonorIncome.TabIndex = 35;
        lblHonorIncome.Text = "Income / Cut Off:";
        // 
        // txtHonorIncome
        // 
        txtHonorIncome.Location = new Point(180, 436);
        txtHonorIncome.Name = "txtHonorIncome";
        txtHonorIncome.ReadOnly = true;
        txtHonorIncome.Size = new Size(100, 23);
        txtHonorIncome.TabIndex = 36;
        // 
        // lblOtherInc
        // 
        lblOtherInc.AutoSize = true;
        lblOtherInc.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
        lblOtherInc.Location = new Point(30, 480);
        lblOtherInc.Name = "lblOtherInc";
        lblOtherInc.Size = new Size(131, 17);
        lblOtherInc.TabIndex = 37;
        lblOtherInc.Text = "OTHER INCOME:";
        // 
        // lblOtherRate
        // 
        lblOtherRate.AutoSize = true;
        lblOtherRate.Font = new Font("Microsoft Sans Serif", 9F);
        lblOtherRate.Location = new Point(30, 514);
        lblOtherRate.Name = "lblOtherRate";
        lblOtherRate.Size = new Size(72, 15);
        lblOtherRate.TabIndex = 38;
        lblOtherRate.Text = "Rate / Hour:";
        // 
        // txtOtherRate
        // 
        txtOtherRate.Location = new Point(180, 510);
        txtOtherRate.Name = "txtOtherRate";
        txtOtherRate.Size = new Size(100, 23);
        txtOtherRate.TabIndex = 39;
        // 
        // lblOtherHours
        // 
        lblOtherHours.AutoSize = true;
        lblOtherHours.Font = new Font("Microsoft Sans Serif", 9F);
        lblOtherHours.Location = new Point(30, 542);
        lblOtherHours.Name = "lblOtherHours";
        lblOtherHours.Size = new Size(123, 15);
        lblOtherHours.TabIndex = 40;
        lblOtherHours.Text = "No. of Hours / Cut Off:";
        // 
        // txtOtherHours
        // 
        txtOtherHours.Location = new Point(180, 538);
        txtOtherHours.Name = "txtOtherHours";
        txtOtherHours.Size = new Size(100, 23);
        txtOtherHours.TabIndex = 41;
        // 
        // lblOtherIncome
        // 
        lblOtherIncome.AutoSize = true;
        lblOtherIncome.Font = new Font("Microsoft Sans Serif", 9F);
        lblOtherIncome.Location = new Point(30, 570);
        lblOtherIncome.Name = "lblOtherIncome";
        lblOtherIncome.Size = new Size(96, 15);
        lblOtherIncome.TabIndex = 42;
        lblOtherIncome.Text = "Income / Cut Off:";
        // 
        // txtOtherIncome
        // 
        txtOtherIncome.Location = new Point(180, 566);
        txtOtherIncome.Name = "txtOtherIncome";
        txtOtherIncome.ReadOnly = true;
        txtOtherIncome.Size = new Size(100, 23);
        txtOtherIncome.TabIndex = 43;
        // 
        // lblSummaryInc
        // 
        lblSummaryInc.AutoSize = true;
        lblSummaryInc.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
        lblSummaryInc.Location = new Point(30, 610);
        lblSummaryInc.Name = "lblSummaryInc";
        lblSummaryInc.Size = new Size(153, 17);
        lblSummaryInc.TabIndex = 44;
        lblSummaryInc.Text = "SUMMARY INCOME:";
        // 
        // lblGrossIncomeLbl
        // 
        lblGrossIncomeLbl.AutoSize = true;
        lblGrossIncomeLbl.Font = new Font("Microsoft Sans Serif", 9F);
        lblGrossIncomeLbl.Location = new Point(30, 644);
        lblGrossIncomeLbl.Name = "lblGrossIncomeLbl";
        lblGrossIncomeLbl.Size = new Size(104, 15);
        lblGrossIncomeLbl.TabIndex = 45;
        lblGrossIncomeLbl.Text = "GROSS INCOME:";
        // 
        // txtGrossIncome
        // 
        txtGrossIncome.Location = new Point(180, 640);
        txtGrossIncome.Name = "txtGrossIncome";
        txtGrossIncome.ReadOnly = true;
        txtGrossIncome.Size = new Size(100, 23);
        txtGrossIncome.TabIndex = 46;
        // 
        // lblNetIncomeLbl
        // 
        lblNetIncomeLbl.AutoSize = true;
        lblNetIncomeLbl.Font = new Font("Microsoft Sans Serif", 9F);
        lblNetIncomeLbl.Location = new Point(30, 672);
        lblNetIncomeLbl.Name = "lblNetIncomeLbl";
        lblNetIncomeLbl.Size = new Size(85, 15);
        lblNetIncomeLbl.TabIndex = 47;
        lblNetIncomeLbl.Text = "NET INCOME:";
        // 
        // txtNetIncome
        // 
        txtNetIncome.Location = new Point(180, 668);
        txtNetIncome.Name = "txtNetIncome";
        txtNetIncome.ReadOnly = true;
        txtNetIncome.Size = new Size(100, 23);
        txtNetIncome.TabIndex = 48;
        // 
        // lblRegDed
        // 
        lblRegDed.AutoSize = true;
        lblRegDed.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
        lblRegDed.Location = new Point(520, 220);
        lblRegDed.Name = "lblRegDed";
        lblRegDed.Size = new Size(192, 17);
        lblRegDed.TabIndex = 49;
        lblRegDed.Text = "REGULAR DEDUCTIONS:";
        // 
        // lblSSS
        // 
        lblSSS.AutoSize = true;
        lblSSS.Font = new Font("Microsoft Sans Serif", 9F);
        lblSSS.Location = new Point(520, 254);
        lblSSS.Name = "lblSSS";
        lblSSS.Size = new Size(103, 15);
        lblSSS.TabIndex = 50;
        lblSSS.Text = "SSS Contribution:";
        // 
        // txtSSS
        // 
        txtSSS.Location = new Point(670, 250);
        txtSSS.Name = "txtSSS";
        txtSSS.ReadOnly = true;
        txtSSS.Size = new Size(100, 23);
        txtSSS.TabIndex = 51;
        // 
        // lblPhilHealth
        // 
        lblPhilHealth.AutoSize = true;
        lblPhilHealth.Font = new Font("Microsoft Sans Serif", 9F);
        lblPhilHealth.Location = new Point(520, 282);
        lblPhilHealth.Name = "lblPhilHealth";
        lblPhilHealth.Size = new Size(136, 15);
        lblPhilHealth.TabIndex = 52;
        lblPhilHealth.Text = "PhilHealth Contribution:";
        // 
        // txtPhilHealth
        // 
        txtPhilHealth.Location = new Point(670, 278);
        txtPhilHealth.Name = "txtPhilHealth";
        txtPhilHealth.ReadOnly = true;
        txtPhilHealth.Size = new Size(100, 23);
        txtPhilHealth.TabIndex = 53;
        // 
        // lblPagIbig
        // 
        lblPagIbig.AutoSize = true;
        lblPagIbig.Font = new Font("Microsoft Sans Serif", 9F);
        lblPagIbig.Location = new Point(520, 310);
        lblPagIbig.Name = "lblPagIbig";
        lblPagIbig.Size = new Size(128, 15);
        lblPagIbig.TabIndex = 54;
        lblPagIbig.Text = "Pag-IBIG Contribution:";
        // 
        // txtPagIbig
        // 
        txtPagIbig.Location = new Point(670, 306);
        txtPagIbig.Name = "txtPagIbig";
        txtPagIbig.ReadOnly = true;
        txtPagIbig.Size = new Size(100, 23);
        txtPagIbig.TabIndex = 55;
        // 
        // lblIncomeTax
        // 
        lblIncomeTax.AutoSize = true;
        lblIncomeTax.Font = new Font("Microsoft Sans Serif", 9F);
        lblIncomeTax.Location = new Point(520, 338);
        lblIncomeTax.Name = "lblIncomeTax";
        lblIncomeTax.Size = new Size(143, 15);
        lblIncomeTax.TabIndex = 56;
        lblIncomeTax.Text = "Income Tax Contribution:";
        // 
        // txtIncomeTax
        // 
        txtIncomeTax.Location = new Point(670, 334);
        txtIncomeTax.Name = "txtIncomeTax";
        txtIncomeTax.ReadOnly = true;
        txtIncomeTax.Size = new Size(100, 23);
        txtIncomeTax.TabIndex = 57;
        // 
        // lblOtherDed
        // 
        lblOtherDed.AutoSize = true;
        lblOtherDed.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
        lblOtherDed.Location = new Point(520, 375);
        lblOtherDed.Name = "lblOtherDed";
        lblOtherDed.Size = new Size(172, 17);
        lblOtherDed.TabIndex = 58;
        lblOtherDed.Text = "OTHER DEDUCTIONS:";
        // 
        // lblSSSLoan
        // 
        lblSSSLoan.AutoSize = true;
        lblSSSLoan.Font = new Font("Microsoft Sans Serif", 9F);
        lblSSSLoan.Location = new Point(520, 409);
        lblSSSLoan.Name = "lblSSSLoan";
        lblSSSLoan.Size = new Size(65, 15);
        lblSSSLoan.TabIndex = 59;
        lblSSSLoan.Text = "SSS Loan:";
        // 
        // txtSSSLoan
        // 
        txtSSSLoan.Location = new Point(670, 405);
        txtSSSLoan.Name = "txtSSSLoan";
        txtSSSLoan.Size = new Size(100, 23);
        txtSSSLoan.TabIndex = 60;
        // 
        // lblPagIbigLoan
        // 
        lblPagIbigLoan.AutoSize = true;
        lblPagIbigLoan.Font = new Font("Microsoft Sans Serif", 9F);
        lblPagIbigLoan.Location = new Point(520, 437);
        lblPagIbigLoan.Name = "lblPagIbigLoan";
        lblPagIbigLoan.Size = new Size(90, 15);
        lblPagIbigLoan.TabIndex = 61;
        lblPagIbigLoan.Text = "Pag-IBIG Loan:";
        // 
        // txtPagIbigLoan
        // 
        txtPagIbigLoan.Location = new Point(670, 433);
        txtPagIbigLoan.Name = "txtPagIbigLoan";
        txtPagIbigLoan.Size = new Size(100, 23);
        txtPagIbigLoan.TabIndex = 62;
        // 
        // lblFacultySavings
        // 
        lblFacultySavings.AutoSize = true;
        lblFacultySavings.Font = new Font("Microsoft Sans Serif", 9F);
        lblFacultySavings.Location = new Point(520, 465);
        lblFacultySavings.Name = "lblFacultySavings";
        lblFacultySavings.Size = new Size(139, 15);
        lblFacultySavings.TabIndex = 63;
        lblFacultySavings.Text = "Faculty Savings Deposit:";
        // 
        // txtFacultySavings
        // 
        txtFacultySavings.Location = new Point(670, 461);
        txtFacultySavings.Name = "txtFacultySavings";
        txtFacultySavings.Size = new Size(100, 23);
        txtFacultySavings.TabIndex = 64;
        // 
        // lblSalaryLoan
        // 
        lblSalaryLoan.AutoSize = true;
        lblSalaryLoan.Font = new Font("Microsoft Sans Serif", 9F);
        lblSalaryLoan.Location = new Point(520, 493);
        lblSalaryLoan.Name = "lblSalaryLoan";
        lblSalaryLoan.Size = new Size(75, 15);
        lblSalaryLoan.TabIndex = 65;
        lblSalaryLoan.Text = "Salary Loan:";
        // 
        // txtSalaryLoan
        // 
        txtSalaryLoan.Location = new Point(670, 489);
        txtSalaryLoan.Name = "txtSalaryLoan";
        txtSalaryLoan.Size = new Size(100, 23);
        txtSalaryLoan.TabIndex = 66;
        // 
        // lblOtherLoans
        // 
        lblOtherLoans.AutoSize = true;
        lblOtherLoans.Font = new Font("Microsoft Sans Serif", 9F);
        lblOtherLoans.Location = new Point(520, 521);
        lblOtherLoans.Name = "lblOtherLoans";
        lblOtherLoans.Size = new Size(77, 15);
        lblOtherLoans.TabIndex = 67;
        lblOtherLoans.Text = "Other Loans:";
        // 
        // txtOtherLoans
        // 
        txtOtherLoans.Location = new Point(670, 517);
        txtOtherLoans.Name = "txtOtherLoans";
        txtOtherLoans.Size = new Size(100, 23);
        txtOtherLoans.TabIndex = 68;
        // 
        // lblDedSummary
        // 
        lblDedSummary.AutoSize = true;
        lblDedSummary.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
        lblDedSummary.Location = new Point(520, 560);
        lblDedSummary.Name = "lblDedSummary";
        lblDedSummary.Size = new Size(184, 17);
        lblDedSummary.TabIndex = 69;
        lblDedSummary.Text = "DEDUCTION SUMMARY:";
        // 
        // lblTotalDeductionsLbl
        // 
        lblTotalDeductionsLbl.AutoSize = true;
        lblTotalDeductionsLbl.Font = new Font("Microsoft Sans Serif", 9F);
        lblTotalDeductionsLbl.Location = new Point(520, 594);
        lblTotalDeductionsLbl.Name = "lblTotalDeductionsLbl";
        lblTotalDeductionsLbl.Size = new Size(129, 15);
        lblTotalDeductionsLbl.TabIndex = 70;
        lblTotalDeductionsLbl.Text = "TOTAL DEDUCTIONS:";
        // 
        // txtTotalDeductions
        // 
        txtTotalDeductions.Location = new Point(670, 590);
        txtTotalDeductions.Name = "txtTotalDeductions";
        txtTotalDeductions.ReadOnly = true;
        txtTotalDeductions.Size = new Size(100, 23);
        txtTotalDeductions.TabIndex = 71;
        // 
        // btnGrossIncome
        // 
        btnGrossIncome.BackColor = Color.FromArgb(80, 80, 80);
        btnGrossIncome.Cursor = Cursors.Hand;
        btnGrossIncome.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
        btnGrossIncome.ForeColor = Color.White;
        btnGrossIncome.Location = new Point(320, 753);
        btnGrossIncome.Name = "btnGrossIncome";
        btnGrossIncome.Size = new Size(134, 35);
        btnGrossIncome.TabIndex = 72;
        btnGrossIncome.Text = "GROSS INCOME";
        btnGrossIncome.UseVisualStyleBackColor = false;
        btnGrossIncome.Click += BtnGrossIncome_Click;
        // 
        // btnNetIncome
        // 
        btnNetIncome.BackColor = Color.FromArgb(100, 100, 100);
        btnNetIncome.Cursor = Cursors.Hand;
        btnNetIncome.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
        btnNetIncome.ForeColor = Color.White;
        btnNetIncome.Location = new Point(460, 753);
        btnNetIncome.Name = "btnNetIncome";
        btnNetIncome.Size = new Size(100, 35);
        btnNetIncome.TabIndex = 73;
        btnNetIncome.Text = "NET INCOME";
        btnNetIncome.UseVisualStyleBackColor = false;
        btnNetIncome.Click += BtnNetIncome_Click;
        // 
        // btnSave
        // 
        btnSave.BackColor = Color.FromArgb(120, 120, 120);
        btnSave.Cursor = Cursors.Hand;
        btnSave.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
        btnSave.ForeColor = Color.White;
        btnSave.Location = new Point(580, 753);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(100, 35);
        btnSave.TabIndex = 74;
        btnSave.Text = "SAVE";
        btnSave.UseVisualStyleBackColor = false;
        btnSave.Click += BtnSave_Click;
        // 
        // btnUpdate
        // 
        btnUpdate.BackColor = Color.FromArgb(140, 140, 140);
        btnUpdate.Cursor = Cursors.Hand;
        btnUpdate.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
        btnUpdate.ForeColor = Color.White;
        btnUpdate.Location = new Point(700, 753);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new Size(100, 35);
        btnUpdate.TabIndex = 75;
        btnUpdate.Text = "UPDATE";
        btnUpdate.UseVisualStyleBackColor = false;
        btnUpdate.Click += BtnUpdate_Click;
        // 
        // btnNew
        // 
        btnNew.BackColor = Color.FromArgb(160, 160, 160);
        btnNew.Cursor = Cursors.Hand;
        btnNew.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
        btnNew.ForeColor = Color.White;
        btnNew.Location = new Point(820, 753);
        btnNew.Name = "btnNew";
        btnNew.Size = new Size(100, 35);
        btnNew.TabIndex = 76;
        btnNew.Text = "NEW";
        btnNew.UseVisualStyleBackColor = false;
        btnNew.Click += BtnNew_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(1200, 800);
        Controls.Add(lblTitle);
        Controls.Add(lblEmpInfo);
        Controls.Add(pnlAvatar);
        Controls.Add(lblEmpNumber);
        Controls.Add(txtEmployeeNumber);
        Controls.Add(lblFirstName);
        Controls.Add(txtFirstName);
        Controls.Add(lblMiddleName);
        Controls.Add(txtMiddleName);
        Controls.Add(lblSurname);
        Controls.Add(txtSurname);
        Controls.Add(lblCivilStatus);
        Controls.Add(txtCivilStatus);
        Controls.Add(lblQualifiedDependents);
        Controls.Add(txtQualifiedDependents);
        Controls.Add(lblDependentsCount);
        Controls.Add(txtDependentsCount);
        Controls.Add(lblPaydate);
        Controls.Add(txtPaydate);
        Controls.Add(lblEmployeeStatus);
        Controls.Add(txtEmployeeStatus);
        Controls.Add(lblDesignation);
        Controls.Add(txtDesignation);
        Controls.Add(lblBasicInc);
        Controls.Add(lblBasicRate);
        Controls.Add(txtBasicRate);
        Controls.Add(lblBasicHours);
        Controls.Add(txtBasicHours);
        Controls.Add(lblBasicIncome);
        Controls.Add(txtBasicIncome);
        Controls.Add(lblHonorInc);
        Controls.Add(lblHonorRate);
        Controls.Add(txtHonorRate);
        Controls.Add(lblHonorHours);
        Controls.Add(txtHonorHours);
        Controls.Add(lblHonorIncome);
        Controls.Add(txtHonorIncome);
        Controls.Add(lblOtherInc);
        Controls.Add(lblOtherRate);
        Controls.Add(txtOtherRate);
        Controls.Add(lblOtherHours);
        Controls.Add(txtOtherHours);
        Controls.Add(lblOtherIncome);
        Controls.Add(txtOtherIncome);
        Controls.Add(lblSummaryInc);
        Controls.Add(lblGrossIncomeLbl);
        Controls.Add(txtGrossIncome);
        Controls.Add(lblNetIncomeLbl);
        Controls.Add(txtNetIncome);
        Controls.Add(lblRegDed);
        Controls.Add(lblSSS);
        Controls.Add(txtSSS);
        Controls.Add(lblPhilHealth);
        Controls.Add(txtPhilHealth);
        Controls.Add(lblPagIbig);
        Controls.Add(txtPagIbig);
        Controls.Add(lblIncomeTax);
        Controls.Add(txtIncomeTax);
        Controls.Add(lblOtherDed);
        Controls.Add(lblSSSLoan);
        Controls.Add(txtSSSLoan);
        Controls.Add(lblPagIbigLoan);
        Controls.Add(txtPagIbigLoan);
        Controls.Add(lblFacultySavings);
        Controls.Add(txtFacultySavings);
        Controls.Add(lblSalaryLoan);
        Controls.Add(txtSalaryLoan);
        Controls.Add(lblOtherLoans);
        Controls.Add(txtOtherLoans);
        Controls.Add(lblDedSummary);
        Controls.Add(lblTotalDeductionsLbl);
        Controls.Add(txtTotalDeductions);
        Controls.Add(btnGrossIncome);
        Controls.Add(btnNetIncome);
        Controls.Add(btnSave);
        Controls.Add(btnUpdate);
        Controls.Add(btnNew);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "SE-RI'S CHOICE PAYROLL";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
}
