using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using LabaInformationTechologics.Bd;
using LabaInformationTechologics.Configurations;
using LabaInformationTechologics.Controllers;
using LabaInformationTechologics.BuisnesModels;
using LabaInformationTechologics.EntityModel;
namespace LabaInformationTechologics
{
    public partial class Form1 : Form
    {
        private Configuration _Config { get; set; }
        private ControllerUser _ControllerUser { get; set; }
        private Filtr _filtr;
        private BindingList<BuisnesModelUser> FiltreList { get; set; }
        private BindingList<BuisnesModelUser> ListUsers { get; set; }
        private Mappers.Mapper<BuisnesModelUser,EntityModel.EntityModelUser> _Mapper;
        public Form1(Configuration config)
        {
            _Config = config;
            _ControllerUser = _Config.ConfigureControllerUser();
            _Mapper = _Config.configureMapper<BuisnesModelUser, EntityModel.EntityModelUser>();
            ListUsers = new BindingList<BuisnesModelUser>();
            FiltreList = new BindingList<BuisnesModelUser>();
            _filtr = new Filtr();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var EntityUsers = _ControllerUser.getAll();
            if(EntityUsers != null)
            {
                foreach (var User in EntityUsers)
                {
                    
                    ListUsers.Add(_Mapper.Map(User));
                }
                dataGridUsers.DataSource = ListUsers;
            }
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_3(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_4(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_3(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var id = textIdForDelete.Text;
                if (id != String.Empty)
                {
                    _ControllerUser.Delete(int.Parse(id));
                    var user = ListUsers.FirstOrDefault(c=>c.Id == int.Parse(id));
                    ListUsers.Remove(user);
                }
                else
                {
                    MessageBox.Show("введите id элемента");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Source);
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var FIO = TextFio.Text;
                var Number = TextNumber.Text;
                var DateBirth = dateTimeDateBirth.Value.Date;
                var DateStart = dateTimeDate.Value.Date;
                
                if (FIO != String.Empty && Number != String.Empty)
                {
                    if((DateBirth > DateStart))
                    {
                        MessageBox.Show("Некоректно введена дата рождения или оступления");
                    }
                    else
                    {
                        
                        BuisnesModelUser buisnesUser = new BuisnesModelUser(ListUsers.Count + 1, FIO, Number, DateBirth, DateStart);
                        EntityModelUser user = _Mapper.Map(buisnesUser);

                        ListUsers.Add(buisnesUser);
                        
                        _ControllerUser.Add(user);
                    }
                }
                else
                {
                    MessageBox.Show("Заполните все поля");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
            }
        }

        private void AgeStart_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonFiltr_Click(object sender, EventArgs e)
        {
            var dateTimeBefore = dateTimeFiltrDateBefore.Value.Date;
            var dateTimeAfter = dateTimeFiltrDateAfter.Value.Date;
            var ageStart = AgeStart.Value;
            var ageEnd = AgeEnd.Value;
            if (dateTimeAfter > dateTimeBefore)
            {
                MessageBox.Show("Некоректно введена дата поступивших после или поступивших до");
                return;
            }
            if (ageStart > ageEnd)
            {
                MessageBox.Show("Некоректно введен интервал возраста");
                return;
            }
            var Users= _filtr.AddFilter(ListUsers,dateTimeAfter,dateTimeBefore,Decimal.ToInt32(ageStart),Decimal.ToInt32(ageEnd));
            FiltreList.Clear();
            foreach (var user in Users)
            {
                FiltreList.Add(user);
            }
            dataGridUsers.DataSource = FiltreList;

        }

        private void buttonDeleteFiltr_Click(object sender, EventArgs e)
        {
            var EntityUsers = _ControllerUser.getAll();
            ListUsers.Clear();
            if (EntityUsers != null)
            {
                foreach (var User in EntityUsers)
                {

                    ListUsers.Add(_Mapper.Map(User));
                }
                dataGridUsers.DataSource = ListUsers;
            }

        }

        private void AgeEnd_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimeFiltrDateBefore_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Forward_click(object sender, EventArgs e)
        {
            Form2 newform = new Form2(this);
            newform.Show();
        }
    }
}
