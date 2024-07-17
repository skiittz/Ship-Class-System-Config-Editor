namespace ShipClassConfiguratorUiV2.UI
{
    partial class BlockDefinitionSelector
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lst_BlockDefinitions = new System.Windows.Forms.ListBox();
            this.cubeBlockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilterBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cubeBlockBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.txtFilterBox);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.lst_BlockDefinitions);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(6, 397);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(172, 397);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lst_BlockDefinitions
            // 
            this.lst_BlockDefinitions.DataSource = this.cubeBlockBindingSource;
            this.lst_BlockDefinitions.DisplayMember = "DisplayName";
            this.lst_BlockDefinitions.FormattingEnabled = true;
            this.lst_BlockDefinitions.HorizontalScrollbar = true;
            this.lst_BlockDefinitions.Location = new System.Drawing.Point(6, 80);
            this.lst_BlockDefinitions.Name = "lst_BlockDefinitions";
            this.lst_BlockDefinitions.Size = new System.Drawing.Size(241, 303);
            this.lst_BlockDefinitions.Sorted = true;
            this.lst_BlockDefinitions.TabIndex = 1;
            // 
            // cubeBlockBindingSource
            // 
            this.cubeBlockBindingSource.DataSource = typeof(ShipConfigurator_Definitions.CubeBlock);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add block definitions by copying the .sbc file into the Definitions folder";
            // 
            // txtFilterBox
            // 
            this.txtFilterBox.Location = new System.Drawing.Point(6, 54);
            this.txtFilterBox.Name = "txtFilterBox";
            this.txtFilterBox.Size = new System.Drawing.Size(239, 20);
            this.txtFilterBox.TabIndex = 3;
            this.txtFilterBox.TextChanged += new System.EventHandler(this.txtFilterBox_TextChanged);
            // 
            // BlockDefinitionSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "BlockDefinitionSelector";
            this.Text = "Block Definition Selector";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cubeBlockBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lst_BlockDefinitions;
        private System.Windows.Forms.BindingSource cubeBlockBindingSource;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtFilterBox;
    }
}