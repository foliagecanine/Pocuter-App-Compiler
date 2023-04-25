namespace Pocuter_App_Compiler
{
    partial class MainForm
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
            label1 = new Label();
            textBoxAppProject = new TextBox();
            buttonAppProjectBrowse = new Button();
            label2 = new Label();
            textBoxAppName = new TextBox();
            label3 = new Label();
            numericVersionMaj = new NumericUpDown();
            label4 = new Label();
            numericVersionMin = new NumericUpDown();
            numericVersionPatch = new NumericUpDown();
            label5 = new Label();
            label6 = new Label();
            pictureBoxAppIcon = new PictureBox();
            buttonBrowseAppIcon = new Button();
            label7 = new Label();
            textBoxAppAuthor = new TextBox();
            label8 = new Label();
            label9 = new Label();
            numericAppID = new NumericUpDown();
            textBoxAppIconPath = new TextBox();
            textBoxOutputPath = new TextBox();
            buttonOutputBrowse = new Button();
            checkBoxInstall = new CheckBox();
            numericIP_C = new NumericUpDown();
            label11 = new Label();
            numericIP_B = new NumericUpDown();
            label12 = new Label();
            numericIP_A = new NumericUpDown();
            numericIP_D = new NumericUpDown();
            label13 = new Label();
            label14 = new Label();
            buttonCompile = new Button();
            progressBar = new ProgressBar();
            folderBrowserDialogApp = new FolderBrowserDialog();
            openFileDialogIcon = new OpenFileDialog();
            processArduino = new System.Diagnostics.Process();
            processAppConverter = new System.Diagnostics.Process();
            checkBoxOutputApps = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)numericVersionMaj).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericVersionMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericVersionPatch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAppIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericAppID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericIP_C).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericIP_B).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericIP_A).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericIP_D).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 0;
            label1.Text = "App Project";
            // 
            // textBoxAppProject
            // 
            textBoxAppProject.Location = new Point(12, 32);
            textBoxAppProject.Name = "textBoxAppProject";
            textBoxAppProject.Size = new Size(218, 27);
            textBoxAppProject.TabIndex = 1;
            // 
            // buttonAppProjectBrowse
            // 
            buttonAppProjectBrowse.Location = new Point(236, 32);
            buttonAppProjectBrowse.Name = "buttonAppProjectBrowse";
            buttonAppProjectBrowse.Size = new Size(94, 27);
            buttonAppProjectBrowse.TabIndex = 2;
            buttonAppProjectBrowse.Text = "Browse...";
            buttonAppProjectBrowse.UseVisualStyleBackColor = true;
            buttonAppProjectBrowse.Click += buttonAppProjectBrowse_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 62);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 3;
            label2.Text = "App Name";
            // 
            // textBoxAppName
            // 
            textBoxAppName.Location = new Point(12, 85);
            textBoxAppName.Name = "textBoxAppName";
            textBoxAppName.Size = new Size(318, 27);
            textBoxAppName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 115);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 5;
            label3.Text = "App Version";
            // 
            // numericVersionMaj
            // 
            numericVersionMaj.Location = new Point(12, 138);
            numericVersionMaj.Maximum = new decimal(new int[] { 2, 0, 0, 0 });
            numericVersionMaj.Name = "numericVersionMaj";
            numericVersionMaj.Size = new Size(34, 27);
            numericVersionMaj.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 145);
            label4.Name = "label4";
            label4.Size = new Size(12, 20);
            label4.TabIndex = 7;
            label4.Text = ".";
            // 
            // numericVersionMin
            // 
            numericVersionMin.Location = new Point(70, 138);
            numericVersionMin.Maximum = new decimal(new int[] { 9, 0, 0, 0 });
            numericVersionMin.Name = "numericVersionMin";
            numericVersionMin.Size = new Size(34, 27);
            numericVersionMin.TabIndex = 8;
            // 
            // numericVersionPatch
            // 
            numericVersionPatch.Location = new Point(128, 138);
            numericVersionPatch.Maximum = new decimal(new int[] { 9, 0, 0, 0 });
            numericVersionPatch.Name = "numericVersionPatch";
            numericVersionPatch.Size = new Size(34, 27);
            numericVersionPatch.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(110, 145);
            label5.Name = "label5";
            label5.Size = new Size(12, 20);
            label5.TabIndex = 9;
            label5.Text = ".";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 221);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 11;
            label6.Text = "App Icon";
            // 
            // pictureBoxAppIcon
            // 
            pictureBoxAppIcon.Location = new Point(14, 244);
            pictureBoxAppIcon.Name = "pictureBoxAppIcon";
            pictureBoxAppIcon.Size = new Size(32, 32);
            pictureBoxAppIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxAppIcon.TabIndex = 12;
            pictureBoxAppIcon.TabStop = false;
            // 
            // buttonBrowseAppIcon
            // 
            buttonBrowseAppIcon.Location = new Point(236, 244);
            buttonBrowseAppIcon.Name = "buttonBrowseAppIcon";
            buttonBrowseAppIcon.Size = new Size(94, 27);
            buttonBrowseAppIcon.TabIndex = 13;
            buttonBrowseAppIcon.Text = "Browse...";
            buttonBrowseAppIcon.UseVisualStyleBackColor = true;
            buttonBrowseAppIcon.Click += buttonBrowseAppIcon_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 168);
            label7.Name = "label7";
            label7.Size = new Size(86, 20);
            label7.TabIndex = 14;
            label7.Text = "App Author";
            // 
            // textBoxAppAuthor
            // 
            textBoxAppAuthor.Location = new Point(12, 191);
            textBoxAppAuthor.Name = "textBoxAppAuthor";
            textBoxAppAuthor.Size = new Size(318, 27);
            textBoxAppAuthor.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 221);
            label8.Name = "label8";
            label8.Size = new Size(0, 20);
            label8.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(182, 115);
            label9.Name = "label9";
            label9.Size = new Size(56, 20);
            label9.TabIndex = 17;
            label9.Text = "App ID";
            // 
            // numericAppID
            // 
            numericAppID.Location = new Point(182, 138);
            numericAppID.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numericAppID.Name = "numericAppID";
            numericAppID.Size = new Size(148, 27);
            numericAppID.TabIndex = 19;
            // 
            // textBoxAppIconPath
            // 
            textBoxAppIconPath.Location = new Point(52, 244);
            textBoxAppIconPath.Name = "textBoxAppIconPath";
            textBoxAppIconPath.ReadOnly = true;
            textBoxAppIconPath.Size = new Size(178, 27);
            textBoxAppIconPath.TabIndex = 20;
            // 
            // textBoxOutputPath
            // 
            textBoxOutputPath.Enabled = false;
            textBoxOutputPath.Location = new Point(14, 302);
            textBoxOutputPath.Name = "textBoxOutputPath";
            textBoxOutputPath.Size = new Size(218, 27);
            textBoxOutputPath.TabIndex = 22;
            // 
            // buttonOutputBrowse
            // 
            buttonOutputBrowse.Enabled = false;
            buttonOutputBrowse.Location = new Point(236, 302);
            buttonOutputBrowse.Name = "buttonOutputBrowse";
            buttonOutputBrowse.Size = new Size(94, 27);
            buttonOutputBrowse.TabIndex = 23;
            buttonOutputBrowse.Text = "Browse...";
            buttonOutputBrowse.UseVisualStyleBackColor = true;
            buttonOutputBrowse.Click += buttonOutputBrowse_Click;
            // 
            // checkBoxInstall
            // 
            checkBoxInstall.AutoSize = true;
            checkBoxInstall.Location = new Point(12, 335);
            checkBoxInstall.Name = "checkBoxInstall";
            checkBoxInstall.Size = new Size(214, 24);
            checkBoxInstall.TabIndex = 24;
            checkBoxInstall.Text = "Install on Pocuter Wirelessly";
            checkBoxInstall.UseVisualStyleBackColor = true;
            checkBoxInstall.CheckedChanged += checkBoxInstall_CheckedChanged;
            // 
            // numericIP_C
            // 
            numericIP_C.Enabled = false;
            numericIP_C.Location = new Point(196, 365);
            numericIP_C.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericIP_C.Name = "numericIP_C";
            numericIP_C.Size = new Size(53, 27);
            numericIP_C.TabIndex = 29;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(178, 372);
            label11.Name = "label11";
            label11.Size = new Size(12, 20);
            label11.TabIndex = 28;
            label11.Text = ".";
            // 
            // numericIP_B
            // 
            numericIP_B.Enabled = false;
            numericIP_B.Location = new Point(119, 365);
            numericIP_B.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericIP_B.Name = "numericIP_B";
            numericIP_B.Size = new Size(53, 27);
            numericIP_B.TabIndex = 27;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(101, 372);
            label12.Name = "label12";
            label12.Size = new Size(12, 20);
            label12.TabIndex = 26;
            label12.Text = ".";
            // 
            // numericIP_A
            // 
            numericIP_A.Enabled = false;
            numericIP_A.Location = new Point(42, 365);
            numericIP_A.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericIP_A.Name = "numericIP_A";
            numericIP_A.Size = new Size(53, 27);
            numericIP_A.TabIndex = 25;
            // 
            // numericIP_D
            // 
            numericIP_D.Enabled = false;
            numericIP_D.Location = new Point(273, 365);
            numericIP_D.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericIP_D.Name = "numericIP_D";
            numericIP_D.Size = new Size(53, 27);
            numericIP_D.TabIndex = 31;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(255, 372);
            label13.Name = "label13";
            label13.Size = new Size(12, 20);
            label13.TabIndex = 30;
            label13.Text = ".";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(12, 367);
            label14.Name = "label14";
            label14.Size = new Size(24, 20);
            label14.TabIndex = 32;
            label14.Text = "IP:";
            // 
            // buttonCompile
            // 
            buttonCompile.Location = new Point(10, 398);
            buttonCompile.Name = "buttonCompile";
            buttonCompile.Size = new Size(320, 29);
            buttonCompile.TabIndex = 33;
            buttonCompile.Text = "Compile App";
            buttonCompile.UseVisualStyleBackColor = true;
            buttonCompile.Click += buttonCompile_Click;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(12, 433);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(318, 29);
            progressBar.TabIndex = 34;
            // 
            // folderBrowserDialogApp
            // 
            folderBrowserDialogApp.RootFolder = Environment.SpecialFolder.MyDocuments;
            // 
            // openFileDialogIcon
            // 
            openFileDialogIcon.DefaultExt = "png";
            openFileDialogIcon.FileName = "icon.bmp";
            openFileDialogIcon.Filter = "Image Files|*.bmp;*.png;*.jpg;*.jpeg|All files|*.*";
            // 
            // processArduino
            // 
            processArduino.StartInfo.Domain = "";
            processArduino.StartInfo.ErrorDialog = true;
            processArduino.StartInfo.FileName = "resources/arduino-cli.exe";
            processArduino.StartInfo.LoadUserProfile = false;
            processArduino.StartInfo.Password = null;
            processArduino.StartInfo.RedirectStandardOutput = true;
            processArduino.StartInfo.StandardErrorEncoding = null;
            processArduino.StartInfo.StandardInputEncoding = null;
            processArduino.StartInfo.StandardOutputEncoding = null;
            processArduino.StartInfo.UserName = "";
            processArduino.SynchronizingObject = this;
            processArduino.Exited += processArduino_Exited;
            // 
            // processAppConverter
            // 
            processAppConverter.StartInfo.Domain = "";
            processAppConverter.StartInfo.FileName = "resources/appconverter.exe";
            processAppConverter.StartInfo.LoadUserProfile = false;
            processAppConverter.StartInfo.Password = null;
            processAppConverter.StartInfo.RedirectStandardOutput = true;
            processAppConverter.StartInfo.StandardErrorEncoding = null;
            processAppConverter.StartInfo.StandardInputEncoding = null;
            processAppConverter.StartInfo.StandardOutputEncoding = null;
            processAppConverter.StartInfo.UserName = "";
            processAppConverter.SynchronizingObject = this;
            // 
            // checkBoxOutputApps
            // 
            checkBoxOutputApps.AutoSize = true;
            checkBoxOutputApps.Location = new Point(12, 277);
            checkBoxOutputApps.Name = "checkBoxOutputApps";
            checkBoxOutputApps.Size = new Size(179, 24);
            checkBoxOutputApps.TabIndex = 35;
            checkBoxOutputApps.Text = "Output to Apps Folder";
            checkBoxOutputApps.UseVisualStyleBackColor = true;
            checkBoxOutputApps.CheckedChanged += checkBoxOutputApps_CheckedChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 469);
            Controls.Add(checkBoxOutputApps);
            Controls.Add(progressBar);
            Controls.Add(buttonCompile);
            Controls.Add(label14);
            Controls.Add(numericIP_D);
            Controls.Add(label13);
            Controls.Add(numericIP_C);
            Controls.Add(label11);
            Controls.Add(numericIP_B);
            Controls.Add(label12);
            Controls.Add(numericIP_A);
            Controls.Add(checkBoxInstall);
            Controls.Add(buttonOutputBrowse);
            Controls.Add(textBoxOutputPath);
            Controls.Add(textBoxAppIconPath);
            Controls.Add(numericAppID);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(textBoxAppAuthor);
            Controls.Add(label7);
            Controls.Add(buttonBrowseAppIcon);
            Controls.Add(pictureBoxAppIcon);
            Controls.Add(label6);
            Controls.Add(numericVersionPatch);
            Controls.Add(label5);
            Controls.Add(numericVersionMin);
            Controls.Add(label4);
            Controls.Add(numericVersionMaj);
            Controls.Add(label3);
            Controls.Add(textBoxAppName);
            Controls.Add(label2);
            Controls.Add(buttonAppProjectBrowse);
            Controls.Add(textBoxAppProject);
            Controls.Add(label1);
            MaximizeBox = false;
            MaximumSize = new Size(360, 516);
            MinimumSize = new Size(360, 516);
            Name = "MainForm";
            Text = "App Compiler";
            ((System.ComponentModel.ISupportInitialize)numericVersionMaj).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericVersionMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericVersionPatch).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAppIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericAppID).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericIP_C).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericIP_B).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericIP_A).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericIP_D).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxAppProject;
        private Button buttonAppProjectBrowse;
        private Label label2;
        private TextBox textBoxAppName;
        private Label label3;
        private NumericUpDown numericVersionMaj;
        private Label label4;
        private NumericUpDown numericVersionMin;
        private NumericUpDown numericVersionPatch;
        private Label label5;
        private Label label6;
        private PictureBox pictureBoxAppIcon;
        private Button buttonBrowseAppIcon;
        private Label label7;
        private TextBox textBoxAppAuthor;
        private Label label8;
        private Label label9;
        private NumericUpDown numericAppID;
        private TextBox textBoxAppIconPath;
        private TextBox textBoxOutputPath;
        private Button buttonOutputBrowse;
        private CheckBox checkBoxInstall;
        private NumericUpDown numericIP_C;
        private Label label11;
        private NumericUpDown numericIP_B;
        private Label label12;
        private NumericUpDown numericIP_A;
        private NumericUpDown numericIP_D;
        private Label label13;
        private Label label14;
        private Button buttonCompile;
        private ProgressBar progressBar;
        private FolderBrowserDialog folderBrowserDialogApp;
        private OpenFileDialog openFileDialogIcon;
        private System.Diagnostics.Process processArduino;
        private System.Diagnostics.Process processAppConverter;
        private CheckBox checkBoxOutputApps;
    }
}