namespace Student_Roster
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMain = new System.Windows.Forms.TableLayoutPanel();
            this.addStudentButton = new System.Windows.Forms.Button();
            this.panelAddStudent = new System.Windows.Forms.TableLayoutPanel();
            this.studentGrid = new System.Windows.Forms.DataGridView();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.dobLabel = new System.Windows.Forms.Label();
            this.majorLabel = new System.Windows.Forms.Label();
            this.studentIdLabel = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbDob = new System.Windows.Forms.TextBox();
            this.tbMajor = new System.Windows.Forms.TextBox();
            this.tbStudentId = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.panelAddStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.ColumnCount = 1;
            this.panelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelMain.Controls.Add(this.addStudentButton, 0, 1);
            this.panelMain.Controls.Add(this.studentGrid, 0, 0);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.RowCount = 2;
            this.panelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelMain.Size = new System.Drawing.Size(384, 261);
            this.panelMain.TabIndex = 0;
            // 
            // addStudentButton
            // 
            this.addStudentButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addStudentButton.Location = new System.Drawing.Point(154, 184);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(75, 23);
            this.addStudentButton.TabIndex = 0;
            this.addStudentButton.Text = "Add Student";
            this.addStudentButton.UseVisualStyleBackColor = true;
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click);
            // 
            // panelAddStudent
            // 
            this.panelAddStudent.ColumnCount = 2;
            this.panelAddStudent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelAddStudent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.panelAddStudent.Controls.Add(this.firstNameLabel, 0, 0);
            this.panelAddStudent.Controls.Add(this.lastNameLabel, 0, 1);
            this.panelAddStudent.Controls.Add(this.dobLabel, 0, 2);
            this.panelAddStudent.Controls.Add(this.majorLabel, 0, 3);
            this.panelAddStudent.Controls.Add(this.studentIdLabel, 0, 4);
            this.panelAddStudent.Controls.Add(this.tbFirstName, 1, 0);
            this.panelAddStudent.Controls.Add(this.tbLastName, 1, 1);
            this.panelAddStudent.Controls.Add(this.tbDob, 1, 2);
            this.panelAddStudent.Controls.Add(this.tbMajor, 1, 3);
            this.panelAddStudent.Controls.Add(this.tbStudentId, 1, 4);
            this.panelAddStudent.Controls.Add(this.submitButton, 0, 6);
            this.panelAddStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAddStudent.Location = new System.Drawing.Point(0, 0);
            this.panelAddStudent.Name = "panelAddStudent";
            this.panelAddStudent.Padding = new System.Windows.Forms.Padding(0, 20, 10, 0);
            this.panelAddStudent.RowCount = 7;
            this.panelAddStudent.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelAddStudent.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelAddStudent.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelAddStudent.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelAddStudent.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelAddStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelAddStudent.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelAddStudent.Size = new System.Drawing.Size(384, 261);
            this.panelAddStudent.TabIndex = 1;
            // 
            // studentGrid
            // 
            this.studentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.studentGrid.GridColor = System.Drawing.SystemColors.ControlLight;
            this.studentGrid.Location = new System.Drawing.Point(3, 3);
            this.studentGrid.Name = "studentGrid";
            this.studentGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.studentGrid.Size = new System.Drawing.Size(378, 124);
            this.studentGrid.TabIndex = 1;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(30, 26);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(60, 13);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(29, 52);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(61, 13);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // dobLabel
            // 
            this.dobLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dobLabel.AutoSize = true;
            this.dobLabel.Location = new System.Drawing.Point(57, 78);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(33, 13);
            this.dobLabel.TabIndex = 2;
            this.dobLabel.Text = "DOB:";
            // 
            // majorLabel
            // 
            this.majorLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.majorLabel.AutoSize = true;
            this.majorLabel.Location = new System.Drawing.Point(54, 104);
            this.majorLabel.Name = "majorLabel";
            this.majorLabel.Size = new System.Drawing.Size(36, 13);
            this.majorLabel.TabIndex = 3;
            this.majorLabel.Text = "Major:";
            // 
            // studentIdLabel
            // 
            this.studentIdLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.studentIdLabel.AutoSize = true;
            this.studentIdLabel.Location = new System.Drawing.Point(29, 130);
            this.studentIdLabel.Name = "studentIdLabel";
            this.studentIdLabel.Size = new System.Drawing.Size(61, 13);
            this.studentIdLabel.TabIndex = 4;
            this.studentIdLabel.Text = "Student ID:";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFirstName.Location = new System.Drawing.Point(96, 23);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(275, 20);
            this.tbFirstName.TabIndex = 5;
            // 
            // tbLastName
            // 
            this.tbLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLastName.Location = new System.Drawing.Point(96, 49);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(275, 20);
            this.tbLastName.TabIndex = 6;
            // 
            // tbDob
            // 
            this.tbDob.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDob.Location = new System.Drawing.Point(96, 75);
            this.tbDob.Name = "tbDob";
            this.tbDob.Size = new System.Drawing.Size(275, 20);
            this.tbDob.TabIndex = 7;
            // 
            // tbMajor
            // 
            this.tbMajor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMajor.Location = new System.Drawing.Point(96, 101);
            this.tbMajor.Name = "tbMajor";
            this.tbMajor.Size = new System.Drawing.Size(275, 20);
            this.tbMajor.TabIndex = 8;
            // 
            // tbStudentId
            // 
            this.tbStudentId.AllowDrop = true;
            this.tbStudentId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbStudentId.Location = new System.Drawing.Point(96, 127);
            this.tbStudentId.Name = "tbStudentId";
            this.tbStudentId.Size = new System.Drawing.Size(275, 20);
            this.tbStudentId.TabIndex = 9;
            // 
            // submitButton
            // 
            this.submitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.submitButton.AutoSize = true;
            this.submitButton.Location = new System.Drawing.Point(8, 173);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(82, 23);
            this.submitButton.TabIndex = 10;
            this.submitButton.Text = "Save Student";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelAddStudent);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Student Roster";
            this.panelMain.ResumeLayout(false);
            this.panelAddStudent.ResumeLayout(false);
            this.panelAddStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panelMain;
        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.TableLayoutPanel panelAddStudent;
        private System.Windows.Forms.DataGridView studentGrid;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.Label majorLabel;
        private System.Windows.Forms.Label studentIdLabel;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbDob;
        private System.Windows.Forms.TextBox tbMajor;
        private System.Windows.Forms.TextBox tbStudentId;
        private System.Windows.Forms.Button submitButton;

    }
}

