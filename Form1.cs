namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int totalCost { get; private set; }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (rdoHamBurger.Checked)
            {
                totalCost += 5000;
                lstOrder.Items.Add("햄버거 5,000원");
            }
            else if (rdoBulgogiBurger.Checked)
            {
                totalCost += 4000;
                lstOrder.Items.Add("불고기버거 4,000원");
            }
            else if (rdoChickenBurger.Checked)
            {
                totalCost += 3000;
                lstOrder.Items.Add("치킨버거 3,000원");
            }
            if (chkPotato.Checked)
            {
                totalCost += 3500;
                lstOrder.Items.Add("감자튀김 3,500원");
            }
            if (chkCola.Checked)
            {
                totalCost += 2500;
                lstOrder.Items.Add("콜라 2,500원");
            }
            if (chkCheese.Checked)
            {
                totalCost += 1500;
                lstOrder.Items.Add("치즈추가 1,500원");
            }
            if (chkSauce.Checked)
            {
                totalCost += 500;
                lstOrder.Items.Add("소스추가 500원");
            }
            lblTotalCost.ForeColor = Color.Blue;
            lblTotalCost.Text = "총 금액: " + totalCost.ToString("N0") + "원";

            if (!rdoHamBurger.Checked && !rdoBulgogiBurger.Checked && !rdoChickenBurger.Checked)
            {
                lblTotalCost.Text = "메뉴를 선택하세요.";
                lblTotalCost.ForeColor = Color.Red;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rdoHamBurger.Checked = false; 
            rdoBulgogiBurger.Checked = false; 
            rdoChickenBurger.Checked = false;

            chkPotato.Checked = false;
            chkCola.Checked = false; 
            chkCheese.Checked = false; 
            chkSauce.Checked = false; 

            lstOrder.Items.Clear(); 
            totalCost = 0;
            lblTotalCost.ForeColor = Color.Blue;
            lblTotalCost.Text = "총 금액: ";
        }
    }
}