namespace r06521607
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.cOB19DataSet = new r06521607.COB19DataSet();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.assetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.assetTableAdapter = new r06521607.COB19DataSetTableAdapters.AssetTableAdapter();
			this.assetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.extIdentifierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.barCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.assetIdentifierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.expr1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cOB19DataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.assetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.assetBindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// bindingSource1
			// 
			this.bindingSource1.DataSource = this.cOB19DataSet;
			this.bindingSource1.Position = 0;
			// 
			// cOB19DataSet
			// 
			this.cOB19DataSet.DataSetName = "COB19DataSet";
			this.cOB19DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.extIdentifierDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.barCodeDataGridViewTextBoxColumn,
            this.assetIdentifierDataGridViewTextBoxColumn,
            this.expr1DataGridViewTextBoxColumn,
            this.manufacturerDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.assetBindingSource1;
			this.dataGridView1.Location = new System.Drawing.Point(12, 110);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(763, 319);
			this.dataGridView1.TabIndex = 0;
			// 
			// assetBindingSource
			// 
			this.assetBindingSource.DataMember = "Asset";
			this.assetBindingSource.DataSource = this.bindingSource1;
			// 
			// assetTableAdapter
			// 
			this.assetTableAdapter.ClearBeforeFill = true;
			// 
			// assetBindingSource1
			// 
			this.assetBindingSource1.DataMember = "Asset";
			this.assetBindingSource1.DataSource = this.bindingSource1;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "產品名稱";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			// 
			// extIdentifierDataGridViewTextBoxColumn
			// 
			this.extIdentifierDataGridViewTextBoxColumn.DataPropertyName = "ExtIdentifier";
			this.extIdentifierDataGridViewTextBoxColumn.HeaderText = "產品ID";
			this.extIdentifierDataGridViewTextBoxColumn.Name = "extIdentifierDataGridViewTextBoxColumn";
			// 
			// descriptionDataGridViewTextBoxColumn
			// 
			this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
			this.descriptionDataGridViewTextBoxColumn.HeaderText = "類型ID";
			this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
			// 
			// barCodeDataGridViewTextBoxColumn
			// 
			this.barCodeDataGridViewTextBoxColumn.DataPropertyName = "BarCode";
			this.barCodeDataGridViewTextBoxColumn.HeaderText = "財產名稱";
			this.barCodeDataGridViewTextBoxColumn.Name = "barCodeDataGridViewTextBoxColumn";
			// 
			// assetIdentifierDataGridViewTextBoxColumn
			// 
			this.assetIdentifierDataGridViewTextBoxColumn.DataPropertyName = "AssetIdentifier";
			this.assetIdentifierDataGridViewTextBoxColumn.HeaderText = "財產代碼";
			this.assetIdentifierDataGridViewTextBoxColumn.Name = "assetIdentifierDataGridViewTextBoxColumn";
			// 
			// expr1DataGridViewTextBoxColumn
			// 
			this.expr1DataGridViewTextBoxColumn.DataPropertyName = "Expr1";
			this.expr1DataGridViewTextBoxColumn.HeaderText = "類型名稱";
			this.expr1DataGridViewTextBoxColumn.Name = "expr1DataGridViewTextBoxColumn";
			// 
			// manufacturerDataGridViewTextBoxColumn
			// 
			this.manufacturerDataGridViewTextBoxColumn.DataPropertyName = "Manufacturer";
			this.manufacturerDataGridViewTextBoxColumn.HeaderText = "製造廠商";
			this.manufacturerDataGridViewTextBoxColumn.Name = "manufacturerDataGridViewTextBoxColumn";
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.textBox1.Location = new System.Drawing.Point(221, 36);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(181, 27);
			this.textBox1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(22, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(193, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "請輸入要查詢之產品名稱 :";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.button1.Location = new System.Drawing.Point(421, 31);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(82, 34);
			this.button1.TabIndex = 3;
			this.button1.Text = "開始查詢";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cOB19DataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.assetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.assetBindingSource1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.BindingSource bindingSource1;
		private COB19DataSet cOB19DataSet;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.BindingSource assetBindingSource;
		private COB19DataSetTableAdapters.AssetTableAdapter assetTableAdapter;
		private System.Windows.Forms.BindingSource assetBindingSource1;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn extIdentifierDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn barCodeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn assetIdentifierDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
	}
}

