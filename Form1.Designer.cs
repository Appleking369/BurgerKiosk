namespace BurgerKiosk
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblTitle = new Label();
            rdoHamBurger = new RadioButton();
            rdoBulgogiBurger = new RadioButton();
            rdoChickenBurger = new RadioButton();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            chkPotato = new CheckBox();
            chkSauce = new CheckBox();
            chkCheese = new CheckBox();
            chkCola = new CheckBox();
            grpMenu = new GroupBox();
            grpOption = new GroupBox();
            grpOrder = new GroupBox();
            lblTotalCost = new Label();
            lstOrder = new ListBox();
            btnOrder = new Button();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            grpOrder.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("맑은 고딕", 48F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblTitle.ForeColor = Color.Blue;
            lblTitle.Location = new Point(40, 33);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(595, 86);
            lblTitle.TabIndex = 9;
            lblTitle.Text = "버거 주문 키오스크";
            // 
            // rdoHamBurger
            // 
            rdoHamBurger.AutoSize = true;
            rdoHamBurger.Font = new Font("맑은 고딕", 20.25F);
            rdoHamBurger.Location = new Point(57, 213);
            rdoHamBurger.Name = "rdoHamBurger";
            rdoHamBurger.Size = new Size(116, 41);
            rdoHamBurger.TabIndex = 1;
            rdoHamBurger.TabStop = true;
            rdoHamBurger.Text = "햄버거";
            rdoHamBurger.UseVisualStyleBackColor = true;
            // 
            // rdoBulgogiBurger
            // 
            rdoBulgogiBurger.AutoSize = true;
            rdoBulgogiBurger.Font = new Font("맑은 고딕", 20.25F);
            rdoBulgogiBurger.Location = new Point(57, 338);
            rdoBulgogiBurger.Name = "rdoBulgogiBurger";
            rdoBulgogiBurger.Size = new Size(170, 41);
            rdoBulgogiBurger.TabIndex = 2;
            rdoBulgogiBurger.TabStop = true;
            rdoBulgogiBurger.Text = "불고기버거";
            rdoBulgogiBurger.UseVisualStyleBackColor = true;
            // 
            // rdoChickenBurger
            // 
            rdoChickenBurger.AutoSize = true;
            rdoChickenBurger.Font = new Font("맑은 고딕", 20.25F);
            rdoChickenBurger.Location = new Point(57, 463);
            rdoChickenBurger.Name = "rdoChickenBurger";
            rdoChickenBurger.Size = new Size(143, 41);
            rdoChickenBurger.TabIndex = 3;
            rdoChickenBurger.TabStop = true;
            rdoChickenBurger.Text = "치킨버거";
            rdoChickenBurger.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(251, 180);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(154, 104);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(251, 310);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(154, 104);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(251, 440);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(154, 104);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // chkPotato
            // 
            chkPotato.AutoSize = true;
            chkPotato.Font = new Font("맑은 고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            chkPotato.Location = new Point(473, 211);
            chkPotato.Name = "chkPotato";
            chkPotato.Size = new Size(116, 34);
            chkPotato.TabIndex = 4;
            chkPotato.Text = "감자튀김\r\n";
            chkPotato.UseVisualStyleBackColor = true;
            // 
            // chkSauce
            // 
            chkSauce.AutoSize = true;
            chkSauce.Font = new Font("맑은 고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            chkSauce.Location = new Point(473, 400);
            chkSauce.Name = "chkSauce";
            chkSauce.Size = new Size(123, 34);
            chkSauce.TabIndex = 7;
            chkSauce.Text = "소스 추가";
            chkSauce.UseVisualStyleBackColor = true;
            // 
            // chkCheese
            // 
            chkCheese.AutoSize = true;
            chkCheese.Font = new Font("맑은 고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            chkCheese.Location = new Point(473, 337);
            chkCheese.Name = "chkCheese";
            chkCheese.Size = new Size(123, 34);
            chkCheese.TabIndex = 6;
            chkCheese.Text = "치즈 추가";
            chkCheese.UseVisualStyleBackColor = true;
            // 
            // chkCola
            // 
            chkCola.AutoSize = true;
            chkCola.Font = new Font("맑은 고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            chkCola.Location = new Point(473, 274);
            chkCola.Name = "chkCola";
            chkCola.Size = new Size(74, 34);
            chkCola.TabIndex = 5;
            chkCola.Text = "콜라";
            chkCola.UseVisualStyleBackColor = true;
            // 
            // grpMenu
            // 
            grpMenu.Font = new Font("맑은 고딕", 24F, FontStyle.Regular, GraphicsUnit.Point, 129);
            grpMenu.ForeColor = Color.Red;
            grpMenu.Location = new Point(40, 141);
            grpMenu.Name = "grpMenu";
            grpMenu.Size = new Size(382, 430);
            grpMenu.TabIndex = 10;
            grpMenu.TabStop = false;
            grpMenu.Text = "메뉴 선택";
            // 
            // grpOption
            // 
            grpOption.Font = new Font("맑은 고딕", 24F, FontStyle.Regular, GraphicsUnit.Point, 129);
            grpOption.ForeColor = Color.Red;
            grpOption.Location = new Point(452, 141);
            grpOption.Name = "grpOption";
            grpOption.Size = new Size(203, 324);
            grpOption.TabIndex = 11;
            grpOption.TabStop = false;
            grpOption.Text = "추가 옵션";
            // 
            // grpOrder
            // 
            grpOrder.Controls.Add(lblTotalCost);
            grpOrder.Controls.Add(lstOrder);
            grpOrder.Font = new Font("맑은 고딕", 24F, FontStyle.Regular, GraphicsUnit.Point, 129);
            grpOrder.ForeColor = Color.Red;
            grpOrder.Location = new Point(681, 141);
            grpOrder.Name = "grpOrder";
            grpOrder.Size = new Size(334, 382);
            grpOrder.TabIndex = 12;
            grpOrder.TabStop = false;
            grpOrder.Text = "주문 내역";
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.ForeColor = Color.Blue;
            lblTotalCost.Location = new Point(17, 322);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(145, 45);
            lblTotalCost.TabIndex = 0;
            lblTotalCost.Text = "총 금액: ";
            // 
            // lstOrder
            // 
            lstOrder.Font = new Font("맑은 고딕", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lstOrder.FormattingEnabled = true;
            lstOrder.Location = new Point(21, 63);
            lstOrder.Name = "lstOrder";
            lstOrder.Size = new Size(293, 244);
            lstOrder.TabIndex = 0;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.Lime;
            btnOrder.Font = new Font("맑은 고딕", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnOrder.ForeColor = Color.Transparent;
            btnOrder.Location = new Point(681, 541);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(162, 55);
            btnOrder.TabIndex = 0;
            btnOrder.Text = "주문하기";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Red;
            btnClear.Font = new Font("맑은 고딕", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnClear.ForeColor = Color.Transparent;
            btnClear.Location = new Point(853, 541);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(162, 55);
            btnClear.TabIndex = 8;
            btnClear.Text = "초기화";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 631);
            Controls.Add(btnClear);
            Controls.Add(btnOrder);
            Controls.Add(chkCola);
            Controls.Add(chkCheese);
            Controls.Add(chkSauce);
            Controls.Add(chkPotato);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(rdoChickenBurger);
            Controls.Add(rdoBulgogiBurger);
            Controls.Add(rdoHamBurger);
            Controls.Add(lblTitle);
            Controls.Add(grpMenu);
            Controls.Add(grpOption);
            Controls.Add(grpOrder);
            Name = "Form1";
            Text = "Burger Kiosk v1.0";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            grpOrder.ResumeLayout(false);
            grpOrder.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private RadioButton rdoHamBurger;
        private RadioButton rdoBulgogiBurger;
        private RadioButton rdoChickenBurger;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private CheckBox chkPotato;
        private CheckBox chkSauce;
        private CheckBox chkCheese;
        private CheckBox chkCola;
        private GroupBox grpMenu;
        private GroupBox grpOption;
        private GroupBox grpOrder;
        private Label lblTotalCost;
        private ListBox lstOrder;
        private Button btnOrder;
        private Button btnClear;
    }
}
