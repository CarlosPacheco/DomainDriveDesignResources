namespace DomainDriveDesignResourcesVSIX
{
    partial class OptionsForm
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
            this.ControllersProject = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DataTransferObjectsProject = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DataProject = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ApplicationProject = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.chkHaveControllersProject = new System.Windows.Forms.CheckBox();
            this.chkHaveApplicationProject = new System.Windows.Forms.CheckBox();
            this.chkHaveDataTransferObjectsProject = new System.Windows.Forms.CheckBox();
            this.chkHaveDataProject = new System.Windows.Forms.CheckBox();
            this.chkHaveEntitiesProject = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.EntitiesProject = new System.Windows.Forms.ComboBox();
            this.chkHaveBusinessProject = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.BusinessProject = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ControllersProject
            // 
            this.ControllersProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ControllersProject.FormattingEnabled = true;
            this.ControllersProject.Location = new System.Drawing.Point(157, 17);
            this.ControllersProject.Name = "ControllersProject";
            this.ControllersProject.Size = new System.Drawing.Size(121, 21);
            this.ControllersProject.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "\"Controller\" project";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "\"DataTransferObjects\"";
            // 
            // DataTransferObjectsProject
            // 
            this.DataTransferObjectsProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DataTransferObjectsProject.FormattingEnabled = true;
            this.DataTransferObjectsProject.Location = new System.Drawing.Point(157, 71);
            this.DataTransferObjectsProject.Name = "DataTransferObjectsProject";
            this.DataTransferObjectsProject.Size = new System.Drawing.Size(121, 21);
            this.DataTransferObjectsProject.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "\"Data\" project";
            // 
            // DataProject
            // 
            this.DataProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DataProject.FormattingEnabled = true;
            this.DataProject.Location = new System.Drawing.Point(157, 98);
            this.DataProject.Name = "DataProject";
            this.DataProject.Size = new System.Drawing.Size(121, 21);
            this.DataProject.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "\"Application\" project";
            // 
            // ApplicationProject
            // 
            this.ApplicationProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ApplicationProject.FormattingEnabled = true;
            this.ApplicationProject.Location = new System.Drawing.Point(157, 44);
            this.ApplicationProject.Name = "ApplicationProject";
            this.ApplicationProject.Size = new System.Drawing.Size(121, 21);
            this.ApplicationProject.TabIndex = 6;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(427, 189);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Create";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(284, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "where interfaces will be created";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(284, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(228, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "where repository implementation will be created";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(284, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "where bunissess model will be created";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(284, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(217, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "where service implementation will be created";
            // 
            // chkHaveControllersProject
            // 
            this.chkHaveControllersProject.AutoSize = true;
            this.chkHaveControllersProject.Checked = true;
            this.chkHaveControllersProject.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHaveControllersProject.Location = new System.Drawing.Point(16, 19);
            this.chkHaveControllersProject.Name = "chkHaveControllersProject";
            this.chkHaveControllersProject.Size = new System.Drawing.Size(15, 14);
            this.chkHaveControllersProject.TabIndex = 13;
            this.chkHaveControllersProject.UseVisualStyleBackColor = true;
            // 
            // chkHaveApplicationProject
            // 
            this.chkHaveApplicationProject.AutoSize = true;
            this.chkHaveApplicationProject.Checked = true;
            this.chkHaveApplicationProject.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHaveApplicationProject.Location = new System.Drawing.Point(16, 47);
            this.chkHaveApplicationProject.Name = "chkHaveApplicationProject";
            this.chkHaveApplicationProject.Size = new System.Drawing.Size(15, 14);
            this.chkHaveApplicationProject.TabIndex = 14;
            this.chkHaveApplicationProject.UseVisualStyleBackColor = true;
            // 
            // chkHaveDataTransferObjectsProject
            // 
            this.chkHaveDataTransferObjectsProject.AutoSize = true;
            this.chkHaveDataTransferObjectsProject.Checked = true;
            this.chkHaveDataTransferObjectsProject.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHaveDataTransferObjectsProject.Location = new System.Drawing.Point(16, 73);
            this.chkHaveDataTransferObjectsProject.Name = "chkHaveDataTransferObjectsProject";
            this.chkHaveDataTransferObjectsProject.Size = new System.Drawing.Size(15, 14);
            this.chkHaveDataTransferObjectsProject.TabIndex = 15;
            this.chkHaveDataTransferObjectsProject.UseVisualStyleBackColor = true;
            // 
            // chkHaveDataProject
            // 
            this.chkHaveDataProject.AutoSize = true;
            this.chkHaveDataProject.Checked = true;
            this.chkHaveDataProject.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHaveDataProject.Location = new System.Drawing.Point(16, 101);
            this.chkHaveDataProject.Name = "chkHaveDataProject";
            this.chkHaveDataProject.Size = new System.Drawing.Size(15, 14);
            this.chkHaveDataProject.TabIndex = 16;
            this.chkHaveDataProject.UseVisualStyleBackColor = true;
            // 
            // chkHaveEntitiesProject
            // 
            this.chkHaveEntitiesProject.AutoSize = true;
            this.chkHaveEntitiesProject.Checked = true;
            this.chkHaveEntitiesProject.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHaveEntitiesProject.Location = new System.Drawing.Point(16, 128);
            this.chkHaveEntitiesProject.Name = "chkHaveEntitiesProject";
            this.chkHaveEntitiesProject.Size = new System.Drawing.Size(15, 14);
            this.chkHaveEntitiesProject.TabIndex = 20;
            this.chkHaveEntitiesProject.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(284, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(217, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "where service implementation will be created";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "\"Entities\" project";
            // 
            // EntitiesProject
            // 
            this.EntitiesProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EntitiesProject.FormattingEnabled = true;
            this.EntitiesProject.Location = new System.Drawing.Point(157, 125);
            this.EntitiesProject.Name = "EntitiesProject";
            this.EntitiesProject.Size = new System.Drawing.Size(121, 21);
            this.EntitiesProject.TabIndex = 17;
            // 
            // chkHaveBusinessProject
            // 
            this.chkHaveBusinessProject.AutoSize = true;
            this.chkHaveBusinessProject.Checked = true;
            this.chkHaveBusinessProject.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHaveBusinessProject.Location = new System.Drawing.Point(16, 155);
            this.chkHaveBusinessProject.Name = "chkHaveBusinessProject";
            this.chkHaveBusinessProject.Size = new System.Drawing.Size(15, 14);
            this.chkHaveBusinessProject.TabIndex = 24;
            this.chkHaveBusinessProject.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(284, 155);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(217, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "where service implementation will be created";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(37, 155);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "\"Business\" project";
            // 
            // BusinessProject
            // 
            this.BusinessProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BusinessProject.FormattingEnabled = true;
            this.BusinessProject.Location = new System.Drawing.Point(157, 152);
            this.BusinessProject.Name = "BusinessProject";
            this.BusinessProject.Size = new System.Drawing.Size(121, 21);
            this.BusinessProject.TabIndex = 21;
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(521, 221);
            this.Controls.Add(this.chkHaveBusinessProject);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.BusinessProject);
            this.Controls.Add(this.chkHaveEntitiesProject);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.EntitiesProject);
            this.Controls.Add(this.chkHaveDataProject);
            this.Controls.Add(this.chkHaveDataTransferObjectsProject);
            this.Controls.Add(this.chkHaveApplicationProject);
            this.Controls.Add(this.chkHaveControllersProject);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ApplicationProject);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DataProject);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DataTransferObjectsProject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ControllersProject);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select files locations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ControllersProject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox DataTransferObjectsProject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox DataProject;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ApplicationProject;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkHaveControllersProject;
        private System.Windows.Forms.CheckBox chkHaveApplicationProject;
        private System.Windows.Forms.CheckBox chkHaveDataTransferObjectsProject;
        private System.Windows.Forms.CheckBox chkHaveDataProject;
        private System.Windows.Forms.CheckBox chkHaveEntitiesProject;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox EntitiesProject;
        private System.Windows.Forms.CheckBox chkHaveBusinessProject;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox BusinessProject;
    }
}