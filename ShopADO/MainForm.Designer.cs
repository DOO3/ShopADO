namespace ShopADO
{
    partial class MainForm
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
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpGoods = new System.Windows.Forms.TabPage();
            this.dgvGoods = new System.Windows.Forms.DataGridView();
            this.tpCategories = new System.Windows.Forms.TabPage();
            this.dgvCategories = new System.Windows.Forms.DataGridView();
            this.tpManufacturers = new System.Windows.Forms.TabPage();
            this.dgvManufacturers = new System.Windows.Forms.DataGridView();
            this.bSave = new System.Windows.Forms.Button();
            this.tcMain.SuspendLayout();
            this.tpGoods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoods)).BeginInit();
            this.tpCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
            this.tpManufacturers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManufacturers)).BeginInit();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpGoods);
            this.tcMain.Controls.Add(this.tpCategories);
            this.tcMain.Controls.Add(this.tpManufacturers);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(475, 353);
            this.tcMain.TabIndex = 0;
            // 
            // tpGoods
            // 
            this.tpGoods.Controls.Add(this.dgvGoods);
            this.tpGoods.Location = new System.Drawing.Point(4, 22);
            this.tpGoods.Name = "tpGoods";
            this.tpGoods.Padding = new System.Windows.Forms.Padding(3);
            this.tpGoods.Size = new System.Drawing.Size(467, 327);
            this.tpGoods.TabIndex = 0;
            this.tpGoods.Text = "Goods";
            this.tpGoods.UseVisualStyleBackColor = true;
            // 
            // dgvGoods
            // 
            this.dgvGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGoods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGoods.Location = new System.Drawing.Point(3, 3);
            this.dgvGoods.Name = "dgvGoods";
            this.dgvGoods.Size = new System.Drawing.Size(461, 321);
            this.dgvGoods.TabIndex = 0;
            // 
            // tpCategories
            // 
            this.tpCategories.Controls.Add(this.dgvCategories);
            this.tpCategories.Location = new System.Drawing.Point(4, 22);
            this.tpCategories.Name = "tpCategories";
            this.tpCategories.Padding = new System.Windows.Forms.Padding(3);
            this.tpCategories.Size = new System.Drawing.Size(467, 323);
            this.tpCategories.TabIndex = 1;
            this.tpCategories.Text = "Categories";
            this.tpCategories.UseVisualStyleBackColor = true;
            // 
            // dgvCategories
            // 
            this.dgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCategories.Location = new System.Drawing.Point(3, 3);
            this.dgvCategories.Name = "dgvCategories";
            this.dgvCategories.Size = new System.Drawing.Size(461, 317);
            this.dgvCategories.TabIndex = 1;
            // 
            // tpManufacturers
            // 
            this.tpManufacturers.Controls.Add(this.dgvManufacturers);
            this.tpManufacturers.Location = new System.Drawing.Point(4, 22);
            this.tpManufacturers.Name = "tpManufacturers";
            this.tpManufacturers.Padding = new System.Windows.Forms.Padding(3);
            this.tpManufacturers.Size = new System.Drawing.Size(467, 323);
            this.tpManufacturers.TabIndex = 2;
            this.tpManufacturers.Text = "Manufacturers";
            this.tpManufacturers.UseVisualStyleBackColor = true;
            // 
            // dgvManufacturers
            // 
            this.dgvManufacturers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManufacturers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvManufacturers.Location = new System.Drawing.Point(3, 3);
            this.dgvManufacturers.Name = "dgvManufacturers";
            this.dgvManufacturers.Size = new System.Drawing.Size(461, 317);
            this.dgvManufacturers.TabIndex = 1;
            // 
            // bSave
            // 
            this.bSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bSave.Location = new System.Drawing.Point(0, 319);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(475, 34);
            this.bSave.TabIndex = 1;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 353);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.tcMain);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.tcMain.ResumeLayout(false);
            this.tpGoods.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoods)).EndInit();
            this.tpCategories.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
            this.tpManufacturers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManufacturers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpGoods;
        private System.Windows.Forms.DataGridView dgvGoods;
        private System.Windows.Forms.TabPage tpCategories;
        private System.Windows.Forms.DataGridView dgvCategories;
        private System.Windows.Forms.TabPage tpManufacturers;
        private System.Windows.Forms.DataGridView dgvManufacturers;
        private System.Windows.Forms.Button bSave;
    }
}

