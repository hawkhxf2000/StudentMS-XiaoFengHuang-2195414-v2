namespace StudentMS_XiaoFengHuang_2195414
{
    partial class FrmStudentMS
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
            this.label1 = new System.Windows.Forms.Label();
            this.TbxId = new System.Windows.Forms.TextBox();
            this.TbxFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TbxLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MtxPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CbxSearch = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TbxSearch = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnList = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.LvwStudent = new System.Windows.Forms.ListView();
            this.Id = new System.Windows.Forms.ColumnHeader();
            this.FirstName = new System.Windows.Forms.ColumnHeader();
            this.LastName = new System.Windows.Forms.ColumnHeader();
            this.PhoneNumber = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(48, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID";
            // 
            // TbxId
            // 
            this.TbxId.Location = new System.Drawing.Point(49, 54);
            this.TbxId.Name = "TbxId";
            this.TbxId.Size = new System.Drawing.Size(158, 23);
            this.TbxId.TabIndex = 1;
            // 
            // TbxFirstName
            // 
            this.TbxFirstName.Location = new System.Drawing.Point(259, 54);
            this.TbxFirstName.Name = "TbxFirstName";
            this.TbxFirstName.Size = new System.Drawing.Size(170, 23);
            this.TbxFirstName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(258, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name";
            // 
            // TbxLastName
            // 
            this.TbxLastName.Location = new System.Drawing.Point(49, 128);
            this.TbxLastName.Name = "TbxLastName";
            this.TbxLastName.Size = new System.Drawing.Size(158, 23);
            this.TbxLastName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(48, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(257, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Phone Number";
            // 
            // MtxPhoneNumber
            // 
            this.MtxPhoneNumber.Location = new System.Drawing.Point(259, 128);
            this.MtxPhoneNumber.Mask = "(900)900-0000";
            this.MtxPhoneNumber.Name = "MtxPhoneNumber";
            this.MtxPhoneNumber.Size = new System.Drawing.Size(170, 23);
            this.MtxPhoneNumber.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(49, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Search By";
            // 
            // CbxSearch
            // 
            this.CbxSearch.FormattingEnabled = true;
            this.CbxSearch.Items.AddRange(new object[] {
            "ID",
            "first name",
            "last name",
            "phone number"});
            this.CbxSearch.Location = new System.Drawing.Point(49, 202);
            this.CbxSearch.Name = "CbxSearch";
            this.CbxSearch.Size = new System.Drawing.Size(158, 23);
            this.CbxSearch.TabIndex = 9;
            this.CbxSearch.Text = "ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(49, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Input Info";
            // 
            // TbxSearch
            // 
            this.TbxSearch.Location = new System.Drawing.Point(49, 267);
            this.TbxSearch.Name = "TbxSearch";
            this.TbxSearch.Size = new System.Drawing.Size(158, 23);
            this.TbxSearch.TabIndex = 11;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSearch.Location = new System.Drawing.Point(259, 247);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(114, 33);
            this.BtnSearch.TabIndex = 12;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAdd.Location = new System.Drawing.Point(484, 54);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(141, 37);
            this.BtnAdd.TabIndex = 13;
            this.BtnAdd.Text = "Add To List";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSave.Location = new System.Drawing.Point(484, 128);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(141, 37);
            this.BtnSave.TabIndex = 14;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnDelete.Location = new System.Drawing.Point(484, 202);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(141, 37);
            this.BtnDelete.TabIndex = 15;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnList
            // 
            this.BtnList.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnList.Location = new System.Drawing.Point(477, 532);
            this.BtnList.Name = "BtnList";
            this.BtnList.Size = new System.Drawing.Size(148, 37);
            this.BtnList.TabIndex = 17;
            this.BtnList.Text = "List Students";
            this.BtnList.UseVisualStyleBackColor = true;
            this.BtnList.Click += new System.EventHandler(this.BtnList_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnExit.Location = new System.Drawing.Point(477, 605);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(148, 37);
            this.BtnExit.TabIndex = 18;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // LvwStudent
            // 
            this.LvwStudent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.FirstName,
            this.LastName,
            this.PhoneNumber});
            this.LvwStudent.FullRowSelect = true;
            this.LvwStudent.GridLines = true;
            this.LvwStudent.Location = new System.Drawing.Point(49, 311);
            this.LvwStudent.Name = "LvwStudent";
            this.LvwStudent.Size = new System.Drawing.Size(576, 215);
            this.LvwStudent.TabIndex = 19;
            this.LvwStudent.UseCompatibleStateImageBehavior = false;
            this.LvwStudent.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "ID";
            this.Id.Width = 70;
            // 
            // FirstName
            // 
            this.FirstName.Text = "First Name";
            this.FirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FirstName.Width = 150;
            // 
            // LastName
            // 
            this.LastName.Text = "Last Name";
            this.LastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LastName.Width = 150;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Text = "Phone Number";
            this.PhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PhoneNumber.Width = 180;
            // 
            // FrmStudentMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 682);
            this.Controls.Add(this.LvwStudent);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnList);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.TbxSearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CbxSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MtxPhoneNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TbxLastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbxFirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbxId);
            this.Controls.Add(this.label1);
            this.Name = "FrmStudentMS";
            this.Text = "XiaoFengHuang-2195414-20220811";
            this.Load += new System.EventHandler(this.FrmStudentMS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox TbxId;
        private TextBox TbxFirstName;
        private Label label2;
        private TextBox TbxLastName;
        private Label label3;
        private Label label4;
        private MaskedTextBox MtxPhoneNumber;
        private Label label5;
        private ComboBox CbxSearch;
        private Label label6;
        private TextBox TbxSearch;
        private Button BtnSearch;
        private Button BtnAdd;
        private Button BtnSave;
        private Button BtnDelete;
        private Button BtnList;
        private Button BtnExit;
        private ListView LvwStudent;
        private ColumnHeader Id;
        private ColumnHeader FirstName;
        private ColumnHeader LastName;
        private ColumnHeader PhoneNumber;
    }
}