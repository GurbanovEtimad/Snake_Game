namespace snake_game
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            food = new PictureBox();
            snake = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            buttonup = new Button();
            buttondown = new Button();
            buttonleft = new Button();
            buttonright = new Button();
            button2 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)food).BeginInit();
            ((System.ComponentModel.ISupportInitialize)snake).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(food);
            panel1.Controls.Add(snake);
            panel1.Location = new Point(16, 18);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(813, 415);
            panel1.TabIndex = 0;
            // 
            // food
            // 
            food.BackColor = Color.Black;
            food.Location = new Point(333, 183);
            food.Name = "food";
            food.Size = new Size(33, 27);
            food.TabIndex = 1;
            food.TabStop = false;
            // 
            // snake
            // 
            snake.BackColor = Color.Black;
            snake.Location = new Point(224, 76);
            snake.Name = "snake";
            snake.Size = new Size(33, 27);
            snake.TabIndex = 0;
            snake.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(67, 468);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(51, 22);
            label1.TabIndex = 1;
            label1.Text = "Xal: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(128, 468);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(21, 24);
            label2.TabIndex = 2;
            label2.Text = "0";
            // 
            // buttonup
            // 
            buttonup.Image = (Image)resources.GetObject("buttonup.Image");
            buttonup.Location = new Point(475, 443);
            buttonup.Margin = new Padding(4, 5, 4, 5);
            buttonup.Name = "buttonup";
            buttonup.Size = new Size(75, 73);
            buttonup.TabIndex = 3;
            buttonup.UseVisualStyleBackColor = true;
            buttonup.Click += buttonUp_Click;
            // 
            // buttondown
            // 
            buttondown.Image = (Image)resources.GetObject("buttondown.Image");
            buttondown.Location = new Point(475, 591);
            buttondown.Margin = new Padding(4, 5, 4, 5);
            buttondown.Name = "buttondown";
            buttondown.Size = new Size(75, 73);
            buttondown.TabIndex = 4;
            buttondown.UseVisualStyleBackColor = true;
            buttondown.Click += buttonDown_Click;
            // 
            // buttonleft
            // 
            buttonleft.Image = (Image)resources.GetObject("buttonleft.Image");
            buttonleft.Location = new Point(391, 517);
            buttonleft.Margin = new Padding(4, 5, 4, 5);
            buttonleft.Name = "buttonleft";
            buttonleft.Size = new Size(76, 67);
            buttonleft.TabIndex = 5;
            buttonleft.UseVisualStyleBackColor = true;
            buttonleft.Click += buttonLeft_Click;
            // 
            // buttonright
            // 
            buttonright.Image = (Image)resources.GetObject("buttonright.Image");
            buttonright.Location = new Point(558, 514);
            buttonright.Margin = new Padding(4, 5, 4, 5);
            buttonright.Name = "buttonright";
            buttonright.Size = new Size(75, 73);
            buttonright.TabIndex = 6;
            buttonright.UseVisualStyleBackColor = true;
            buttonright.Click += buttonRight_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(67, 591);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(120, 54);
            button2.TabIndex = 7;
            button2.Text = "Çıxış";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(845, 678);
            Controls.Add(button2);
            Controls.Add(buttonright);
            Controls.Add(buttonleft);
            Controls.Add(buttondown);
            Controls.Add(buttonup);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "İlan Oyunu";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)food).EndInit();
            ((System.ComponentModel.ISupportInitialize)snake).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonup;
        private System.Windows.Forms.Button buttondown;
        private System.Windows.Forms.Button buttonleft;
        private System.Windows.Forms.Button buttonright;
        private System.Windows.Forms.Button button2;
        private PictureBox food;
        private PictureBox snake;
        private System.Windows.Forms.Timer timer1;
    }
}