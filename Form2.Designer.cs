namespace CourseWork
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonBySortFirstName = new System.Windows.Forms.Button();
            this.buttonBySortDate = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(534, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student Detail";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 82);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1296, 421);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Red;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonExit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonExit.Location = new System.Drawing.Point(1177, 560);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(108, 45);
            this.buttonExit.TabIndex = 14;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonBySortFirstName
            // 
            this.buttonBySortFirstName.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonBySortFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonBySortFirstName.Location = new System.Drawing.Point(416, 523);
            this.buttonBySortFirstName.Name = "buttonBySortFirstName";
            this.buttonBySortFirstName.Size = new System.Drawing.Size(158, 46);
            this.buttonBySortFirstName.TabIndex = 15;
            this.buttonBySortFirstName.Text = "Sort By FirstName";
            this.buttonBySortFirstName.UseVisualStyleBackColor = false;
            this.buttonBySortFirstName.Click += new System.EventHandler(this.buttonBySortFirstName_Click);
            // 
            // buttonBySortDate
            // 
            this.buttonBySortDate.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonBySortDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonBySortDate.Location = new System.Drawing.Point(722, 523);
            this.buttonBySortDate.Name = "buttonBySortDate";
            this.buttonBySortDate.Size = new System.Drawing.Size(176, 46);
            this.buttonBySortDate.TabIndex = 16;
            this.buttonBySortDate.Text = "Sort By Register Date";
            this.buttonBySortDate.UseVisualStyleBackColor = false;
            this.buttonBySortDate.Click += new System.EventHandler(this.buttonBySortDate_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonRefresh.Location = new System.Drawing.Point(30, 560);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(158, 46);
            this.buttonRefresh.TabIndex = 24;
            this.buttonRefresh.TabStop = false;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 638);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonBySortDate);
            this.Controls.Add(this.buttonBySortFirstName);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonBySortFirstName;
        private System.Windows.Forms.Button buttonBySortDate;
        private System.Windows.Forms.Button buttonRefresh;
    }
}