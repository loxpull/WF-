namespace WindowsFormsApp1
{
partial class OrdersForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBoxOrders;
        private System.Windows.Forms.Button buttonNewOrder;

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
            this.listBoxOrders = new System.Windows.Forms.ListBox();
            this.buttonNewOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // listBoxOrders
            //
            this.listBoxOrders.FormattingEnabled = true;
            this.listBoxOrders.Location = new System.Drawing.Point(12, 12);
            this.listBoxOrders.Name = "listBoxOrders";
            this.listBoxOrders.Size = new System.Drawing.Size(260, 199);
            this.listBoxOrders.TabIndex = 0;
            //
            // buttonNewOrder
            //
            this.buttonNewOrder.Location = new System.Drawing.Point(12, 217);
            this.buttonNewOrder.Name = "buttonNewOrder";
            this.buttonNewOrder.Size = new System.Drawing.Size(260, 23);
            this.buttonNewOrder.TabIndex = 1;
            this.buttonNewOrder.Text = "Новый заказ";
            this.buttonNewOrder.UseVisualStyleBackColor = true;
            this.buttonNewOrder.Click += new System.EventHandler(this.ButtonNewOrder_Click);
            //
            // OrdersForm
            //
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonNewOrder);
            this.Controls.Add(this.listBoxOrders);
            this.Name = "OrdersForm";
            this.ResumeLayout(false);
        }
    }
}