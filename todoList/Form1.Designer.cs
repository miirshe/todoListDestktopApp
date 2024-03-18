namespace todoList
{
    partial class TODO
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtTitle = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.todoListTable = new System.Windows.Forms.DataGridView();
			this.txtDesc = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.todoListTable)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(25, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(223, 42);
			this.label1.TabIndex = 0;
			this.label1.Text = "TODO LIST";
			// 
			// txtTitle
			// 
			this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTitle.Location = new System.Drawing.Point(32, 112);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(331, 31);
			this.txtTitle.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(28, 78);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "Title";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(28, 164);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "Description";
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.RoyalBlue;
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.ForeColor = System.Drawing.Color.White;
			this.btnAdd.Location = new System.Drawing.Point(32, 307);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(93, 43);
			this.btnAdd.TabIndex = 5;
			this.btnAdd.Text = "Add Todo";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.BackColor = System.Drawing.Color.RoyalBlue;
			this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEdit.ForeColor = System.Drawing.Color.White;
			this.btnEdit.Location = new System.Drawing.Point(143, 307);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(93, 43);
			this.btnEdit.TabIndex = 6;
			this.btnEdit.Text = "Edit Todo";
			this.btnEdit.UseVisualStyleBackColor = false;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.Crimson;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.ForeColor = System.Drawing.Color.White;
			this.btnDelete.Location = new System.Drawing.Point(255, 307);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(108, 43);
			this.btnDelete.TabIndex = 7;
			this.btnDelete.Text = "Delete Todo";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.todoListTable);
			this.panel1.Location = new System.Drawing.Point(404, 112);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(381, 238);
			this.panel1.TabIndex = 9;
			// 
			// todoListTable
			// 
			this.todoListTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.todoListTable.Dock = System.Windows.Forms.DockStyle.Fill;
			this.todoListTable.Location = new System.Drawing.Point(0, 0);
			this.todoListTable.Name = "todoListTable";
			this.todoListTable.RowHeadersWidth = 170;
			this.todoListTable.Size = new System.Drawing.Size(381, 238);
			this.todoListTable.TabIndex = 0;
			// 
			// txtDesc
			// 
			this.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDesc.Location = new System.Drawing.Point(32, 187);
			this.txtDesc.Multiline = true;
			this.txtDesc.Name = "txtDesc";
			this.txtDesc.Size = new System.Drawing.Size(331, 102);
			this.txtDesc.TabIndex = 10;
			// 
			// TODO
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(797, 414);
			this.Controls.Add(this.txtDesc);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtTitle);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "TODO";
			this.Text = "TODO";
			this.Load += new System.EventHandler(this.TODO_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.todoListTable)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView todoListTable;
		private System.Windows.Forms.TextBox txtDesc;
	}
}

