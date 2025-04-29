namespace WindowsFormsApp1
{
    partial class NewOrder
    {
        partial class NewOrderForm
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
                this.labelSteelGrade = new System.Windows.Forms.Label();
                this.labelRawMaterial = new System.Windows.Forms.Label();
                this.labelTimeBlastFurnace = new System.Windows.Forms.Label();
                this.labelTimeConverter = new System.Windows.Forms.Label();
                this.labelTimeRollingMill = new System.Windows.Forms.Label();
                this.labelPricePerTon = new System.Windows.Forms.Label();
                this.labelTargetVolume = new System.Windows.Forms.Label();
                this.textBoxSteelGrade = new System.Windows.Forms.TextBox();
                this.textBoxRawMaterial = new System.Windows.Forms.TextBox();
                this.textBoxTimeBlastFurnace = new System.Windows.Forms.TextBox();
                this.textBoxTimeConverter = new System.Windows.Forms.TextBox();
                this.textBoxTimeRollingMill = new System.Windows.Forms.TextBox();
                this.textBoxPricePerTon = new System.Windows.Forms.TextBox();
                this.textBoxTargetVolume = new System.Windows.Forms.TextBox();
                this.buttonExecuteOrder = new System.Windows.Forms.Button();
                this.SuspendLayout();
                // 
                // labelSteelGrade
                // 
                this.labelSteelGrade.AutoSize = true;
                this.labelSteelGrade.Location = new System.Drawing.Point(13, 13);
                this.labelSteelGrade.Name = "labelSteelGrade";
                this.labelSteelGrade.Size = new System.Drawing.Size(76, 13);
                this.labelSteelGrade.TabIndex = 0;
                this.labelSteelGrade.Text = "Марка стали";
                // 
                // labelRawMaterial
                // 
                this.labelRawMaterial.AutoSize = true;
                this.labelRawMaterial.Location = new System.Drawing.Point(13, 39);
                this.labelRawMaterial.Name = "labelRawMaterial";
                this.labelRawMaterial.Size = new System.Drawing.Size(69, 13);
                this.labelRawMaterial.TabIndex = 1;
                this.labelRawMaterial.Text = "Сырье";
                // 
                // labelTimeBlastFurnace
                // 
                this.labelTimeBlastFurnace.AutoSize = true;
                this.labelTimeBlastFurnace.Location = new System.Drawing.Point(13, 65);
                this.labelTimeBlastFurnace.Name = "labelTimeBlastFurnace";
                this.labelTimeBlastFurnace.Size = new System.Drawing.Size(121, 13);
                this.labelTimeBlastFurnace.TabIndex = 2;
                this.labelTimeBlastFurnace.Text = "Время работы ДП";
                // 
                // labelTimeConverter
                // 
                this.labelTimeConverter.AutoSize = true;
                this.labelTimeConverter.Location = new System.Drawing.Point(13, 91);
                this.labelTimeConverter.Name = "labelTimeConverter";
                this.labelTimeConverter.Size = new System.Drawing.Size(128, 13);
                this.labelTimeConverter.TabIndex = 3;
                this.labelTimeConverter.Text = "Время работы конвертера";
                // 
                // labelTimeRollingMill
                // 
                this.labelTimeRollingMill.AutoSize = true;
                this.labelTimeRollingMill.Location = new System.Drawing.Point(13, 117);
                this.labelTimeRollingMill.Name = "labelTimeRollingMill";
                this.labelTimeRollingMill.Size = new System.Drawing.Size(133, 13);
                this.labelTimeRollingMill.TabIndex = 4;
                this.labelTimeRollingMill.Text = "Время работы ПС";
                // 
                // labelPricePerTon
                // 
                this.labelPricePerTon.AutoSize = true;
                this.labelPricePerTon.Location = new System.Drawing.Point(13, 143);
                this.labelPricePerTon.Name = "labelPricePerTon";
                this.labelPricePerTon.Size = new System.Drawing.Size(86, 13);
                this.labelPricePerTon.TabIndex = 5;
                this.labelPricePerTon.Text = "Цена за тонну";
                // 
                // labelTargetVolume
                // 
                this.labelTargetVolume.AutoSize = true;
                this.labelTargetVolume.Location = new System.Drawing.Point(13, 169);
                this.labelTargetVolume.Name = "labelTargetVolume";
                this.labelTargetVolume.Size = new System.Drawing.Size(95, 13);
                this.labelTargetVolume.TabIndex = 6;
                this.labelTargetVolume.Text = "Целевой объем";
                // 
                // textBoxSteelGrade
                // 
                this.textBoxSteelGrade.Location = new System.Drawing.Point(150, 10);
                this.textBoxSteelGrade.Name = "textBoxSteelGrade";
                this.textBoxSteelGrade.Size = new System.Drawing.Size(100, 20);
                this.textBoxSteelGrade.TabIndex = 7;
                // 
                // textBoxRawMaterial
                // 
                this.textBoxRawMaterial.Location = new System.Drawing.Point(150, 36);
                this.textBoxRawMaterial.Name = "textBoxRawMaterial";
                this.textBoxRawMaterial.Size = new System.Drawing.Size(100, 20);
                this.textBoxRawMaterial.TabIndex = 8;
                // 
                // textBoxTimeBlastFurnace
                // 
                this.textBoxTimeBlastFurnace.Location = new System.Drawing.Point(150, 62);
                this.textBoxTimeBlastFurnace.Name = "textBoxTimeBlastFurnace";
                this.textBoxTimeBlastFurnace.Size = new System.Drawing.Size(100, 20);
                this.textBoxTimeBlastFurnace.TabIndex = 9;
                // 
                // textBoxTimeConverter
                // 
                this.textBoxTimeConverter.Location = new System.Drawing.Point(150, 88);
                this.textBoxTimeConverter.Name = "textBoxTimeConverter";
                this.textBoxTimeConverter.Size = new System.Drawing.Size(100, 20);
                this.textBoxTimeConverter.TabIndex = 10;
                // 
                // textBoxTimeRollingMill
                // 
                this.textBoxTimeRollingMill.Location = new System.Drawing.Point(150, 114);
                this.textBoxTimeRollingMill.Name = "textBoxTimeRollingMill";
                this.textBoxTimeRollingMill.Size = new System.Drawing.Size(100, 20);
                this.textBoxTimeRollingMill.TabIndex = 11;
                // 
                // textBoxPricePerTon
                // 
                this.textBoxPricePerTon.Location = new System.Drawing.Point(150, 140);
                this.textBoxPricePerTon.Name = "textBoxPricePerTon";
                this.textBoxPricePerTon.Size = new System.Drawing.Size(100, 20);
                this.textBoxPricePerTon.TabIndex = 12;
                // 
                // textBoxTargetVolume
                // 
                this.textBoxTargetVolume.Location = new System.Drawing.Point(150, 166);
                this.textBoxTargetVolume.Name = "textBoxTargetVolume";
                this.textBoxTargetVolume.Size = new System.Drawing.Size(100, 20);
                this.textBoxTargetVolume.TabIndex = 13;
                // 
                // buttonExecuteOrder
                // 
                this.buttonExecuteOrder.Location = new System.Drawing.Point(150, 192);
                this.buttonExecuteOrder.Name = "buttonExecuteOrder";
                this.buttonExecuteOrder.Size = new System.Drawing.Size(100, 23);
                this.buttonExecuteOrder.TabIndex = 14;
                this.buttonExecuteOrder.Text = "Выполнить заказ";
                this.buttonExecuteOrder.UseVisualStyleBackColor = true;
                this.buttonExecuteOrder.Click += new System.EventHandler(this.ButtonExecuteOrder_Click);
                // 
                // NewOrderForm
                // 
                this.ClientSize = new System.Drawing.Size(284, 227);
                this.Controls.Add(this.buttonExecuteOrder);
                this.Controls.Add(this.textBoxTargetVolume);
                this.Controls.Add(this.textBoxPricePerTon);
                this.Controls.Add(this.textBoxTimeRollingMill);
                this.Controls.Add(this.textBoxTimeConverter);
                this.Controls.Add(this.textBoxTimeBlastFurnace);
                this.Controls.Add(this.textBoxRawMaterial);
                this.Controls.Add(this.textBoxSteelGrade);
                this.Controls.Add(this.labelTargetVolume);
                this.Controls.Add(this.labelPricePerTon);
                this.Controls.Add(this.labelTimeRollingMill);
                this.Controls.Add(this.labelTimeConverter);
                this.Controls.Add(this.labelTimeBlastFurnace);
                this.Controls.Add(this.labelRawMaterial);
                this.Controls.Add(this.labelSteelGrade);
                this.Name = "NewOrderForm";
                this.ResumeLayout(false);
                this.PerformLayout();

            }

            #endregion

            private System.Windows.Forms.Label labelSteelGrade;
            private System.Windows.Forms.Label labelRawMaterial;
            private System.Windows.Forms.Label labelTimeBlastFurnace;
            private System.Windows.Forms.Label labelTimeConverter;
            private System.Windows.Forms.Label labelTimeRollingMill;
            private System.Windows.Forms.Label labelPricePerTon;
            private System.Windows.Forms.Label labelTargetVolume;
            private System.Windows.Forms.TextBox textBoxSteelGrade;
            private System.Windows.Forms.TextBox textBoxRawMaterial;
            private System.Windows.Forms.TextBox textBoxTimeBlastFurnace;
            private System.Windows.Forms.TextBox textBoxTimeConverter;
            private System.Windows.Forms.TextBox textBoxTimeRollingMill;
            private System.Windows.Forms.TextBox textBoxPricePerTon;
            private System.Windows.Forms.TextBox textBoxTargetVolume;
            private System.Windows.Forms.Button buttonExecuteOrder;
        }
    }
}