namespace Project1
{
    partial class Form1
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
            this.gbxCategories = new System.Windows.Forms.GroupBox();
            this.lblCategories = new System.Windows.Forms.Label();
            this.cbxCategories = new System.Windows.Forms.ComboBox();
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gvProducts = new System.Windows.Forms.DataGridView();
            this.gbxCategories.SuspendLayout();
            this.gbxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxCategories
            // 
            this.gbxCategories.Controls.Add(this.lblCategories);
            this.gbxCategories.Controls.Add(this.cbxCategories);
            this.gbxCategories.Location = new System.Drawing.Point(12, 12);
            this.gbxCategories.Name = "gbxCategories";
            this.gbxCategories.Size = new System.Drawing.Size(776, 71);
            this.gbxCategories.TabIndex = 0;
            this.gbxCategories.TabStop = false;
            this.gbxCategories.Text = "List with Category Name";
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Location = new System.Drawing.Point(25, 30);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(76, 13);
            this.lblCategories.TabIndex = 1;
            this.lblCategories.Text = "CATEGORIES";
            // 
            // cbxCategories
            // 
            this.cbxCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategories.FormattingEnabled = true;
            this.cbxCategories.Location = new System.Drawing.Point(110, 27);
            this.cbxCategories.Name = "cbxCategories";
            this.cbxCategories.Size = new System.Drawing.Size(214, 21);
            this.cbxCategories.TabIndex = 0;
            this.cbxCategories.SelectedIndexChanged += new System.EventHandler(this.cbxCategories_SelectedIndexChanged);
            // 
            // gbxSearch
            // 
            this.gbxSearch.Controls.Add(this.tbxSearch);
            this.gbxSearch.Controls.Add(this.label2);
            this.gbxSearch.Location = new System.Drawing.Point(12, 89);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Size = new System.Drawing.Size(776, 79);
            this.gbxSearch.TabIndex = 1;
            this.gbxSearch.TabStop = false;
            this.gbxSearch.Text = "Search with Product Name";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(110, 32);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(214, 20);
            this.tbxSearch.TabIndex = 1;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "SEARCH";
            // 
            // gvProducts
            // 
            this.gvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvProducts.Location = new System.Drawing.Point(12, 197);
            this.gvProducts.Name = "gvProducts";
            this.gvProducts.Size = new System.Drawing.Size(776, 168);
            this.gvProducts.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gvProducts);
            this.Controls.Add(this.gbxSearch);
            this.Controls.Add(this.gbxCategories);
            this.Name = "Form1";
            this.Text = "PRODUCTS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxCategories.ResumeLayout(false);
            this.gbxCategories.PerformLayout();
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCategories;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.ComboBox cbxCategories;
        private System.Windows.Forms.GroupBox gbxSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gvProducts;
    }
}

