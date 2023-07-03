namespace Dismord_voic
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Main_tabPage = new System.Windows.Forms.TabPage();
            this.Confidence_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Confidence_trackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.File_tabPage = new System.Windows.Forms.TabPage();
            this.Save_File_button = new System.Windows.Forms.Button();
            this.Load_FIle_button = new System.Windows.Forms.Button();
            this.FileDataGridView = new System.Windows.Forms.DataGridView();
            this.Voic_Command_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.File_Puth_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EXE_tabPage = new System.Windows.Forms.TabPage();
            this.EXESaveButton = new System.Windows.Forms.Button();
            this.EXEOpenButton = new System.Windows.Forms.Button();
            this.EXEDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.Dota2ProtocolNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.tabControl1.SuspendLayout();
            this.Main_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Confidence_trackBar)).BeginInit();
            this.File_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FileDataGridView)).BeginInit();
            this.EXE_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EXEDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dota2ProtocolNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.Main_tabPage);
            this.tabControl1.Controls.Add(this.File_tabPage);
            this.tabControl1.Controls.Add(this.EXE_tabPage);
            this.tabControl1.Location = new System.Drawing.Point(4, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(793, 448);
            this.tabControl1.TabIndex = 3;
            // 
            // Main_tabPage
            // 
            this.Main_tabPage.Controls.Add(this.Dota2ProtocolNumericUpDown);
            this.Main_tabPage.Controls.Add(this.label3);
            this.Main_tabPage.Controls.Add(this.Confidence_label);
            this.Main_tabPage.Controls.Add(this.label2);
            this.Main_tabPage.Controls.Add(this.Confidence_trackBar);
            this.Main_tabPage.Controls.Add(this.label1);
            this.Main_tabPage.Controls.Add(this.textBox1);
            this.Main_tabPage.Location = new System.Drawing.Point(4, 22);
            this.Main_tabPage.Name = "Main_tabPage";
            this.Main_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.Main_tabPage.Size = new System.Drawing.Size(785, 422);
            this.Main_tabPage.TabIndex = 0;
            this.Main_tabPage.Text = "Главная";
            this.Main_tabPage.UseVisualStyleBackColor = true;
            // 
            // Confidence_label
            // 
            this.Confidence_label.AutoSize = true;
            this.Confidence_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Confidence_label.Location = new System.Drawing.Point(692, 204);
            this.Confidence_label.Name = "Confidence_label";
            this.Confidence_label.Size = new System.Drawing.Size(0, 24);
            this.Confidence_label.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(456, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Коэфициент сходства:";
            // 
            // Confidence_trackBar
            // 
            this.Confidence_trackBar.Location = new System.Drawing.Point(451, 231);
            this.Confidence_trackBar.Maximum = 100;
            this.Confidence_trackBar.Name = "Confidence_trackBar";
            this.Confidence_trackBar.Size = new System.Drawing.Size(311, 45);
            this.Confidence_trackBar.TabIndex = 2;
            this.Confidence_trackBar.Scroll += new System.EventHandler(this.Confidence_trackBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(526, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ответ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(451, 61);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(311, 132);
            this.textBox1.TabIndex = 0;
            // 
            // File_tabPage
            // 
            this.File_tabPage.Controls.Add(this.Save_File_button);
            this.File_tabPage.Controls.Add(this.Load_FIle_button);
            this.File_tabPage.Controls.Add(this.FileDataGridView);
            this.File_tabPage.Location = new System.Drawing.Point(4, 22);
            this.File_tabPage.Name = "File_tabPage";
            this.File_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.File_tabPage.Size = new System.Drawing.Size(785, 422);
            this.File_tabPage.TabIndex = 1;
            this.File_tabPage.Text = "Файлы";
            this.File_tabPage.UseVisualStyleBackColor = true;
            // 
            // Save_File_button
            // 
            this.Save_File_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Save_File_button.Location = new System.Drawing.Point(553, 378);
            this.Save_File_button.Name = "Save_File_button";
            this.Save_File_button.Size = new System.Drawing.Size(110, 38);
            this.Save_File_button.TabIndex = 1;
            this.Save_File_button.Text = "Сохранить";
            this.Save_File_button.UseVisualStyleBackColor = true;
            this.Save_File_button.Click += new System.EventHandler(this.Save_File_button_Click);
            // 
            // Load_FIle_button
            // 
            this.Load_FIle_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Load_FIle_button.Location = new System.Drawing.Point(669, 378);
            this.Load_FIle_button.Name = "Load_FIle_button";
            this.Load_FIle_button.Size = new System.Drawing.Size(110, 38);
            this.Load_FIle_button.TabIndex = 1;
            this.Load_FIle_button.Text = "Открыть";
            this.Load_FIle_button.UseVisualStyleBackColor = true;
            this.Load_FIle_button.Click += new System.EventHandler(this.Load_button_Click);
            // 
            // FileDataGridView
            // 
            this.FileDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FileDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FileDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Voic_Command_Column,
            this.File_Puth_Column});
            this.FileDataGridView.Location = new System.Drawing.Point(0, 0);
            this.FileDataGridView.Name = "FileDataGridView";
            this.FileDataGridView.Size = new System.Drawing.Size(785, 372);
            this.FileDataGridView.TabIndex = 0;
            this.FileDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.FileDataGridView_RowHeaderMouseClick);
            // 
            // Voic_Command_Column
            // 
            this.Voic_Command_Column.HeaderText = "Голосовая команда";
            this.Voic_Command_Column.Name = "Voic_Command_Column";
            // 
            // File_Puth_Column
            // 
            this.File_Puth_Column.HeaderText = "Рассположение файла";
            this.File_Puth_Column.Name = "File_Puth_Column";
            // 
            // EXE_tabPage
            // 
            this.EXE_tabPage.Controls.Add(this.EXESaveButton);
            this.EXE_tabPage.Controls.Add(this.EXEOpenButton);
            this.EXE_tabPage.Controls.Add(this.EXEDataGridView);
            this.EXE_tabPage.Location = new System.Drawing.Point(4, 22);
            this.EXE_tabPage.Name = "EXE_tabPage";
            this.EXE_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.EXE_tabPage.Size = new System.Drawing.Size(785, 422);
            this.EXE_tabPage.TabIndex = 2;
            this.EXE_tabPage.Text = "EXE";
            this.EXE_tabPage.UseVisualStyleBackColor = true;
            // 
            // EXESaveButton
            // 
            this.EXESaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EXESaveButton.Location = new System.Drawing.Point(553, 378);
            this.EXESaveButton.Name = "EXESaveButton";
            this.EXESaveButton.Size = new System.Drawing.Size(110, 38);
            this.EXESaveButton.TabIndex = 2;
            this.EXESaveButton.Text = "Сохранить";
            this.EXESaveButton.UseVisualStyleBackColor = true;
            this.EXESaveButton.Click += new System.EventHandler(this.EXESaveButton_Click);
            // 
            // EXEOpenButton
            // 
            this.EXEOpenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EXEOpenButton.Location = new System.Drawing.Point(669, 378);
            this.EXEOpenButton.Name = "EXEOpenButton";
            this.EXEOpenButton.Size = new System.Drawing.Size(110, 38);
            this.EXEOpenButton.TabIndex = 3;
            this.EXEOpenButton.Text = "Открыть";
            this.EXEOpenButton.UseVisualStyleBackColor = true;
            this.EXEOpenButton.Click += new System.EventHandler(this.EXEOpenButton_Click);
            // 
            // EXEDataGridView
            // 
            this.EXEDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EXEDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EXEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EXEDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.EXEDataGridView.Location = new System.Drawing.Point(0, 0);
            this.EXEDataGridView.Name = "EXEDataGridView";
            this.EXEDataGridView.Size = new System.Drawing.Size(785, 372);
            this.EXEDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Голосовая команда";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Программа без .exe";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(350, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Количество сообщений в протоколе \"Dota2\":";
            // 
            // Dota2ProtocolNumericUpDown
            // 
            this.Dota2ProtocolNumericUpDown.Location = new System.Drawing.Point(362, 14);
            this.Dota2ProtocolNumericUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.Dota2ProtocolNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Dota2ProtocolNumericUpDown.Name = "Dota2ProtocolNumericUpDown";
            this.Dota2ProtocolNumericUpDown.Size = new System.Drawing.Size(45, 20);
            this.Dota2ProtocolNumericUpDown.TabIndex = 5;
            this.Dota2ProtocolNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Main_tabPage.ResumeLayout(false);
            this.Main_tabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Confidence_trackBar)).EndInit();
            this.File_tabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FileDataGridView)).EndInit();
            this.EXE_tabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EXEDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dota2ProtocolNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Main_tabPage;
        private System.Windows.Forms.TabPage File_tabPage;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView FileDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Voic_Command_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn File_Puth_Column;
        private System.Windows.Forms.Button Save_File_button;
        private System.Windows.Forms.Button Load_FIle_button;
        private System.Windows.Forms.Label Confidence_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar Confidence_trackBar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabPage EXE_tabPage;
        private System.Windows.Forms.Button EXESaveButton;
        private System.Windows.Forms.Button EXEOpenButton;
        private System.Windows.Forms.DataGridView EXEDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.NumericUpDown Dota2ProtocolNumericUpDown;
        private System.Windows.Forms.Label label3;
    }
}

