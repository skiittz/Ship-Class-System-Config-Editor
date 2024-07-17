namespace ShipClassConfiguratorUiV2.UI
{
    partial class NoFlyZones
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
            this.lstNoFlyZones = new System.Windows.Forms.ListBox();
            this.zonesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddNoFlyZone = new System.Windows.Forms.Button();
            this.btnRemoveNoFlyZone = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_XCoord = new System.Windows.Forms.TextBox();
            this.txt_YCoord = new System.Windows.Forms.TextBox();
            this.txt_ZCoord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Radius = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lst_AllowedClasses = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gridClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_AllowedClasses = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zonesBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridClassBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnAddNoFlyZone);
            this.groupBox1.Controls.Add(this.btnRemoveNoFlyZone);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 296);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lstNoFlyZones
            // 
            this.lstNoFlyZones.DataSource = this.zonesBindingSource;
            this.lstNoFlyZones.DisplayMember = "Id";
            this.lstNoFlyZones.FormattingEnabled = true;
            this.lstNoFlyZones.Location = new System.Drawing.Point(12, 12);
            this.lstNoFlyZones.Name = "lstNoFlyZones";
            this.lstNoFlyZones.Size = new System.Drawing.Size(120, 251);
            this.lstNoFlyZones.TabIndex = 1;
            this.lstNoFlyZones.SelectedIndexChanged += new System.EventHandler(this.lstNoFlyZones_SelectedIndexChanged);
            // 
            // zonesBindingSource
            // 
            this.zonesBindingSource.DataSource = typeof(ShipConfigurator_Definitions.Zones);
            // 
            // btnAddNoFlyZone
            // 
            this.btnAddNoFlyZone.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNoFlyZone.Location = new System.Drawing.Point(42, 266);
            this.btnAddNoFlyZone.Name = "btnAddNoFlyZone";
            this.btnAddNoFlyZone.Size = new System.Drawing.Size(27, 20);
            this.btnAddNoFlyZone.TabIndex = 2;
            this.btnAddNoFlyZone.Text = "+";
            this.btnAddNoFlyZone.UseVisualStyleBackColor = true;
            this.btnAddNoFlyZone.Click += new System.EventHandler(this.btnAddNoFlyZone_Click);
            // 
            // btnRemoveNoFlyZone
            // 
            this.btnRemoveNoFlyZone.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveNoFlyZone.Location = new System.Drawing.Point(9, 266);
            this.btnRemoveNoFlyZone.Name = "btnRemoveNoFlyZone";
            this.btnRemoveNoFlyZone.Size = new System.Drawing.Size(27, 20);
            this.btnRemoveNoFlyZone.TabIndex = 3;
            this.btnRemoveNoFlyZone.Text = "-";
            this.btnRemoveNoFlyZone.UseVisualStyleBackColor = true;
            this.btnRemoveNoFlyZone.Click += new System.EventHandler(this.btnRemoveNoFlyZone_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_Radius);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_XCoord);
            this.groupBox2.Controls.Add(this.txt_ZCoord);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_YCoord);
            this.groupBox2.Location = new System.Drawing.Point(135, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(186, 97);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Coordinates";
            // 
            // txt_XCoord
            // 
            this.txt_XCoord.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zonesBindingSource, "Z", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_XCoord.Location = new System.Drawing.Point(29, 69);
            this.txt_XCoord.Name = "txt_XCoord";
            this.txt_XCoord.Size = new System.Drawing.Size(48, 20);
            this.txt_XCoord.TabIndex = 3;
            // 
            // txt_YCoord
            // 
            this.txt_YCoord.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zonesBindingSource, "X", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_YCoord.Location = new System.Drawing.Point(29, 19);
            this.txt_YCoord.Name = "txt_YCoord";
            this.txt_YCoord.Size = new System.Drawing.Size(48, 20);
            this.txt_YCoord.TabIndex = 4;
            // 
            // txt_ZCoord
            // 
            this.txt_ZCoord.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zonesBindingSource, "Y", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_ZCoord.Location = new System.Drawing.Point(29, 43);
            this.txt_ZCoord.Name = "txt_ZCoord";
            this.txt_ZCoord.Size = new System.Drawing.Size(48, 20);
            this.txt_ZCoord.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Z:";
            // 
            // txt_Radius
            // 
            this.txt_Radius.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zonesBindingSource, "Radius", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_Radius.Location = new System.Drawing.Point(132, 42);
            this.txt_Radius.Name = "txt_Radius";
            this.txt_Radius.Size = new System.Drawing.Size(48, 20);
            this.txt_Radius.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Radius:";
            // 
            // lst_AllowedClasses
            // 
            this.lst_AllowedClasses.DataSource = this.gridClassBindingSource;
            this.lst_AllowedClasses.DisplayMember = "Name";
            this.lst_AllowedClasses.FormattingEnabled = true;
            this.lst_AllowedClasses.Location = new System.Drawing.Point(9, 45);
            this.lst_AllowedClasses.Name = "lst_AllowedClasses";
            this.lst_AllowedClasses.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lst_AllowedClasses.Size = new System.Drawing.Size(171, 108);
            this.lst_AllowedClasses.TabIndex = 2;
            this.lst_AllowedClasses.SelectedIndexChanged += new System.EventHandler(this.lst_AllowedClasses_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_AllowedClasses);
            this.groupBox3.Controls.Add(this.lst_AllowedClasses);
            this.groupBox3.Location = new System.Drawing.Point(135, 122);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(188, 164);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Allowed Classes";
            // 
            // gridClassBindingSource
            // 
            this.gridClassBindingSource.DataSource = typeof(ShipConfigurator_Definitions.GridClass);
            // 
            // lbl_AllowedClasses
            // 
            this.lbl_AllowedClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AllowedClasses.Location = new System.Drawing.Point(7, 19);
            this.lbl_AllowedClasses.Name = "lbl_AllowedClasses";
            this.lbl_AllowedClasses.Size = new System.Drawing.Size(173, 23);
            this.lbl_AllowedClasses.TabIndex = 3;
            // 
            // NoFlyZones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 301);
            this.Controls.Add(this.lstNoFlyZones);
            this.Controls.Add(this.groupBox1);
            this.Name = "NoFlyZones";
            this.Text = "No Fly Zones";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.zonesBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridClassBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstNoFlyZones;
        private System.Windows.Forms.BindingSource zonesBindingSource;
        private System.Windows.Forms.Button btnAddNoFlyZone;
        private System.Windows.Forms.Button btnRemoveNoFlyZone;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_YCoord;
        private System.Windows.Forms.TextBox txt_XCoord;
        private System.Windows.Forms.TextBox txt_ZCoord;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lst_AllowedClasses;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Radius;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource gridClassBindingSource;
        private System.Windows.Forms.Label lbl_AllowedClasses;
    }
}