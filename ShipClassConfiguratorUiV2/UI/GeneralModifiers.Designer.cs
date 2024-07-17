namespace ShipClassConfiguratorUiV2.UI
{
    partial class GeneralModifiers
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
            this.txtAssemblerSpeed = new System.Windows.Forms.TextBox();
            this.utilModifiersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDrillMult = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGyroEfficiency = new System.Windows.Forms.TextBox();
            this.txtGyroForce = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPowerProducerOutput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRefineryEfficiency = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRefinerySpeed = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtThrusterEfficiency = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtThrusterForce = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaxSpeed = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtMaxBoost = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBoostDuration = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBoostCooldown = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.utilModifiersBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 174);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtRefinerySpeed);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtRefineryEfficiency);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtPowerProducerOutput);
            this.groupBox2.Controls.Add(this.txtDrillMult);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtAssemblerSpeed);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(192, 147);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Production";
            // 
            // txtAssemblerSpeed
            // 
            this.txtAssemblerSpeed.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.utilModifiersBindingSource, "AssemblerSpeed", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtAssemblerSpeed.Location = new System.Drawing.Point(126, 13);
            this.txtAssemblerSpeed.Name = "txtAssemblerSpeed";
            this.txtAssemblerSpeed.Size = new System.Drawing.Size(60, 20);
            this.txtAssemblerSpeed.TabIndex = 1;
            // 
            // utilModifiersBindingSource
            // 
            this.utilModifiersBindingSource.DataSource = typeof(ShipConfigurator_Definitions.UtilModifiers);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Assembler Speed:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Drill Harvest:";
            // 
            // txtDrillMult
            // 
            this.txtDrillMult.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.utilModifiersBindingSource, "DrillHarvestMultipler", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtDrillMult.Location = new System.Drawing.Point(126, 38);
            this.txtDrillMult.Name = "txtDrillMult";
            this.txtDrillMult.Size = new System.Drawing.Size(60, 20);
            this.txtDrillMult.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtMaxSpeed);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtThrusterForce);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtThrusterEfficiency);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtGyroForce);
            this.groupBox3.Controls.Add(this.txtGyroEfficiency);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(204, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(176, 147);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mobility";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Gyro Efficiency:";
            // 
            // txtGyroEfficiency
            // 
            this.txtGyroEfficiency.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.utilModifiersBindingSource, "GyroEfficiency", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtGyroEfficiency.Location = new System.Drawing.Point(110, 13);
            this.txtGyroEfficiency.Name = "txtGyroEfficiency";
            this.txtGyroEfficiency.Size = new System.Drawing.Size(60, 20);
            this.txtGyroEfficiency.TabIndex = 4;
            // 
            // txtGyroForce
            // 
            this.txtGyroForce.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.utilModifiersBindingSource, "GyroForce", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtGyroForce.Location = new System.Drawing.Point(110, 38);
            this.txtGyroForce.Name = "txtGyroForce";
            this.txtGyroForce.Size = new System.Drawing.Size(60, 20);
            this.txtGyroForce.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Gyro Force:";
            // 
            // txtPowerProducerOutput
            // 
            this.txtPowerProducerOutput.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.utilModifiersBindingSource, "PowerProducersOutput", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtPowerProducerOutput.Location = new System.Drawing.Point(126, 64);
            this.txtPowerProducerOutput.Name = "txtPowerProducerOutput";
            this.txtPowerProducerOutput.Size = new System.Drawing.Size(60, 20);
            this.txtPowerProducerOutput.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Reactor Output:";
            // 
            // txtRefineryEfficiency
            // 
            this.txtRefineryEfficiency.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.utilModifiersBindingSource, "RefineEfficiency", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtRefineryEfficiency.Location = new System.Drawing.Point(126, 90);
            this.txtRefineryEfficiency.Name = "txtRefineryEfficiency";
            this.txtRefineryEfficiency.Size = new System.Drawing.Size(60, 20);
            this.txtRefineryEfficiency.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Refinery Efficiency:";
            // 
            // txtRefinerySpeed
            // 
            this.txtRefinerySpeed.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.utilModifiersBindingSource, "RefineSpeed", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtRefinerySpeed.Location = new System.Drawing.Point(126, 116);
            this.txtRefinerySpeed.Name = "txtRefinerySpeed";
            this.txtRefinerySpeed.Size = new System.Drawing.Size(60, 20);
            this.txtRefinerySpeed.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Refinery Speed:";
            // 
            // txtThrusterEfficiency
            // 
            this.txtThrusterEfficiency.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.utilModifiersBindingSource, "ThrusterEfficiency", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtThrusterEfficiency.Location = new System.Drawing.Point(110, 64);
            this.txtThrusterEfficiency.Name = "txtThrusterEfficiency";
            this.txtThrusterEfficiency.Size = new System.Drawing.Size(60, 20);
            this.txtThrusterEfficiency.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Thruster Efficiency:";
            // 
            // txtThrusterForce
            // 
            this.txtThrusterForce.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.utilModifiersBindingSource, "ThrusterForce", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtThrusterForce.Location = new System.Drawing.Point(110, 90);
            this.txtThrusterForce.Name = "txtThrusterForce";
            this.txtThrusterForce.Size = new System.Drawing.Size(60, 20);
            this.txtThrusterForce.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Thruster Force:";
            // 
            // txtMaxSpeed
            // 
            this.txtMaxSpeed.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.utilModifiersBindingSource, "MaxSpeed", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtMaxSpeed.Location = new System.Drawing.Point(110, 116);
            this.txtMaxSpeed.Name = "txtMaxSpeed";
            this.txtMaxSpeed.Size = new System.Drawing.Size(60, 20);
            this.txtMaxSpeed.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Max Speed:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.txtBoostCooldown);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.txtBoostDuration);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.txtMaxBoost);
            this.groupBox4.Location = new System.Drawing.Point(386, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(174, 106);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Boost";
            // 
            // txtMaxBoost
            // 
            this.txtMaxBoost.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.utilModifiersBindingSource, "MaxBoost", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtMaxBoost.Location = new System.Drawing.Point(108, 13);
            this.txtMaxBoost.Name = "txtMaxBoost";
            this.txtMaxBoost.Size = new System.Drawing.Size(60, 20);
            this.txtMaxBoost.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Max Boost:";
            // 
            // txtBoostDuration
            // 
            this.txtBoostDuration.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.utilModifiersBindingSource, "BoostDuration", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtBoostDuration.Location = new System.Drawing.Point(108, 41);
            this.txtBoostDuration.Name = "txtBoostDuration";
            this.txtBoostDuration.Size = new System.Drawing.Size(60, 20);
            this.txtBoostDuration.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Boost Duration:";
            // 
            // txtBoostCooldown
            // 
            this.txtBoostCooldown.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.utilModifiersBindingSource, "BoostCoolDown", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtBoostCooldown.Location = new System.Drawing.Point(108, 67);
            this.txtBoostCooldown.Name = "txtBoostCooldown";
            this.txtBoostCooldown.Size = new System.Drawing.Size(60, 20);
            this.txtBoostCooldown.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Boost Cooldown:";
            // 
            // GeneralModifiers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 203);
            this.Controls.Add(this.groupBox1);
            this.Name = "GeneralModifiers";
            this.Text = "General Modifiers";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.utilModifiersBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAssemblerSpeed;
        private System.Windows.Forms.BindingSource utilModifiersBindingSource;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDrillMult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGyroForce;
        private System.Windows.Forms.TextBox txtGyroEfficiency;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPowerProducerOutput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtThrusterEfficiency;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRefinerySpeed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRefineryEfficiency;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMaxSpeed;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtThrusterForce;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtBoostDuration;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMaxBoost;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtBoostCooldown;
        private System.Windows.Forms.Label label12;
    }
}