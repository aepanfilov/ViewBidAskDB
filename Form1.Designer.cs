namespace ViewBidAskDB
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.res_dataGridView = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.countRec_toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.from_toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.to_toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.open_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.update_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.export_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.res_dataGridView)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.res_dataGridView);
            this.groupBox1.Controls.Add(this.statusStrip1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 436);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные";
            // 
            // res_dataGridView
            // 
            this.res_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.res_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.res_dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.res_dataGridView.Location = new System.Drawing.Point(3, 16);
            this.res_dataGridView.Name = "res_dataGridView";
            this.res_dataGridView.RowHeadersVisible = false;
            this.res_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.res_dataGridView.Size = new System.Drawing.Size(491, 395);
            this.res_dataGridView.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.countRec_toolStripStatusLabel,
            this.toolStripStatusLabel3,
            this.from_toolStripStatusLabel,
            this.toolStripStatusLabel5,
            this.to_toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(3, 411);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(491, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(49, 17);
            this.toolStripStatusLabel1.Text = "Кол-во:";
            // 
            // countRec_toolStripStatusLabel
            // 
            this.countRec_toolStripStatusLabel.Name = "countRec_toolStripStatusLabel";
            this.countRec_toolStripStatusLabel.Size = new System.Drawing.Size(25, 17);
            this.countRec_toolStripStatusLabel.Text = "123";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.AutoSize = false;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(36, 17);
            this.toolStripStatusLabel3.Text = "с:";
            this.toolStripStatusLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // from_toolStripStatusLabel
            // 
            this.from_toolStripStatusLabel.Name = "from_toolStripStatusLabel";
            this.from_toolStripStatusLabel.Size = new System.Drawing.Size(31, 17);
            this.from_toolStripStatusLabel.Text = "1234";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(24, 17);
            this.toolStripStatusLabel5.Text = "по:";
            // 
            // to_toolStripStatusLabel
            // 
            this.to_toolStripStatusLabel.Name = "to_toolStripStatusLabel";
            this.to_toolStripStatusLabel.Size = new System.Drawing.Size(31, 17);
            this.to_toolStripStatusLabel.Text = "3423";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.open_toolStripButton,
            this.toolStripSeparator1,
            this.update_toolStripButton,
            this.toolStripSeparator2,
            this.toolStripSeparator3,
            this.export_toolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(497, 39);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // open_toolStripButton
            // 
            this.open_toolStripButton.Image = global::ViewBidAskDB.Properties.Resources.Folder;
            this.open_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.open_toolStripButton.Name = "open_toolStripButton";
            this.open_toolStripButton.Size = new System.Drawing.Size(90, 36);
            this.open_toolStripButton.Text = "Открыть";
            this.open_toolStripButton.Click += new System.EventHandler(this.Open_toolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            this.toolStripSeparator1.Visible = false;
            // 
            // update_toolStripButton
            // 
            this.update_toolStripButton.Image = global::ViewBidAskDB.Properties.Resources.RefreshArrow;
            this.update_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.update_toolStripButton.Name = "update_toolStripButton";
            this.update_toolStripButton.Size = new System.Drawing.Size(97, 36);
            this.update_toolStripButton.Text = "Обновить";
            this.update_toolStripButton.Visible = false;
            this.update_toolStripButton.Click += new System.EventHandler(this.Update_toolStripButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            this.toolStripSeparator3.Visible = false;
            // 
            // export_toolStripButton
            // 
            this.export_toolStripButton.Image = global::ViewBidAskDB.Properties.Resources.excel;
            this.export_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.export_toolStripButton.Name = "export_toolStripButton";
            this.export_toolStripButton.Size = new System.Drawing.Size(88, 36);
            this.export_toolStripButton.Text = "Экспорт";
            this.export_toolStripButton.Click += new System.EventHandler(this.Export_toolStripButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 475);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Просмотр БД с данными по Bid и Ask";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.res_dataGridView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView res_dataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel countRec_toolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel from_toolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel to_toolStripStatusLabel;
        private System.Windows.Forms.ToolStripButton open_toolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton export_toolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton update_toolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}

