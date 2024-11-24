using Kursobaya.Storage.DataBase;
using Kursobaya.Storage.Models;
using Kursobaya.Storage.Repository;


namespace Kursovaya_DataBases
{
    public partial class Form1 : Form
    {
        private readonly MyDbContext _context;
        private readonly DetailRepository _detailRepository;
        private readonly UnitRepository _unitRepository;
        private Unit _unit;
        private Detail _detail;
        private Reliability _reliability;
        private bool isNewUint;
        public Form1()
        {
            InitializeComponent();
            label9.Visible = false;
            label17.Visible = false;
            label20.Visible = false;
            ResultQH.Visible = false;
            ResultQHP.Visible = false;
            textBoxResult.Visible = false;
            SaveBut.Enabled = false;
            text_isSaved.Visible = false;
            ResultCodeDetail.Visible = false;
            ResultCodeUnitText.Visible = false;
            textBoxUnitCode.Visible = false;
            textDetailCode.Visible = false;

            isNewUint = true;

            _context = new MyDbContext();
            _detailRepository = new DetailRepository();
            _unitRepository = new UnitRepository();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await LoadUnitsAsync();
        }

        private async Task LoadUnitsAsync()
        {
            UnitCodeBox.Items.Clear();
            var codes = _unitRepository.GetAllUnitsCodes(_context);
            UnitCodeBox.Items.Add("Новая");
            foreach(var code in codes)
            {
                UnitCodeBox.Items.Add(code.ToString());
            }

            if (UnitCodeBox.Items.Count > 0 && isNewUint)
            {
                UnitCodeBox.SelectedIndex = 0;
                isNewUint = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void CoefFt_TextChanged(object sender, EventArgs e)
        {

        }

        private void CoefEa_TextChanged(object sender, EventArgs e)
        {

        }

        private void typeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = BoxZubie.Text;
            labelKhv.Visible = false;
            BoxKhv.Visible = false;
            labelKha.Visible = false;
            BoxKha.Visible = false;

            switch (type)
            {
                case "Прямозубая":
                    break;

                case "Коническая":
                    break;

                case "Круговые":
                    labelKhv.Visible = true;
                    BoxKhv.Visible = true;
                    labelKha.Visible = true;
                    BoxKha.Visible = true;
                    break;

                case "Тангенциальные":

                    labelKha.Visible = true;
                    BoxKha.Visible = true;
                    break;
            }
        }


        private async void button1_Click(object sender, EventArgs e)
        {

            TextBox[] textBoxes = { CoefEa, textFt, CoefVm, CountOfU, BoxWeight, textRe, textDm1, textKhl };
            ComboBox[] comboBoxes = { BoxZubie, BoxDeltaH, BoxZh, BoxZm, BoxSigma, Boxg0, BoxKhb, BoxKha, BoxKhv };

            fill_empty_textBoxes(textBoxes);
            fill_empty_ComboBox(comboBoxes);



            Unit unit = new Unit();
            Detail detail = new Detail();
            Reliability reliability = new Reliability();

            string unitCode = Convert.ToString(UnitCodeBox.Text);

            if(unitCode == "Новая")
            {
                isNewUint = true;
                unit.UnitCode = Guid.NewGuid();
                unit.Ft = Convert.ToDouble(textFt.Text);
                unit.Khb = Convert.ToDouble(BoxKhb.Text);
                unit.Ea = Convert.ToDouble(CoefEa.Text);
                unit.b = Convert.ToDouble(BoxWeight.Text);
                unit.g0 = Convert.ToDouble(Boxg0.Text);
                unit.Re = Convert.ToDouble(textRe.Text);
            }
            else
            {
                isNewUint = false;
                Guid code = new Guid(unitCode);
                unit = _unitRepository.GetUnitById(_context, code);
            }

            detail.DetailCode = Guid.NewGuid();
            detail.UnitCode = unit.UnitCode;
            detail.DetailType = BoxZubie.Text;
            detail.U = Convert.ToDouble(CountOfU.Text);
            detail.dm1 = Convert.ToDouble(textDm1.Text);
            detail.Zh = Convert.ToDouble(BoxZh.Text);
            detail.Zm = Convert.ToDouble(BoxZm.Text);
            detail.Khl = Convert.ToDouble(textKhl.Text);
            detail.sigma = Convert.ToDouble(BoxSigma.Text);
            detail.delta_h = Convert.ToDouble(BoxDeltaH.Text);
            detail.Vm = Convert.ToDouble(CoefVm.Text);


            Calc(ref unit, ref detail);

            label9.Visible = true;
            label17.Visible = true;
            label20.Visible = true;
            ResultQH.Visible = true;
            ResultQHP.Visible = true;
            textBoxResult.Visible = true;
            SaveBut.Enabled = true;
            text_isSaved.Text = "";
            ResultCodeDetail.Visible = true;
            ResultCodeUnitText.Visible = true;
            textBoxUnitCode.Visible = true;
            textDetailCode.Visible = true;

            ResultQH.Text = Convert.ToString(unit.SigmaH);
            ResultQHP.Text = Convert.ToString(unit.SigmaHP);

            if (unit.SigmaH <= unit.SigmaHP)
            {
                reliability.dost = "Полученный расчет является правильным";
            }
            else
            {
                reliability.dost = "Полученный расчет имеет нарушения";
            }
            reliability.UnitCode = unit.UnitCode;
            reliability.DetailCode = detail.DetailCode;
            textBoxResult.Text = reliability.dost;
            textBoxUnitCode.Text = unit.UnitCode.ToString();
            textDetailCode.Text = detail.DetailCode.ToString();

            _unit = unit;
            _detail = detail;
            _reliability = reliability;
        }
        private void fill_empty_textBoxes(TextBox[] textBoxes)
        {
            for (int i = 0; i < textBoxes.Length; i++)
            {
                if (string.IsNullOrEmpty(textBoxes[i].Text))
                {
                    textBoxes[i].Text = "1,00";
                }
            }
        }

        private void fill_empty_ComboBox(ComboBox[] comboBoxes)
        {
            for (int i = 0; i < comboBoxes.Length; i++)
            {
                if (comboBoxes[i].SelectedItem == null)
                {
                    comboBoxes[i].SelectedIndex = 0;
                }
            }
        }

        private void Calc(ref Unit unit, ref Detail detail)
        {
            double ze = 0;
            switch (detail.DetailType)
            {
                case "Прямозубые":
                    unit.Kha = 1;
                    unit.Khv = searchKhv(unit, detail);
                    ze = Math.Sqrt((4 - unit.Ea) / 3);
                    break;

                case "Конические":
                    unit.Kha = 1;
                    unit.Khv = searchKhv(unit, detail);
                    ze = Math.Sqrt((4 - unit.Ea) / 3);
                    break;

                case "Круговые":
                    unit.Kha = Convert.ToDouble(BoxKha.Text);
                    unit.Khv = Convert.ToDouble(BoxKhb.Text);
                    ze = Math.Sqrt(1 / unit.Ea);
                    break;


                case "Тангенциальные":
                    unit.Kha = Convert.ToDouble(BoxKha.Text);
                    unit.Khv = searchKhv(unit, detail);
                    ze = Math.Sqrt(1 / unit.Ea);
                    break;
            }

            unit.Kh = unit.Kha * unit.Khb * unit.Khv;
            unit.SigmaH = detail.Zh * detail.Zm * ze * Math.Sqrt(unit.Ft * unit.Kh * Math.Sqrt(detail.U * detail.U + 1 / (0.85 * unit.b * detail.dm1 * detail.U))); //se
            unit.SigmaHP = detail.sigma * detail.Khl;
        }

        private double searchKhv(Unit unit, Detail detail)
        {
            double OmegaHT;
            double result;
            OmegaHT = (unit.Ft * unit.Kha * unit.Khb) / unit.b;
            double OmegaHV = detail.delta_h * unit.g0 * detail.Vm * Math.Sqrt((unit.Re - 0.5 * unit.b) / detail.U);
            result = 1 + OmegaHV / OmegaHT;
            return result;
        }

        private void SaveResult()
        {
            _detailRepository.AddToDataBase(_context, _detail);
            if(isNewUint)
            _unitRepository.AddToDataBase(_context, _unit);
            _context.Reliabilitys.Add(_reliability);
            _context.SaveChanges();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _context.Dispose();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            text_isSaved.Visible = true;
            try
            {
                SaveResult();
                text_isSaved.Text = "Успешно";
                await LoadUnitsAsync();
            }
            catch (Exception ex)
            {
                text_isSaved.Text = "Не сохранилось";
            }
            SaveBut.Enabled = false;
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void UnitCodeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var code = UnitCodeBox.Text;
            if (code != "Новая")
            {
                isNewUint = true;
                var unit = _unitRepository.GetUnitById(_context, new Guid(code));
                textFt.Text = Convert.ToString(unit.Ft);
                BoxKhb.Text = Convert.ToString(unit.Khb);
                CoefEa.Text = Convert.ToString(unit.Ea);
                BoxWeight.Text = Convert.ToString(unit.b);
                Boxg0.Text = Convert.ToString(unit.g0);
                textRe.Text = Convert.ToString(unit.Re);
                textBoxUnitCode.Text = code;

                textFt.Enabled = false;
                BoxKhb.Enabled = false;
                CoefEa.Enabled = false;
                BoxWeight.Enabled = false;
                Boxg0.Enabled = false;
                textRe.Enabled = false;
            }
            else
            {
                isNewUint = false;
                textFt.Enabled = true;
                BoxKhb.Enabled = true;
                CoefEa.Enabled = true;
                BoxWeight.Enabled = true;
                Boxg0.Enabled = true;
                textRe.Enabled = true;

                textFt.Text = "";
                BoxKhb.Text = "";
                CoefEa.Text = "";
                BoxWeight.Text = "";
                Boxg0.Text = "";
                textRe.Text = "";
                textBoxUnitCode.Text = "";
            }
        }
    }
}
