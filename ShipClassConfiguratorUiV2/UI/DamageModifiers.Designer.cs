namespace ShipClassConfiguratorUiV2.UI
{
    partial class DamageModifiers
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
            this.txtBulletMod = new System.Windows.Forms.TextBox();
            this.damageModifiersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtRocketMod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtExplosionMod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEnvironmentMod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEnergyMod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKineticMod = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.damageModifiersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtKineticMod);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtEnergyMod);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtEnvironmentMod);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtExplosionMod);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtRocketMod);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBulletMod);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 175);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Damage Type Multipliers";
            // 
            // txtBulletMod
            // 
            this.txtBulletMod.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.damageModifiersBindingSource, "Bullet", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtBulletMod.Location = new System.Drawing.Point(89, 16);
            this.txtBulletMod.Name = "txtBulletMod";
            this.txtBulletMod.Size = new System.Drawing.Size(75, 20);
            this.txtBulletMod.TabIndex = 1;
            // 
            // damageModifiersBindingSource
            // 
            this.damageModifiersBindingSource.DataSource = typeof(ShipConfigurator_Definitions.DamageModifiers);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bullet:";
            // 
            // txtRocketMod
            // 
            this.txtRocketMod.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.damageModifiersBindingSource, "Rocket", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtRocketMod.Location = new System.Drawing.Point(89, 42);
            this.txtRocketMod.Name = "txtRocketMod";
            this.txtRocketMod.Size = new System.Drawing.Size(75, 20);
            this.txtRocketMod.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rocket:";
            // 
            // txtExplosionMod
            // 
            this.txtExplosionMod.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.damageModifiersBindingSource, "Explosion", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtExplosionMod.Location = new System.Drawing.Point(89, 68);
            this.txtExplosionMod.Name = "txtExplosionMod";
            this.txtExplosionMod.Size = new System.Drawing.Size(75, 20);
            this.txtExplosionMod.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Explosion:";
            // 
            // txtEnvironmentMod
            // 
            this.txtEnvironmentMod.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.damageModifiersBindingSource, "Environment", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtEnvironmentMod.Location = new System.Drawing.Point(89, 94);
            this.txtEnvironmentMod.Name = "txtEnvironmentMod";
            this.txtEnvironmentMod.Size = new System.Drawing.Size(75, 20);
            this.txtEnvironmentMod.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Environment:";
            // 
            // txtEnergyMod
            // 
            this.txtEnergyMod.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.damageModifiersBindingSource, "Energy", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtEnergyMod.Location = new System.Drawing.Point(89, 120);
            this.txtEnergyMod.Name = "txtEnergyMod";
            this.txtEnergyMod.Size = new System.Drawing.Size(75, 20);
            this.txtEnergyMod.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Energy:";
            // 
            // txtKineticMod
            // 
            this.txtKineticMod.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.damageModifiersBindingSource, "Kinetic", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtKineticMod.Location = new System.Drawing.Point(89, 146);
            this.txtKineticMod.Name = "txtKineticMod";
            this.txtKineticMod.Size = new System.Drawing.Size(75, 20);
            this.txtKineticMod.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Kinetic";
            // 
            // DamageModifiers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 194);
            this.Controls.Add(this.groupBox1);
            this.Name = "DamageModifiers";
            this.Text = "Damage Modifiers";
            this.Load += new System.EventHandler(this.DamageModifiers_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.damageModifiersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBulletMod;
        private System.Windows.Forms.BindingSource damageModifiersBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtExplosionMod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRocketMod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKineticMod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEnergyMod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEnvironmentMod;
    }
}