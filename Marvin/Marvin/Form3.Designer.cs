namespace Marvin
{
    partial class Form3
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
            System.Windows.Forms.Label label6;
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtCusto = new System.Windows.Forms.TextBox();
            this.TxtPreVenda = new System.Windows.Forms.TextBox();
            this.lblIncluir = new System.Windows.Forms.Button();
            this.lblAlterar = new System.Windows.Forms.Button();
            this.lblExcluir = new System.Windows.Forms.Button();
            this.lblConsultar = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dB_BEBIDASDataSet = new Marvin.DB_BEBIDASDataSet();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new Marvin.DB_BEBIDASDataSetTableAdapters.TableTableAdapter();
            this.codBebidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoVendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_BEBIDASDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(279, 31);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(62, 13);
            label6.TabIndex = 16;
            label6.Text = "Quantidade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Custo";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(505, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Preço de Venda";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(24, 47);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(65, 20);
            this.txtCodigo.TabIndex = 4;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(101, 48);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(76, 20);
            this.txtTipo.TabIndex = 5;
            // 
            // txtCusto
            // 
            this.txtCusto.Location = new System.Drawing.Point(380, 50);
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.Size = new System.Drawing.Size(76, 20);
            this.txtCusto.TabIndex = 6;
            // 
            // TxtPreVenda
            // 
            this.TxtPreVenda.Location = new System.Drawing.Point(508, 50);
            this.TxtPreVenda.Name = "TxtPreVenda";
            this.TxtPreVenda.Size = new System.Drawing.Size(76, 20);
            this.TxtPreVenda.TabIndex = 7;
            // 
            // lblIncluir
            // 
            this.lblIncluir.Location = new System.Drawing.Point(65, 244);
            this.lblIncluir.Name = "lblIncluir";
            this.lblIncluir.Size = new System.Drawing.Size(75, 23);
            this.lblIncluir.TabIndex = 8;
            this.lblIncluir.Text = "Incluir";
            this.lblIncluir.UseVisualStyleBackColor = true;
            this.lblIncluir.Click += new System.EventHandler(this.lblIncluir_Click);
            // 
            // lblAlterar
            // 
            this.lblAlterar.Location = new System.Drawing.Point(155, 244);
            this.lblAlterar.Name = "lblAlterar";
            this.lblAlterar.Size = new System.Drawing.Size(75, 23);
            this.lblAlterar.TabIndex = 9;
            this.lblAlterar.Text = "Alterar";
            this.lblAlterar.UseVisualStyleBackColor = true;
            // 
            // lblExcluir
            // 
            this.lblExcluir.Location = new System.Drawing.Point(253, 244);
            this.lblExcluir.Name = "lblExcluir";
            this.lblExcluir.Size = new System.Drawing.Size(75, 23);
            this.lblExcluir.TabIndex = 10;
            this.lblExcluir.Text = "Excluir";
            this.lblExcluir.UseVisualStyleBackColor = true;
            // 
            // lblConsultar
            // 
            this.lblConsultar.Location = new System.Drawing.Point(350, 244);
            this.lblConsultar.Name = "lblConsultar";
            this.lblConsultar.Size = new System.Drawing.Size(75, 23);
            this.lblConsultar.TabIndex = 11;
            this.lblConsultar.Text = "Consultar";
            this.lblConsultar.UseVisualStyleBackColor = true;
            this.lblConsultar.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(561, 255);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(66, 23);
            this.button5.TabIndex = 12;
            this.button5.Text = "Sair";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(187, 48);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(65, 20);
            this.txtMarca.TabIndex = 13;
            // 
            // txtEstoque
            // 
            this.txtEstoque.Location = new System.Drawing.Point(275, 48);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(65, 20);
            this.txtEstoque.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Marca";
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(Marvin.Form1);
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataSource = typeof(Marvin.Program);
            // 
            // programBindingSource1
            // 
            this.programBindingSource1.DataSource = typeof(Marvin.Program);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codBebidaDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.custoDataGridViewTextBoxColumn,
            this.precoVendaDataGridViewTextBoxColumn,
            this.estoqueDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(14, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(634, 121);
            this.dataGridView1.TabIndex = 17;
            // 
            // dB_BEBIDASDataSet
            // 
            this.dB_BEBIDASDataSet.DataSetName = "DB_BEBIDASDataSet";
            this.dB_BEBIDASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.dB_BEBIDASDataSet;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // codBebidaDataGridViewTextBoxColumn
            // 
            this.codBebidaDataGridViewTextBoxColumn.DataPropertyName = "Cod_Bebida";
            this.codBebidaDataGridViewTextBoxColumn.HeaderText = "Cod_Bebida";
            this.codBebidaDataGridViewTextBoxColumn.Name = "codBebidaDataGridViewTextBoxColumn";
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            // 
            // custoDataGridViewTextBoxColumn
            // 
            this.custoDataGridViewTextBoxColumn.DataPropertyName = "Custo";
            this.custoDataGridViewTextBoxColumn.HeaderText = "Custo";
            this.custoDataGridViewTextBoxColumn.Name = "custoDataGridViewTextBoxColumn";
            // 
            // precoVendaDataGridViewTextBoxColumn
            // 
            this.precoVendaDataGridViewTextBoxColumn.DataPropertyName = "PrecoVenda";
            this.precoVendaDataGridViewTextBoxColumn.HeaderText = "PrecoVenda";
            this.precoVendaDataGridViewTextBoxColumn.Name = "precoVendaDataGridViewTextBoxColumn";
            // 
            // estoqueDataGridViewTextBoxColumn
            // 
            this.estoqueDataGridViewTextBoxColumn.DataPropertyName = "Estoque";
            this.estoqueDataGridViewTextBoxColumn.HeaderText = "Estoque";
            this.estoqueDataGridViewTextBoxColumn.Name = "estoqueDataGridViewTextBoxColumn";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 296);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEstoque);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.lblConsultar);
            this.Controls.Add(this.lblExcluir);
            this.Controls.Add(this.lblAlterar);
            this.Controls.Add(this.lblIncluir);
            this.Controls.Add(this.TxtPreVenda);
            this.Controls.Add(this.txtCusto);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_BEBIDASDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtCusto;
        private System.Windows.Forms.TextBox TxtPreVenda;
        private System.Windows.Forms.Button lblIncluir;
        private System.Windows.Forms.Button lblAlterar;
        private System.Windows.Forms.Button lblExcluir;
        private System.Windows.Forms.Button lblConsultar;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.BindingSource programBindingSource;
        private System.Windows.Forms.BindingSource programBindingSource1;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DB_BEBIDASDataSet dB_BEBIDASDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private DB_BEBIDASDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codBebidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoVendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoqueDataGridViewTextBoxColumn;
    }
}