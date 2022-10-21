
namespace Pizzer_v2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Cheese = new System.Windows.Forms.Button();
            this.BBQ = new System.Windows.Forms.Button();
            this.Meat = new System.Windows.Forms.Button();
            this.Piri = new System.Windows.Forms.Button();
            this.Hawaii = new System.Windows.Forms.Button();
            this.Mediteranian = new System.Windows.Forms.Button();
            this.Mexican = new System.Windows.Forms.Button();
            this.TheWorks = new System.Windows.Forms.Button();
            this.OrderTotal = new System.Windows.Forms.Label();
            this.Checkout = new System.Windows.Forms.Button();
            this.NewOrder = new System.Windows.Forms.Button();
            this.SelectedPizzas = new System.Windows.Forms.ListBox();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cheese
            // 
            this.Cheese.Location = new System.Drawing.Point(48, 93);
            this.Cheese.Name = "Cheese";
            this.Cheese.Size = new System.Drawing.Size(133, 55);
            this.Cheese.TabIndex = 0;
            this.Cheese.Text = "Cheese and Tomato";
            this.Cheese.UseVisualStyleBackColor = true;
            this.Cheese.Click += new System.EventHandler(this.Cheese_Click);
            // 
            // BBQ
            // 
            this.BBQ.Location = new System.Drawing.Point(48, 154);
            this.BBQ.Name = "BBQ";
            this.BBQ.Size = new System.Drawing.Size(133, 55);
            this.BBQ.TabIndex = 1;
            this.BBQ.Text = "BBQ Chicken";
            this.BBQ.UseVisualStyleBackColor = true;
            this.BBQ.Click += new System.EventHandler(this.BBQ_Click);
            // 
            // Meat
            // 
            this.Meat.Location = new System.Drawing.Point(48, 215);
            this.Meat.Name = "Meat";
            this.Meat.Size = new System.Drawing.Size(133, 55);
            this.Meat.TabIndex = 2;
            this.Meat.Text = "Meat Feast";
            this.Meat.UseVisualStyleBackColor = true;
            this.Meat.Click += new System.EventHandler(this.Meat_Click);
            // 
            // Piri
            // 
            this.Piri.Location = new System.Drawing.Point(48, 276);
            this.Piri.Name = "Piri";
            this.Piri.Size = new System.Drawing.Size(133, 55);
            this.Piri.TabIndex = 3;
            this.Piri.Text = "Piri Piri Chicken";
            this.Piri.UseVisualStyleBackColor = true;
            this.Piri.Click += new System.EventHandler(this.Piri_Click);
            // 
            // Hawaii
            // 
            this.Hawaii.Location = new System.Drawing.Point(187, 93);
            this.Hawaii.Name = "Hawaii";
            this.Hawaii.Size = new System.Drawing.Size(133, 55);
            this.Hawaii.TabIndex = 4;
            this.Hawaii.Text = "Hawaii";
            this.Hawaii.UseVisualStyleBackColor = true;
            this.Hawaii.Click += new System.EventHandler(this.Hawaii_Click);
            // 
            // Mediteranian
            // 
            this.Mediteranian.Location = new System.Drawing.Point(187, 154);
            this.Mediteranian.Name = "Mediteranian";
            this.Mediteranian.Size = new System.Drawing.Size(133, 55);
            this.Mediteranian.TabIndex = 5;
            this.Mediteranian.Text = "Mediteranian";
            this.Mediteranian.UseVisualStyleBackColor = true;
            this.Mediteranian.Click += new System.EventHandler(this.Mediteranian_Click);
            // 
            // Mexican
            // 
            this.Mexican.Location = new System.Drawing.Point(187, 215);
            this.Mexican.Name = "Mexican";
            this.Mexican.Size = new System.Drawing.Size(133, 55);
            this.Mexican.TabIndex = 6;
            this.Mexican.Text = "The Mexican";
            this.Mexican.UseVisualStyleBackColor = true;
            this.Mexican.Click += new System.EventHandler(this.Mexican_Click);
            // 
            // TheWorks
            // 
            this.TheWorks.Location = new System.Drawing.Point(187, 276);
            this.TheWorks.Name = "TheWorks";
            this.TheWorks.Size = new System.Drawing.Size(133, 55);
            this.TheWorks.TabIndex = 7;
            this.TheWorks.Text = "The Works";
            this.TheWorks.UseVisualStyleBackColor = true;
            this.TheWorks.Click += new System.EventHandler(this.TheWorks_Click);
            // 
            // OrderTotal
            // 
            this.OrderTotal.AutoSize = true;
            this.OrderTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderTotal.Location = new System.Drawing.Point(345, 334);
            this.OrderTotal.Name = "OrderTotal";
            this.OrderTotal.Size = new System.Drawing.Size(162, 29);
            this.OrderTotal.TabIndex = 12;
            this.OrderTotal.Text = "Order Total: ";
            this.OrderTotal.Click += new System.EventHandler(this.OrderTotal_Click);
            // 
            // Checkout
            // 
            this.Checkout.Location = new System.Drawing.Point(634, 93);
            this.Checkout.Name = "Checkout";
            this.Checkout.Size = new System.Drawing.Size(152, 116);
            this.Checkout.TabIndex = 18;
            this.Checkout.Text = "Checkout";
            this.Checkout.UseVisualStyleBackColor = true;
            this.Checkout.Click += new System.EventHandler(this.Checkout_Click);
            // 
            // NewOrder
            // 
            this.NewOrder.Location = new System.Drawing.Point(634, 215);
            this.NewOrder.Name = "NewOrder";
            this.NewOrder.Size = new System.Drawing.Size(152, 116);
            this.NewOrder.TabIndex = 19;
            this.NewOrder.Text = "New Order";
            this.NewOrder.UseVisualStyleBackColor = true;
            this.NewOrder.Click += new System.EventHandler(this.NewOrder_Click);
            // 
            // SelectedPizzas
            // 
            this.SelectedPizzas.FormattingEnabled = true;
            this.SelectedPizzas.Location = new System.Drawing.Point(350, 93);
            this.SelectedPizzas.Name = "SelectedPizzas";
            this.SelectedPizzas.Size = new System.Drawing.Size(278, 238);
            this.SelectedPizzas.TabIndex = 20;
            this.SelectedPizzas.SelectedIndexChanged += new System.EventHandler(this.SelectedPizzas_SelectedIndexChanged);
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.Location = new System.Drawing.Point(42, 31);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(134, 31);
            this.WelcomeLabel.TabIndex = 21;
            this.WelcomeLabel.Text = "Welcome!";
            this.WelcomeLabel.Click += new System.EventHandler(this.WelcomeLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.SelectedPizzas);
            this.Controls.Add(this.NewOrder);
            this.Controls.Add(this.Checkout);
            this.Controls.Add(this.OrderTotal);
            this.Controls.Add(this.TheWorks);
            this.Controls.Add(this.Mexican);
            this.Controls.Add(this.Mediteranian);
            this.Controls.Add(this.Hawaii);
            this.Controls.Add(this.Piri);
            this.Controls.Add(this.Meat);
            this.Controls.Add(this.BBQ);
            this.Controls.Add(this.Cheese);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Pizza Project";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cheese;
        private System.Windows.Forms.Button BBQ;
        private System.Windows.Forms.Button Meat;
        private System.Windows.Forms.Button Piri;
        private System.Windows.Forms.Button Hawaii;
        private System.Windows.Forms.Button Mediteranian;
        private System.Windows.Forms.Button Mexican;
        private System.Windows.Forms.Button TheWorks;
        private System.Windows.Forms.Label OrderTotal;
        private System.Windows.Forms.Button Checkout;
        private System.Windows.Forms.Button NewOrder;
        private System.Windows.Forms.ListBox SelectedPizzas;
        private System.Windows.Forms.Label WelcomeLabel;
    }
}

