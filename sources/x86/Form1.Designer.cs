namespace SimpleDLLinjector_x86
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnSelectDll = new Button();
            txtSelectedDll = new TextBox();
            comboBoxProcesses = new ComboBox();
            btnSelectProcess = new Button();
            lblDllStatus = new Label();
            lblProcessStatus = new Label();
            btnInject = new Button();
            lblDllArchitecture = new Label();
            lblProcessArchitecture = new Label();
            rtbLogs = new RichTextBox();
            chkAutoInject = new CheckBox();
            txtProcessName = new TextBox();
            btnStartAutoInject = new Button();
            btnStopSearch = new Button();
            rbtnLoadLibraryA = new RadioButton();
            rbtnLoadLibraryW = new RadioButton();
            rbtnLdrLoadDll = new RadioButton();
            grpLoadingApis = new GroupBox();
            chkUnhook = new CheckBox();
            chkCloseAutomatically = new CheckBox();
            grpLoadingApis.SuspendLayout();
            SuspendLayout();
            // 
            // btnSelectDll
            // 
            btnSelectDll.BackColor = Color.YellowGreen;
            btnSelectDll.FlatAppearance.BorderColor = SystemColors.Desktop;
            btnSelectDll.FlatStyle = FlatStyle.Flat;
            btnSelectDll.ForeColor = SystemColors.Desktop;
            btnSelectDll.Location = new Point(18, 22);
            btnSelectDll.Margin = new Padding(3, 1, 3, 1);
            btnSelectDll.Name = "btnSelectDll";
            btnSelectDll.Size = new Size(125, 23);
            btnSelectDll.TabIndex = 0;
            btnSelectDll.Text = "Selecionar Dll";
            btnSelectDll.UseVisualStyleBackColor = false;
            btnSelectDll.Click += SelectDllButton_Click;
            // 
            // txtSelectedDll
            // 
            txtSelectedDll.Enabled = false;
            txtSelectedDll.Location = new Point(151, 23);
            txtSelectedDll.Margin = new Padding(3, 1, 3, 1);
            txtSelectedDll.Name = "txtSelectedDll";
            txtSelectedDll.PlaceholderText = "Selecione a DLL que sera injetada...";
            txtSelectedDll.Size = new Size(286, 23);
            txtSelectedDll.TabIndex = 1;
            // 
            // comboBoxProcesses
            // 
            comboBoxProcesses.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProcesses.FormattingEnabled = true;
            comboBoxProcesses.Location = new Point(153, 72);
            comboBoxProcesses.Margin = new Padding(1);
            comboBoxProcesses.Name = "comboBoxProcesses";
            comboBoxProcesses.Size = new Size(284, 23);
            comboBoxProcesses.TabIndex = 2;
            comboBoxProcesses.DropDown += ProcessComboBox_DropDown;
            // 
            // btnSelectProcess
            // 
            btnSelectProcess.BackColor = Color.YellowGreen;
            btnSelectProcess.FlatAppearance.BorderColor = SystemColors.Desktop;
            btnSelectProcess.FlatStyle = FlatStyle.Flat;
            btnSelectProcess.ForeColor = SystemColors.Desktop;
            btnSelectProcess.Location = new Point(18, 71);
            btnSelectProcess.Margin = new Padding(1);
            btnSelectProcess.Name = "btnSelectProcess";
            btnSelectProcess.Size = new Size(125, 23);
            btnSelectProcess.TabIndex = 3;
            btnSelectProcess.Text = "Selecionar Processo";
            btnSelectProcess.UseVisualStyleBackColor = false;
            btnSelectProcess.Click += SelectProcessButton_Click;
            // 
            // lblDllStatus
            // 
            lblDllStatus.AutoSize = true;
            lblDllStatus.BackColor = Color.LightBlue;
            lblDllStatus.ForeColor = Color.Black;
            lblDllStatus.Location = new Point(207, 6);
            lblDllStatus.Margin = new Padding(1, 0, 1, 0);
            lblDllStatus.Name = "lblDllStatus";
            lblDllStatus.Size = new Size(0, 15);
            lblDllStatus.TabIndex = 4;
            // 
            // lblProcessStatus
            // 
            lblProcessStatus.AutoSize = true;
            lblProcessStatus.BackColor = Color.LightBlue;
            lblProcessStatus.ForeColor = Color.Black;
            lblProcessStatus.Location = new Point(193, 54);
            lblProcessStatus.Margin = new Padding(1, 0, 1, 0);
            lblProcessStatus.Name = "lblProcessStatus";
            lblProcessStatus.Size = new Size(0, 15);
            lblProcessStatus.TabIndex = 5;
            // 
            // btnInject
            // 
            btnInject.BackColor = Color.YellowGreen;
            btnInject.FlatAppearance.BorderColor = SystemColors.Desktop;
            btnInject.FlatStyle = FlatStyle.Flat;
            btnInject.Location = new Point(270, 205);
            btnInject.Margin = new Padding(1);
            btnInject.Name = "btnInject";
            btnInject.Size = new Size(78, 26);
            btnInject.TabIndex = 6;
            btnInject.Text = "Injetar";
            btnInject.UseVisualStyleBackColor = false;
            btnInject.Click += InjectButton_Click;
            // 
            // lblDllArchitecture
            // 
            lblDllArchitecture.AutoSize = true;
            lblDllArchitecture.BackColor = Color.CadetBlue;
            lblDllArchitecture.Location = new Point(329, 6);
            lblDllArchitecture.Name = "lblDllArchitecture";
            lblDllArchitecture.Size = new Size(0, 15);
            lblDllArchitecture.TabIndex = 11;
            // 
            // lblProcessArchitecture
            // 
            lblProcessArchitecture.AutoSize = true;
            lblProcessArchitecture.BackColor = Color.CadetBlue;
            lblProcessArchitecture.Location = new Point(329, 54);
            lblProcessArchitecture.Name = "lblProcessArchitecture";
            lblProcessArchitecture.Size = new Size(0, 15);
            lblProcessArchitecture.TabIndex = 12;
            // 
            // rtbLogs
            // 
            rtbLogs.BackColor = Color.PaleTurquoise;
            rtbLogs.Location = new Point(13, 279);
            rtbLogs.Name = "rtbLogs";
            rtbLogs.ReadOnly = true;
            rtbLogs.Size = new Size(424, 170);
            rtbLogs.TabIndex = 13;
            rtbLogs.Text = "";
            // 
            // chkAutoInject
            // 
            chkAutoInject.AutoSize = true;
            chkAutoInject.BackColor = Color.LightGreen;
            chkAutoInject.Location = new Point(220, 121);
            chkAutoInject.Margin = new Padding(3, 2, 3, 2);
            chkAutoInject.Name = "chkAutoInject";
            chkAutoInject.Size = new Size(91, 19);
            chkAutoInject.TabIndex = 16;
            chkAutoInject.Text = "Auto Injetar ";
            chkAutoInject.UseVisualStyleBackColor = false;
            chkAutoInject.CheckedChanged += AutoInjectCheckBox_CheckedChanged;
            // 
            // txtProcessName
            // 
            txtProcessName.Location = new Point(151, 71);
            txtProcessName.Margin = new Padding(3, 2, 3, 2);
            txtProcessName.Name = "txtProcessName";
            txtProcessName.PlaceholderText = "Digite o nome do processo...";
            txtProcessName.Size = new Size(286, 23);
            txtProcessName.TabIndex = 17;
            txtProcessName.Visible = false;
            // 
            // btnStartAutoInject
            // 
            btnStartAutoInject.BackColor = Color.YellowGreen;
            btnStartAutoInject.FlatAppearance.BorderColor = SystemColors.Desktop;
            btnStartAutoInject.FlatStyle = FlatStyle.Flat;
            btnStartAutoInject.Location = new Point(253, 205);
            btnStartAutoInject.Margin = new Padding(3, 2, 3, 2);
            btnStartAutoInject.Name = "btnStartAutoInject";
            btnStartAutoInject.Size = new Size(115, 26);
            btnStartAutoInject.TabIndex = 18;
            btnStartAutoInject.Text = "Auto Injetar";
            btnStartAutoInject.UseVisualStyleBackColor = false;
            btnStartAutoInject.Visible = false;
            btnStartAutoInject.Click += AutoInjectButton_Click;
            // 
            // btnStopSearch
            // 
            btnStopSearch.BackColor = Color.Red;
            btnStopSearch.FlatAppearance.BorderColor = SystemColors.Desktop;
            btnStopSearch.FlatStyle = FlatStyle.Flat;
            btnStopSearch.Location = new Point(253, 205);
            btnStopSearch.Margin = new Padding(3, 2, 3, 2);
            btnStopSearch.Name = "btnStopSearch";
            btnStopSearch.Size = new Size(115, 26);
            btnStopSearch.TabIndex = 19;
            btnStopSearch.Text = "Cancelar Procura";
            btnStopSearch.UseVisualStyleBackColor = false;
            btnStopSearch.Visible = false;
            btnStopSearch.Click += StopSearchingButton_Click;
            // 
            // rbtnLoadLibraryA
            // 
            rbtnLoadLibraryA.AutoSize = true;
            rbtnLoadLibraryA.BackColor = Color.DarkSeaGreen;
            rbtnLoadLibraryA.FlatAppearance.BorderColor = Color.Black;
            rbtnLoadLibraryA.Location = new Point(13, 30);
            rbtnLoadLibraryA.Margin = new Padding(3, 2, 3, 2);
            rbtnLoadLibraryA.Name = "rbtnLoadLibraryA";
            rbtnLoadLibraryA.Size = new Size(95, 19);
            rbtnLoadLibraryA.TabIndex = 0;
            rbtnLoadLibraryA.TabStop = true;
            rbtnLoadLibraryA.Text = "LoadLibraryA";
            rbtnLoadLibraryA.UseVisualStyleBackColor = false;
            rbtnLoadLibraryA.CheckedChanged += LoadMethodRadioButton_CheckedChanged;
            // 
            // rbtnLoadLibraryW
            // 
            rbtnLoadLibraryW.AutoSize = true;
            rbtnLoadLibraryW.BackColor = Color.DarkSeaGreen;
            rbtnLoadLibraryW.Location = new Point(13, 61);
            rbtnLoadLibraryW.Margin = new Padding(3, 2, 3, 2);
            rbtnLoadLibraryW.Name = "rbtnLoadLibraryW";
            rbtnLoadLibraryW.Size = new Size(98, 19);
            rbtnLoadLibraryW.TabIndex = 1;
            rbtnLoadLibraryW.TabStop = true;
            rbtnLoadLibraryW.Text = "LoadLibraryW";
            rbtnLoadLibraryW.UseVisualStyleBackColor = false;
            rbtnLoadLibraryW.CheckedChanged += LoadMethodRadioButton_CheckedChanged;
            // 
            // rbtnLdrLoadDll
            // 
            rbtnLdrLoadDll.AutoSize = true;
            rbtnLdrLoadDll.BackColor = Color.DarkSeaGreen;
            rbtnLdrLoadDll.Location = new Point(13, 94);
            rbtnLdrLoadDll.Margin = new Padding(3, 2, 3, 2);
            rbtnLdrLoadDll.Name = "rbtnLdrLoadDll";
            rbtnLdrLoadDll.Size = new Size(82, 19);
            rbtnLdrLoadDll.TabIndex = 2;
            rbtnLdrLoadDll.TabStop = true;
            rbtnLdrLoadDll.Text = "LdrLoadDll";
            rbtnLdrLoadDll.UseVisualStyleBackColor = false;
            rbtnLdrLoadDll.CheckedChanged += LoadMethodRadioButton_CheckedChanged;
            // 
            // grpLoadingApis
            // 
            grpLoadingApis.BackColor = Color.LawnGreen;
            grpLoadingApis.Controls.Add(chkUnhook);
            grpLoadingApis.Controls.Add(rbtnLoadLibraryA);
            grpLoadingApis.Controls.Add(rbtnLdrLoadDll);
            grpLoadingApis.Controls.Add(rbtnLoadLibraryW);
            grpLoadingApis.ForeColor = Color.Black;
            grpLoadingApis.Location = new Point(13, 111);
            grpLoadingApis.Margin = new Padding(3, 2, 3, 2);
            grpLoadingApis.Name = "grpLoadingApis";
            grpLoadingApis.Padding = new Padding(3, 2, 3, 2);
            grpLoadingApis.Size = new Size(177, 157);
            grpLoadingApis.TabIndex = 20;
            grpLoadingApis.TabStop = false;
            grpLoadingApis.Text = "APIs de Carregamento";
            // 
            // chkUnhook
            // 
            chkUnhook.AutoSize = true;
            chkUnhook.BackColor = Color.DarkSeaGreen;
            chkUnhook.Location = new Point(55, 127);
            chkUnhook.Margin = new Padding(3, 2, 3, 2);
            chkUnhook.Name = "chkUnhook";
            chkUnhook.Size = new Size(70, 19);
            chkUnhook.TabIndex = 3;
            chkUnhook.Text = "UnHook";
            chkUnhook.UseVisualStyleBackColor = false;
            // 
            // chkCloseAutomatically
            // 
            chkCloseAutomatically.AutoSize = true;
            chkCloseAutomatically.BackColor = Color.LightGreen;
            chkCloseAutomatically.Location = new Point(220, 157);
            chkCloseAutomatically.Margin = new Padding(3, 2, 3, 2);
            chkCloseAutomatically.Name = "chkCloseAutomatically";
            chkCloseAutomatically.Size = new Size(116, 19);
            chkCloseAutomatically.TabIndex = 21;
            chkCloseAutomatically.Text = "Fechar  ao Injetar";
            chkCloseAutomatically.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            BackColor = Color.LimeGreen;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(449, 461);
            Controls.Add(chkCloseAutomatically);
            Controls.Add(grpLoadingApis);
            Controls.Add(btnStopSearch);
            Controls.Add(btnStartAutoInject);
            Controls.Add(txtProcessName);
            Controls.Add(chkAutoInject);
            Controls.Add(rtbLogs);
            Controls.Add(lblProcessArchitecture);
            Controls.Add(lblDllArchitecture);
            Controls.Add(btnInject);
            Controls.Add(lblProcessStatus);
            Controls.Add(lblDllStatus);
            Controls.Add(btnSelectProcess);
            Controls.Add(comboBoxProcesses);
            Controls.Add(txtSelectedDll);
            Controls.Add(btnSelectDll);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 1, 3, 1);
            Name = "Form1";
            RightToLeft = RightToLeft.No;
            Text = "Form1";
            grpLoadingApis.ResumeLayout(false);
            grpLoadingApis.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSelectDll;
        private TextBox txtSelectedDll;
        private ComboBox comboBoxProcesses;
        private Button btnSelectProcess;
        private Label lblDllStatus;
        private Label lblProcessStatus;
        private Button btnInject;
        private Label lblDllArchitecture;
        private Label lblProcessArchitecture;
        private RichTextBox rtbLogs;
        private CheckBox chkAutoInject;
        private TextBox txtProcessName;
        private Button btnStartAutoInject;
        private Button btnStopSearch;
        private RadioButton rbtnLoadLibraryA;
        private RadioButton rbtnLoadLibraryW;
        private RadioButton rbtnLdrLoadDll;
        private GroupBox grpLoadingApis;
        private CheckBox chkCloseAutomatically;
        private CheckBox chkUnhook;
    }

}
