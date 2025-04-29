namespace WindowsFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelOre;
        private System.Windows.Forms.Label labelManganese;
        private System.Windows.Forms.Label labelChromium;
        private System.Windows.Forms.Label labelNickel;
        private System.Windows.Forms.Label labelBlastFurnaceTime;
        private System.Windows.Forms.Label labelConverterTime;
        private System.Windows.Forms.Label labelRollingMillTime;
        private System.Windows.Forms.TextBox textBoxOre;
        private System.Windows.Forms.TextBox textBoxManganese;
        private System.Windows.Forms.TextBox textBoxChromium;
        private System.Windows.Forms.TextBox textBoxNickel;
        private System.Windows.Forms.TextBox textBoxBlastFurnaceTime;
        private System.Windows.Forms.TextBox textBoxConverterTime;
        private System.Windows.Forms.TextBox textBoxRollingMillTime;
        private System.Windows.Forms.Button buttonSave;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelOre = new System.Windows.Forms.Label();
            this.labelManganese = new System.Windows.Forms.Label();
            this.labelChromium = new System.Windows.Forms.Label();
            this.labelNickel = new System.Windows.Forms.Label();
            this.labelBlastFurnaceTime = new System.Windows.Forms.Label();
            this.labelConverterTime = new System.Windows.Forms.Label();
            this.labelRollingMillTime = new System.Windows.Forms.Label();
            this.textBoxOre = new System.Windows.Forms.TextBox();
            this.textBoxManganese = new System.Windows.Forms.TextBox();
            this.textBoxChromium = new System.Windows.Forms.TextBox();
            this.textBoxNickel = new System.Windows.Forms.TextBox();
            this.textBoxBlastFurnaceTime = new System.Windows.Forms.TextBox();
            this.textBoxConverterTime = new System.Windows.Forms.TextBox();
            this.textBoxRollingMillTime = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // labelOre
            //
            this.labelOre.AutoSize = true;
            this.labelOre.Location = new System.Drawing.Point(13, 13);
            this.labelOre.Name = "labelOre";
            this.labelOre.Size = new System.Drawing.Size(31, 13);
            this.labelOre.TabIndex = 0;
            this.labelOre.Text = "Руда";
            //
            // labelManganese
            //
            this.labelManganese.AutoSize = true;
            this.labelManganese.Location = new System.Drawing.Point(13, 39);
            this.labelManganese.Name = "labelManganese";
            this.labelManganese.Size = new System.Drawing.Size(62, 13);
            this.labelManganese.TabIndex = 1;
            this.labelManganese.Text = "Марганец";
            //
            // labelChromium
            //
            this.labelChromium.AutoSize = true;
            this.labelChromium.Location = new System.Drawing.Point(13, 65);
            this.labelChromium.Name = "labelChromium";
            this.labelChromium.Size = new System.Drawing.Size(47, 13);
            this.labelChromium.TabIndex = 2;
            this.labelChromium.Text = "Хром";
            //
            // labelNickel
            //
            this.labelNickel.AutoSize = true;
            this.labelNickel.Location = new System.Drawing.Point(13, 91);
            this.labelNickel.Name = "labelNickel";
            this.labelNickel.Size = new System.Drawing.Size(44, 13);
            this.labelNickel.TabIndex = 3;
            this.labelNickel.Text = "Никель";
            //
            // labelBlastFurnaceTime
            //
            this.labelBlastFurnaceTime.AutoSize = true;
            this.labelBlastFurnaceTime.Location = new System.Drawing.Point(13, 117);
            this.labelBlastFurnaceTime.Name = "labelBlastFurnaceTime";
            this.labelBlastFurnaceTime.Size = new System.Drawing.Size(121, 13);
            this.labelBlastFurnaceTime.TabIndex = 4;
            this.labelBlastFurnaceTime.Text = "Время работы ДП";
            //
            // labelConverterTime
            //
            this.labelConverterTime.AutoSize = true;
            this.labelConverterTime.Location = new System.Drawing.Point(13, 143);
            this.labelConverterTime.Name = "labelConverterTime";
            this.labelConverterTime.Size = new System.Drawing.Size(128, 13);
            this.labelConverterTime.TabIndex = 5;
            this.labelConverterTime.Text = "Время работы конвертера";
            //
            // labelRollingMillTime
            //
            this.labelRollingMillTime.AutoSize = true;
            this.labelRollingMillTime.Location = new System.Drawing.Point(13, 169);
            this.labelRollingMillTime.Name = "labelRollingMillTime";
            this.labelRollingMillTime.Size = new System.Drawing.Size(133, 13);
            this.labelRollingMillTime.TabIndex = 6;
            this.labelRollingMillTime.Text = "Время работы ПС";
            //
            // textBoxOre
            //
            this.textBoxOre.Location = new System.Drawing.Point(150, 10);
            this.textBoxOre.Name = "textBoxOre";
            this.textBoxOre.Size = new System.Drawing.Size(100, 20);
            this.textBoxOre.TabIndex = 7;
            //
            // textBoxManganese
            //
            this.textBoxManganese.Location = new System.Drawing.Point(150, 36);
            this.textBoxManganese.Name = "textBoxManganese";
            this.textBoxManganese.Size = new System.Drawing.Size(100, 20);
            this.textBoxManganese.TabIndex = 8;
            //
            // textBoxChromium
            //
            this.textBoxChromium.Location = new System.Drawing.Point(150, 62);
            this.textBoxChromium.Name = "textBoxChromium";
            this.textBoxChromium.Size = new System.Drawing.Size(100, 20);
            this.textBoxChromium.TabIndex = 9;
            //
            // textBoxNickel
            //
            this.textBoxNickel.Location = new System.Drawing.Point(150, 88);
            this.textBoxNickel.Name = "textBoxNickel";
            this.textBoxNickel.Size = new System.Drawing.Size(100, 20);
            this.textBoxNickel.TabIndex = 10;
            //
            // textBoxBlastFurnaceTime
            //
            this.textBoxBlastFurnaceTime.Location = new System.Drawing.Point(150, 114);
            this.textBoxBlastFurnaceTime.Name = "textBoxBlastFurnaceTime";
            this.textBoxBlastFurnaceTime.Size = new System.Drawing.Size(100, 20);
            this.textBoxBlastFurnaceTime.TabIndex = 11;
            //
            // textBoxConverterTime
            //
            this.textBoxConverterTime.Location = new System.Drawing.Point(150, 140);
            this.textBoxConverterTime.Name = "textBoxConverterTime";
            this.textBoxConverterTime.Size = new System.Drawing.Size(100, 20);
            this.textBoxConverterTime.TabIndex = 12;
            //
            // textBoxRollingMillTime
            //
            this.textBoxRollingMillTime.Location = new System.Drawing.Point(150, 166);
            this.textBoxRollingMillTime.Name = "textBoxRollingMillTime";
            this.textBoxRollingMillTime.Size = new System.Drawing.Size(100, 20);
            this.textBoxRollingMillTime.TabIndex = 13;
            //
            // buttonSave
            //
            this.buttonSave.Location = new System.Drawing.Point(150, 192);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 14;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            //
            // Form1
            //
            this.ClientSize = new System.Drawing.Size(284, 227);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxRollingMillTime);
            this.Controls.Add(this.textBoxConverterTime);
            this.Controls.Add(this.textBoxBlastFurnaceTime);
            this.Controls.Add(this.textBoxNickel);
            this.Controls.Add(this.textBoxChromium);
            this.Controls.Add(this.textBoxManganese);
            this.Controls.Add(this.textBoxOre);
            this.Controls.Add(this.labelRollingMillTime);
            this.Controls.Add(this.labelConverterTime);
            this.Controls.Add(this.labelBlastFurnaceTime);
            this.Controls.Add(this.labelNickel);
            this.Controls.Add(this.labelChromium);
            this.Controls.Add(this.labelManganese);
            this.Controls.Add(this.labelOre);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
