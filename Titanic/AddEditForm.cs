using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Titanic
{
    public partial class AddEditForm : Form
    {
        public AddEditForm()
        {
            InitializeComponent();
        }

        private void AddEditForm_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public AddEditForm(Titanic titanic)
        {
            InitializeComponent();
            comboBoxSurvived.Text = titanic.Survived.ToString();
            comboBoxClass.Text = titanic.Pclass.ToString();
            textBoxName.Text = titanic.Passenger.ToString();
            comboBoxSex.Text = titanic.Sex.ToString();
            numericUpDownAge.Value = titanic.Age ?? 0;
            numericUpDownSibsp.Value = titanic.Sibsp;
            numericUpDownParch.Value = titanic.Parch;
            textBoxTicket.Text = titanic.Ticket;
            textBoxFare.Text = titanic.Fare.ToString();
            textBoxCabin.Text = titanic.Cabin!.ToString();
            comboBoxEmbarce.Text = titanic.Embarket.ToString();
        }

        //private void comboBoxSurvived_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}
    }
}
