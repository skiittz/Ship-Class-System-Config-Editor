namespace ShipClassConfiguratorUiV2.UI
{
    partial class IgnoredFactionTags
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
            this.btnRemoveFaction = new System.Windows.Forms.Button();
            this.btnAddFaction = new System.Windows.Forms.Button();
            this.txtFactionTag = new System.Windows.Forms.TextBox();
            this.lstIgnoredFactionTags = new System.Windows.Forms.ListBox();
            this.modConfigBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnApply = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modConfigBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnApply);
            this.groupBox1.Controls.Add(this.btnRemoveFaction);
            this.groupBox1.Controls.Add(this.btnAddFaction);
            this.groupBox1.Controls.Add(this.txtFactionTag);
            this.groupBox1.Controls.Add(this.lstIgnoredFactionTags);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnRemoveFaction
            // 
            this.btnRemoveFaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveFaction.Location = new System.Drawing.Point(6, 401);
            this.btnRemoveFaction.Name = "btnRemoveFaction";
            this.btnRemoveFaction.Size = new System.Drawing.Size(35, 19);
            this.btnRemoveFaction.TabIndex = 3;
            this.btnRemoveFaction.Text = "-";
            this.btnRemoveFaction.UseVisualStyleBackColor = true;
            this.btnRemoveFaction.Click += new System.EventHandler(this.btnRemoveFaction_Click);
            // 
            // btnAddFaction
            // 
            this.btnAddFaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFaction.Location = new System.Drawing.Point(159, 401);
            this.btnAddFaction.Name = "btnAddFaction";
            this.btnAddFaction.Size = new System.Drawing.Size(35, 19);
            this.btnAddFaction.TabIndex = 2;
            this.btnAddFaction.Text = "+";
            this.btnAddFaction.UseVisualStyleBackColor = true;
            this.btnAddFaction.Click += new System.EventHandler(this.btnAddFaction_Click);
            // 
            // txtFactionTag
            // 
            this.txtFactionTag.Location = new System.Drawing.Point(6, 375);
            this.txtFactionTag.Name = "txtFactionTag";
            this.txtFactionTag.Size = new System.Drawing.Size(139, 20);
            this.txtFactionTag.TabIndex = 1;
            // 
            // lstIgnoredFactionTags
            // 
            this.lstIgnoredFactionTags.CausesValidation = false;
            this.lstIgnoredFactionTags.FormattingEnabled = true;
            this.lstIgnoredFactionTags.Location = new System.Drawing.Point(6, 10);
            this.lstIgnoredFactionTags.Name = "lstIgnoredFactionTags";
            this.lstIgnoredFactionTags.Size = new System.Drawing.Size(188, 355);
            this.lstIgnoredFactionTags.TabIndex = 0;
            this.lstIgnoredFactionTags.SelectedIndexChanged += new System.EventHandler(this.lstIgnoredFactionTags_SelectedIndexChanged);
            // 
            // modConfigBindingSource
            // 
            this.modConfigBindingSource.DataSource = typeof(ShipConfigurator_Definitions.ModConfig);
            // 
            // btnApply
            // 
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.Location = new System.Drawing.Point(151, 371);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(43, 28);
            this.btnApply.TabIndex = 4;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // IgnoredFactionTags
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "IgnoredFactionTags";
            this.Text = "Ignored Faction Tags";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modConfigBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstIgnoredFactionTags;
        private System.Windows.Forms.Button btnRemoveFaction;
        private System.Windows.Forms.Button btnAddFaction;
        private System.Windows.Forms.TextBox txtFactionTag;
        private System.Windows.Forms.BindingSource modConfigBindingSource;
        private System.Windows.Forms.Button btnApply;
    }
}