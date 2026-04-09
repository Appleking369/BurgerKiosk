namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // 실시간으로 선택 항목을 리스트에 반영하도록 이벤트 연결
            rdoHamBurger.CheckedChanged += SelectionChanged;
            rdoBulgogiBurger.CheckedChanged += SelectionChanged;
            rdoChickenBurger.CheckedChanged += SelectionChanged;

            chkPotato.CheckedChanged += SelectionChanged;
            chkCola.CheckedChanged += SelectionChanged;
            chkCheese.CheckedChanged += SelectionChanged;
            chkSauce.CheckedChanged += SelectionChanged;
            UpdateOrderList();
        }

        public int totalCost { get; private set; }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            // 현재 선택된 항목을 기반으로 실시간 합계가 이미 계산되어 있으므로,
            // 메뉴가 선택되지 않았다면 경고를 표시하고, 그렇지 않으면 주문 완료 메시지를 보여준다.
            if (!rdoHamBurger.Checked && !rdoBulgogiBurger.Checked && !rdoChickenBurger.Checked)
            {
                lblTotalCost.Text = "메뉴를 선택하세요.";
                lblTotalCost.ForeColor = Color.Red;
                return;
            }

           
        }

        private void SelectionChanged(object? sender, EventArgs e)
        {
            UpdateOrderList();
        }

        private void UpdateOrderList()
        {
            lstOrder.Items.Clear();
            int currentTotal = 0;

            if (rdoHamBurger.Checked)
            {
                lstOrder.Items.Add("햄버거 5,000원");
                currentTotal += 5000;
            }
            else if (rdoBulgogiBurger.Checked)
            {
                lstOrder.Items.Add("불고기버거 4,000원");
                currentTotal += 4000;
            }
            else if (rdoChickenBurger.Checked)
            {
                lstOrder.Items.Add("치킨버거 3,000원");
                currentTotal += 3000;
            }

            if (chkPotato.Checked)
            {
                lstOrder.Items.Add("감자튀김 3,500원");
                currentTotal += 3500;
            }
            if (chkCola.Checked)
            {
                lstOrder.Items.Add("콜라 2,500원");
                currentTotal += 2500;
            }
            if (chkCheese.Checked)
            {
                lstOrder.Items.Add("치즈추가 1,500원");
                currentTotal += 1500;
            }
            if (chkSauce.Checked)
            {
                lstOrder.Items.Add("소스추가 500원");
                currentTotal += 500;
            }

            totalCost = currentTotal;
            if (!rdoHamBurger.Checked && !rdoBulgogiBurger.Checked && !rdoChickenBurger.Checked)
            {
                lblTotalCost.Text = "메뉴를 선택하세요.";
                lblTotalCost.ForeColor = Color.Red;
            }
            else
            {
                lblTotalCost.ForeColor = Color.Blue;
                lblTotalCost.Text = "총 금액: " + totalCost.ToString("N0") + "원";
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
            lblTotalCost.Text = "총 금액: 0원";
        }
    }
}