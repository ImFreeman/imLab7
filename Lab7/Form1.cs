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
            NumberOfIncidents.Text = _policeDepartment.Incidents.ToString();
            NumberOfStuff.Text = _policeDepartment.Staff.ToString();
            NumberOfArrests.Text = _policeDepartment.Arrests.ToString();
            AmountBudget.Text = _policeDepartment.Budget.ToString();
            AmountPopulation.Text = _policeDepartment.Population.ToString();
            AmoutOfFines.Text = _policeDepartment.AmountOfFines.ToString();
            chart1.Series[0].Points.AddXY(_policeDepartment.MounthOfWork, _policeDepartment.ClosedDeals);
            chart1.Series[1].Points.AddXY(_policeDepartment.MounthOfWork, _policeDepartment.Incidents);
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
        public int Incidents => _incidents;
        public int Arrests => _arrests;
        public double AmountOfFines => _amountOfFines;
        public int Staff => _staff;
        public int Population => _population;
        public double Budget => _budget;

        /// <summary>
        /// Полицейский участок
        /// </summary>
        /// <param name="budget">Бюджет</param>
        public PoliceDepartment(double budget, int population)
        {
            //Бюджет вычисляется в 1т.р
            _budget = budget;
            _population = population;
            //На каждого сотрудника в среднем выделяется 100т.р.
            _staff = Convert.ToInt32(_budget / 100);
            _detectives = Convert.ToInt32(_staff * 0.4);
            _patrols = Convert.ToInt32(_staff * 0.4);
            _preventions = Convert.ToInt32(_staff * 0.2);
            //Уровень безопасности/жизни равен единице, когда количество сотрудников полиции покрывает всю численность населения. В среднем один сотрудник эквивалентен 50 гражданам.
            _lifeQuality = _staff * 75.0 / _population;
        }

        private void CityDataUpdate()
        {
            //В зависимости от прироста населения прирост бюджета варьируется от -10% до 10%
            var dif = 1 + 0.2 * (_random.NextDouble() - 0.5);
            _population = Convert.ToInt32(dif * _population);
            _budget = Convert.ToInt32(dif * _budget);
            _staff = Convert.ToInt32(dif * _staff);
            _detectives = Convert.ToInt32(dif * _detectives);
            _patrols = Convert.ToInt32(dif * _patrols);
            _preventions = Convert.ToInt32(dif * _preventions);
            //
            var politQuality = 2.5 * _preventions / _population;
            //Качество жизни/безопасноти варьируется в пределах от -2.5% до 2.5% и увеличивается в зависимости от качества профилактики
            _lifeQuality += (0.05 * (_random.NextDouble() - 0.5)) + politQuality;
            _lifeQuality = _lifeQuality >= 1 ? 1 : _lifeQuality;
            //Количество инцидентов зависит от уровня жизни/безопасноти и населения. При максимальном показателе уровня жизни на каждые 500 человек происходит 1 инцидент
            _incidents = Convert.ToInt32(_population / _lifeQuality / 500);

            //Популяция растет на рандомное число процентов(от -10% до 10%)
            //На тот же процент растет бюджет
            //ПОлитруки влияют на качество жизни
            //Качество жизни растет на рандомное число процентов(от -10% до 10%)
            //Вычисляется количество инцидентов

            _mounthOfWork++;

        }

        public void WorkUpdate()
        {
            CityDataUpdate();

            _closedDeals = 0;
            _amountOfFines = 0;
            _arrests = 0;
            var prevIncidents = _incidents;

            //патрули
            var streetIncidents = Convert.ToInt32(0.25f * _incidents);
            _incidents -= (streetIncidents - _patrols) >= 0 ? _patrols : streetIncidents;

            //следователи
            
            var criminalIncidents = Convert.ToInt32(0.75f * prevIncidents);
            var incPerDet = criminalIncidents / _detectives;
            for(int i = 0; i < _detectives;i++)
            {
                for(int j = 0; j < incPerDet; j++)
                {
                    var chance = _random.NextDouble();
                    if(chance <= 0.5f)
                    {
                        _incidents--;                        
                    }
                }
            }
            for(int i = 0;i < (prevIncidents - _incidents); i++)
            {
                CloseDeal();
            }
            //генерация арестов и штрафов, в зависомости от сотрудников
        }

        private void CloseDeal()
        {
            int penalty = 0;
            var penaltyChance = _random.NextDouble();
            if(penaltyChance <= 0.5f)
            {
                penalty = _random.Next(500, 1000000);
                _amountOfFines += penalty;
                _budget += penalty;
            }
            if(penalty == 0)
            {
                _arrests++;
            }
            else 
            {
                var arrestChance = _random.NextDouble();
                if(arrestChance <= 0.5f)
                {
                    _arrests++;
                }
            }
            _closedDeals++;
        }
    }

}
