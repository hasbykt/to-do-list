using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_Do_List1
{
    public partial class ToDoList : Form
    {
        public ToDoList()
        {
            InitializeComponent();
        }
        DataTable todoList = new DataTable();
        bool isEditing = false;
        private void ToDoList_Load(object sender, EventArgs e)
        {
            //Create Colomns
            todoList.Columns.Add("Judul");
            todoList.Columns.Add("Deskripsi");

            // Point our datagridview to our datasource
            toDoListView.DataSource = todoList;
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            JudulTextBox.Text = "";
            DeskripsiTextBox.Text = "";

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            isEditing = true;
            JudulTextBox.Text = todoList.Rows[toDoListView.CurrentCell.RowIndex].ItemArray[0].ToString();
            DeskripsiTextBox.Text = todoList.Rows[toDoListView.CurrentCell.RowIndex].ItemArray[1].ToString();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                todoList.Rows[toDoListView.CurrentCell.RowIndex].Delete();
            }
            catch(Exception ex) 
            {
                Console.WriteLine("Error: " + ex);    
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if(isEditing)
            {
                todoList.Rows[toDoListView.CurrentCell.RowIndex]["Judul"] = JudulTextBox.Text;
                todoList.Rows[toDoListView.CurrentCell.RowIndex]["Deskripsi"] = DeskripsiTextBox.Text;
            }
            else
            {
                todoList.Rows.Add(JudulTextBox.Text, DeskripsiTextBox.Text);
            }
            //Clear Fields
            JudulTextBox.Text = "";
            DeskripsiTextBox.Text = "";
            isEditing = false;
        }
    }
}
