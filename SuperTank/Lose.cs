using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperTank
{
    public partial class Lose : Form
    {
        private frmGameMulti _gameForm;

        public Lose()
        {
            InitializeComponent();
            this.FormClosed += Lose_FormClosed;


        }


        private async Task WaitFunction()
        {
            await Task.Delay(700);
        }
        private void Lose_Load_1(object sender, EventArgs e)
        {
            if (_gameForm != null)
            {
                _gameForm.Close();
            }
        }

        private void Lose_FormClosed(object sender, FormClosedEventArgs e)
        {
            SocketClient.Disconnect();
            SocketClient.ClearLobby();
            Application.Exit();
            newRoom newroom = new newRoom();
            newroom.Show();
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            SocketClient.Disconnect();
            SocketClient.ClearLobby();
            Application.Exit();
        }
    }
}
