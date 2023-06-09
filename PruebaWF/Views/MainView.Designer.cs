namespace PruebaWF
{
    partial class MainView
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
            this.registerPassengerButton = new System.Windows.Forms.Button();
            this.passangerListDataGrid = new System.Windows.Forms.DataGridView();
            this.PassengerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.remove3Btn = new System.Windows.Forms.Button();
            this.change3Btn = new System.Windows.Forms.Button();
            this.assign3Btn = new System.Windows.Forms.Button();
            this.client3Txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.seat3Txt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.remove2Btn = new System.Windows.Forms.Button();
            this.change2Btn = new System.Windows.Forms.Button();
            this.assign2Btn = new System.Windows.Forms.Button();
            this.client2Txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.seat2Txt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.remove1Btn = new System.Windows.Forms.Button();
            this.change1Btn = new System.Windows.Forms.Button();
            this.assign1Btn = new System.Windows.Forms.Button();
            this.client1Txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.seat1Txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.passangerNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.seat1 = new System.Windows.Forms.Label();
            this.seat2 = new System.Windows.Forms.Label();
            this.seat4 = new System.Windows.Forms.Label();
            this.seat3 = new System.Windows.Forms.Label();
            this.seat6 = new System.Windows.Forms.Label();
            this.seat5 = new System.Windows.Forms.Label();
            this.seat8 = new System.Windows.Forms.Label();
            this.seat7 = new System.Windows.Forms.Label();
            this.seat10 = new System.Windows.Forms.Label();
            this.seat9 = new System.Windows.Forms.Label();
            this.seat12 = new System.Windows.Forms.Label();
            this.seat11 = new System.Windows.Forms.Label();
            this.seat14 = new System.Windows.Forms.Label();
            this.seat13 = new System.Windows.Forms.Label();
            this.seat16 = new System.Windows.Forms.Label();
            this.seat15 = new System.Windows.Forms.Label();
            this.seat18 = new System.Windows.Forms.Label();
            this.seat17 = new System.Windows.Forms.Label();
            this.seat20 = new System.Windows.Forms.Label();
            this.seat19 = new System.Windows.Forms.Label();
            this.seat22 = new System.Windows.Forms.Label();
            this.seat21 = new System.Windows.Forms.Label();
            this.seat24 = new System.Windows.Forms.Label();
            this.seat23 = new System.Windows.Forms.Label();
            this.seat26 = new System.Windows.Forms.Label();
            this.seat25 = new System.Windows.Forms.Label();
            this.seat28 = new System.Windows.Forms.Label();
            this.seat27 = new System.Windows.Forms.Label();
            this.seat30 = new System.Windows.Forms.Label();
            this.seat29 = new System.Windows.Forms.Label();
            this.seat32 = new System.Windows.Forms.Label();
            this.seat31 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.passangerListDataGrid)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // registerPassengerButton
            // 
            this.registerPassengerButton.Location = new System.Drawing.Point(23, 139);
            this.registerPassengerButton.Name = "registerPassengerButton";
            this.registerPassengerButton.Size = new System.Drawing.Size(75, 23);
            this.registerPassengerButton.TabIndex = 21;
            this.registerPassengerButton.Text = "Registrar";
            this.registerPassengerButton.UseVisualStyleBackColor = true;
            this.registerPassengerButton.Click += new System.EventHandler(this.registerPassengerButton_Click);
            // 
            // passangerListDataGrid
            // 
            this.passangerListDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.passangerListDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PassengerName,
            this.Id});
            this.passangerListDataGrid.Location = new System.Drawing.Point(23, 195);
            this.passangerListDataGrid.Name = "passangerListDataGrid";
            this.passangerListDataGrid.RowTemplate.Height = 25;
            this.passangerListDataGrid.Size = new System.Drawing.Size(274, 423);
            this.passangerListDataGrid.TabIndex = 20;
            // 
            // PassengerName
            // 
            this.PassengerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PassengerName.HeaderText = "Nombre";
            this.PassengerName.Name = "PassengerName";
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.remove3Btn);
            this.groupBox3.Controls.Add(this.change3Btn);
            this.groupBox3.Controls.Add(this.assign3Btn);
            this.groupBox3.Controls.Add(this.client3Txt);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.seat3Txt);
            this.groupBox3.Location = new System.Drawing.Point(645, 435);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(296, 184);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ventana 3";
            // 
            // remove3Btn
            // 
            this.remove3Btn.Location = new System.Drawing.Point(191, 141);
            this.remove3Btn.Name = "remove3Btn";
            this.remove3Btn.Size = new System.Drawing.Size(75, 23);
            this.remove3Btn.TabIndex = 9;
            this.remove3Btn.Text = "Eliminar";
            this.remove3Btn.UseVisualStyleBackColor = true;
            this.remove3Btn.Click += new System.EventHandler(this.remove3Btn_Click);
            // 
            // change3Btn
            // 
            this.change3Btn.Location = new System.Drawing.Point(106, 141);
            this.change3Btn.Name = "change3Btn";
            this.change3Btn.Size = new System.Drawing.Size(75, 23);
            this.change3Btn.TabIndex = 8;
            this.change3Btn.Text = "Cambiar";
            this.change3Btn.UseVisualStyleBackColor = true;
            this.change3Btn.Click += new System.EventHandler(this.change3Btn_Click);
            // 
            // assign3Btn
            // 
            this.assign3Btn.Location = new System.Drawing.Point(21, 141);
            this.assign3Btn.Name = "assign3Btn";
            this.assign3Btn.Size = new System.Drawing.Size(75, 23);
            this.assign3Btn.TabIndex = 7;
            this.assign3Btn.Text = "Reservar";
            this.assign3Btn.UseVisualStyleBackColor = true;
            this.assign3Btn.Click += new System.EventHandler(this.assign3Btn_Click);
            // 
            // client3Txt
            // 
            this.client3Txt.Location = new System.Drawing.Point(21, 53);
            this.client3Txt.Name = "client3Txt";
            this.client3Txt.Size = new System.Drawing.Size(245, 23);
            this.client3Txt.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "Cliente:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "Asiento:";
            // 
            // seat3Txt
            // 
            this.seat3Txt.Location = new System.Drawing.Point(21, 109);
            this.seat3Txt.Name = "seat3Txt";
            this.seat3Txt.Size = new System.Drawing.Size(245, 23);
            this.seat3Txt.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.remove2Btn);
            this.groupBox2.Controls.Add(this.change2Btn);
            this.groupBox2.Controls.Add(this.assign2Btn);
            this.groupBox2.Controls.Add(this.client2Txt);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.seat2Txt);
            this.groupBox2.Location = new System.Drawing.Point(645, 239);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 184);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ventana 2";
            // 
            // remove2Btn
            // 
            this.remove2Btn.Location = new System.Drawing.Point(191, 141);
            this.remove2Btn.Name = "remove2Btn";
            this.remove2Btn.Size = new System.Drawing.Size(75, 23);
            this.remove2Btn.TabIndex = 9;
            this.remove2Btn.Text = "Eliminar";
            this.remove2Btn.UseVisualStyleBackColor = true;
            this.remove2Btn.Click += new System.EventHandler(this.remove2Btn_Click);
            // 
            // change2Btn
            // 
            this.change2Btn.Location = new System.Drawing.Point(106, 141);
            this.change2Btn.Name = "change2Btn";
            this.change2Btn.Size = new System.Drawing.Size(75, 23);
            this.change2Btn.TabIndex = 8;
            this.change2Btn.Text = "Cambiar";
            this.change2Btn.UseVisualStyleBackColor = true;
            this.change2Btn.Click += new System.EventHandler(this.change2Btn_Click);
            // 
            // assign2Btn
            // 
            this.assign2Btn.Location = new System.Drawing.Point(21, 141);
            this.assign2Btn.Name = "assign2Btn";
            this.assign2Btn.Size = new System.Drawing.Size(75, 23);
            this.assign2Btn.TabIndex = 7;
            this.assign2Btn.Text = "Reservar";
            this.assign2Btn.UseVisualStyleBackColor = true;
            this.assign2Btn.Click += new System.EventHandler(this.assign2Btn_Click);
            // 
            // client2Txt
            // 
            this.client2Txt.Location = new System.Drawing.Point(21, 53);
            this.client2Txt.Name = "client2Txt";
            this.client2Txt.Size = new System.Drawing.Size(245, 23);
            this.client2Txt.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Cliente:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Asiento:";
            // 
            // seat2Txt
            // 
            this.seat2Txt.Location = new System.Drawing.Point(21, 109);
            this.seat2Txt.Name = "seat2Txt";
            this.seat2Txt.Size = new System.Drawing.Size(245, 23);
            this.seat2Txt.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.remove1Btn);
            this.groupBox1.Controls.Add(this.change1Btn);
            this.groupBox1.Controls.Add(this.assign1Btn);
            this.groupBox1.Controls.Add(this.client1Txt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.seat1Txt);
            this.groupBox1.Location = new System.Drawing.Point(645, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 184);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ventana 1";
            // 
            // remove1Btn
            // 
            this.remove1Btn.Location = new System.Drawing.Point(191, 141);
            this.remove1Btn.Name = "remove1Btn";
            this.remove1Btn.Size = new System.Drawing.Size(75, 23);
            this.remove1Btn.TabIndex = 9;
            this.remove1Btn.Text = "Eliminar";
            this.remove1Btn.UseVisualStyleBackColor = true;
            this.remove1Btn.Click += new System.EventHandler(this.remove1Btn_Click);
            // 
            // change1Btn
            // 
            this.change1Btn.Location = new System.Drawing.Point(106, 141);
            this.change1Btn.Name = "change1Btn";
            this.change1Btn.Size = new System.Drawing.Size(75, 23);
            this.change1Btn.TabIndex = 8;
            this.change1Btn.Text = "Cambiar";
            this.change1Btn.UseVisualStyleBackColor = true;
            this.change1Btn.Click += new System.EventHandler(this.change1Btn_Click);
            // 
            // assign1Btn
            // 
            this.assign1Btn.Location = new System.Drawing.Point(21, 141);
            this.assign1Btn.Name = "assign1Btn";
            this.assign1Btn.Size = new System.Drawing.Size(75, 23);
            this.assign1Btn.TabIndex = 7;
            this.assign1Btn.Text = "Reservar";
            this.assign1Btn.UseVisualStyleBackColor = true;
            this.assign1Btn.Click += new System.EventHandler(this.assign1Btn_Click);
            // 
            // client1Txt
            // 
            this.client1Txt.Location = new System.Drawing.Point(21, 53);
            this.client1Txt.Name = "client1Txt";
            this.client1Txt.Size = new System.Drawing.Size(245, 23);
            this.client1Txt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Asiento:";
            // 
            // seat1Txt
            // 
            this.seat1Txt.Location = new System.Drawing.Point(21, 109);
            this.seat1Txt.Name = "seat1Txt";
            this.seat1Txt.Size = new System.Drawing.Size(245, 23);
            this.seat1Txt.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nombre:";
            // 
            // passangerNameTextBox
            // 
            this.passangerNameTextBox.Location = new System.Drawing.Point(23, 106);
            this.passangerNameTextBox.Name = "passangerNameTextBox";
            this.passangerNameTextBox.Size = new System.Drawing.Size(274, 23);
            this.passangerNameTextBox.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "Reserva de Tickets";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(365, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 25);
            this.label5.TabIndex = 54;
            this.label5.Text = "Distribución de Asientos";
            // 
            // seat1
            // 
            this.seat1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.seat1.Location = new System.Drawing.Point(378, 195);
            this.seat1.Name = "seat1";
            this.seat1.Size = new System.Drawing.Size(32, 32);
            this.seat1.TabIndex = 55;
            this.seat1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // seat2
            // 
            this.seat2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.seat2.Location = new System.Drawing.Point(416, 195);
            this.seat2.Name = "seat2";
            this.seat2.Size = new System.Drawing.Size(32, 32);
            this.seat2.TabIndex = 56;
            this.seat2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // seat4
            // 
            this.seat4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.seat4.Location = new System.Drawing.Point(416, 233);
            this.seat4.Name = "seat4";
            this.seat4.Size = new System.Drawing.Size(32, 32);
            this.seat4.TabIndex = 58;
            this.seat4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // seat3
            // 
            this.seat3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.seat3.Location = new System.Drawing.Point(378, 233);
            this.seat3.Name = "seat3";
            this.seat3.Size = new System.Drawing.Size(32, 32);
            this.seat3.TabIndex = 57;
            this.seat3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // seat6
            // 
            this.seat6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.seat6.Location = new System.Drawing.Point(416, 273);
            this.seat6.Name = "seat6";
            this.seat6.Size = new System.Drawing.Size(32, 32);
            this.seat6.TabIndex = 60;
            this.seat6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // seat5
            // 
            this.seat5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.seat5.Location = new System.Drawing.Point(378, 273);
            this.seat5.Name = "seat5";
            this.seat5.Size = new System.Drawing.Size(32, 32);
            this.seat5.TabIndex = 59;
            this.seat5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // seat8
            // 
            this.seat8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.seat8.Location = new System.Drawing.Point(416, 311);
            this.seat8.Name = "seat8";
            this.seat8.Size = new System.Drawing.Size(32, 32);
            this.seat8.TabIndex = 62;
            this.seat8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // seat7
            // 
            this.seat7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.seat7.Location = new System.Drawing.Point(378, 311);
            this.seat7.Name = "seat7";
            this.seat7.Size = new System.Drawing.Size(32, 32);
            this.seat7.TabIndex = 61;
            this.seat7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // seat10
            // 
            this.seat10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.seat10.Location = new System.Drawing.Point(416, 350);
            this.seat10.Name = "seat10";
            this.seat10.Size = new System.Drawing.Size(32, 32);
            this.seat10.TabIndex = 64;
            this.seat10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // seat9
            // 
            this.seat9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.seat9.Location = new System.Drawing.Point(378, 350);
            this.seat9.Name = "seat9";
            this.seat9.Size = new System.Drawing.Size(32, 32);
            this.seat9.TabIndex = 63;
            this.seat9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // seat12
            // 
            this.seat12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.seat12.Location = new System.Drawing.Point(416, 391);
            this.seat12.Name = "seat12";
            this.seat12.Size = new System.Drawing.Size(32, 32);
            this.seat12.TabIndex = 66;
            this.seat12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // seat11
            // 
            this.seat11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.seat11.Location = new System.Drawing.Point(378, 391);
            this.seat11.Name = "seat11";
            this.seat11.Size = new System.Drawing.Size(32, 32);
            this.seat11.TabIndex = 65;
            this.seat11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // seat14
            // 
            this.seat14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.seat14.Location = new System.Drawing.Point(416, 429);
            this.seat14.Name = "seat14";
            this.seat14.Size = new System.Drawing.Size(32, 32);
            this.seat14.TabIndex = 68;
            this.seat14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // seat13
            // 
            this.seat13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.seat13.Location = new System.Drawing.Point(378, 429);
            this.seat13.Name = "seat13";
            this.seat13.Size = new System.Drawing.Size(32, 32);
            this.seat13.TabIndex = 67;
            this.seat13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // seat16
            // 
            this.seat16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.seat16.Location = new System.Drawing.Point(416, 468);
            this.seat16.Name = "seat16";
            this.seat16.Size = new System.Drawing.Size(32, 32);
            this.seat16.TabIndex = 70;
            this.seat16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // seat15
            // 
            this.seat15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.seat15.Location = new System.Drawing.Point(378, 468);
            this.seat15.Name = "seat15";
            this.seat15.Size = new System.Drawing.Size(32, 32);
            this.seat15.TabIndex = 69;
            this.seat15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // seat18
            // 
            this.seat18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.seat18.Location = new System.Drawing.Point(530, 195);
            this.seat18.Name = "seat18";
            this.seat18.Size = new System.Drawing.Size(32, 32);
            this.seat18.TabIndex = 72;
            this.seat18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // seat17
            // 
            this.seat17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.seat17.Location = new System.Drawing.Point(492, 195);
            this.seat17.Name = "seat17";
            this.seat17.Size = new System.Drawing.Size(32, 32);
            this.seat17.TabIndex = 71;
            this.seat17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // seat20
            // 
            this.seat20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.seat20.Location = new System.Drawing.Point(530, 233);
            this.seat20.Name = "seat20";
            this.seat20.Size = new System.Drawing.Size(32, 32);
            this.seat20.TabIndex = 74;
            this.seat20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // seat19
            // 
            this.seat19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.seat19.Location = new System.Drawing.Point(492, 233);
            this.seat19.Name = "seat19";
            this.seat19.Size = new System.Drawing.Size(32, 32);
            this.seat19.TabIndex = 73;
            this.seat19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // seat22
            // 
            this.seat22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.seat22.Location = new System.Drawing.Point(530, 273);
            this.seat22.Name = "seat22";
            this.seat22.Size = new System.Drawing.Size(32, 32);
            this.seat22.TabIndex = 76;
            this.seat22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // seat21
            // 
            this.seat21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.seat21.Location = new System.Drawing.Point(492, 273);
            this.seat21.Name = "seat21";
            this.seat21.Size = new System.Drawing.Size(32, 32);
            this.seat21.TabIndex = 75;
            this.seat21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // seat24
            // 
            this.seat24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.seat24.Location = new System.Drawing.Point(530, 311);
            this.seat24.Name = "seat24";
            this.seat24.Size = new System.Drawing.Size(32, 32);
            this.seat24.TabIndex = 78;
            this.seat24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // seat23
            // 
            this.seat23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.seat23.Location = new System.Drawing.Point(492, 311);
            this.seat23.Name = "seat23";
            this.seat23.Size = new System.Drawing.Size(32, 32);
            this.seat23.TabIndex = 77;
            this.seat23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // seat26
            // 
            this.seat26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.seat26.Location = new System.Drawing.Point(530, 350);
            this.seat26.Name = "seat26";
            this.seat26.Size = new System.Drawing.Size(32, 32);
            this.seat26.TabIndex = 80;
            this.seat26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // seat25
            // 
            this.seat25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.seat25.Location = new System.Drawing.Point(492, 350);
            this.seat25.Name = "seat25";
            this.seat25.Size = new System.Drawing.Size(32, 32);
            this.seat25.TabIndex = 79;
            this.seat25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // seat28
            // 
            this.seat28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.seat28.Location = new System.Drawing.Point(530, 391);
            this.seat28.Name = "seat28";
            this.seat28.Size = new System.Drawing.Size(32, 32);
            this.seat28.TabIndex = 82;
            this.seat28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // seat27
            // 
            this.seat27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.seat27.Location = new System.Drawing.Point(492, 391);
            this.seat27.Name = "seat27";
            this.seat27.Size = new System.Drawing.Size(32, 32);
            this.seat27.TabIndex = 81;
            this.seat27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // seat30
            // 
            this.seat30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.seat30.Location = new System.Drawing.Point(530, 429);
            this.seat30.Name = "seat30";
            this.seat30.Size = new System.Drawing.Size(32, 32);
            this.seat30.TabIndex = 84;
            this.seat30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // seat29
            // 
            this.seat29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.seat29.Location = new System.Drawing.Point(492, 429);
            this.seat29.Name = "seat29";
            this.seat29.Size = new System.Drawing.Size(32, 32);
            this.seat29.TabIndex = 83;
            this.seat29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // seat32
            // 
            this.seat32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.seat32.Location = new System.Drawing.Point(530, 468);
            this.seat32.Name = "seat32";
            this.seat32.Size = new System.Drawing.Size(32, 32);
            this.seat32.TabIndex = 86;
            this.seat32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // seat31
            // 
            this.seat31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.seat31.Location = new System.Drawing.Point(492, 468);
            this.seat31.Name = "seat31";
            this.seat31.Size = new System.Drawing.Size(32, 32);
            this.seat31.TabIndex = 85;
            this.seat31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 652);
            this.Controls.Add(this.seat32);
            this.Controls.Add(this.seat31);
            this.Controls.Add(this.seat30);
            this.Controls.Add(this.seat29);
            this.Controls.Add(this.seat28);
            this.Controls.Add(this.seat27);
            this.Controls.Add(this.seat26);
            this.Controls.Add(this.seat25);
            this.Controls.Add(this.seat24);
            this.Controls.Add(this.seat23);
            this.Controls.Add(this.seat22);
            this.Controls.Add(this.seat21);
            this.Controls.Add(this.seat20);
            this.Controls.Add(this.seat19);
            this.Controls.Add(this.seat18);
            this.Controls.Add(this.seat17);
            this.Controls.Add(this.seat16);
            this.Controls.Add(this.seat15);
            this.Controls.Add(this.seat14);
            this.Controls.Add(this.seat13);
            this.Controls.Add(this.seat12);
            this.Controls.Add(this.seat11);
            this.Controls.Add(this.seat10);
            this.Controls.Add(this.seat9);
            this.Controls.Add(this.seat8);
            this.Controls.Add(this.seat7);
            this.Controls.Add(this.seat6);
            this.Controls.Add(this.seat5);
            this.Controls.Add(this.seat4);
            this.Controls.Add(this.seat3);
            this.Controls.Add(this.seat2);
            this.Controls.Add(this.seat1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.registerPassengerButton);
            this.Controls.Add(this.passangerListDataGrid);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passangerNameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "MainView";
            this.Text = "MainView";
            ((System.ComponentModel.ISupportInitialize)(this.passangerListDataGrid)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button registerPassengerButton;
        private DataGridView passangerListDataGrid;
        private GroupBox groupBox3;
        private Button remove3Btn;
        private Button change3Btn;
        private Button assign3Btn;
        private TextBox client3Txt;
        private Label label8;
        private Label label9;
        private TextBox seat3Txt;
        private GroupBox groupBox2;
        private Button remove2Btn;
        private Button change2Btn;
        private Button assign2Btn;
        private TextBox client2Txt;
        private Label label6;
        private Label label7;
        private TextBox seat2Txt;
        private GroupBox groupBox1;
        private Button remove1Btn;
        private Button change1Btn;
        private Button assign1Btn;
        private TextBox client1Txt;
        private Label label3;
        private Label label4;
        private TextBox seat1Txt;
        private Label label2;
        private TextBox passangerNameTextBox;
        private Label label1;
        private DataGridViewTextBoxColumn PassengerName;
        private DataGridViewTextBoxColumn Id;
        private Label label5;
        private Label seat1;
        private Label seat2;
        private Label seat4;
        private Label seat3;
        private Label seat6;
        private Label seat5;
        private Label seat8;
        private Label seat7;
        private Label seat10;
        private Label seat9;
        private Label seat12;
        private Label seat11;
        private Label seat14;
        private Label seat13;
        private Label seat16;
        private Label seat15;
        private Label seat18;
        private Label seat17;
        private Label seat20;
        private Label seat19;
        private Label seat22;
        private Label seat21;
        private Label seat24;
        private Label seat23;
        private Label seat26;
        private Label seat25;
        private Label seat28;
        private Label seat27;
        private Label seat30;
        private Label seat29;
        private Label seat32;
        private Label seat31;
    }
}