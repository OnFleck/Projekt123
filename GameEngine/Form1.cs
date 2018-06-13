using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameEngine
{
    public partial class Form1 : Form
    {
        static int x, PlayerShootSpeed, rndzahl = 1;
        


        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.sC.IsSplitterFixed = true;
        }


        private void sC_Panel2_MouseClick(object sender, MouseEventArgs e)
        {
            sC.Panel2.BackgroundImage = null;
        }


        private void rBCustom_CheckedChanged(object sender, EventArgs e)
        {
            if (rBCustom.Checked)
            {
                comboBoxFarbe.Text = "White";
                pBSModel.Image = null;
                pBModel.Image = null;

            }
        }

        private void rBSpaceInvaders_CheckedChanged(object sender, EventArgs e)
        {
            if (rBSpaceInvaders.Checked)
            {
                //Model
                tBPositionX.Text = "325";//680/2 - 25
                tBPositionY.Text = "500";//558
                pBModel.Location = new Point(325, 500);
                pBSModel.Image = Properties.Resources.PlayerModel3;
                pBModel.Image = Properties.Resources.PlayerModel3;

                //Background
                comboBoxFarbe.Text = "Black";
                sC.Panel2.BackgroundImage = Properties.Resources.loading;

                //Player
                cBMoveLeft.Checked = true;
                cBMoveRight.Checked = true;
                cBShoot.Checked = true;

                //Shoot
                tBShootSpeed.Text = "15";
                PlayerShootSpeed = 15;
                cBEnemyShoot.Checked = true;

                //Enemy
                pBShoot.BringToFront();//Bringt pBShoot über pBEnemy
                tBEnemyX.Text = "60";
                tBEnemyY.Text = "10";
                pBSEnemy.Image = Properties.Resources.enemy2;
                comboBoxEnemys.Text = "10";
                tBEnemyDistance.Text = "6";
            }
        }

        private void rBGame2_CheckedChanged(object sender, EventArgs e)
        {
            if (rBGame2.Checked)
            {
                MessageBox.Show("2");
            }
        }

        private void rBGame3_CheckedChanged(object sender, EventArgs e)
        {
            if (rBGame3.Checked)
            {
                MessageBox.Show("3");
            }
        }


        private void comboBoxFarbe_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxFarbe.Text)
            {
                case "White":
                    this.sC.Panel2.BackColor = Color.White;
                    break;
                case "Black":
                    this.sC.Panel2.BackColor = Color.Black;
                    break;
                case "Gray":
                    this.sC.Panel2.BackColor = Color.Gray;
                    break;
                case "Blue":
                    this.sC.Panel2.BackColor = Color.Blue;
                    break;
                case "Green":
                    this.sC.Panel2.BackColor = Color.Green;
                    break;
                case "Yellow":
                    this.sC.Panel2.BackColor = Color.Yellow;
                    break;
                case "Red":
                    this.sC.Panel2.BackColor = Color.Red;
                    break;
                case "Orange":
                    this.sC.Panel2.BackColor = Color.Orange;
                    break;
            }
        }

        private void comboBoxEnemys_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxEnemys.Text)
            {
                case "1":
                    pBEnemy1.Image = pBSEnemy.Image;
                    pBEnemy2.Image = null;
                    pBEnemy3.Image = null;
                    pBEnemy4.Image = null;
                    pBEnemy5.Image = null;
                    pBEnemy6.Image = null;
                    pBEnemy7.Image = null;
                    pBEnemy8.Image = null;
                    pBEnemy9.Image = null;
                    pBEnemy10.Image = null;

                    if (cBEnemyShoot.Checked)
                    {
                        pbEnemyShoot1.Image = Properties.Resources.fire2;
                        pbEnemyShoot2.Image = null;
                        pbEnemyShoot3.Image = null;
                        pbEnemyShoot4.Image = null;
                        pbEnemyShoot5.Image = null;
                        pbEnemyShoot6.Image = null;
                        pbEnemyShoot7.Image = null;
                        pbEnemyShoot8.Image = null;
                        pbEnemyShoot9.Image = null;
                        pbEnemyShoot10.Image = null;

                        pbEnemyShoot1.Location = new Point(pBEnemy1.Location.X + 20, pBEnemy1.Location.Y + 40);
                    }
                    break;
                case "2":
                    pBEnemy1.Image = pBSEnemy.Image;
                    pBEnemy2.Image = pBSEnemy.Image;
                    pBEnemy3.Image = null;
                    pBEnemy4.Image = null;
                    pBEnemy5.Image = null;
                    pBEnemy6.Image = null;
                    pBEnemy7.Image = null;
                    pBEnemy8.Image = null;
                    pBEnemy9.Image = null;
                    pBEnemy10.Image = null;

                    if (cBEnemyShoot.Checked)
                    {
                        pbEnemyShoot1.Image = Properties.Resources.fire2;
                        pbEnemyShoot2.Image = Properties.Resources.fire2;
                        pbEnemyShoot3.Image = null;
                        pbEnemyShoot4.Image = null;
                        pbEnemyShoot5.Image = null;
                        pbEnemyShoot6.Image = null;
                        pbEnemyShoot7.Image = null;
                        pbEnemyShoot8.Image = null;
                        pbEnemyShoot9.Image = null;
                        pbEnemyShoot10.Image = null;

                        pbEnemyShoot1.Location = new Point(pBEnemy1.Location.X + 20, pBEnemy1.Location.Y + 40);
                        pbEnemyShoot2.Location = new Point(pBEnemy2.Location.X + 20, pBEnemy2.Location.Y + 40);
                    }
                    break;
                case "3":
                    pBEnemy1.Image = pBSEnemy.Image;
                    pBEnemy2.Image = pBSEnemy.Image;
                    pBEnemy3.Image = pBSEnemy.Image;
                    pBEnemy4.Image = null;
                    pBEnemy5.Image = null;
                    pBEnemy6.Image = null;
                    pBEnemy7.Image = null;
                    pBEnemy8.Image = null;
                    pBEnemy9.Image = null;
                    pBEnemy10.Image = null;

                    if (cBEnemyShoot.Checked)
                    {
                        pbEnemyShoot1.Image = Properties.Resources.fire2;
                        pbEnemyShoot2.Image = Properties.Resources.fire2;
                        pbEnemyShoot3.Image = Properties.Resources.fire2;
                        pbEnemyShoot4.Image = null;
                        pbEnemyShoot5.Image = null;
                        pbEnemyShoot6.Image = null;
                        pbEnemyShoot7.Image = null;
                        pbEnemyShoot8.Image = null;
                        pbEnemyShoot9.Image = null;
                        pbEnemyShoot10.Image = null;

                        pbEnemyShoot1.Location = new Point(pBEnemy1.Location.X + 20, pBEnemy1.Location.Y + 40);
                        pbEnemyShoot2.Location = new Point(pBEnemy2.Location.X + 20, pBEnemy2.Location.Y + 40);
                        pbEnemyShoot3.Location = new Point(pBEnemy3.Location.X + 20, pBEnemy3.Location.Y + 40);
                    }
                    break;
                case "4":
                    pBEnemy1.Image = pBSEnemy.Image;
                    pBEnemy2.Image = pBSEnemy.Image;
                    pBEnemy3.Image = pBSEnemy.Image;
                    pBEnemy4.Image = pBSEnemy.Image;
                    pBEnemy5.Image = null;
                    pBEnemy6.Image = null;
                    pBEnemy7.Image = null;
                    pBEnemy8.Image = null;
                    pBEnemy9.Image = null;
                    pBEnemy10.Image = null;


                    if (cBEnemyShoot.Checked)
                    {
                        pbEnemyShoot1.Image = Properties.Resources.fire2;
                        pbEnemyShoot2.Image = Properties.Resources.fire2;
                        pbEnemyShoot3.Image = Properties.Resources.fire2;
                        pbEnemyShoot4.Image = Properties.Resources.fire2;
                        pbEnemyShoot5.Image = null;
                        pbEnemyShoot6.Image = null;
                        pbEnemyShoot7.Image = null;
                        pbEnemyShoot8.Image = null;
                        pbEnemyShoot9.Image = null;
                        pbEnemyShoot10.Image = null;

                        pbEnemyShoot1.Location = new Point(pBEnemy1.Location.X + 20, pBEnemy1.Location.Y + 40);
                        pbEnemyShoot2.Location = new Point(pBEnemy2.Location.X + 20, pBEnemy2.Location.Y + 40);
                        pbEnemyShoot3.Location = new Point(pBEnemy3.Location.X + 20, pBEnemy3.Location.Y + 40);
                        pbEnemyShoot4.Location = new Point(pBEnemy4.Location.X + 20, pBEnemy4.Location.Y + 40);
                    }
                    break;
                case "5":
                    pBEnemy1.Image = pBSEnemy.Image;
                    pBEnemy2.Image = pBSEnemy.Image;
                    pBEnemy3.Image = pBSEnemy.Image;
                    pBEnemy4.Image = pBSEnemy.Image;
                    pBEnemy5.Image = pBSEnemy.Image;
                    pBEnemy6.Image = null;
                    pBEnemy7.Image = null;
                    pBEnemy8.Image = null;
                    pBEnemy9.Image = null;
                    pBEnemy10.Image = null;

                    if (cBEnemyShoot.Checked)
                    {
                        pbEnemyShoot1.Image = Properties.Resources.fire2;
                        pbEnemyShoot2.Image = Properties.Resources.fire2;
                        pbEnemyShoot3.Image = Properties.Resources.fire2;
                        pbEnemyShoot4.Image = Properties.Resources.fire2;
                        pbEnemyShoot5.Image = Properties.Resources.fire2;
                        pbEnemyShoot6.Image = null;
                        pbEnemyShoot7.Image = null;
                        pbEnemyShoot8.Image = null;
                        pbEnemyShoot9.Image = null;
                        pbEnemyShoot10.Image = null;

                        pbEnemyShoot1.Location = new Point(pBEnemy1.Location.X + 20, pBEnemy1.Location.Y + 40);
                        pbEnemyShoot2.Location = new Point(pBEnemy2.Location.X + 20, pBEnemy2.Location.Y + 40);
                        pbEnemyShoot3.Location = new Point(pBEnemy3.Location.X + 20, pBEnemy3.Location.Y + 40);
                        pbEnemyShoot4.Location = new Point(pBEnemy4.Location.X + 20, pBEnemy4.Location.Y + 40);
                        pbEnemyShoot5.Location = new Point(pBEnemy5.Location.X + 20, pBEnemy5.Location.Y + 40);
                    }
                    break;
                case "6":
                    pBEnemy1.Image = pBSEnemy.Image;
                    pBEnemy2.Image = pBSEnemy.Image;
                    pBEnemy3.Image = pBSEnemy.Image;
                    pBEnemy4.Image = pBSEnemy.Image;
                    pBEnemy5.Image = pBSEnemy.Image;
                    pBEnemy6.Image = pBSEnemy.Image;
                    pBEnemy7.Image = null;
                    pBEnemy8.Image = null;
                    pBEnemy9.Image = null;
                    pBEnemy10.Image = null;

                    if (cBEnemyShoot.Checked)
                    {
                        pbEnemyShoot1.Image = Properties.Resources.fire2;
                        pbEnemyShoot2.Image = Properties.Resources.fire2;
                        pbEnemyShoot3.Image = Properties.Resources.fire2;
                        pbEnemyShoot4.Image = Properties.Resources.fire2;
                        pbEnemyShoot5.Image = Properties.Resources.fire2;
                        pbEnemyShoot6.Image = Properties.Resources.fire2;
                        pbEnemyShoot7.Image = null;
                        pbEnemyShoot8.Image = null;
                        pbEnemyShoot9.Image = null;
                        pbEnemyShoot10.Image = null;

                        pbEnemyShoot1.Location = new Point(pBEnemy1.Location.X + 20, pBEnemy1.Location.Y + 40);
                        pbEnemyShoot2.Location = new Point(pBEnemy2.Location.X + 20, pBEnemy2.Location.Y + 40);
                        pbEnemyShoot3.Location = new Point(pBEnemy3.Location.X + 20, pBEnemy3.Location.Y + 40);
                        pbEnemyShoot4.Location = new Point(pBEnemy4.Location.X + 20, pBEnemy4.Location.Y + 40);
                        pbEnemyShoot5.Location = new Point(pBEnemy5.Location.X + 20, pBEnemy5.Location.Y + 40);
                        pbEnemyShoot6.Location = new Point(pBEnemy6.Location.X + 20, pBEnemy6.Location.Y + 40);
                    }
                    break;
                case "7":
                    pBEnemy1.Image = pBSEnemy.Image;
                    pBEnemy2.Image = pBSEnemy.Image;
                    pBEnemy3.Image = pBSEnemy.Image;
                    pBEnemy4.Image = pBSEnemy.Image;
                    pBEnemy5.Image = pBSEnemy.Image;
                    pBEnemy6.Image = pBSEnemy.Image;
                    pBEnemy7.Image = pBSEnemy.Image;
                    pBEnemy8.Image = null;
                    pBEnemy9.Image = null;
                    pBEnemy10.Image = null;

                    if (cBEnemyShoot.Checked)
                    {
                        pbEnemyShoot1.Image = Properties.Resources.fire2;
                        pbEnemyShoot2.Image = Properties.Resources.fire2;
                        pbEnemyShoot3.Image = Properties.Resources.fire2;
                        pbEnemyShoot4.Image = Properties.Resources.fire2;
                        pbEnemyShoot5.Image = Properties.Resources.fire2;
                        pbEnemyShoot6.Image = Properties.Resources.fire2;
                        pbEnemyShoot7.Image = Properties.Resources.fire2;
                        pbEnemyShoot8.Image = null;
                        pbEnemyShoot9.Image = null;
                        pbEnemyShoot10.Image = null;

                        pbEnemyShoot1.Location = new Point(pBEnemy1.Location.X + 20, pBEnemy1.Location.Y + 40);
                        pbEnemyShoot2.Location = new Point(pBEnemy2.Location.X + 20, pBEnemy2.Location.Y + 40);
                        pbEnemyShoot3.Location = new Point(pBEnemy3.Location.X + 20, pBEnemy3.Location.Y + 40);
                        pbEnemyShoot4.Location = new Point(pBEnemy4.Location.X + 20, pBEnemy4.Location.Y + 40);
                        pbEnemyShoot5.Location = new Point(pBEnemy5.Location.X + 20, pBEnemy5.Location.Y + 40);
                        pbEnemyShoot6.Location = new Point(pBEnemy6.Location.X + 20, pBEnemy6.Location.Y + 40);
                        pbEnemyShoot7.Location = new Point(pBEnemy7.Location.X + 20, pBEnemy7.Location.Y + 40);
                    }
                    break;
                case "8":
                    pBEnemy1.Image = pBSEnemy.Image;
                    pBEnemy2.Image = pBSEnemy.Image;
                    pBEnemy3.Image = pBSEnemy.Image;
                    pBEnemy4.Image = pBSEnemy.Image;
                    pBEnemy5.Image = pBSEnemy.Image;
                    pBEnemy6.Image = pBSEnemy.Image;
                    pBEnemy7.Image = pBSEnemy.Image;
                    pBEnemy8.Image = pBSEnemy.Image;
                    pBEnemy9.Image = null;
                    pBEnemy10.Image = null;

                    if (cBEnemyShoot.Checked)
                    {
                        pbEnemyShoot1.Image = Properties.Resources.fire2;
                        pbEnemyShoot2.Image = Properties.Resources.fire2;
                        pbEnemyShoot3.Image = Properties.Resources.fire2;
                        pbEnemyShoot4.Image = Properties.Resources.fire2;
                        pbEnemyShoot5.Image = Properties.Resources.fire2;
                        pbEnemyShoot6.Image = Properties.Resources.fire2;
                        pbEnemyShoot7.Image = Properties.Resources.fire2;
                        pbEnemyShoot8.Image = Properties.Resources.fire2;
                        pbEnemyShoot9.Image = null;
                        pbEnemyShoot10.Image = null;

                        pbEnemyShoot1.Location = new Point(pBEnemy1.Location.X + 20, pBEnemy1.Location.Y + 40);
                        pbEnemyShoot2.Location = new Point(pBEnemy2.Location.X + 20, pBEnemy2.Location.Y + 40);
                        pbEnemyShoot3.Location = new Point(pBEnemy3.Location.X + 20, pBEnemy3.Location.Y + 40);
                        pbEnemyShoot4.Location = new Point(pBEnemy4.Location.X + 20, pBEnemy4.Location.Y + 40);
                        pbEnemyShoot5.Location = new Point(pBEnemy5.Location.X + 20, pBEnemy5.Location.Y + 40);
                        pbEnemyShoot6.Location = new Point(pBEnemy6.Location.X + 20, pBEnemy6.Location.Y + 40);
                        pbEnemyShoot7.Location = new Point(pBEnemy7.Location.X + 20, pBEnemy7.Location.Y + 40);
                        pbEnemyShoot8.Location = new Point(pBEnemy8.Location.X + 20, pBEnemy8.Location.Y + 40);
                    }
                    break;
                case "9":
                    pBEnemy1.Image = pBSEnemy.Image;
                    pBEnemy2.Image = pBSEnemy.Image;
                    pBEnemy3.Image = pBSEnemy.Image;
                    pBEnemy4.Image = pBSEnemy.Image;
                    pBEnemy5.Image = pBSEnemy.Image;
                    pBEnemy6.Image = pBSEnemy.Image;
                    pBEnemy7.Image = pBSEnemy.Image;
                    pBEnemy8.Image = pBSEnemy.Image;
                    pBEnemy9.Image = pBSEnemy.Image;
                    pBEnemy10.Image = null;


                    if (cBEnemyShoot.Checked)
                    {
                        pbEnemyShoot1.Image = Properties.Resources.fire2;
                        pbEnemyShoot2.Image = Properties.Resources.fire2;
                        pbEnemyShoot3.Image = Properties.Resources.fire2;
                        pbEnemyShoot4.Image = Properties.Resources.fire2;
                        pbEnemyShoot5.Image = Properties.Resources.fire2;
                        pbEnemyShoot6.Image = Properties.Resources.fire2;
                        pbEnemyShoot7.Image = Properties.Resources.fire2;
                        pbEnemyShoot8.Image = Properties.Resources.fire2;
                        pbEnemyShoot9.Image = Properties.Resources.fire2;
                        pbEnemyShoot10.Image = null;

                        pbEnemyShoot1.Location = new Point(pBEnemy1.Location.X + 20, pBEnemy1.Location.Y + 40);
                        pbEnemyShoot2.Location = new Point(pBEnemy2.Location.X + 20, pBEnemy2.Location.Y + 40);
                        pbEnemyShoot3.Location = new Point(pBEnemy3.Location.X + 20, pBEnemy3.Location.Y + 40);
                        pbEnemyShoot4.Location = new Point(pBEnemy4.Location.X + 20, pBEnemy4.Location.Y + 40);
                        pbEnemyShoot5.Location = new Point(pBEnemy5.Location.X + 20, pBEnemy5.Location.Y + 40);
                        pbEnemyShoot6.Location = new Point(pBEnemy6.Location.X + 20, pBEnemy6.Location.Y + 40);
                        pbEnemyShoot7.Location = new Point(pBEnemy7.Location.X + 20, pBEnemy7.Location.Y + 40);
                        pbEnemyShoot8.Location = new Point(pBEnemy8.Location.X + 20, pBEnemy8.Location.Y + 40);
                        pbEnemyShoot9.Location = new Point(pBEnemy9.Location.X + 20, pBEnemy9.Location.Y + 40);
                    }
                    break;
                case "10":
                    pBEnemy1.Image = pBSEnemy.Image;
                    pBEnemy2.Image = pBSEnemy.Image;
                    pBEnemy3.Image = pBSEnemy.Image;
                    pBEnemy4.Image = pBSEnemy.Image;
                    pBEnemy5.Image = pBSEnemy.Image;
                    pBEnemy6.Image = pBSEnemy.Image;
                    pBEnemy7.Image = pBSEnemy.Image;
                    pBEnemy8.Image = pBSEnemy.Image;
                    pBEnemy9.Image = pBSEnemy.Image;
                    pBEnemy10.Image = pBSEnemy.Image;

                    if (cBEnemyShoot.Checked)
                    {
                        pbEnemyShoot1.Image = Properties.Resources.fire2;
                        pbEnemyShoot2.Image = Properties.Resources.fire2;
                        pbEnemyShoot3.Image = Properties.Resources.fire2;
                        pbEnemyShoot4.Image = Properties.Resources.fire2;
                        pbEnemyShoot5.Image = Properties.Resources.fire2;
                        pbEnemyShoot6.Image = Properties.Resources.fire2;
                        pbEnemyShoot7.Image = Properties.Resources.fire2;
                        pbEnemyShoot8.Image = Properties.Resources.fire2;
                        pbEnemyShoot9.Image = Properties.Resources.fire2;
                        pbEnemyShoot10.Image = Properties.Resources.fire2;

                        pbEnemyShoot1.Location = new Point(pBEnemy1.Location.X + 20, pBEnemy1.Location.Y + 40);
                        pbEnemyShoot2.Location = new Point(pBEnemy2.Location.X + 20, pBEnemy2.Location.Y + 40);
                        pbEnemyShoot3.Location = new Point(pBEnemy3.Location.X + 20, pBEnemy3.Location.Y + 40);
                        pbEnemyShoot4.Location = new Point(pBEnemy4.Location.X + 20, pBEnemy4.Location.Y + 40);
                        pbEnemyShoot5.Location = new Point(pBEnemy5.Location.X + 20, pBEnemy5.Location.Y + 40);
                        pbEnemyShoot6.Location = new Point(pBEnemy6.Location.X + 20, pBEnemy6.Location.Y + 40);
                        pbEnemyShoot7.Location = new Point(pBEnemy7.Location.X + 20, pBEnemy7.Location.Y + 40);
                        pbEnemyShoot8.Location = new Point(pBEnemy8.Location.X + 20, pBEnemy8.Location.Y + 40);
                        pbEnemyShoot9.Location = new Point(pBEnemy9.Location.X + 20, pBEnemy9.Location.Y + 40);
                        pbEnemyShoot10.Location = new Point(pBEnemy10.Location.X + 20, pBEnemy10.Location.Y + 40);
                    }
                    break;
            }
        }


        private void btnModelNext_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(pBSModel.Tag) == "1")
            {
                pBSModel.Image = Properties.Resources.PlayerModel2;
                pBSModel.Tag = "2";
            }
            else if (Convert.ToString(pBSModel.Tag) == "2")
            {
                pBSModel.Image = Properties.Resources.PlayerModel3;
                pBSModel.Tag = "3";
            }
            else if (Convert.ToString(pBSModel.Tag) == "3")
            {
                pBSModel.Image = Properties.Resources.PlayerModel1;
                pBSModel.Tag = "1";
            }
            pBModel.Image = pBSModel.Image;
        }

        private void btnModelBack_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(pBSModel.Tag) == "1")
            {
                pBSModel.Image = Properties.Resources.PlayerModel3;
                pBSModel.Tag = "3";
            }
            else if (Convert.ToString(pBSModel.Tag) == "2")
            {
                pBSModel.Image = Properties.Resources.PlayerModel1;
                pBSModel.Tag = "1";
            }
            else if (Convert.ToString(pBSModel.Tag) == "3")
            {
                pBSModel.Image = Properties.Resources.PlayerModel2;
                pBSModel.Tag = "2";
            }
            pBModel.Image = pBSModel.Image;
        }

        private void btnEnemyNext_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(pBSEnemy.Tag) == "1")
            {
                pBSEnemy.Image = Properties.Resources.enemy2;
                pBSEnemy.Tag = "2";
            }
            else if (Convert.ToString(pBSEnemy.Tag) == "2")
            {
                pBSEnemy.Image = Properties.Resources.enemy3;
                pBSEnemy.Tag = "3";
            }
            else if (Convert.ToString(pBSEnemy.Tag) == "3")
            {
                pBSEnemy.Image = Properties.Resources.enemy1;
                pBSEnemy.Tag = "1";
            }
            pBEnemy1.Image = pBSEnemy.Image;
        }

        private void btnEnemyBack_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(pBSEnemy.Tag) == "1")
            {
                pBSEnemy.Image = Properties.Resources.enemy3;
                pBSEnemy.Tag = "3";
            }
            else if (Convert.ToString(pBSEnemy.Tag) == "2")
            {
                pBSEnemy.Image = Properties.Resources.enemy1;
                pBSEnemy.Tag = "1";
            }
            else if (Convert.ToString(pBSEnemy.Tag) == "3")
            {
                pBSEnemy.Image = Properties.Resources.enemy2;
                pBSEnemy.Tag = "2";
            }
            pBEnemy1.Image = pBSEnemy.Image;
        }


        private void tBPostionX_TextChanged(object sender, EventArgs e)
        {

            try
            {
                pBModel.Location = new Point(Convert.ToInt32(tBPositionX.Text), Convert.ToInt32(tBPositionY.Text));
            }
            catch (Exception)
            {

            }

        }

        private void tBPositionY_TextChanged(object sender, EventArgs e)
        {
            try
            {
                pBModel.Location = new Point(Convert.ToInt32(tBPositionX.Text), Convert.ToInt32(tBPositionY.Text));
            }
            catch (Exception)
            {

            }
        }

        private void tBEnemyX_TextChanged(object sender, EventArgs e)
        {
            try
            {
                pBEnemy1.Location = new Point(Convert.ToInt32(tBEnemyX.Text), Convert.ToInt32(tBEnemyY.Text));
                tBEnemyDistance.Text = tBEnemyDistance.Text;
            }
            catch (Exception)
            {

            }
        }

        private void tBEnemyY_TextChanged(object sender, EventArgs e)
        {
            try
            {
                pBEnemy1.Location = new Point(Convert.ToInt32(tBEnemyX.Text), Convert.ToInt32(tBEnemyY.Text));
                tBEnemyDistance.Text = tBEnemyDistance.Text;
            }
            catch (Exception)
            {

            }
        }


        private void tBEnemyDistance_TextChanged(object sender, EventArgs e)
        {
            try
            {
                
                pBEnemy2.Location = new Point(50 + pBEnemy1.Location.X + Convert.ToInt32(tBEnemyDistance.Text), pBEnemy1.Location.Y);
                pBEnemy3.Location = new Point(50 + pBEnemy2.Location.X + Convert.ToInt32(tBEnemyDistance.Text), pBEnemy1.Location.Y);
                pBEnemy4.Location = new Point(50 + pBEnemy3.Location.X + Convert.ToInt32(tBEnemyDistance.Text), pBEnemy1.Location.Y);
                pBEnemy5.Location = new Point(50 + pBEnemy4.Location.X + Convert.ToInt32(tBEnemyDistance.Text), pBEnemy1.Location.Y);
                pBEnemy6.Location = new Point(50 + pBEnemy5.Location.X + Convert.ToInt32(tBEnemyDistance.Text), pBEnemy1.Location.Y);
                pBEnemy7.Location = new Point(50 + pBEnemy6.Location.X + Convert.ToInt32(tBEnemyDistance.Text), pBEnemy1.Location.Y);
                pBEnemy8.Location = new Point(50 + pBEnemy7.Location.X + Convert.ToInt32(tBEnemyDistance.Text), pBEnemy1.Location.Y);
                pBEnemy9.Location = new Point(50 + pBEnemy8.Location.X + Convert.ToInt32(tBEnemyDistance.Text), pBEnemy1.Location.Y);
                pBEnemy10.Location = new Point(50 + pBEnemy9.Location.X + Convert.ToInt32(tBEnemyDistance.Text), pBEnemy1.Location.Y);
            }
            catch (Exception)
            {
            }
            
        }

        private void tBShootSpeed_TextChanged(object sender, EventArgs e)
        {
            try
            {
                PlayerShootSpeed = Convert.ToInt32(tBShootSpeed.Text);
            }
            catch (Exception)
            {

            }
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (sC.Panel2.BackgroundImage == null)
            {
                if (cBMoveLeft.Checked)
                {
                    if (e.KeyCode == Keys.A && pBModel.Left > 0)
                    {
                        pBModel.Left = pBModel.Left - 7;
                    }
                }

                if (cBMoveRight.Checked && pBModel.Left < 630)
                {
                    if (e.KeyCode == Keys.D)
                    {
                        pBModel.Left = pBModel.Left + 7;
                    }
                }

                if (cBMoveDown.Checked && pBModel.Top < 510)
                {
                    if (e.KeyCode == Keys.S)
                    {
                        pBModel.Top = pBModel.Top + 7;
                    }
                }

                if (cBMoveUp.Checked && pBModel.Top > 0)
                {
                    if (e.KeyCode == Keys.W)
                    {
                        pBModel.Top = pBModel.Top - 7;
                    }
                }
                if (cBShoot.Checked)
                {
                    if (e.KeyCode == Keys.Space)
                    {
                        if (timerShoot1.Enabled == false)
                        {
                            pBShoot.Image = Properties.Resources.fire;
                            x = pBModel.Left + 20;
                            pBShoot.Location = new Point(x, pBModel.Top);
                            timerShoot1.Enabled = true;
                        }
                    }
                }
            }
        }

        private void cBEnemyShoot_CheckedChanged(object sender, EventArgs e)
        {
            timerEnemyShoot1.Enabled = true;
        }

        private void timerEnemyShoot1_Tick(object sender, EventArgs e)
        {
            if (pbEnemyShoot1.Location.Y <= 535 && rndzahl == 1 && pbEnemyShoot1.Image != null && pBModel.Bounds.IntersectsWith(pbEnemyShoot1.Bounds) == false)
            {
                pbEnemyShoot1.Location = new Point(pbEnemyShoot1.Location.X, pbEnemyShoot1.Location.Y + 10);
            }
            else
            {
                if (pbEnemyShoot1.Location.Y == 540 || pBModel.Bounds.IntersectsWith(pbEnemyShoot1.Bounds))
                {
                    pbEnemyShoot1.Location = new Point(pBEnemy1.Location.X + 20, pBEnemy1.Location.Y + 40);
                    pbEnemyShoot1.Image = Properties.Resources.fire2;

                    Random rnd = new Random();
                    rndzahl = rnd.Next(1, 11);
                }
                /*else if (pBModel.Bounds.IntersectsWith(pbEnemyShoot1.Bounds)) //Wird automatisch bei timerShoot1 gemacht.
                {
                    pbEnemyShoot1.Image = null;
                }*/
            }

            if (pbEnemyShoot2.Location.Y <= 535 && rndzahl == 2 && pbEnemyShoot2.Image != null && pBModel.Bounds.IntersectsWith(pbEnemyShoot2.Bounds) == false)
            {
                pbEnemyShoot2.Location = new Point(pbEnemyShoot2.Location.X, pbEnemyShoot2.Location.Y + 10);
            }
            else
            {
                if (pbEnemyShoot2.Location.Y == 540 || pBModel.Bounds.IntersectsWith(pbEnemyShoot2.Bounds))
                {
                    pbEnemyShoot2.Location = new Point(pBEnemy2.Location.X + 20, pBEnemy2.Location.Y + 40);
                    pbEnemyShoot2.Image = Properties.Resources.fire2;

                    Random rnd = new Random();
                    rndzahl = rnd.Next(1, 11);
                }
            }

            if (pbEnemyShoot3.Location.Y <= 535 && rndzahl == 3 && pbEnemyShoot3.Image != null && pBModel.Bounds.IntersectsWith(pbEnemyShoot3.Bounds) == false)
            {
                pbEnemyShoot3.Location = new Point(pbEnemyShoot3.Location.X, pbEnemyShoot3.Location.Y + 10);
            }
            else
            {
                if (pbEnemyShoot3.Location.Y == 540 || pBModel.Bounds.IntersectsWith(pbEnemyShoot3.Bounds))
                {
                    pbEnemyShoot3.Location = new Point(pBEnemy3.Location.X + 20, pBEnemy3.Location.Y + 40);
                    pbEnemyShoot3.Image = Properties.Resources.fire2;

                    Random rnd = new Random();
                    rndzahl = rnd.Next(1, 11);
                }
            }

            if (pbEnemyShoot4.Location.Y <= 535 && rndzahl == 4 && pbEnemyShoot4.Image != null && pBModel.Bounds.IntersectsWith(pbEnemyShoot4.Bounds) == false)
            {
                pbEnemyShoot4.Location = new Point(pbEnemyShoot4.Location.X, pbEnemyShoot4.Location.Y + 10);
            }
            else
            {
                if (pbEnemyShoot4.Location.Y == 540 || pBModel.Bounds.IntersectsWith(pbEnemyShoot4.Bounds))
                {
                    pbEnemyShoot4.Location = new Point(pBEnemy4.Location.X + 20, pBEnemy4.Location.Y + 40);
                    pbEnemyShoot4.Image = Properties.Resources.fire2;

                    Random rnd = new Random();
                    rndzahl = rnd.Next(1,11);
                }
            }

            if (pbEnemyShoot5.Location.Y <= 535 && rndzahl == 5 && pbEnemyShoot5.Image != null && pBModel.Bounds.IntersectsWith(pbEnemyShoot5.Bounds) == false)
            {
                pbEnemyShoot5.Location = new Point(pbEnemyShoot5.Location.X, pbEnemyShoot5.Location.Y + 10);
            }
            else
            {
                if (pbEnemyShoot5.Location.Y == 540 || pBModel.Bounds.IntersectsWith(pbEnemyShoot5.Bounds))
                {
                    pbEnemyShoot5.Location = new Point(pBEnemy5.Location.X + 20, pBEnemy5.Location.Y + 40);
                    pbEnemyShoot5.Image = Properties.Resources.fire2;

                    Random rnd = new Random();
                    rndzahl = rnd.Next(1, 11);
                }
            }

            if (pbEnemyShoot6.Location.Y <= 535 && rndzahl == 6 && pbEnemyShoot6.Image != null && pBModel.Bounds.IntersectsWith(pbEnemyShoot6.Bounds) == false)
            {
                pbEnemyShoot6.Location = new Point(pbEnemyShoot6.Location.X, pbEnemyShoot6.Location.Y + 10);
            }
            else
            {
                if (pbEnemyShoot6.Location.Y == 540 || pBModel.Bounds.IntersectsWith(pbEnemyShoot6.Bounds))
                {
                    pbEnemyShoot6.Location = new Point(pBEnemy6.Location.X + 20, pBEnemy6.Location.Y + 40);
                    pbEnemyShoot6.Image = Properties.Resources.fire2;

                    Random rnd = new Random();
                    rndzahl = rnd.Next(1, 11);
                }
            }

            if (pbEnemyShoot7.Location.Y <= 535 && rndzahl == 7 && pbEnemyShoot7.Image != null && pBModel.Bounds.IntersectsWith(pbEnemyShoot7.Bounds) == false)
            {
                pbEnemyShoot7.Location = new Point(pbEnemyShoot7.Location.X, pbEnemyShoot7.Location.Y + 10);
            }
            else
            {
                if (pbEnemyShoot7.Location.Y == 540 || pBModel.Bounds.IntersectsWith(pbEnemyShoot7.Bounds))
                {
                    pbEnemyShoot7.Location = new Point(pBEnemy7.Location.X + 20, pBEnemy7.Location.Y + 40);
                    pbEnemyShoot7.Image = Properties.Resources.fire2;

                    Random rnd = new Random();
                    rndzahl = rnd.Next(1, 11);
                }
            }

            if (pbEnemyShoot8.Location.Y <= 535 && rndzahl == 8 && pbEnemyShoot8.Image != null && pBModel.Bounds.IntersectsWith(pbEnemyShoot8.Bounds) == false)
            {
                pbEnemyShoot8.Location = new Point(pbEnemyShoot8.Location.X, pbEnemyShoot8.Location.Y + 10);
            }
            else
            {
                if (pbEnemyShoot8.Location.Y == 540 || pBModel.Bounds.IntersectsWith(pbEnemyShoot8.Bounds))
                {
                    pbEnemyShoot8.Location = new Point(pBEnemy8.Location.X + 20, pBEnemy8.Location.Y + 40);
                    pbEnemyShoot8.Image = Properties.Resources.fire2;

                    Random rnd = new Random();
                    rndzahl = rnd.Next(1, 11);
                }
            }

            if (pbEnemyShoot9.Location.Y <= 535 && rndzahl == 9 && pbEnemyShoot9.Image != null && pBModel.Bounds.IntersectsWith(pbEnemyShoot9.Bounds) == false)
            {
                pbEnemyShoot9.Location = new Point(pbEnemyShoot9.Location.X, pbEnemyShoot9.Location.Y + 10);
            }
            else
            {
                if (pbEnemyShoot9.Location.Y == 540 || pBModel.Bounds.IntersectsWith(pbEnemyShoot9.Bounds))
                {
                    pbEnemyShoot9.Location = new Point(pBEnemy9.Location.X + 20, pBEnemy9.Location.Y + 40);
                    pbEnemyShoot9.Image = Properties.Resources.fire2;

                    Random rnd = new Random();
                    rndzahl = rnd.Next(1, 11);
                }
            }

            if (pbEnemyShoot10.Location.Y <= 535 && rndzahl == 10 && pbEnemyShoot7.Image != null && pBModel.Bounds.IntersectsWith(pbEnemyShoot10.Bounds) == false)
            {
                pbEnemyShoot10.Location = new Point(pbEnemyShoot10.Location.X, pbEnemyShoot10.Location.Y + 10);
            }
            else
            {
                if (pbEnemyShoot10.Location.Y == 540 || pBModel.Bounds.IntersectsWith(pbEnemyShoot10.Bounds))
                {
                    pbEnemyShoot10.Location = new Point(pBEnemy10.Location.X + 20, pBEnemy10.Location.Y + 40);
                    pbEnemyShoot10.Image = Properties.Resources.fire2;

                    Random rnd = new Random();
                    rndzahl = rnd.Next(1, 11);
                }
            }


        }

        private void timerShoot1_Tick(object sender, EventArgs e)
        {
            if (pBShoot.Top > 0)
            {
                pBShoot.Location = new Point(x, pBShoot.Top - PlayerShootSpeed);
            }
            else
            {
                pBShoot.Image = null;
                timerShoot1.Enabled = false;
            }

            if (pBEnemy1.Bounds.IntersectsWith(pBShoot.Bounds) && pBEnemy1.Image != null)
            {
                timerShoot1.Enabled = false;
                pBEnemy1.Image = null;
                pBShoot.Image = null;
                pbEnemyShoot1.Image = null;
            }
            if (pBEnemy2.Bounds.IntersectsWith(pBShoot.Bounds) && pBEnemy2.Image != null)
            {
                timerShoot1.Enabled = false;
                pBEnemy2.Image = null;
                pBShoot.Image = null;
                pbEnemyShoot2.Image = null;
            }
            if (pBEnemy3.Bounds.IntersectsWith(pBShoot.Bounds) && pBEnemy3.Image != null)
            {
                timerShoot1.Enabled = false;
                pBEnemy3.Image = null;
                pBShoot.Image = null;
                pbEnemyShoot3.Image = null;
            }
            if (pBEnemy4.Bounds.IntersectsWith(pBShoot.Bounds) && pBEnemy4.Image != null)
            {
                timerShoot1.Enabled = false;
                pBEnemy4.Image = null;
                pBShoot.Image = null;
                pbEnemyShoot4.Image = null;
            }
            if (pBEnemy5.Bounds.IntersectsWith(pBShoot.Bounds) && pBEnemy5.Image != null)
            {
                timerShoot1.Enabled = false;
                pBEnemy5.Image = null;
                pBShoot.Image = null;
                pbEnemyShoot5.Image = null;
            }
            if (pBEnemy6.Bounds.IntersectsWith(pBShoot.Bounds) && pBEnemy6.Image != null)
            {
                timerShoot1.Enabled = false;
                pBEnemy6.Image = null;
                pBShoot.Image = null;
                pbEnemyShoot6.Image = null;
            }
            if (pBEnemy7.Bounds.IntersectsWith(pBShoot.Bounds) && pBEnemy7.Image != null)
            {
                timerShoot1.Enabled = false;
                pBEnemy7.Image = null;
                pBShoot.Image = null;
                pbEnemyShoot7.Image = null;
            }
            if (pBEnemy8.Bounds.IntersectsWith(pBShoot.Bounds) && pBEnemy8.Image != null)
            {
                timerShoot1.Enabled = false;
                pBEnemy8.Image = null;
                pBShoot.Image = null;
                pbEnemyShoot8.Image = null;
            }
            if (pBEnemy9.Bounds.IntersectsWith(pBShoot.Bounds) && pBEnemy9.Image != null)
            {
                timerShoot1.Enabled = false;
                pBEnemy9.Image = null;
                pBShoot.Image = null;
                pbEnemyShoot9.Image = null;
            }
            if (pBEnemy10.Bounds.IntersectsWith(pBShoot.Bounds) && pBEnemy10.Image != null)
            {
                timerShoot1.Enabled = false;
                pBEnemy10.Image = null;
                pBShoot.Image = null;
                pbEnemyShoot10.Image = null;
            }


        }
    }
}
