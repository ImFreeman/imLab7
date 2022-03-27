using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Form1 : Form
    {
        private bool _firstLaunch = false;
        private PoliceDepartment _policeDepartment;
        public Form1()
        {
            InitializeComponent();
        }

        private void NextMonth_Click(object sender, EventArgs e)
        {
            if(!_firstLaunch)
            {
                var button = sender as Button;
                button.Text = "След. месяц";

                _policeDepartment = new PoliceDepartment(
                    Convert.ToDouble(StartBudget.Value),
                    Convert.ToInt32(StartPopulation.Value)
                    );
                _policeDepartment.WorkUpdate();
                _firstLaunch = true;
            }
            else
            {
                _policeDepartment.WorkUpdate();
            }
            chart1.Series[0].Points.AddXY(_policeDepartment.MounthOfWork, _policeDepartment.ClosedDeals);
        }
    }    

    public class PoliceDepartment
    {
        private double _budget;
        private double _lifeQuality;
        private int _population;
        private int _mounthOfWork;

        private int _incidents;        
        private int _arrests;
        private int _closedDeals;
        private double _amountOfFines;

        private int _staff;
        private int _detectives;
        private int _patrols;
        private int _preventions;        

        private Random _random = new Random();

        public int ClosedDeals => _closedDeals;
        public int MounthOfWork => _mounthOfWork;

        /// <summary>
        /// Полицейский участок
        /// </summary>
        /// <param name="budget">Бюджет</param>
        public PoliceDepartment(double budget, int population)
        {
            _budget = budget;
            _population = population;
            //вычисление количества сотрудников
            //разделение сотрудников на детективов, патрули и политруков
        }

        private void CityDataUpdate()
        {
            //var dif = _random.Next(0, Convert.ToInt32(Convert.ToDouble(_population) * 0.1f));
            //Популяция растет на рандомное число процентов(от -10% до 10%)
            //На тот же процент растет бюджет
            //ПОлитруки влияют на качество жизни
            //Качество жизни растет на рандомное число процентов(от -10% до 10%)
            //Вычисляется количество инцидентов
        }        

        public void WorkUpdate()
        {
            CityDataUpdate();
            //генерация арестов и штрафов, в зависомости от сотрудников
        }
    }

}
