namespace KnittingDiary2
{
    partial class KnittingDiary
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtTyönnimi = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtKenelle = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtMateriaali = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtKuvaus = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtEtsi = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnTallenna = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnPeruuta = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnMuokkaa = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnUusi = new MaterialSkin.Controls.MaterialFlatButton();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.työnNimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kenelleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materiaaliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kuvausDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData = new KnittingDiary2.AppData();
            this.appDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new KnittingDiary2.AppDataTableAdapters.TableTableAdapter();
            this.btnEtsi = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(41, 94);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(76, 18);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Työn nimi:";
            // 
            // txtTyönnimi
            // 
            this.txtTyönnimi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Työn nimi", true));
            this.txtTyönnimi.Depth = 0;
            this.txtTyönnimi.Hint = "";
            this.txtTyönnimi.Location = new System.Drawing.Point(155, 94);
            this.txtTyönnimi.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTyönnimi.Name = "txtTyönnimi";
            this.txtTyönnimi.PasswordChar = '\0';
            this.txtTyönnimi.SelectedText = "";
            this.txtTyönnimi.SelectionLength = 0;
            this.txtTyönnimi.SelectionStart = 0;
            this.txtTyönnimi.Size = new System.Drawing.Size(420, 23);
            this.txtTyönnimi.TabIndex = 0;
            this.txtTyönnimi.UseSystemPasswordChar = false;
            // 
            // txtKenelle
            // 
            this.txtKenelle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Kenelle", true));
            this.txtKenelle.Depth = 0;
            this.txtKenelle.Hint = "";
            this.txtKenelle.Location = new System.Drawing.Point(155, 123);
            this.txtKenelle.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtKenelle.Name = "txtKenelle";
            this.txtKenelle.PasswordChar = '\0';
            this.txtKenelle.SelectedText = "";
            this.txtKenelle.SelectionLength = 0;
            this.txtKenelle.SelectionStart = 0;
            this.txtKenelle.Size = new System.Drawing.Size(420, 23);
            this.txtKenelle.TabIndex = 1;
            this.txtKenelle.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(41, 123);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(60, 18);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "Kenelle:";
            // 
            // txtMateriaali
            // 
            this.txtMateriaali.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Materiaali", true));
            this.txtMateriaali.Depth = 0;
            this.txtMateriaali.Hint = "";
            this.txtMateriaali.Location = new System.Drawing.Point(155, 153);
            this.txtMateriaali.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMateriaali.Name = "txtMateriaali";
            this.txtMateriaali.PasswordChar = '\0';
            this.txtMateriaali.SelectedText = "";
            this.txtMateriaali.SelectionLength = 0;
            this.txtMateriaali.SelectionStart = 0;
            this.txtMateriaali.Size = new System.Drawing.Size(420, 23);
            this.txtMateriaali.TabIndex = 2;
            this.txtMateriaali.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(41, 153);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(75, 18);
            this.materialLabel3.TabIndex = 0;
            this.materialLabel3.Text = "Materiaali:";
            // 
            // txtKuvaus
            // 
            this.txtKuvaus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Kuvaus", true));
            this.txtKuvaus.Depth = 0;
            this.txtKuvaus.Hint = "";
            this.txtKuvaus.Location = new System.Drawing.Point(155, 184);
            this.txtKuvaus.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtKuvaus.Name = "txtKuvaus";
            this.txtKuvaus.PasswordChar = '\0';
            this.txtKuvaus.SelectedText = "";
            this.txtKuvaus.SelectionLength = 0;
            this.txtKuvaus.SelectionStart = 0;
            this.txtKuvaus.Size = new System.Drawing.Size(420, 23);
            this.txtKuvaus.TabIndex = 3;
            this.txtKuvaus.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(41, 184);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(61, 18);
            this.materialLabel4.TabIndex = 0;
            this.materialLabel4.Text = "Kuvaus:";
            // 
            // txtEtsi
            // 
            this.txtEtsi.Depth = 0;
            this.txtEtsi.Hint = "";
            this.txtEtsi.Location = new System.Drawing.Point(155, 218);
            this.txtEtsi.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEtsi.Name = "txtEtsi";
            this.txtEtsi.PasswordChar = '\0';
            this.txtEtsi.SelectedText = "";
            this.txtEtsi.SelectionLength = 0;
            this.txtEtsi.SelectionStart = 0;
            this.txtEtsi.Size = new System.Drawing.Size(517, 23);
            this.txtEtsi.TabIndex = 4;
            this.txtEtsi.UseSystemPasswordChar = false;
            this.txtEtsi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEtsi_KeyDown);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(41, 218);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(37, 18);
            this.materialLabel5.TabIndex = 0;
            this.materialLabel5.Text = "Etsi:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.työnNimiDataGridViewTextBoxColumn,
            this.kenelleDataGridViewTextBoxColumn,
            this.materiaaliDataGridViewTextBoxColumn,
            this.kuvausDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(45, 263);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(769, 204);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView1_KeyPress);
            // 
            // btnTallenna
            // 
            this.btnTallenna.AutoSize = true;
            this.btnTallenna.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTallenna.Depth = 0;
            this.btnTallenna.Location = new System.Drawing.Point(749, 476);
            this.btnTallenna.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTallenna.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTallenna.Name = "btnTallenna";
            this.btnTallenna.Primary = false;
            this.btnTallenna.Size = new System.Drawing.Size(81, 36);
            this.btnTallenna.TabIndex = 8;
            this.btnTallenna.Text = "Tallenna";
            this.btnTallenna.UseVisualStyleBackColor = true;
            this.btnTallenna.Click += new System.EventHandler(this.btnTallenna_Click);
            // 
            // btnPeruuta
            // 
            this.btnPeruuta.AutoSize = true;
            this.btnPeruuta.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPeruuta.Depth = 0;
            this.btnPeruuta.Location = new System.Drawing.Point(669, 476);
            this.btnPeruuta.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPeruuta.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPeruuta.Name = "btnPeruuta";
            this.btnPeruuta.Primary = false;
            this.btnPeruuta.Size = new System.Drawing.Size(72, 36);
            this.btnPeruuta.TabIndex = 7;
            this.btnPeruuta.Text = "Peruuta";
            this.btnPeruuta.UseVisualStyleBackColor = true;
            this.btnPeruuta.Click += new System.EventHandler(this.btnPeruuta_Click);
            // 
            // btnMuokkaa
            // 
            this.btnMuokkaa.AutoSize = true;
            this.btnMuokkaa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMuokkaa.Depth = 0;
            this.btnMuokkaa.Location = new System.Drawing.Point(583, 476);
            this.btnMuokkaa.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnMuokkaa.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMuokkaa.Name = "btnMuokkaa";
            this.btnMuokkaa.Primary = false;
            this.btnMuokkaa.Size = new System.Drawing.Size(78, 36);
            this.btnMuokkaa.TabIndex = 6;
            this.btnMuokkaa.Text = "Muokkaa";
            this.btnMuokkaa.UseVisualStyleBackColor = true;
            this.btnMuokkaa.Click += new System.EventHandler(this.btnMuokkaa_Click);
            // 
            // btnUusi
            // 
            this.btnUusi.AutoSize = true;
            this.btnUusi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUusi.Depth = 0;
            this.btnUusi.Location = new System.Drawing.Point(533, 476);
            this.btnUusi.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUusi.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUusi.Name = "btnUusi";
            this.btnUusi.Primary = false;
            this.btnUusi.Size = new System.Drawing.Size(42, 36);
            this.btnUusi.TabIndex = 5;
            this.btnUusi.Text = "Uusi";
            this.btnUusi.UseVisualStyleBackColor = true;
            this.btnUusi.Click += new System.EventHandler(this.btnUusi_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // työnNimiDataGridViewTextBoxColumn
            // 
            this.työnNimiDataGridViewTextBoxColumn.DataPropertyName = "Työn nimi";
            this.työnNimiDataGridViewTextBoxColumn.HeaderText = "Työn nimi";
            this.työnNimiDataGridViewTextBoxColumn.Name = "työnNimiDataGridViewTextBoxColumn";
            this.työnNimiDataGridViewTextBoxColumn.Width = 150;
            // 
            // kenelleDataGridViewTextBoxColumn
            // 
            this.kenelleDataGridViewTextBoxColumn.DataPropertyName = "Kenelle";
            this.kenelleDataGridViewTextBoxColumn.HeaderText = "Kenelle";
            this.kenelleDataGridViewTextBoxColumn.Name = "kenelleDataGridViewTextBoxColumn";
            this.kenelleDataGridViewTextBoxColumn.Width = 150;
            // 
            // materiaaliDataGridViewTextBoxColumn
            // 
            this.materiaaliDataGridViewTextBoxColumn.DataPropertyName = "Materiaali";
            this.materiaaliDataGridViewTextBoxColumn.HeaderText = "Materiaali";
            this.materiaaliDataGridViewTextBoxColumn.Name = "materiaaliDataGridViewTextBoxColumn";
            this.materiaaliDataGridViewTextBoxColumn.Width = 150;
            // 
            // kuvausDataGridViewTextBoxColumn
            // 
            this.kuvausDataGridViewTextBoxColumn.DataPropertyName = "Kuvaus";
            this.kuvausDataGridViewTextBoxColumn.HeaderText = "Kuvaus";
            this.kuvausDataGridViewTextBoxColumn.Name = "kuvausDataGridViewTextBoxColumn";
            this.kuvausDataGridViewTextBoxColumn.Width = 150;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.appData;
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appDataBindingSource
            // 
            this.appDataBindingSource.DataSource = this.appData;
            this.appDataBindingSource.Position = 0;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // btnEtsi
            // 
            this.btnEtsi.AutoSize = true;
            this.btnEtsi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEtsi.Depth = 0;
            this.btnEtsi.Location = new System.Drawing.Point(679, 218);
            this.btnEtsi.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEtsi.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEtsi.Name = "btnEtsi";
            this.btnEtsi.Primary = false;
            this.btnEtsi.Size = new System.Drawing.Size(40, 36);
            this.btnEtsi.TabIndex = 9;
            this.btnEtsi.Text = "Etsi";
            this.btnEtsi.UseVisualStyleBackColor = true;
            this.btnEtsi.Click += new System.EventHandler(this.btnEtsi_Click);
            // 
            // KnittingDiary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 517);
            this.Controls.Add(this.btnEtsi);
            this.Controls.Add(this.btnUusi);
            this.Controls.Add(this.btnMuokkaa);
            this.Controls.Add(this.btnPeruuta);
            this.Controls.Add(this.btnTallenna);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtEtsi);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.txtKuvaus);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.txtMateriaali);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.txtKenelle);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtTyönnimi);
            this.Controls.Add(this.materialLabel1);
            this.Name = "KnittingDiary";
            this.Text = "KnittingDiary";
            this.Load += new System.EventHandler(this.KnittingDiary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTyönnimi;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtKenelle;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMateriaali;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtKuvaus;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEtsi;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialFlatButton btnTallenna;
        private MaterialSkin.Controls.MaterialFlatButton btnPeruuta;
        private MaterialSkin.Controls.MaterialFlatButton btnMuokkaa;
        private MaterialSkin.Controls.MaterialFlatButton btnUusi;
        private AppData appData;
        private System.Windows.Forms.BindingSource appDataBindingSource;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private AppDataTableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn työnNimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kenelleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materiaaliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kuvausDataGridViewTextBoxColumn;
        private MaterialSkin.Controls.MaterialFlatButton btnEtsi;
    }
}

