namespace مخزن_صيدلية
{
    partial class taqarer_mawad
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.mawadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Database1DataSet3 = new مخزن_صيدلية.Database1DataSet3();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.mawadBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mawadTableAdapter = new مخزن_صيدلية.Database1DataSet3TableAdapters.mawadTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.Database1DataSet2 = new مخزن_صيدلية.Database1DataSet2();
            this.beanatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.beanatTableAdapter = new مخزن_صيدلية.Database1DataSet2TableAdapters.beanatTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.mawadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mawadBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beanatBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mawadBindingSource
            // 
            this.mawadBindingSource.DataMember = "mawad";
            this.mawadBindingSource.DataSource = this.Database1DataSet3;
            // 
            // Database1DataSet3
            // 
            this.Database1DataSet3.DataSetName = "Database1DataSet3";
            this.Database1DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.mawadBindingSource1;
            this.comboBox1.DisplayMember = "name_of_thing";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(100, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.ValueMember = "name_of_thing";
            // 
            // mawadBindingSource1
            // 
            this.mawadBindingSource1.DataMember = "mawad";
            this.mawadBindingSource1.DataSource = this.Database1DataSet3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(548, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 10;
            this.button1.Text = "بحث";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "أسم المادة";
            // 
            // mawadTableAdapter
            // 
            this.mawadTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(540, 411);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "رجوع";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Database1DataSet2
            // 
            this.Database1DataSet2.DataSetName = "Database1DataSet2";
            this.Database1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // beanatBindingSource
            // 
            this.beanatBindingSource.DataMember = "beanat";
            this.beanatBindingSource.DataSource = this.Database1DataSet2;
            // 
            // beanatTableAdapter
            // 
            this.beanatTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.mawadBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "مخزن_صيدلية.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(24, 159);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(633, 246);
            this.reportViewer1.TabIndex = 14;
            // 
            // taqarer_mawad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 440);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "taqarer_mawad";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "تقرير المواد";
            this.Load += new System.EventHandler(this.taqarer_mawad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mawadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mawadBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beanatBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource mawadBindingSource;
        private Database1DataSet3 Database1DataSet3;
        private Database1DataSet3TableAdapters.mawadTableAdapter mawadTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource beanatBindingSource;
        private Database1DataSet2 Database1DataSet2;
        private Database1DataSet2TableAdapters.beanatTableAdapter beanatTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource mawadBindingSource1;
    }
}