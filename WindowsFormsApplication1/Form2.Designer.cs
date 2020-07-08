namespace WindowsFormsApplication1
{
    partial class Form2
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
            this.History = new System.Windows.Forms.Button();
            this.Reseve = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button7 = new System.Windows.Forms.Button();
            this.hist = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.reserve = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.loc = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.destination = new System.Windows.Forms.TextBox();
            this.location = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DriverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pric = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.hist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.reserve.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // History
            // 
            this.History.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.History.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.History.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.History.Location = new System.Drawing.Point(51, 151);
            this.History.Margin = new System.Windows.Forms.Padding(2);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(308, 58);
            this.History.TabIndex = 0;
            this.History.Text = "View Your History";
            this.History.UseVisualStyleBackColor = false;
            this.History.Click += new System.EventHandler(this.button1_Click);
            // 
            // Reseve
            // 
            this.Reseve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Reseve.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reseve.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Reseve.Location = new System.Drawing.Point(52, 245);
            this.Reseve.Margin = new System.Windows.Forms.Padding(2);
            this.Reseve.Name = "Reseve";
            this.Reseve.Size = new System.Drawing.Size(308, 58);
            this.Reseve.TabIndex = 1;
            this.Reseve.Text = "Reserve A Taxi";
            this.Reseve.UseVisualStyleBackColor = false;
            this.Reseve.Click += new System.EventHandler(this.Reseve_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Forte", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(7, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please Select Your Choice";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.Reseve);
            this.panel1.Controls.Add(this.History);
            this.panel1.Location = new System.Drawing.Point(334, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 479);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.pictureBox3.Image = global::WindowsFormsApplication1.Properties.Resources.reply__1_3;
            this.pictureBox3.Location = new System.Drawing.Point(82, 390);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(34, 32);
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources.taxi__1_;
            this.pictureBox2.Location = new System.Drawing.Point(14, 258);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 32);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.file2;
            this.pictureBox1.Location = new System.Drawing.Point(14, 164);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 32);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(51, 379);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(308, 58);
            this.button7.TabIndex = 13;
            this.button7.Text = "Return Back";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // hist
            // 
            this.hist.BackColor = System.Drawing.Color.Gray;
            this.hist.Controls.Add(this.label3);
            this.hist.Controls.Add(this.dataGridView1);
            this.hist.Controls.Add(this.pictureBox5);
            this.hist.Controls.Add(this.button4);
            this.hist.Controls.Add(this.pictureBox4);
            this.hist.Location = new System.Drawing.Point(338, 2);
            this.hist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hist.Name = "hist";
            this.hist.Size = new System.Drawing.Size(369, 506);
            this.hist.TabIndex = 17;
            this.hist.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Forte", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(58, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(301, 52);
            this.label3.TabIndex = 21;
            this.label3.Text = "Your History";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DriverName,
            this.Price,
            this.Desti,
            this.pric,
            this.time,
            this.plate,
            this.model,
            this.colorr,
            this.yearr});
            this.dataGridView1.Location = new System.Drawing.Point(27, 81);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(334, 318);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.pictureBox5.Image = global::WindowsFormsApplication1.Properties.Resources.reply__1_2;
            this.pictureBox5.Location = new System.Drawing.Point(77, 416);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(34, 32);
            this.pictureBox5.TabIndex = 20;
            this.pictureBox5.TabStop = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(40, 405);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(308, 58);
            this.button4.TabIndex = 16;
            this.button4.Text = "Return Back";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApplication1.Properties.Resources.clock;
            this.pictureBox4.Location = new System.Drawing.Point(18, 28);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(34, 32);
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // reserve
            // 
            this.reserve.BackColor = System.Drawing.Color.Gray;
            this.reserve.Controls.Add(this.textBox1);
            this.reserve.Controls.Add(this.pictureBox10);
            this.reserve.Controls.Add(this.label2);
            this.reserve.Controls.Add(this.pictureBox6);
            this.reserve.Controls.Add(this.label7);
            this.reserve.Controls.Add(this.pictureBox7);
            this.reserve.Controls.Add(this.pictureBox19);
            this.reserve.Controls.Add(this.pictureBox9);
            this.reserve.Controls.Add(this.pictureBox8);
            this.reserve.Controls.Add(this.button2);
            this.reserve.Controls.Add(this.label4);
            this.reserve.Controls.Add(this.loc);
            this.reserve.Controls.Add(this.button1);
            this.reserve.Controls.Add(this.destination);
            this.reserve.Controls.Add(this.location);
            this.reserve.Location = new System.Drawing.Point(334, 0);
            this.reserve.Margin = new System.Windows.Forms.Padding(2);
            this.reserve.Name = "reserve";
            this.reserve.Size = new System.Drawing.Size(370, 507);
            this.reserve.TabIndex = 22;
            this.reserve.Visible = false;
            this.reserve.Paint += new System.Windows.Forms.PaintEventHandler(this.reserve_Paint);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(44, 281);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(285, 20);
            this.textBox1.TabIndex = 25;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::WindowsFormsApplication1.Properties.Resources.money__2_;
            this.pictureBox10.Location = new System.Drawing.Point(3, 250);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(34, 28);
            this.pictureBox10.TabIndex = 24;
            this.pictureBox10.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 29);
            this.label2.TabIndex = 23;
            this.label2.Text = "Add Promocode :";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::WindowsFormsApplication1.Properties.Resources.pin;
            this.pictureBox6.Location = new System.Drawing.Point(8, 112);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(29, 28);
            this.pictureBox6.TabIndex = 29;
            this.pictureBox6.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Forte", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(62, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(275, 35);
            this.label7.TabIndex = 28;
            this.label7.Text = "Trips Information";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.pictureBox7.Image = global::WindowsFormsApplication1.Properties.Resources.reply__1_4;
            this.pictureBox7.Location = new System.Drawing.Point(77, 405);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(34, 32);
            this.pictureBox7.TabIndex = 27;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox19
            // 
            this.pictureBox19.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.pictureBox19.Image = global::WindowsFormsApplication1.Properties.Resources.icon__2_;
            this.pictureBox19.Location = new System.Drawing.Point(77, 329);
            this.pictureBox19.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(34, 32);
            this.pictureBox19.TabIndex = 10;
            this.pictureBox19.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::WindowsFormsApplication1.Properties.Resources.road;
            this.pictureBox9.Location = new System.Drawing.Point(14, 12);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(34, 32);
            this.pictureBox9.TabIndex = 9;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::WindowsFormsApplication1.Properties.Resources.maps_and_flags;
            this.pictureBox8.Location = new System.Drawing.Point(3, 187);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(34, 28);
            this.pictureBox8.TabIndex = 8;
            this.pictureBox8.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(40, 317);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(308, 58);
            this.button2.TabIndex = 5;
            this.button2.Text = "Confirm";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 187);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Dropoff Location:";
            // 
            // loc
            // 
            this.loc.AutoSize = true;
            this.loc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loc.Location = new System.Drawing.Point(38, 112);
            this.loc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loc.Name = "loc";
            this.loc.Size = new System.Drawing.Size(189, 29);
            this.loc.TabIndex = 3;
            this.loc.Text = "Pickup Location:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(40, 390);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(308, 58);
            this.button1.TabIndex = 2;
            this.button1.Text = "Return Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // destination
            // 
            this.destination.Location = new System.Drawing.Point(40, 221);
            this.destination.Margin = new System.Windows.Forms.Padding(2);
            this.destination.Name = "destination";
            this.destination.Size = new System.Drawing.Size(289, 20);
            this.destination.TabIndex = 1;
            // 
            // location
            // 
            this.location.Location = new System.Drawing.Point(40, 151);
            this.location.Margin = new System.Windows.Forms.Padding(2);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(289, 20);
            this.location.TabIndex = 0;
            this.location.TextChanged += new System.EventHandler(this.location_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // DriverName
            // 
            this.DriverName.HeaderText = "Driver Name";
            this.DriverName.Name = "DriverName";
            // 
            // Price
            // 
            this.Price.HeaderText = "Pickup";
            this.Price.Name = "Price";
            // 
            // Desti
            // 
            this.Desti.HeaderText = "Dropoff";
            this.Desti.Name = "Desti";
            // 
            // pric
            // 
            this.pric.HeaderText = "Price";
            this.pric.Name = "pric";
            // 
            // time
            // 
            this.time.HeaderText = "Date";
            this.time.Name = "time";
            // 
            // plate
            // 
            this.plate.HeaderText = "Plate Number";
            this.plate.Name = "plate";
            // 
            // model
            // 
            this.model.HeaderText = "Car\'s Model";
            this.model.Name = "model";
            // 
            // colorr
            // 
            this.colorr.HeaderText = "Car\'s Color";
            this.colorr.Name = "colorr";
            // 
            // yearr
            // 
            this.yearr.HeaderText = "Car\'s Year";
            this.yearr.Name = "yearr";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.taxi_background;
            this.ClientSize = new System.Drawing.Size(701, 474);
            this.Controls.Add(this.reserve);
            this.Controls.Add(this.hist);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.hist.ResumeLayout(false);
            this.hist.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.reserve.ResumeLayout(false);
            this.reserve.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button History;
        private System.Windows.Forms.Button Reseve;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel hist;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel reserve;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label loc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox destination;
        private System.Windows.Forms.TextBox location;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox19;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desti;
        private System.Windows.Forms.DataGridViewTextBoxColumn pric;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn plate;
        private System.Windows.Forms.DataGridViewTextBoxColumn model;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorr;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearr;
    }
}