namespace ShipClassConfiguratorUiV2.UI
{
    partial class BlockLimits
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chk_NoFlyDisable = new System.Windows.Forms.CheckBox();
            this.blockLimitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaxCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBlockLimitName = new System.Windows.Forms.TextBox();
            this.lstBlockLimits = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSelectDefinition = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCountWeight = new System.Windows.Forms.TextBox();
            this.blockTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lstBlockTypes = new System.Windows.Forms.ListBox();
            this.btnCopyBlockLimit = new System.Windows.Forms.Button();
            this.btnPasteLimit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blockLimitBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blockTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lstBlockLimits);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 257);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Limits";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPasteLimit);
            this.groupBox2.Controls.Add(this.btnCopyBlockLimit);
            this.groupBox2.Controls.Add(this.chk_NoFlyDisable);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtMaxCount);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtBlockLimitName);
            this.groupBox2.Location = new System.Drawing.Point(188, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 120);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
            // 
            // chk_NoFlyDisable
            // 
            this.chk_NoFlyDisable.AutoSize = true;
            this.chk_NoFlyDisable.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.blockLimitBindingSource, "TurnedOffByNoFlyZone", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chk_NoFlyDisable.Location = new System.Drawing.Point(9, 65);
            this.chk_NoFlyDisable.Name = "chk_NoFlyDisable";
            this.chk_NoFlyDisable.Size = new System.Drawing.Size(153, 17);
            this.chk_NoFlyDisable.TabIndex = 4;
            this.chk_NoFlyDisable.Text = "Turned Off By No Fly Zone";
            this.chk_NoFlyDisable.UseVisualStyleBackColor = true;
            // 
            // blockLimitBindingSource
            // 
            this.blockLimitBindingSource.DataSource = typeof(ShipConfigurator_Definitions.BlockLimit);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Max Count:";
            // 
            // txtMaxCount
            // 
            this.txtMaxCount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.blockLimitBindingSource, "MaxCount", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtMaxCount.Location = new System.Drawing.Point(73, 39);
            this.txtMaxCount.Name = "txtMaxCount";
            this.txtMaxCount.Size = new System.Drawing.Size(141, 20);
            this.txtMaxCount.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // txtBlockLimitName
            // 
            this.txtBlockLimitName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.blockLimitBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtBlockLimitName.Location = new System.Drawing.Point(73, 13);
            this.txtBlockLimitName.Name = "txtBlockLimitName";
            this.txtBlockLimitName.Size = new System.Drawing.Size(141, 20);
            this.txtBlockLimitName.TabIndex = 1;
            // 
            // lstBlockLimits
            // 
            this.lstBlockLimits.DataSource = this.blockLimitBindingSource;
            this.lstBlockLimits.DisplayMember = "Name";
            this.lstBlockLimits.FormattingEnabled = true;
            this.lstBlockLimits.Location = new System.Drawing.Point(6, 19);
            this.lstBlockLimits.Name = "lstBlockLimits";
            this.lstBlockLimits.Size = new System.Drawing.Size(176, 225);
            this.lstBlockLimits.TabIndex = 0;
            this.lstBlockLimits.SelectedIndexChanged += new System.EventHandler(this.lstBlockLimits_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.lstBlockTypes);
            this.groupBox3.Location = new System.Drawing.Point(432, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(438, 257);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Block Types Per Limit";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSelectDefinition);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtCountWeight);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Location = new System.Drawing.Point(169, 71);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(262, 120);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Details";
            // 
            // btnSelectDefinition
            // 
            this.btnSelectDefinition.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectDefinition.Location = new System.Drawing.Point(87, 62);
            this.btnSelectDefinition.Name = "btnSelectDefinition";
            this.btnSelectDefinition.Size = new System.Drawing.Size(115, 23);
            this.btnSelectDefinition.TabIndex = 7;
            this.btnSelectDefinition.Text = "Select from Definitions";
            this.btnSelectDefinition.UseVisualStyleBackColor = true;
            this.btnSelectDefinition.Click += new System.EventHandler(this.btnSelectDefinition_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Count Weight:";
            // 
            // txtCountWeight
            // 
            this.txtCountWeight.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.blockTypeBindingSource, "CountWeight", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtCountWeight.Location = new System.Drawing.Point(87, 88);
            this.txtCountWeight.Name = "txtCountWeight";
            this.txtCountWeight.Size = new System.Drawing.Size(68, 20);
            this.txtCountWeight.TabIndex = 5;
            // 
            // blockTypeBindingSource
            // 
            this.blockTypeBindingSource.DataSource = typeof(ShipConfigurator_Definitions.BlockType);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "SubTypeId:";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.blockTypeBindingSource, "SubtypeId", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox1.Location = new System.Drawing.Point(87, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "TypeId:";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.blockTypeBindingSource, "TypeId", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox2.Location = new System.Drawing.Point(87, 13);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(169, 20);
            this.textBox2.TabIndex = 1;
            // 
            // lstBlockTypes
            // 
            this.lstBlockTypes.DataSource = this.blockTypeBindingSource;
            this.lstBlockTypes.DisplayMember = "CombinedName";
            this.lstBlockTypes.FormattingEnabled = true;
            this.lstBlockTypes.HorizontalScrollbar = true;
            this.lstBlockTypes.Location = new System.Drawing.Point(6, 19);
            this.lstBlockTypes.Name = "lstBlockTypes";
            this.lstBlockTypes.Size = new System.Drawing.Size(157, 225);
            this.lstBlockTypes.TabIndex = 0;
            // 
            // btnCopyBlockLimit
            // 
            this.btnCopyBlockLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopyBlockLimit.Location = new System.Drawing.Point(118, 88);
            this.btnCopyBlockLimit.Name = "btnCopyBlockLimit";
            this.btnCopyBlockLimit.Size = new System.Drawing.Size(44, 22);
            this.btnCopyBlockLimit.TabIndex = 4;
            this.btnCopyBlockLimit.Text = "Copy";
            this.btnCopyBlockLimit.UseVisualStyleBackColor = true;
            this.btnCopyBlockLimit.Click += new System.EventHandler(this.btnCopyBlockLimit_Click);
            // 
            // btnPasteLimit
            // 
            this.btnPasteLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasteLimit.Location = new System.Drawing.Point(170, 88);
            this.btnPasteLimit.Name = "btnPasteLimit";
            this.btnPasteLimit.Size = new System.Drawing.Size(44, 22);
            this.btnPasteLimit.TabIndex = 5;
            this.btnPasteLimit.Text = "Paste";
            this.btnPasteLimit.UseVisualStyleBackColor = true;
            this.btnPasteLimit.Click += new System.EventHandler(this.btnPasteLimit_Click);
            // 
            // BlockLimits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 279);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "BlockLimits";
            this.Text = "Block Limits";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blockLimitBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blockTypeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstBlockLimits;
        private System.Windows.Forms.BindingSource blockLimitBindingSource;
        private System.Windows.Forms.TextBox txtMaxCount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBlockLimitName;
        private System.Windows.Forms.CheckBox chk_NoFlyDisable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lstBlockTypes;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCountWeight;
        private System.Windows.Forms.BindingSource blockTypeBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnSelectDefinition;
        private System.Windows.Forms.Button btnPasteLimit;
        private System.Windows.Forms.Button btnCopyBlockLimit;
    }
}