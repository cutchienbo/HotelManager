namespace GUI.ChildForms
{
    partial class FormPermission
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
            this.lstFull = new System.Windows.Forms.ListBox();
            this.lstRolePer = new System.Windows.Forms.ListBox();
            this.lblPer = new System.Windows.Forms.Label();
            this.lblPerOfRole = new System.Windows.Forms.Label();
            this.btnRemovePerOfRole = new FontAwesome.Sharp.IconButton();
            this.btnAddPerOfRole = new FontAwesome.Sharp.IconButton();
            this.lstRole = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.lblTextBoxRoleError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstFull
            // 
            this.lstFull.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.lstFull.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstFull.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstFull.ForeColor = System.Drawing.Color.White;
            this.lstFull.FormattingEnabled = true;
            this.lstFull.ItemHeight = 23;
            this.lstFull.Location = new System.Drawing.Point(26, 65);
            this.lstFull.Name = "lstFull";
            this.lstFull.Size = new System.Drawing.Size(248, 487);
            this.lstFull.TabIndex = 0;
            // 
            // lstRolePer
            // 
            this.lstRolePer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.lstRolePer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRolePer.ForeColor = System.Drawing.Color.White;
            this.lstRolePer.FormattingEnabled = true;
            this.lstRolePer.ItemHeight = 23;
            this.lstRolePer.Location = new System.Drawing.Point(616, 65);
            this.lstRolePer.Name = "lstRolePer";
            this.lstRolePer.Size = new System.Drawing.Size(276, 487);
            this.lstRolePer.TabIndex = 1;
            // 
            // lblPer
            // 
            this.lblPer.AutoSize = true;
            this.lblPer.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPer.ForeColor = System.Drawing.Color.White;
            this.lblPer.Location = new System.Drawing.Point(22, 32);
            this.lblPer.Name = "lblPer";
            this.lblPer.Size = new System.Drawing.Size(96, 19);
            this.lblPer.TabIndex = 2;
            this.lblPer.Text = "Permission";
            // 
            // lblPerOfRole
            // 
            this.lblPerOfRole.AutoSize = true;
            this.lblPerOfRole.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerOfRole.ForeColor = System.Drawing.Color.White;
            this.lblPerOfRole.Location = new System.Drawing.Point(612, 32);
            this.lblPerOfRole.Name = "lblPerOfRole";
            this.lblPerOfRole.Size = new System.Drawing.Size(156, 19);
            this.lblPerOfRole.TabIndex = 4;
            this.lblPerOfRole.Text = "Permission of Role";
            // 
            // btnRemovePerOfRole
            // 
            this.btnRemovePerOfRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.btnRemovePerOfRole.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemovePerOfRole.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRemovePerOfRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemovePerOfRole.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemovePerOfRole.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.btnRemovePerOfRole.IconColor = System.Drawing.Color.White;
            this.btnRemovePerOfRole.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRemovePerOfRole.IconSize = 30;
            this.btnRemovePerOfRole.Location = new System.Drawing.Point(529, 443);
            this.btnRemovePerOfRole.Name = "btnRemovePerOfRole";
            this.btnRemovePerOfRole.Size = new System.Drawing.Size(49, 46);
            this.btnRemovePerOfRole.TabIndex = 7;
            this.btnRemovePerOfRole.UseVisualStyleBackColor = false;
            this.btnRemovePerOfRole.Click += new System.EventHandler(this.btnRemovePerOfRole_Click);
            // 
            // btnAddPerOfRole
            // 
            this.btnAddPerOfRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.btnAddPerOfRole.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPerOfRole.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddPerOfRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPerOfRole.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPerOfRole.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            this.btnAddPerOfRole.IconColor = System.Drawing.Color.White;
            this.btnAddPerOfRole.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddPerOfRole.IconSize = 30;
            this.btnAddPerOfRole.Location = new System.Drawing.Point(316, 443);
            this.btnAddPerOfRole.Name = "btnAddPerOfRole";
            this.btnAddPerOfRole.Size = new System.Drawing.Size(51, 46);
            this.btnAddPerOfRole.TabIndex = 9;
            this.btnAddPerOfRole.UseVisualStyleBackColor = false;
            this.btnAddPerOfRole.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // lstRole
            // 
            this.lstRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.lstRole.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstRole.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRole.ForeColor = System.Drawing.Color.White;
            this.lstRole.FormattingEnabled = true;
            this.lstRole.ItemHeight = 23;
            this.lstRole.Location = new System.Drawing.Point(316, 65);
            this.lstRole.Name = "lstRole";
            this.lstRole.Size = new System.Drawing.Size(262, 188);
            this.lstRole.TabIndex = 12;
            this.lstRole.SelectedIndexChanged += new System.EventHandler(this.lstRole_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(312, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Role";
            // 
            // txtRole
            // 
            this.txtRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.txtRole.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRole.ForeColor = System.Drawing.Color.White;
            this.txtRole.Location = new System.Drawing.Point(316, 271);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(262, 30);
            this.txtRole.TabIndex = 14;
            this.txtRole.TextChanged += new System.EventHandler(this.txtRole_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDelete.IconColor = System.Drawing.Color.White;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.IconSize = 30;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.Location = new System.Drawing.Point(463, 348);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDelete.Size = new System.Drawing.Size(115, 46);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnAdd.IconColor = System.Drawing.Color.White;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.IconSize = 30;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.Location = new System.Drawing.Point(316, 348);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAdd.Size = new System.Drawing.Size(115, 46);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblTextBoxRoleError
            // 
            this.lblTextBoxRoleError.AutoSize = true;
            this.lblTextBoxRoleError.ForeColor = System.Drawing.Color.Red;
            this.lblTextBoxRoleError.Location = new System.Drawing.Point(315, 314);
            this.lblTextBoxRoleError.Name = "lblTextBoxRoleError";
            this.lblTextBoxRoleError.Size = new System.Drawing.Size(0, 16);
            this.lblTextBoxRoleError.TabIndex = 17;
            // 
            // FormPermission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(921, 582);
            this.Controls.Add(this.lblTextBoxRoleError);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstRole);
            this.Controls.Add(this.btnAddPerOfRole);
            this.Controls.Add(this.btnRemovePerOfRole);
            this.Controls.Add(this.lblPerOfRole);
            this.Controls.Add(this.lblPer);
            this.Controls.Add(this.lstRolePer);
            this.Controls.Add(this.lstFull);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPermission";
            this.Text = "FormPermission";
            this.Load += new System.EventHandler(this.FormPermission_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstFull;
        private System.Windows.Forms.ListBox lstRolePer;
        private System.Windows.Forms.Label lblPer;
        private System.Windows.Forms.Label lblPerOfRole;
        private FontAwesome.Sharp.IconButton btnRemovePerOfRole;
        private FontAwesome.Sharp.IconButton btnAddPerOfRole;
        private System.Windows.Forms.ListBox lstRole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRole;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnAdd;
        private System.Windows.Forms.Label lblTextBoxRoleError;
    }
}