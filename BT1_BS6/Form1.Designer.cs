namespace BT1_BS6
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnInitialize;
        private System.Windows.Forms.TextBox txtCows;
        private System.Windows.Forms.TextBox txtSheep;
        private System.Windows.Forms.TextBox txtGoats;
        private System.Windows.Forms.Label lblCows;
        private System.Windows.Forms.Label lblSheep;
        private System.Windows.Forms.Label lblGoats;
        private System.Windows.Forms.ListView listViewAnimals;
        private System.Windows.Forms.TextBox txtTotalMilk;
        private System.Windows.Forms.TextBox txtTotalCows;
        private System.Windows.Forms.TextBox txtTotalSheep;
        private System.Windows.Forms.TextBox txtTotalGoats;
        private System.Windows.Forms.TextBox txtSounds;
        private System.Windows.Forms.Label lblTotalMilk;
        private System.Windows.Forms.Label lblTotalCows;
        private System.Windows.Forms.Label lblTotalSheep;
        private System.Windows.Forms.Label lblTotalGoats;
        private System.Windows.Forms.Label lblSounds;

        private void InitializeComponent()
        {
            this.btnInitialize = new System.Windows.Forms.Button();
            this.txtCows = new System.Windows.Forms.TextBox();
            this.txtSheep = new System.Windows.Forms.TextBox();
            this.txtGoats = new System.Windows.Forms.TextBox();
            this.lblCows = new System.Windows.Forms.Label();
            this.lblSheep = new System.Windows.Forms.Label();
            this.lblGoats = new System.Windows.Forms.Label();
            this.listViewAnimals = new System.Windows.Forms.ListView();
            this.txtTotalMilk = new System.Windows.Forms.TextBox();
            this.txtTotalCows = new System.Windows.Forms.TextBox();
            this.txtTotalSheep = new System.Windows.Forms.TextBox();
            this.txtTotalGoats = new System.Windows.Forms.TextBox();
            this.txtSounds = new System.Windows.Forms.TextBox();
            this.lblTotalMilk = new System.Windows.Forms.Label();
            this.lblTotalCows = new System.Windows.Forms.Label();
            this.lblTotalSheep = new System.Windows.Forms.Label();
            this.lblTotalGoats = new System.Windows.Forms.Label();
            this.lblSounds = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInitialize
            // 
            this.btnInitialize.Location = new System.Drawing.Point(125, 156);
            this.btnInitialize.Name = "btnInitialize";
            this.btnInitialize.Size = new System.Drawing.Size(143, 30);
            this.btnInitialize.TabIndex = 6;
            this.btnInitialize.Text = "Initialize Farm";
            this.btnInitialize.Click += new System.EventHandler(this.btnInitialize_Click);
            // 
            // txtCows
            // 
            this.txtCows.Location = new System.Drawing.Point(181, 29);
            this.txtCows.Name = "txtCows";
            this.txtCows.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCows.Size = new System.Drawing.Size(100, 27);
            this.txtCows.TabIndex = 1;
            // 
            // txtSheep
            // 
            this.txtSheep.Location = new System.Drawing.Point(181, 69);
            this.txtSheep.Name = "txtSheep";
            this.txtSheep.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSheep.Size = new System.Drawing.Size(100, 27);
            this.txtSheep.TabIndex = 3;
            // 
            // txtGoats
            // 
            this.txtGoats.Location = new System.Drawing.Point(181, 109);
            this.txtGoats.Name = "txtGoats";
            this.txtGoats.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtGoats.Size = new System.Drawing.Size(100, 27);
            this.txtGoats.TabIndex = 5;
            // 
            // lblCows
            // 
            this.lblCows.Location = new System.Drawing.Point(22, 32);
            this.lblCows.Name = "lblCows";
            this.lblCows.Size = new System.Drawing.Size(153, 20);
            this.lblCows.TabIndex = 0;
            this.lblCows.Text = "Number of Cows:";
            // 
            // lblSheep
            // 
            this.lblSheep.Location = new System.Drawing.Point(22, 72);
            this.lblSheep.Name = "lblSheep";
            this.lblSheep.Size = new System.Drawing.Size(153, 20);
            this.lblSheep.TabIndex = 2;
            this.lblSheep.Text = "Number of Sheep:";
            // 
            // lblGoats
            // 
            this.lblGoats.Location = new System.Drawing.Point(22, 112);
            this.lblGoats.Name = "lblGoats";
            this.lblGoats.Size = new System.Drawing.Size(153, 20);
            this.lblGoats.TabIndex = 4;
            this.lblGoats.Text = "Number of Goats:";
            // 
            // listViewAnimals
            // 
            this.listViewAnimals.HideSelection = false;
            this.listViewAnimals.Location = new System.Drawing.Point(12, 236);
            this.listViewAnimals.Name = "listViewAnimals";
            this.listViewAnimals.Size = new System.Drawing.Size(730, 263);
            this.listViewAnimals.TabIndex = 10;
            this.listViewAnimals.UseCompatibleStateImageBehavior = false;
            // 
            // txtTotalMilk
            // 
            this.txtTotalMilk.Location = new System.Drawing.Point(145, 34);
            this.txtTotalMilk.Name = "txtTotalMilk";
            this.txtTotalMilk.ReadOnly = true;
            this.txtTotalMilk.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalMilk.Size = new System.Drawing.Size(100, 27);
            this.txtTotalMilk.TabIndex = 11;
            // 
            // txtTotalCows
            // 
            this.txtTotalCows.Location = new System.Drawing.Point(145, 69);
            this.txtTotalCows.Name = "txtTotalCows";
            this.txtTotalCows.ReadOnly = true;
            this.txtTotalCows.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalCows.Size = new System.Drawing.Size(100, 27);
            this.txtTotalCows.TabIndex = 12;
            // 
            // txtTotalSheep
            // 
            this.txtTotalSheep.Location = new System.Drawing.Point(145, 96);
            this.txtTotalSheep.Name = "txtTotalSheep";
            this.txtTotalSheep.ReadOnly = true;
            this.txtTotalSheep.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalSheep.Size = new System.Drawing.Size(100, 27);
            this.txtTotalSheep.TabIndex = 13;
            // 
            // txtTotalGoats
            // 
            this.txtTotalGoats.Location = new System.Drawing.Point(145, 126);
            this.txtTotalGoats.Name = "txtTotalGoats";
            this.txtTotalGoats.ReadOnly = true;
            this.txtTotalGoats.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalGoats.Size = new System.Drawing.Size(100, 27);
            this.txtTotalGoats.TabIndex = 14;
            // 
            // txtSounds
            // 
            this.txtSounds.Location = new System.Drawing.Point(100, 156);
            this.txtSounds.Name = "txtSounds";
            this.txtSounds.ReadOnly = true;
            this.txtSounds.Size = new System.Drawing.Size(235, 27);
            this.txtSounds.TabIndex = 15;
            // 
            // lblTotalMilk
            // 
            this.lblTotalMilk.Location = new System.Drawing.Point(24, 42);
            this.lblTotalMilk.Name = "lblTotalMilk";
            this.lblTotalMilk.Size = new System.Drawing.Size(100, 20);
            this.lblTotalMilk.TabIndex = 16;
            this.lblTotalMilk.Text = "Total Milk:";
            // 
            // lblTotalCows
            // 
            this.lblTotalCows.Location = new System.Drawing.Point(24, 72);
            this.lblTotalCows.Name = "lblTotalCows";
            this.lblTotalCows.Size = new System.Drawing.Size(100, 20);
            this.lblTotalCows.TabIndex = 17;
            this.lblTotalCows.Text = "Total Cows:";
            // 
            // lblTotalSheep
            // 
            this.lblTotalSheep.Location = new System.Drawing.Point(24, 102);
            this.lblTotalSheep.Name = "lblTotalSheep";
            this.lblTotalSheep.Size = new System.Drawing.Size(100, 20);
            this.lblTotalSheep.TabIndex = 18;
            this.lblTotalSheep.Text = "Total Sheep:";
            // 
            // lblTotalGoats
            // 
            this.lblTotalGoats.Location = new System.Drawing.Point(24, 132);
            this.lblTotalGoats.Name = "lblTotalGoats";
            this.lblTotalGoats.Size = new System.Drawing.Size(100, 20);
            this.lblTotalGoats.TabIndex = 19;
            this.lblTotalGoats.Text = "Total Goats:";
            // 
            // lblSounds
            // 
            this.lblSounds.Location = new System.Drawing.Point(24, 161);
            this.lblSounds.Name = "lblSounds";
            this.lblSounds.Size = new System.Drawing.Size(70, 20);
            this.lblSounds.TabIndex = 20;
            this.lblSounds.Text = "Sounds:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCows);
            this.groupBox1.Controls.Add(this.btnInitialize);
            this.groupBox1.Controls.Add(this.txtCows);
            this.groupBox1.Controls.Add(this.txtGoats);
            this.groupBox1.Controls.Add(this.lblSheep);
            this.groupBox1.Controls.Add(this.lblGoats);
            this.groupBox1.Controls.Add(this.txtSheep);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(38, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 202);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INPUT";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTotalCows);
            this.groupBox2.Controls.Add(this.lblSounds);
            this.groupBox2.Controls.Add(this.lblTotalGoats);
            this.groupBox2.Controls.Add(this.txtTotalMilk);
            this.groupBox2.Controls.Add(this.lblTotalSheep);
            this.groupBox2.Controls.Add(this.lblTotalCows);
            this.groupBox2.Controls.Add(this.txtTotalSheep);
            this.groupBox2.Controls.Add(this.lblTotalMilk);
            this.groupBox2.Controls.Add(this.txtTotalGoats);
            this.groupBox2.Controls.Add(this.txtSounds);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(378, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 202);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "OUTPUT";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(754, 530);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listViewAnimals);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Farm Simulator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }



}

