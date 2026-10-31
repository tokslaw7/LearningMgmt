namespace LearningMgmt
{
    partial class DashBoard
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
            stuGrid = new DataGridView();
            lblDashBoard = new Label();
            btnAdd = new Button();
            btnRefresh = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)stuGrid).BeginInit();
            SuspendLayout();
            // 
            // stuGrid
            // 
            stuGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            stuGrid.Location = new Point(582, 286);
            stuGrid.Margin = new Padding(4);
            stuGrid.Name = "stuGrid";
            stuGrid.RowHeadersWidth = 102;
            stuGrid.Size = new Size(1744, 843);
            stuGrid.TabIndex = 0;
            // 
            // lblDashBoard
            // 
            lblDashBoard.AutoSize = true;
            lblDashBoard.Location = new Point(1318, 143);
            lblDashBoard.Margin = new Padding(4, 0, 4, 0);
            lblDashBoard.Name = "lblDashBoard";
            lblDashBoard.Size = new Size(360, 49);
            lblDashBoard.TabIndex = 1;
            lblDashBoard.Text = "Student DashBoard";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LimeGreen;
            btnAdd.Location = new Point(665, 1215);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(424, 153);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add Student";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.DarkGoldenrod;
            btnRefresh.Location = new Point(1263, 1215);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(424, 153);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.Location = new Point(1853, 1215);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(424, 153);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete Student";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(22F, 49F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2843, 1452);
            Controls.Add(btnDelete);
            Controls.Add(btnRefresh);
            Controls.Add(btnAdd);
            Controls.Add(lblDashBoard);
            Controls.Add(stuGrid);
            Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "DashBoard";
            Text = "DashBoard";
            Load += DashBoard_Load;
            ((System.ComponentModel.ISupportInitialize)stuGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView stuGrid;
        private Label lblDashBoard;
        private Button btnAdd;
        private Button btnRefresh;
        private Button btnDelete;
    }
}