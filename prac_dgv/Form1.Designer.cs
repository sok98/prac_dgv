namespace prac_dgv
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvChild = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblParent = new System.Windows.Forms.Label();
            this.btnPAdd = new System.Windows.Forms.Button();
            this.btnPMerge = new System.Windows.Forms.Button();
            this.btnPDel = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCDel = new System.Windows.Forms.Button();
            this.btnCSep = new System.Windows.Forms.Button();
            this.btnCAdd = new System.Windows.Forms.Button();
            this.btnCDown = new System.Windows.Forms.Button();
            this.lblChild = new System.Windows.Forms.Label();
            this.btnCUp = new System.Windows.Forms.Button();
            this.dgvParent = new System.Windows.Forms.DataGridView();
            this.PNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PCheckbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PCnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChild)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParent)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dgvChild, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvParent, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1011, 517);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvChild
            // 
            this.dgvChild.AllowUserToAddRows = false;
            this.dgvChild.AllowUserToDeleteRows = false;
            this.dgvChild.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChild.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChild.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvChild.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChild.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChild.Location = new System.Drawing.Point(505, 30);
            this.dgvChild.Margin = new System.Windows.Forms.Padding(0);
            this.dgvChild.Name = "dgvChild";
            this.dgvChild.ReadOnly = true;
            this.dgvChild.RowHeadersVisible = false;
            this.dgvChild.RowTemplate.Height = 27;
            this.dgvChild.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChild.Size = new System.Drawing.Size(506, 487);
            this.dgvChild.TabIndex = 3;
            this.dgvChild.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChild_Select);
            this.dgvChild.CurrentCellChanged += new System.EventHandler(this.dgvChild_Select);
            this.dgvChild.SelectionChanged += new System.EventHandler(this.dgvChild_Select);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Width = 54;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewCheckBoxColumn1.HeaderText = "선택";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "이름";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.lblParent, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnPAdd, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnPMerge, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnPDel, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(505, 30);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblParent
            // 
            this.lblParent.AutoSize = true;
            this.lblParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblParent.Location = new System.Drawing.Point(0, 0);
            this.lblParent.Margin = new System.Windows.Forms.Padding(0);
            this.lblParent.Name = "lblParent";
            this.lblParent.Size = new System.Drawing.Size(358, 30);
            this.lblParent.TabIndex = 0;
            this.lblParent.Text = "부모 리스트 (0)";
            this.lblParent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnPAdd
            // 
            this.btnPAdd.AutoSize = true;
            this.btnPAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPAdd.Location = new System.Drawing.Point(359, 1);
            this.btnPAdd.Margin = new System.Windows.Forms.Padding(1);
            this.btnPAdd.Name = "btnPAdd";
            this.btnPAdd.Size = new System.Drawing.Size(47, 28);
            this.btnPAdd.TabIndex = 1;
            this.btnPAdd.Text = "추가";
            this.btnPAdd.UseVisualStyleBackColor = true;
            this.btnPAdd.Click += new System.EventHandler(this.btnPAdd_Click);
            // 
            // btnPMerge
            // 
            this.btnPMerge.AutoSize = true;
            this.btnPMerge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPMerge.Location = new System.Drawing.Point(408, 1);
            this.btnPMerge.Margin = new System.Windows.Forms.Padding(1);
            this.btnPMerge.Name = "btnPMerge";
            this.btnPMerge.Size = new System.Drawing.Size(47, 28);
            this.btnPMerge.TabIndex = 2;
            this.btnPMerge.Text = "병합";
            this.btnPMerge.UseVisualStyleBackColor = true;
            // 
            // btnPDel
            // 
            this.btnPDel.AutoSize = true;
            this.btnPDel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPDel.Location = new System.Drawing.Point(457, 1);
            this.btnPDel.Margin = new System.Windows.Forms.Padding(1);
            this.btnPDel.Name = "btnPDel";
            this.btnPDel.Size = new System.Drawing.Size(47, 28);
            this.btnPDel.TabIndex = 3;
            this.btnPDel.Text = "삭제";
            this.btnPDel.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.btnCDel, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnCSep, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnCAdd, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnCDown, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblChild, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnCUp, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(505, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(506, 30);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // btnCDel
            // 
            this.btnCDel.AutoSize = true;
            this.btnCDel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCDel.Location = new System.Drawing.Point(458, 1);
            this.btnCDel.Margin = new System.Windows.Forms.Padding(1);
            this.btnCDel.Name = "btnCDel";
            this.btnCDel.Size = new System.Drawing.Size(47, 28);
            this.btnCDel.TabIndex = 5;
            this.btnCDel.Text = "삭제";
            this.btnCDel.UseVisualStyleBackColor = true;
            // 
            // btnCSep
            // 
            this.btnCSep.AutoSize = true;
            this.btnCSep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCSep.Location = new System.Drawing.Point(409, 1);
            this.btnCSep.Margin = new System.Windows.Forms.Padding(1);
            this.btnCSep.Name = "btnCSep";
            this.btnCSep.Size = new System.Drawing.Size(47, 28);
            this.btnCSep.TabIndex = 4;
            this.btnCSep.Text = "분리";
            this.btnCSep.UseVisualStyleBackColor = true;
            // 
            // btnCAdd
            // 
            this.btnCAdd.AutoSize = true;
            this.btnCAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCAdd.Location = new System.Drawing.Point(360, 1);
            this.btnCAdd.Margin = new System.Windows.Forms.Padding(1);
            this.btnCAdd.Name = "btnCAdd";
            this.btnCAdd.Size = new System.Drawing.Size(47, 28);
            this.btnCAdd.TabIndex = 3;
            this.btnCAdd.Text = "추가";
            this.btnCAdd.UseVisualStyleBackColor = true;
            this.btnCAdd.Click += new System.EventHandler(this.btnCAdd_Click);
            // 
            // btnCDown
            // 
            this.btnCDown.AutoSize = true;
            this.btnCDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCDown.Location = new System.Drawing.Point(327, 1);
            this.btnCDown.Margin = new System.Windows.Forms.Padding(1, 1, 3, 1);
            this.btnCDown.Name = "btnCDown";
            this.btnCDown.Size = new System.Drawing.Size(29, 28);
            this.btnCDown.TabIndex = 2;
            this.btnCDown.Text = "▼";
            this.btnCDown.UseVisualStyleBackColor = true;
            // 
            // lblChild
            // 
            this.lblChild.AutoSize = true;
            this.lblChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblChild.Location = new System.Drawing.Point(3, 0);
            this.lblChild.Name = "lblChild";
            this.lblChild.Size = new System.Drawing.Size(289, 30);
            this.lblChild.TabIndex = 0;
            this.lblChild.Text = "자식 리스트 (0)";
            this.lblChild.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCUp
            // 
            this.btnCUp.AutoSize = true;
            this.btnCUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCUp.Location = new System.Drawing.Point(296, 1);
            this.btnCUp.Margin = new System.Windows.Forms.Padding(1);
            this.btnCUp.Name = "btnCUp";
            this.btnCUp.Size = new System.Drawing.Size(29, 28);
            this.btnCUp.TabIndex = 1;
            this.btnCUp.Text = "▲";
            this.btnCUp.UseVisualStyleBackColor = true;
            // 
            // dgvParent
            // 
            this.dgvParent.AllowUserToAddRows = false;
            this.dgvParent.AllowUserToDeleteRows = false;
            this.dgvParent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvParent.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvParent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvParent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PNo,
            this.PCheckbox,
            this.PName,
            this.PCnt});
            this.dgvParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvParent.Location = new System.Drawing.Point(0, 30);
            this.dgvParent.Margin = new System.Windows.Forms.Padding(0);
            this.dgvParent.Name = "dgvParent";
            this.dgvParent.ReadOnly = true;
            this.dgvParent.RowHeadersVisible = false;
            this.dgvParent.RowTemplate.Height = 27;
            this.dgvParent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParent.Size = new System.Drawing.Size(505, 487);
            this.dgvParent.TabIndex = 2;
            this.dgvParent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParent_Select);
            this.dgvParent.CurrentCellChanged += new System.EventHandler(this.dgvParent_Select);
            this.dgvParent.SelectionChanged += new System.EventHandler(this.dgvParent_Select);
            // 
            // PNo
            // 
            this.PNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PNo.HeaderText = "No";
            this.PNo.Name = "PNo";
            this.PNo.ReadOnly = true;
            this.PNo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PNo.Width = 54;
            // 
            // PCheckbox
            // 
            this.PCheckbox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PCheckbox.HeaderText = "선택";
            this.PCheckbox.Name = "PCheckbox";
            this.PCheckbox.ReadOnly = true;
            // 
            // PName
            // 
            this.PName.HeaderText = "이름";
            this.PName.Name = "PName";
            this.PName.ReadOnly = true;
            this.PName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // PCnt
            // 
            this.PCnt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PCnt.HeaderText = "count";
            this.PCnt.Name = "PCnt";
            this.PCnt.ReadOnly = true;
            this.PCnt.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PCnt.Width = 73;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 517);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChild)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblParent;
        private System.Windows.Forms.Button btnPAdd;
        private System.Windows.Forms.Button btnPMerge;
        private System.Windows.Forms.Button btnPDel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnCDel;
        private System.Windows.Forms.Button btnCSep;
        private System.Windows.Forms.Button btnCAdd;
        private System.Windows.Forms.Button btnCDown;
        private System.Windows.Forms.Label lblChild;
        private System.Windows.Forms.Button btnCUp;
        private System.Windows.Forms.DataGridView dgvParent;
        private System.Windows.Forms.DataGridView dgvChild;
        private System.Windows.Forms.DataGridViewTextBoxColumn PNo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PCheckbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PCnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}

