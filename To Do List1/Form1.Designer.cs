namespace To_Do_List1
{
    partial class ToDoList
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
            this.JudulTextBox = new System.Windows.Forms.TextBox();
            this.DeskripsiTextBox = new System.Windows.Forms.TextBox();
            this.Deskripsi = new System.Windows.Forms.Label();
            this.Judul = new System.Windows.Forms.Label();
            this.NewButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ToDoListLabel = new System.Windows.Forms.Label();
            this.toDoListView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.toDoListView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 9;
            // 
            // JudulTextBox
            // 
            this.JudulTextBox.Location = new System.Drawing.Point(24, 90);
            this.JudulTextBox.Name = "JudulTextBox";
            this.JudulTextBox.Size = new System.Drawing.Size(1272, 20);
            this.JudulTextBox.TabIndex = 1;
            // 
            // DeskripsiTextBox
            // 
            this.DeskripsiTextBox.Location = new System.Drawing.Point(24, 132);
            this.DeskripsiTextBox.Name = "DeskripsiTextBox";
            this.DeskripsiTextBox.Size = new System.Drawing.Size(1272, 20);
            this.DeskripsiTextBox.TabIndex = 2;
            // 
            // Deskripsi
            // 
            this.Deskripsi.Font = new System.Drawing.Font("Meiryo", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deskripsi.Location = new System.Drawing.Point(24, 113);
            this.Deskripsi.Name = "Deskripsi";
            this.Deskripsi.Size = new System.Drawing.Size(1272, 16);
            this.Deskripsi.TabIndex = 3;
            this.Deskripsi.Text = "Deskripsi";
            // 
            // Judul
            // 
            this.Judul.Font = new System.Drawing.Font("Meiryo", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Judul.Location = new System.Drawing.Point(24, 71);
            this.Judul.Name = "Judul";
            this.Judul.Size = new System.Drawing.Size(1272, 16);
            this.Judul.TabIndex = 4;
            this.Judul.Text = "Judul";
            // 
            // NewButton
            // 
            this.NewButton.Font = new System.Drawing.Font("Meiryo", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewButton.Location = new System.Drawing.Point(24, 158);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(315, 39);
            this.NewButton.TabIndex = 5;
            this.NewButton.Text = "New";
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Font = new System.Drawing.Font("Meiryo", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.Location = new System.Drawing.Point(342, 158);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(315, 39);
            this.EditButton.TabIndex = 6;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Meiryo", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(660, 158);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(315, 39);
            this.DeleteButton.TabIndex = 7;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Meiryo", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(981, 158);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(315, 39);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ToDoListLabel
            // 
            this.ToDoListLabel.Font = new System.Drawing.Font("Meiryo", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToDoListLabel.Location = new System.Drawing.Point(21, 10);
            this.ToDoListLabel.Name = "ToDoListLabel";
            this.ToDoListLabel.Size = new System.Drawing.Size(1275, 61);
            this.ToDoListLabel.TabIndex = 10;
            this.ToDoListLabel.Text = "To Do List";
            this.ToDoListLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // toDoListView
            // 
            this.toDoListView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.toDoListView.BackgroundColor = System.Drawing.Color.White;
            this.toDoListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.toDoListView.Location = new System.Drawing.Point(24, 203);
            this.toDoListView.Name = "toDoListView";
            this.toDoListView.Size = new System.Drawing.Size(1272, 292);
            this.toDoListView.TabIndex = 11;
            // 
            // ToDoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1308, 507);
            this.Controls.Add(this.toDoListView);
            this.Controls.Add(this.ToDoListLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.NewButton);
            this.Controls.Add(this.Judul);
            this.Controls.Add(this.Deskripsi);
            this.Controls.Add(this.DeskripsiTextBox);
            this.Controls.Add(this.JudulTextBox);
            this.Controls.Add(this.label1);
            this.Name = "ToDoList";
            this.Text = "To Do List";
            this.Load += new System.EventHandler(this.ToDoList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.toDoListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox JudulTextBox;
        private System.Windows.Forms.TextBox DeskripsiTextBox;
        private System.Windows.Forms.Label Deskripsi;
        private System.Windows.Forms.Label Judul;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label ToDoListLabel;
        private System.Windows.Forms.DataGridView toDoListView;
    }
}

