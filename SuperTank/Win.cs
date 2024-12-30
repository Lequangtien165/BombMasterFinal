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
    public partial class Win : Form
    {
        public Win()
        {
            InitializeComponent();
            this.FormClosing += Win_FormClosing;
        }

        //private async void checkrank_bt_Click(object sender, EventArgs e)
        //{
        //    SocketClient.SendData("GAMEOVER");
        //    await WaitFunction();
        //    if (SocketClient.CheckGameOver())
        //    {
        //        Ranking ranking = new Ranking();
        //        ranking.Show();
        //        this.Hide();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Các người chơi khác vẫn còn đang trong trận!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }

        //}
        private async Task WaitFunction()
        {
            await Task.Delay(700);
        }
        private void Win_FormClosed(object sender, FormClosedEventArgs e)
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
            Application.Exit();

        }
        private void Win_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }
        private void Win_Load(object sender, EventArgs e)
        {
            //SocketClient.SendData("GAMEOVER");
            //SocketClient.SendData("GAMEOVER");
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
