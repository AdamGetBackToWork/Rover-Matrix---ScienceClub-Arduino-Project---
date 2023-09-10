namespace Arduino_GUI_AS
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LEDiterations = new System.Windows.Forms.Button();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.button_0 = new System.Windows.Forms.Button();
            this.button_1 = new System.Windows.Forms.Button();
            this.button_14 = new System.Windows.Forms.Button();
            this.button_15 = new System.Windows.Forms.Button();
            this.button_17 = new System.Windows.Forms.Button();
            this.button_16 = new System.Windows.Forms.Button();
            this.button_30 = new System.Windows.Forms.Button();
            this.button_31 = new System.Windows.Forms.Button();
            this.button_28 = new System.Windows.Forms.Button();
            this.button_29 = new System.Windows.Forms.Button();
            this.button_19 = new System.Windows.Forms.Button();
            this.button_18 = new System.Windows.Forms.Button();
            this.button_12 = new System.Windows.Forms.Button();
            this.button_13 = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_26 = new System.Windows.Forms.Button();
            this.button_27 = new System.Windows.Forms.Button();
            this.button_21 = new System.Windows.Forms.Button();
            this.button_20 = new System.Windows.Forms.Button();
            this.button_10 = new System.Windows.Forms.Button();
            this.button_11 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_24 = new System.Windows.Forms.Button();
            this.button_25 = new System.Windows.Forms.Button();
            this.button_23 = new System.Windows.Forms.Button();
            this.button_22 = new System.Windows.Forms.Button();
            this.button_8 = new System.Windows.Forms.Button();
            this.button_9 = new System.Windows.Forms.Button();
            this.button_7 = new System.Windows.Forms.Button();
            this.button_6 = new System.Windows.Forms.Button();
            this.button_send = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM4";
            // 
            // button1
            // 
            this.button1.AccessibleName = "pre1";
            this.button1.Location = new System.Drawing.Point(41, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Preset 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AccessibleName = "pre2";
            this.button2.Location = new System.Drawing.Point(122, 391);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Preset 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.AccessibleName = "offButton";
            this.button3.Location = new System.Drawing.Point(216, 391);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "OFF";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.AccessibleName = "TEST LED ON";
            this.button4.Location = new System.Drawing.Point(665, 379);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 47);
            this.button4.TabIndex = 3;
            this.button4.Text = "TEST LED ON";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.AccessibleName = "TEST LED OFF";
            this.button5.Location = new System.Drawing.Point(727, 379);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(61, 47);
            this.button5.TabIndex = 4;
            this.button5.Text = "TEST LED OFF";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(624, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 20);
            this.textBox1.TabIndex = 5;
            // 
            // LEDiterations
            // 
            this.LEDiterations.AccessibleName = "LED iterations";
            this.LEDiterations.Location = new System.Drawing.Point(503, 61);
            this.LEDiterations.Name = "LEDiterations";
            this.LEDiterations.Size = new System.Drawing.Size(89, 19);
            this.LEDiterations.TabIndex = 6;
            this.LEDiterations.Text = "Send iterations";
            this.LEDiterations.UseVisualStyleBackColor = true;
            this.LEDiterations.Click += new System.EventHandler(this.LEDiterations_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(800, 25);
            this.bindingNavigator1.TabIndex = 48;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // button_0
            // 
            this.button_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_0.ForeColor = System.Drawing.Color.Black;
            this.button_0.Location = new System.Drawing.Point(193, 124);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(40, 40);
            this.button_0.TabIndex = 46;
            this.button_0.UseVisualStyleBackColor = false;
            this.button_0.Click += new System.EventHandler(this.button_0_Click);
            // 
            // button_1
            // 
            this.button_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_1.Location = new System.Drawing.Point(239, 124);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(40, 40);
            this.button_1.TabIndex = 49;
            this.button_1.UseVisualStyleBackColor = false;
            this.button_1.Click += new System.EventHandler(this.button_1_Click);
            // 
            // button_14
            // 
            this.button_14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_14.Location = new System.Drawing.Point(239, 170);
            this.button_14.Name = "button_14";
            this.button_14.Size = new System.Drawing.Size(40, 40);
            this.button_14.TabIndex = 51;
            this.button_14.UseVisualStyleBackColor = false;
            this.button_14.Click += new System.EventHandler(this.button_14_Click);
            // 
            // button_15
            // 
            this.button_15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_15.ForeColor = System.Drawing.Color.Black;
            this.button_15.Location = new System.Drawing.Point(193, 170);
            this.button_15.Name = "button_15";
            this.button_15.Size = new System.Drawing.Size(40, 40);
            this.button_15.TabIndex = 50;
            this.button_15.UseVisualStyleBackColor = false;
            this.button_15.Click += new System.EventHandler(this.button_15_Click);
            // 
            // button_17
            // 
            this.button_17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_17.Location = new System.Drawing.Point(239, 216);
            this.button_17.Name = "button_17";
            this.button_17.Size = new System.Drawing.Size(40, 40);
            this.button_17.TabIndex = 53;
            this.button_17.UseVisualStyleBackColor = false;
            this.button_17.Click += new System.EventHandler(this.button_17_Click);
            // 
            // button_16
            // 
            this.button_16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_16.ForeColor = System.Drawing.Color.Black;
            this.button_16.Location = new System.Drawing.Point(193, 216);
            this.button_16.Name = "button_16";
            this.button_16.Size = new System.Drawing.Size(40, 40);
            this.button_16.TabIndex = 52;
            this.button_16.UseVisualStyleBackColor = false;
            this.button_16.Click += new System.EventHandler(this.button_16_Click);
            // 
            // button_30
            // 
            this.button_30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_30.Location = new System.Drawing.Point(239, 262);
            this.button_30.Name = "button_30";
            this.button_30.Size = new System.Drawing.Size(40, 40);
            this.button_30.TabIndex = 55;
            this.button_30.UseVisualStyleBackColor = false;
            this.button_30.Click += new System.EventHandler(this.button_30_Click);
            // 
            // button_31
            // 
            this.button_31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_31.ForeColor = System.Drawing.Color.Black;
            this.button_31.Location = new System.Drawing.Point(193, 262);
            this.button_31.Name = "button_31";
            this.button_31.Size = new System.Drawing.Size(40, 40);
            this.button_31.TabIndex = 54;
            this.button_31.UseVisualStyleBackColor = false;
            this.button_31.Click += new System.EventHandler(this.button_31_Click);
            // 
            // button_28
            // 
            this.button_28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_28.Location = new System.Drawing.Point(331, 262);
            this.button_28.Name = "button_28";
            this.button_28.Size = new System.Drawing.Size(40, 40);
            this.button_28.TabIndex = 63;
            this.button_28.UseVisualStyleBackColor = false;
            this.button_28.Click += new System.EventHandler(this.button_28_Click);
            // 
            // button_29
            // 
            this.button_29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_29.ForeColor = System.Drawing.Color.Black;
            this.button_29.Location = new System.Drawing.Point(285, 262);
            this.button_29.Name = "button_29";
            this.button_29.Size = new System.Drawing.Size(40, 40);
            this.button_29.TabIndex = 62;
            this.button_29.UseVisualStyleBackColor = false;
            this.button_29.Click += new System.EventHandler(this.button_29_Click);
            // 
            // button_19
            // 
            this.button_19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_19.Location = new System.Drawing.Point(331, 216);
            this.button_19.Name = "button_19";
            this.button_19.Size = new System.Drawing.Size(40, 40);
            this.button_19.TabIndex = 61;
            this.button_19.UseVisualStyleBackColor = false;
            this.button_19.Click += new System.EventHandler(this.button_19_Click);
            // 
            // button_18
            // 
            this.button_18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_18.ForeColor = System.Drawing.Color.Black;
            this.button_18.Location = new System.Drawing.Point(285, 216);
            this.button_18.Name = "button_18";
            this.button_18.Size = new System.Drawing.Size(40, 40);
            this.button_18.TabIndex = 60;
            this.button_18.UseVisualStyleBackColor = false;
            this.button_18.Click += new System.EventHandler(this.button_18_Click);
            // 
            // button_12
            // 
            this.button_12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_12.Location = new System.Drawing.Point(331, 170);
            this.button_12.Name = "button_12";
            this.button_12.Size = new System.Drawing.Size(40, 40);
            this.button_12.TabIndex = 59;
            this.button_12.UseVisualStyleBackColor = false;
            this.button_12.Click += new System.EventHandler(this.button_12_Click);
            // 
            // button_13
            // 
            this.button_13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_13.ForeColor = System.Drawing.Color.Black;
            this.button_13.Location = new System.Drawing.Point(285, 170);
            this.button_13.Name = "button_13";
            this.button_13.Size = new System.Drawing.Size(40, 40);
            this.button_13.TabIndex = 58;
            this.button_13.UseVisualStyleBackColor = false;
            this.button_13.Click += new System.EventHandler(this.button_13_Click);
            // 
            // button_3
            // 
            this.button_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_3.Location = new System.Drawing.Point(331, 124);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(40, 40);
            this.button_3.TabIndex = 57;
            this.button_3.UseVisualStyleBackColor = false;
            this.button_3.Click += new System.EventHandler(this.button_3_Click);
            // 
            // button_2
            // 
            this.button_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_2.ForeColor = System.Drawing.Color.Black;
            this.button_2.Location = new System.Drawing.Point(285, 124);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(40, 40);
            this.button_2.TabIndex = 56;
            this.button_2.UseVisualStyleBackColor = false;
            this.button_2.Click += new System.EventHandler(this.button_2_Click);
            // 
            // button_26
            // 
            this.button_26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_26.Location = new System.Drawing.Point(423, 262);
            this.button_26.Name = "button_26";
            this.button_26.Size = new System.Drawing.Size(40, 40);
            this.button_26.TabIndex = 71;
            this.button_26.UseVisualStyleBackColor = false;
            this.button_26.Click += new System.EventHandler(this.button_26_Click);
            // 
            // button_27
            // 
            this.button_27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_27.ForeColor = System.Drawing.Color.Black;
            this.button_27.Location = new System.Drawing.Point(377, 262);
            this.button_27.Name = "button_27";
            this.button_27.Size = new System.Drawing.Size(40, 40);
            this.button_27.TabIndex = 70;
            this.button_27.UseVisualStyleBackColor = false;
            this.button_27.Click += new System.EventHandler(this.button_27_Click);
            // 
            // button_21
            // 
            this.button_21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_21.Location = new System.Drawing.Point(423, 216);
            this.button_21.Name = "button_21";
            this.button_21.Size = new System.Drawing.Size(40, 40);
            this.button_21.TabIndex = 69;
            this.button_21.UseVisualStyleBackColor = false;
            this.button_21.Click += new System.EventHandler(this.button_21_Click);
            // 
            // button_20
            // 
            this.button_20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_20.ForeColor = System.Drawing.Color.Black;
            this.button_20.Location = new System.Drawing.Point(377, 216);
            this.button_20.Name = "button_20";
            this.button_20.Size = new System.Drawing.Size(40, 40);
            this.button_20.TabIndex = 68;
            this.button_20.UseVisualStyleBackColor = false;
            this.button_20.Click += new System.EventHandler(this.button_20_Click);
            // 
            // button_10
            // 
            this.button_10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_10.Location = new System.Drawing.Point(423, 170);
            this.button_10.Name = "button_10";
            this.button_10.Size = new System.Drawing.Size(40, 40);
            this.button_10.TabIndex = 67;
            this.button_10.UseVisualStyleBackColor = false;
            this.button_10.Click += new System.EventHandler(this.button_10_Click);
            // 
            // button_11
            // 
            this.button_11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_11.ForeColor = System.Drawing.Color.Black;
            this.button_11.Location = new System.Drawing.Point(377, 170);
            this.button_11.Name = "button_11";
            this.button_11.Size = new System.Drawing.Size(40, 40);
            this.button_11.TabIndex = 66;
            this.button_11.UseVisualStyleBackColor = false;
            this.button_11.Click += new System.EventHandler(this.button_11_Click);
            // 
            // button_5
            // 
            this.button_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_5.Location = new System.Drawing.Point(423, 124);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(40, 40);
            this.button_5.TabIndex = 65;
            this.button_5.UseVisualStyleBackColor = false;
            this.button_5.Click += new System.EventHandler(this.button_5_Click);
            // 
            // button_4
            // 
            this.button_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_4.ForeColor = System.Drawing.Color.Black;
            this.button_4.Location = new System.Drawing.Point(377, 124);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(40, 40);
            this.button_4.TabIndex = 64;
            this.button_4.UseVisualStyleBackColor = false;
            this.button_4.Click += new System.EventHandler(this.button_4_Click);
            // 
            // button_24
            // 
            this.button_24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_24.Location = new System.Drawing.Point(515, 262);
            this.button_24.Name = "button_24";
            this.button_24.Size = new System.Drawing.Size(40, 40);
            this.button_24.TabIndex = 79;
            this.button_24.UseVisualStyleBackColor = false;
            this.button_24.Click += new System.EventHandler(this.button_24_Click);
            // 
            // button_25
            // 
            this.button_25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_25.ForeColor = System.Drawing.Color.Black;
            this.button_25.Location = new System.Drawing.Point(469, 262);
            this.button_25.Name = "button_25";
            this.button_25.Size = new System.Drawing.Size(40, 40);
            this.button_25.TabIndex = 78;
            this.button_25.UseVisualStyleBackColor = false;
            this.button_25.Click += new System.EventHandler(this.button_25_Click);
            // 
            // button_23
            // 
            this.button_23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_23.Location = new System.Drawing.Point(515, 216);
            this.button_23.Name = "button_23";
            this.button_23.Size = new System.Drawing.Size(40, 40);
            this.button_23.TabIndex = 77;
            this.button_23.UseVisualStyleBackColor = false;
            this.button_23.Click += new System.EventHandler(this.button_23_Click);
            // 
            // button_22
            // 
            this.button_22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_22.ForeColor = System.Drawing.Color.Black;
            this.button_22.Location = new System.Drawing.Point(469, 216);
            this.button_22.Name = "button_22";
            this.button_22.Size = new System.Drawing.Size(40, 40);
            this.button_22.TabIndex = 76;
            this.button_22.UseVisualStyleBackColor = false;
            this.button_22.Click += new System.EventHandler(this.button_22_Click);
            // 
            // button_8
            // 
            this.button_8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_8.Location = new System.Drawing.Point(515, 170);
            this.button_8.Name = "button_8";
            this.button_8.Size = new System.Drawing.Size(40, 40);
            this.button_8.TabIndex = 75;
            this.button_8.UseVisualStyleBackColor = false;
            this.button_8.Click += new System.EventHandler(this.button_8_Click);
            // 
            // button_9
            // 
            this.button_9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_9.ForeColor = System.Drawing.Color.Black;
            this.button_9.Location = new System.Drawing.Point(469, 170);
            this.button_9.Name = "button_9";
            this.button_9.Size = new System.Drawing.Size(40, 40);
            this.button_9.TabIndex = 74;
            this.button_9.UseVisualStyleBackColor = false;
            this.button_9.Click += new System.EventHandler(this.button_9_Click);
            // 
            // button_7
            // 
            this.button_7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_7.Location = new System.Drawing.Point(515, 124);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(40, 40);
            this.button_7.TabIndex = 73;
            this.button_7.UseVisualStyleBackColor = false;
            this.button_7.Click += new System.EventHandler(this.button_7_Click);
            // 
            // button_6
            // 
            this.button_6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_6.ForeColor = System.Drawing.Color.Black;
            this.button_6.Location = new System.Drawing.Point(469, 124);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(40, 40);
            this.button_6.TabIndex = 72;
            this.button_6.UseVisualStyleBackColor = false;
            this.button_6.Click += new System.EventHandler(this.button_6_Click);
            // 
            // button_send
            // 
            this.button_send.Location = new System.Drawing.Point(650, 153);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(106, 43);
            this.button_send.TabIndex = 80;
            this.button_send.Text = "SEND DATA";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.button_24);
            this.Controls.Add(this.button_25);
            this.Controls.Add(this.button_23);
            this.Controls.Add(this.button_22);
            this.Controls.Add(this.button_8);
            this.Controls.Add(this.button_9);
            this.Controls.Add(this.button_7);
            this.Controls.Add(this.button_6);
            this.Controls.Add(this.button_26);
            this.Controls.Add(this.button_27);
            this.Controls.Add(this.button_21);
            this.Controls.Add(this.button_20);
            this.Controls.Add(this.button_10);
            this.Controls.Add(this.button_11);
            this.Controls.Add(this.button_5);
            this.Controls.Add(this.button_4);
            this.Controls.Add(this.button_28);
            this.Controls.Add(this.button_29);
            this.Controls.Add(this.button_19);
            this.Controls.Add(this.button_18);
            this.Controls.Add(this.button_12);
            this.Controls.Add(this.button_13);
            this.Controls.Add(this.button_3);
            this.Controls.Add(this.button_2);
            this.Controls.Add(this.button_30);
            this.Controls.Add(this.button_31);
            this.Controls.Add(this.button_17);
            this.Controls.Add(this.button_16);
            this.Controls.Add(this.button_14);
            this.Controls.Add(this.button_15);
            this.Controls.Add(this.button_1);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.button_0);
            this.Controls.Add(this.LEDiterations);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button LEDiterations;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Button button_0;
        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Button button_14;
        private System.Windows.Forms.Button button_15;
        private System.Windows.Forms.Button button_17;
        private System.Windows.Forms.Button button_16;
        private System.Windows.Forms.Button button_30;
        private System.Windows.Forms.Button button_31;
        private System.Windows.Forms.Button button_28;
        private System.Windows.Forms.Button button_29;
        private System.Windows.Forms.Button button_19;
        private System.Windows.Forms.Button button_18;
        private System.Windows.Forms.Button button_12;
        private System.Windows.Forms.Button button_13;
        private System.Windows.Forms.Button button_3;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Button button_26;
        private System.Windows.Forms.Button button_27;
        private System.Windows.Forms.Button button_21;
        private System.Windows.Forms.Button button_20;
        private System.Windows.Forms.Button button_10;
        private System.Windows.Forms.Button button_11;
        private System.Windows.Forms.Button button_5;
        private System.Windows.Forms.Button button_4;
        private System.Windows.Forms.Button button_24;
        private System.Windows.Forms.Button button_25;
        private System.Windows.Forms.Button button_23;
        private System.Windows.Forms.Button button_22;
        private System.Windows.Forms.Button button_8;
        private System.Windows.Forms.Button button_9;
        private System.Windows.Forms.Button button_7;
        private System.Windows.Forms.Button button_6;
        private System.Windows.Forms.Button button_send;
    }
}

