namespace Project
{
    partial class Form4
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label sunameLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label dateinLabel;
            System.Windows.Forms.Label dateoutLabel;
            System.Windows.Forms.Label sizeLabel;
            System.Windows.Forms.Label billLabel;
            System.Windows.Forms.Label amountLabel;
            this.database1DataSet = new Project.Database1DataSet();
            this.data1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.data1TableAdapter = new Project.Database1DataSetTableAdapters.Data1TableAdapter();
            this.tableAdapterManager = new Project.Database1DataSetTableAdapters.TableAdapterManager();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.TextBox3 = new System.Windows.Forms.TextBox();
            this.TextBox4 = new System.Windows.Forms.TextBox();
            this.TextBox5 = new System.Windows.Forms.TextBox();
            this.TextBox6 = new System.Windows.Forms.TextBox();
            this.TextBox7 = new System.Windows.Forms.TextBox();
            this.TextBox8 = new System.Windows.Forms.TextBox();
            this.TextBox9 = new System.Windows.Forms.TextBox();
            this.TextBox10 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sunameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateoutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            sunameLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            dateinLabel = new System.Windows.Forms.Label();
            dateoutLabel = new System.Windows.Forms.Label();
            sizeLabel = new System.Windows.Forms.Label();
            billLabel = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data1BindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(22, 58);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Name:";
            // 
            // sunameLabel
            // 
            sunameLabel.AutoSize = true;
            sunameLabel.Location = new System.Drawing.Point(22, 84);
            sunameLabel.Name = "sunameLabel";
            sunameLabel.Size = new System.Drawing.Size(49, 13);
            sunameLabel.TabIndex = 4;
            sunameLabel.Text = "Suname:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(22, 110);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(41, 13);
            phoneLabel.TabIndex = 6;
            phoneLabel.Text = "Phone:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(22, 136);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 8;
            addressLabel.Text = "Address:";
            // 
            // dateinLabel
            // 
            dateinLabel.AutoSize = true;
            dateinLabel.Location = new System.Drawing.Point(22, 162);
            dateinLabel.Name = "dateinLabel";
            dateinLabel.Size = new System.Drawing.Size(41, 13);
            dateinLabel.TabIndex = 10;
            dateinLabel.Text = "Datein:";
            // 
            // dateoutLabel
            // 
            dateoutLabel.AutoSize = true;
            dateoutLabel.Location = new System.Drawing.Point(22, 188);
            dateoutLabel.Name = "dateoutLabel";
            dateoutLabel.Size = new System.Drawing.Size(48, 13);
            dateoutLabel.TabIndex = 12;
            dateoutLabel.Text = "Dateout:";
            // 
            // sizeLabel
            // 
            sizeLabel.AutoSize = true;
            sizeLabel.Location = new System.Drawing.Point(22, 214);
            sizeLabel.Name = "sizeLabel";
            sizeLabel.Size = new System.Drawing.Size(30, 13);
            sizeLabel.TabIndex = 14;
            sizeLabel.Text = "Size:";
            // 
            // billLabel
            // 
            billLabel.AutoSize = true;
            billLabel.Location = new System.Drawing.Point(22, 240);
            billLabel.Name = "billLabel";
            billLabel.Size = new System.Drawing.Size(23, 13);
            billLabel.TabIndex = 16;
            billLabel.Text = "Bill:";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(22, 266);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(46, 13);
            amountLabel.TabIndex = 18;
            amountLabel.Text = "Amount:";
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // data1BindingSource
            // 
            this.data1BindingSource.DataMember = "Data1";
            this.data1BindingSource.DataSource = this.database1DataSet;
            // 
            // data1TableAdapter
            // 
            this.data1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Data1TableAdapter = this.data1TableAdapter;
            this.tableAdapterManager.UpdateOrder = Project.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DimGray;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tToolStripMenuItem,
            this.homeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(119, 440);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tToolStripMenuItem
            // 
            this.tToolStripMenuItem.AutoSize = false;
            this.tToolStripMenuItem.Image = global::Project.Properties.Resources.icon2;
            this.tToolStripMenuItem.Name = "tToolStripMenuItem";
            this.tToolStripMenuItem.Size = new System.Drawing.Size(113, 40);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.AutoSize = false;
            this.homeToolStripMenuItem.Font = new System.Drawing.Font("Script MT Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(112, 40);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.HomeToolStripMenuItem_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(77, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // TextBox2
            // 
            this.TextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.data1BindingSource, "Name", true));
            this.TextBox2.Location = new System.Drawing.Point(77, 55);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(100, 20);
            this.TextBox2.TabIndex = 3;
            // 
            // TextBox3
            // 
            this.TextBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.data1BindingSource, "Suname", true));
            this.TextBox3.Location = new System.Drawing.Point(77, 81);
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.Size = new System.Drawing.Size(100, 20);
            this.TextBox3.TabIndex = 5;
            // 
            // TextBox4
            // 
            this.TextBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.data1BindingSource, "Phone", true));
            this.TextBox4.Location = new System.Drawing.Point(77, 107);
            this.TextBox4.Name = "TextBox4";
            this.TextBox4.Size = new System.Drawing.Size(100, 20);
            this.TextBox4.TabIndex = 7;
            // 
            // TextBox5
            // 
            this.TextBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.data1BindingSource, "Address", true));
            this.TextBox5.Location = new System.Drawing.Point(77, 133);
            this.TextBox5.Name = "TextBox5";
            this.TextBox5.Size = new System.Drawing.Size(100, 20);
            this.TextBox5.TabIndex = 9;
            // 
            // TextBox6
            // 
            this.TextBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.data1BindingSource, "Datein", true));
            this.TextBox6.Location = new System.Drawing.Point(77, 159);
            this.TextBox6.Name = "TextBox6";
            this.TextBox6.Size = new System.Drawing.Size(100, 20);
            this.TextBox6.TabIndex = 11;
            // 
            // TextBox7
            // 
            this.TextBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.data1BindingSource, "Dateout", true));
            this.TextBox7.Location = new System.Drawing.Point(77, 185);
            this.TextBox7.Name = "TextBox7";
            this.TextBox7.Size = new System.Drawing.Size(100, 20);
            this.TextBox7.TabIndex = 13;
            // 
            // TextBox8
            // 
            this.TextBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.data1BindingSource, "Size", true));
            this.TextBox8.Location = new System.Drawing.Point(77, 211);
            this.TextBox8.Name = "TextBox8";
            this.TextBox8.Size = new System.Drawing.Size(100, 20);
            this.TextBox8.TabIndex = 15;
            // 
            // TextBox9
            // 
            this.TextBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.data1BindingSource, "Bill", true));
            this.TextBox9.Location = new System.Drawing.Point(77, 237);
            this.TextBox9.Name = "TextBox9";
            this.TextBox9.Size = new System.Drawing.Size(100, 20);
            this.TextBox9.TabIndex = 17;
            // 
            // TextBox10
            // 
            this.TextBox10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.data1BindingSource, "Amount", true));
            this.TextBox10.Location = new System.Drawing.Point(77, 263);
            this.TextBox10.Name = "TextBox10";
            this.TextBox10.Size = new System.Drawing.Size(100, 20);
            this.TextBox10.TabIndex = 19;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.sunameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.dateinDataGridViewTextBoxColumn,
            this.dateoutDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn,
            this.billDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.data1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(493, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 348);
            this.dataGridView1.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // sunameDataGridViewTextBoxColumn
            // 
            this.sunameDataGridViewTextBoxColumn.DataPropertyName = "Suname";
            this.sunameDataGridViewTextBoxColumn.HeaderText = "Suname";
            this.sunameDataGridViewTextBoxColumn.Name = "sunameDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // dateinDataGridViewTextBoxColumn
            // 
            this.dateinDataGridViewTextBoxColumn.DataPropertyName = "Datein";
            this.dateinDataGridViewTextBoxColumn.HeaderText = "Datein";
            this.dateinDataGridViewTextBoxColumn.Name = "dateinDataGridViewTextBoxColumn";
            // 
            // dateoutDataGridViewTextBoxColumn
            // 
            this.dateoutDataGridViewTextBoxColumn.DataPropertyName = "Dateout";
            this.dateoutDataGridViewTextBoxColumn.HeaderText = "Dateout";
            this.dateoutDataGridViewTextBoxColumn.Name = "dateoutDataGridViewTextBoxColumn";
            // 
            // sizeDataGridViewTextBoxColumn
            // 
            this.sizeDataGridViewTextBoxColumn.DataPropertyName = "Size";
            this.sizeDataGridViewTextBoxColumn.HeaderText = "Size";
            this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
            // 
            // billDataGridViewTextBoxColumn
            // 
            this.billDataGridViewTextBoxColumn.DataPropertyName = "Bill";
            this.billDataGridViewTextBoxColumn.HeaderText = "Bill";
            this.billDataGridViewTextBoxColumn.Name = "billDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(121, 302);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.TextBox6);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(dateinLabel);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(dateoutLabel);
            this.groupBox1.Controls.Add(this.TextBox5);
            this.groupBox1.Controls.Add(this.TextBox7);
            this.groupBox1.Controls.Add(addressLabel);
            this.groupBox1.Controls.Add(sizeLabel);
            this.groupBox1.Controls.Add(nameLabel);
            this.groupBox1.Controls.Add(this.TextBox4);
            this.groupBox1.Controls.Add(this.TextBox10);
            this.groupBox1.Controls.Add(this.TextBox8);
            this.groupBox1.Controls.Add(this.TextBox2);
            this.groupBox1.Controls.Add(phoneLabel);
            this.groupBox1.Controls.Add(amountLabel);
            this.groupBox1.Controls.Add(billLabel);
            this.groupBox1.Controls.Add(sunameLabel);
            this.groupBox1.Controls.Add(this.TextBox3);
            this.groupBox1.Controls.Add(this.TextBox9);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Location = new System.Drawing.Point(167, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 348);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit Delete";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "ID:";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 440);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form4";
            this.Text = "Clothes Store";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data1BindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource data1BindingSource;
        private Database1DataSetTableAdapters.Data1TableAdapter data1TableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.TextBox TextBox2;
        private System.Windows.Forms.TextBox TextBox3;
        private System.Windows.Forms.TextBox TextBox4;
        private System.Windows.Forms.TextBox TextBox5;
        private System.Windows.Forms.TextBox TextBox6;
        private System.Windows.Forms.TextBox TextBox7;
        private System.Windows.Forms.TextBox TextBox8;
        private System.Windows.Forms.TextBox TextBox9;
        private System.Windows.Forms.TextBox TextBox10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sunameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateoutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}