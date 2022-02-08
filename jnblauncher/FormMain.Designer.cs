
namespace jnblauncher
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxMap = new System.Windows.Forms.ComboBox();
            this.groupBoxMap = new System.Windows.Forms.GroupBox();
            this.checkBoxLoadMap = new System.Windows.Forms.CheckBox();
            this.checkBoxScaleup = new System.Windows.Forms.CheckBox();
            this.checkBoxFullscreen = new System.Windows.Forms.CheckBox();
            this.buttonRun = new System.Windows.Forms.Button();
            this.checkBoxSoundOff = new System.Windows.Forms.CheckBox();
            this.checkBoxNoSfx = new System.Windows.Forms.CheckBox();
            this.checkBoxFamilyMode = new System.Windows.Forms.CheckBox();
            this.checkBoxNoFlies = new System.Windows.Forms.CheckBox();
            this.groupBoxMap.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxMap
            // 
            this.comboBoxMap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxMap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMap.FormattingEnabled = true;
            this.comboBoxMap.Location = new System.Drawing.Point(5, 46);
            this.comboBoxMap.Name = "comboBoxMap";
            this.comboBoxMap.Size = new System.Drawing.Size(185, 21);
            this.comboBoxMap.TabIndex = 1;
            // 
            // groupBoxMap
            // 
            this.groupBoxMap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxMap.Controls.Add(this.checkBoxLoadMap);
            this.groupBoxMap.Controls.Add(this.comboBoxMap);
            this.groupBoxMap.Location = new System.Drawing.Point(10, 10);
            this.groupBoxMap.Name = "groupBoxMap";
            this.groupBoxMap.Size = new System.Drawing.Size(197, 75);
            this.groupBoxMap.TabIndex = 2;
            this.groupBoxMap.TabStop = false;
            this.groupBoxMap.Text = "Map";
            // 
            // checkBoxLoadMap
            // 
            this.checkBoxLoadMap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxLoadMap.Checked = true;
            this.checkBoxLoadMap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLoadMap.Location = new System.Drawing.Point(5, 19);
            this.checkBoxLoadMap.Name = "checkBoxLoadMap";
            this.checkBoxLoadMap.Size = new System.Drawing.Size(186, 21);
            this.checkBoxLoadMap.TabIndex = 8;
            this.checkBoxLoadMap.Text = "Load map";
            this.checkBoxLoadMap.UseVisualStyleBackColor = true;
            this.checkBoxLoadMap.CheckedChanged += new System.EventHandler(this.checkBoxLoadMap_CheckedChanged);
            // 
            // checkBoxScaleup
            // 
            this.checkBoxScaleup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxScaleup.Checked = true;
            this.checkBoxScaleup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxScaleup.Location = new System.Drawing.Point(15, 91);
            this.checkBoxScaleup.Name = "checkBoxScaleup";
            this.checkBoxScaleup.Size = new System.Drawing.Size(187, 21);
            this.checkBoxScaleup.TabIndex = 3;
            this.checkBoxScaleup.Text = "Enable scaleup";
            this.checkBoxScaleup.UseVisualStyleBackColor = true;
            // 
            // checkBoxFullscreen
            // 
            this.checkBoxFullscreen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxFullscreen.Location = new System.Drawing.Point(15, 117);
            this.checkBoxFullscreen.Name = "checkBoxFullscreen";
            this.checkBoxFullscreen.Size = new System.Drawing.Size(187, 21);
            this.checkBoxFullscreen.TabIndex = 4;
            this.checkBoxFullscreen.Text = "Enable fullscreen";
            this.checkBoxFullscreen.UseVisualStyleBackColor = true;
            // 
            // buttonRun
            // 
            this.buttonRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRun.Location = new System.Drawing.Point(138, 265);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(64, 24);
            this.buttonRun.TabIndex = 5;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // checkBoxSoundOff
            // 
            this.checkBoxSoundOff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxSoundOff.Location = new System.Drawing.Point(15, 144);
            this.checkBoxSoundOff.Name = "checkBoxSoundOff";
            this.checkBoxSoundOff.Size = new System.Drawing.Size(187, 21);
            this.checkBoxSoundOff.TabIndex = 6;
            this.checkBoxSoundOff.Text = "Run without sound";
            this.checkBoxSoundOff.UseVisualStyleBackColor = true;
            // 
            // checkBoxNoSfx
            // 
            this.checkBoxNoSfx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxNoSfx.Location = new System.Drawing.Point(15, 171);
            this.checkBoxNoSfx.Name = "checkBoxNoSfx";
            this.checkBoxNoSfx.Size = new System.Drawing.Size(187, 21);
            this.checkBoxNoSfx.TabIndex = 7;
            this.checkBoxNoSfx.Text = "No sound effects";
            this.checkBoxNoSfx.UseVisualStyleBackColor = true;
            // 
            // checkBoxFamilyMode
            // 
            this.checkBoxFamilyMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxFamilyMode.Location = new System.Drawing.Point(15, 198);
            this.checkBoxFamilyMode.Name = "checkBoxFamilyMode";
            this.checkBoxFamilyMode.Size = new System.Drawing.Size(187, 21);
            this.checkBoxFamilyMode.TabIndex = 8;
            this.checkBoxFamilyMode.Text = "No blood (Family mode)";
            this.checkBoxFamilyMode.UseVisualStyleBackColor = true;
            // 
            // checkBoxNoFlies
            // 
            this.checkBoxNoFlies.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxNoFlies.Location = new System.Drawing.Point(15, 225);
            this.checkBoxNoFlies.Name = "checkBoxNoFlies";
            this.checkBoxNoFlies.Size = new System.Drawing.Size(187, 21);
            this.checkBoxNoFlies.TabIndex = 9;
            this.checkBoxNoFlies.Text = "Disable flies";
            this.checkBoxNoFlies.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 301);
            this.Controls.Add(this.checkBoxNoFlies);
            this.Controls.Add(this.checkBoxFamilyMode);
            this.Controls.Add(this.checkBoxNoSfx);
            this.Controls.Add(this.checkBoxSoundOff);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.checkBoxFullscreen);
            this.Controls.Add(this.checkBoxScaleup);
            this.Controls.Add(this.groupBoxMap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jump\'n\'bump launcher";
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.groupBoxMap.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxMap;
        private System.Windows.Forms.GroupBox groupBoxMap;
        private System.Windows.Forms.CheckBox checkBoxScaleup;
        private System.Windows.Forms.CheckBox checkBoxFullscreen;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.CheckBox checkBoxLoadMap;
        private System.Windows.Forms.CheckBox checkBoxSoundOff;
        private System.Windows.Forms.CheckBox checkBoxNoSfx;
        private System.Windows.Forms.CheckBox checkBoxFamilyMode;
        private System.Windows.Forms.CheckBox checkBoxNoFlies;
    }
}

