
namespace eko
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ekoDataSet = new eko.ekoDataSet();
            this.уровеньЗагрязнениеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.уровеньЗагрязнение_TableAdapter = new eko.ekoDataSetTableAdapters.УровеньЗагрязнение_TableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rivStatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idСубъектаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conMPCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idДатыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idИнгридиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.субъектBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.субъект_TableAdapter = new eko.ekoDataSetTableAdapters.Субъект_TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.уровеньЗагрязнениеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.субъектBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.rivStatDataGridViewTextBoxColumn,
            this.idСубъектаDataGridViewTextBoxColumn,
            this.conMPCDataGridViewTextBoxColumn,
            this.classDataGridViewTextBoxColumn,
            this.idДатыDataGridViewTextBoxColumn,
            this.idИнгридиентаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.уровеньЗагрязнениеBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 310);
            this.dataGridView1.TabIndex = 0;
            // 
            // ekoDataSet
            // 
            this.ekoDataSet.DataSetName = "ekoDataSet";
            this.ekoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // уровеньЗагрязнениеBindingSource
            // 
            this.уровеньЗагрязнениеBindingSource.DataMember = "УровеньЗагрязнение$";
            this.уровеньЗагрязнениеBindingSource.DataSource = this.ekoDataSet;
            // 
            // уровеньЗагрязнение_TableAdapter
            // 
            this.уровеньЗагрязнение_TableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // rivStatDataGridViewTextBoxColumn
            // 
            this.rivStatDataGridViewTextBoxColumn.DataPropertyName = "RivStat";
            this.rivStatDataGridViewTextBoxColumn.HeaderText = "RivStat";
            this.rivStatDataGridViewTextBoxColumn.Name = "rivStatDataGridViewTextBoxColumn";
            // 
            // idСубъектаDataGridViewTextBoxColumn
            // 
            this.idСубъектаDataGridViewTextBoxColumn.DataPropertyName = "id субъекта";
            this.idСубъектаDataGridViewTextBoxColumn.HeaderText = "id субъекта";
            this.idСубъектаDataGridViewTextBoxColumn.Name = "idСубъектаDataGridViewTextBoxColumn";
            // 
            // conMPCDataGridViewTextBoxColumn
            // 
            this.conMPCDataGridViewTextBoxColumn.DataPropertyName = "ConMPC";
            this.conMPCDataGridViewTextBoxColumn.HeaderText = "ConMPC";
            this.conMPCDataGridViewTextBoxColumn.Name = "conMPCDataGridViewTextBoxColumn";
            // 
            // classDataGridViewTextBoxColumn
            // 
            this.classDataGridViewTextBoxColumn.DataPropertyName = "Class";
            this.classDataGridViewTextBoxColumn.HeaderText = "Class";
            this.classDataGridViewTextBoxColumn.Name = "classDataGridViewTextBoxColumn";
            // 
            // idДатыDataGridViewTextBoxColumn
            // 
            this.idДатыDataGridViewTextBoxColumn.DataPropertyName = "id даты";
            this.idДатыDataGridViewTextBoxColumn.HeaderText = "id даты";
            this.idДатыDataGridViewTextBoxColumn.Name = "idДатыDataGridViewTextBoxColumn";
            // 
            // idИнгридиентаDataGridViewTextBoxColumn
            // 
            this.idИнгридиентаDataGridViewTextBoxColumn.DataPropertyName = "id ингридиента";
            this.idИнгридиентаDataGridViewTextBoxColumn.HeaderText = "id ингридиента";
            this.idИнгридиентаDataGridViewTextBoxColumn.Name = "idИнгридиентаDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(390, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Диаграмма";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(49, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите субъект";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.субъектBindingSource;
            this.comboBox1.DisplayMember = "RusFedsub";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(222, 83);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(141, 23);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.ValueMember = "id";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(35, 446);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(328, 64);
            this.label3.TabIndex = 5;
            this.label3.Text = "Среднее значение концентрации вредных веществ в окружающей среды";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(156, 465);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(77, 21);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "7";
            this.textBox1.Click += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(874, 141);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // субъектBindingSource
            // 
            this.субъектBindingSource.DataMember = "Субъект$";
            this.субъектBindingSource.DataSource = this.ekoDataSet;
            // 
            // субъект_TableAdapter
            // 
            this.субъект_TableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 519);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Form1";
            this.Text = "Сведения о загрязнении окружающей среды на территории РФ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.уровеньЗагрязнениеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.субъектBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ekoDataSet ekoDataSet;
        private System.Windows.Forms.BindingSource уровеньЗагрязнениеBindingSource;
        private ekoDataSetTableAdapters.УровеньЗагрязнение_TableAdapter уровеньЗагрязнение_TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rivStatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idСубъектаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conMPCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idДатыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idИнгридиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.BindingSource субъектBindingSource;
        private ekoDataSetTableAdapters.Субъект_TableAdapter субъект_TableAdapter;
    }
}

