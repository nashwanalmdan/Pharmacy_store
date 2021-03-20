namespace مخزن_صيدلية
{
    partial class mawad
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
            System.Windows.Forms.Label name_of_thingLabel;
            System.Windows.Forms.Label made_inLabel;
            System.Windows.Forms.Label colorLabel;
            System.Windows.Forms.Label moasafatLabel;
            System.Windows.Forms.Label markaLabel;
            System.Windows.Forms.Label nodLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mawad));
            this.button1 = new System.Windows.Forms.Button();
            this.mawadBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.mawadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet3 = new مخزن_صيدلية.Database1DataSet3();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mawadBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.mawadDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_of_thingTextBox = new System.Windows.Forms.TextBox();
            this.made_inTextBox = new System.Windows.Forms.TextBox();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.moasafatTextBox = new System.Windows.Forms.TextBox();
            this.markaTextBox = new System.Windows.Forms.TextBox();
            this.nodTextBox = new System.Windows.Forms.TextBox();
            this.mawadTableAdapter = new مخزن_صيدلية.Database1DataSet3TableAdapters.mawadTableAdapter();
            this.tableAdapterManager = new مخزن_صيدلية.Database1DataSet3TableAdapters.TableAdapterManager();
            name_of_thingLabel = new System.Windows.Forms.Label();
            made_inLabel = new System.Windows.Forms.Label();
            colorLabel = new System.Windows.Forms.Label();
            moasafatLabel = new System.Windows.Forms.Label();
            markaLabel = new System.Windows.Forms.Label();
            nodLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mawadBindingNavigator)).BeginInit();
            this.mawadBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mawadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mawadDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // name_of_thingLabel
            // 
            name_of_thingLabel.AutoSize = true;
            name_of_thingLabel.Location = new System.Drawing.Point(12, 100);
            name_of_thingLabel.Name = "name_of_thingLabel";
            name_of_thingLabel.Size = new System.Drawing.Size(58, 13);
            name_of_thingLabel.TabIndex = 3;
            name_of_thingLabel.Text = "أسم المادة";
            // 
            // made_inLabel
            // 
            made_inLabel.AutoSize = true;
            made_inLabel.Location = new System.Drawing.Point(12, 126);
            made_inLabel.Name = "made_inLabel";
            made_inLabel.Size = new System.Drawing.Size(47, 13);
            made_inLabel.TabIndex = 5;
            made_inLabel.Text = "المنشاء:";
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Location = new System.Drawing.Point(12, 152);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new System.Drawing.Size(33, 13);
            colorLabel.TabIndex = 7;
            colorLabel.Text = "اللون:";
            // 
            // moasafatLabel
            // 
            moasafatLabel.AutoSize = true;
            moasafatLabel.Location = new System.Drawing.Point(12, 178);
            moasafatLabel.Name = "moasafatLabel";
            moasafatLabel.Size = new System.Drawing.Size(59, 13);
            moasafatLabel.TabIndex = 9;
            moasafatLabel.Text = "المواصفات:";
            // 
            // markaLabel
            // 
            markaLabel.AutoSize = true;
            markaLabel.Location = new System.Drawing.Point(12, 204);
            markaLabel.Name = "markaLabel";
            markaLabel.Size = new System.Drawing.Size(42, 13);
            markaLabel.TabIndex = 11;
            markaLabel.Text = "الماركة:";
            // 
            // nodLabel
            // 
            nodLabel.AutoSize = true;
            nodLabel.Location = new System.Drawing.Point(12, 230);
            nodLabel.Name = "nodLabel";
            nodLabel.Size = new System.Drawing.Size(52, 13);
            nodLabel.TabIndex = 13;
            nodLabel.Text = "ملاحظات:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "رجوع";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mawadBindingNavigator
            // 
            this.mawadBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.mawadBindingNavigator.BindingSource = this.mawadBindingSource;
            this.mawadBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.mawadBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.mawadBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.mawadBindingNavigatorSaveItem});
            this.mawadBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.mawadBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.mawadBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.mawadBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.mawadBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.mawadBindingNavigator.Name = "mawadBindingNavigator";
            this.mawadBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.mawadBindingNavigator.Size = new System.Drawing.Size(872, 25);
            this.mawadBindingNavigator.TabIndex = 2;
            this.mawadBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // mawadBindingSource
            // 
            this.mawadBindingSource.DataMember = "mawad";
            this.mawadBindingSource.DataSource = this.database1DataSet3;
            // 
            // database1DataSet3
            // 
            this.database1DataSet3.DataSetName = "Database1DataSet3";
            this.database1DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // mawadBindingNavigatorSaveItem
            // 
            this.mawadBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mawadBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("mawadBindingNavigatorSaveItem.Image")));
            this.mawadBindingNavigatorSaveItem.Name = "mawadBindingNavigatorSaveItem";
            this.mawadBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.mawadBindingNavigatorSaveItem.Text = "Save Data";
            this.mawadBindingNavigatorSaveItem.Click += new System.EventHandler(this.mawadBindingNavigatorSaveItem_Click);
            // 
            // mawadDataGridView
            // 
            this.mawadDataGridView.AutoGenerateColumns = false;
            this.mawadDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mawadDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.mawadDataGridView.DataSource = this.mawadBindingSource;
            this.mawadDataGridView.Location = new System.Drawing.Point(208, 88);
            this.mawadDataGridView.Name = "mawadDataGridView";
            this.mawadDataGridView.Size = new System.Drawing.Size(644, 220);
            this.mawadDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "name_of_thing";
            this.dataGridViewTextBoxColumn1.HeaderText = "أسم المادة";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "made_in";
            this.dataGridViewTextBoxColumn2.HeaderText = "المنشاء";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "color";
            this.dataGridViewTextBoxColumn3.HeaderText = "اللون";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "moasafat";
            this.dataGridViewTextBoxColumn4.HeaderText = "المواصفات";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "marka";
            this.dataGridViewTextBoxColumn5.HeaderText = "الماركة";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "nod";
            this.dataGridViewTextBoxColumn6.HeaderText = "ملاحظات";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // name_of_thingTextBox
            // 
            this.name_of_thingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mawadBindingSource, "name_of_thing", true));
            this.name_of_thingTextBox.Location = new System.Drawing.Point(95, 97);
            this.name_of_thingTextBox.Name = "name_of_thingTextBox";
            this.name_of_thingTextBox.Size = new System.Drawing.Size(100, 20);
            this.name_of_thingTextBox.TabIndex = 4;
            this.name_of_thingTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.name_of_thingTextBox_KeyDown);
            // 
            // made_inTextBox
            // 
            this.made_inTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mawadBindingSource, "made_in", true));
            this.made_inTextBox.Location = new System.Drawing.Point(95, 123);
            this.made_inTextBox.Name = "made_inTextBox";
            this.made_inTextBox.Size = new System.Drawing.Size(100, 20);
            this.made_inTextBox.TabIndex = 6;
            this.made_inTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.made_inTextBox_KeyDown);
            // 
            // colorTextBox
            // 
            this.colorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mawadBindingSource, "color", true));
            this.colorTextBox.Location = new System.Drawing.Point(95, 149);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(100, 20);
            this.colorTextBox.TabIndex = 8;
            this.colorTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.colorTextBox_KeyDown);
            // 
            // moasafatTextBox
            // 
            this.moasafatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mawadBindingSource, "moasafat", true));
            this.moasafatTextBox.Location = new System.Drawing.Point(95, 175);
            this.moasafatTextBox.Name = "moasafatTextBox";
            this.moasafatTextBox.Size = new System.Drawing.Size(100, 20);
            this.moasafatTextBox.TabIndex = 10;
            this.moasafatTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.moasafatTextBox_KeyDown);
            // 
            // markaTextBox
            // 
            this.markaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mawadBindingSource, "marka", true));
            this.markaTextBox.Location = new System.Drawing.Point(95, 201);
            this.markaTextBox.Name = "markaTextBox";
            this.markaTextBox.Size = new System.Drawing.Size(100, 20);
            this.markaTextBox.TabIndex = 12;
            this.markaTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.markaTextBox_KeyDown);
            // 
            // nodTextBox
            // 
            this.nodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mawadBindingSource, "nod", true));
            this.nodTextBox.Location = new System.Drawing.Point(95, 227);
            this.nodTextBox.Name = "nodTextBox";
            this.nodTextBox.Size = new System.Drawing.Size(100, 20);
            this.nodTextBox.TabIndex = 14;
            // 
            // mawadTableAdapter
            // 
            this.mawadTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.mawadTableAdapter = this.mawadTableAdapter;
            this.tableAdapterManager.UpdateOrder = مخزن_صيدلية.Database1DataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mawad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 369);
            this.Controls.Add(name_of_thingLabel);
            this.Controls.Add(this.name_of_thingTextBox);
            this.Controls.Add(made_inLabel);
            this.Controls.Add(this.made_inTextBox);
            this.Controls.Add(colorLabel);
            this.Controls.Add(this.colorTextBox);
            this.Controls.Add(moasafatLabel);
            this.Controls.Add(this.moasafatTextBox);
            this.Controls.Add(markaLabel);
            this.Controls.Add(this.markaTextBox);
            this.Controls.Add(nodLabel);
            this.Controls.Add(this.nodTextBox);
            this.Controls.Add(this.mawadDataGridView);
            this.Controls.Add(this.mawadBindingNavigator);
            this.Controls.Add(this.button1);
            this.Name = "mawad";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "المواد";
            this.Load += new System.EventHandler(this.mawad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mawadBindingNavigator)).EndInit();
            this.mawadBindingNavigator.ResumeLayout(false);
            this.mawadBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mawadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mawadDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private Database1DataSet3 database1DataSet3;
        private System.Windows.Forms.BindingSource mawadBindingSource;
        private Database1DataSet3TableAdapters.mawadTableAdapter mawadTableAdapter;
        private Database1DataSet3TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator mawadBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton mawadBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView mawadDataGridView;
        private System.Windows.Forms.TextBox name_of_thingTextBox;
        private System.Windows.Forms.TextBox made_inTextBox;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.TextBox moasafatTextBox;
        private System.Windows.Forms.TextBox markaTextBox;
        private System.Windows.Forms.TextBox nodTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}