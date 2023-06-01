﻿using Blackjack;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using BP = Blackjack.Program;

namespace blackjack_windform
{
    public partial class GamePage : Form
    {
        private bool insurance_box_has_value = false;

        public static double bet_amount = 0;

        public static double total_betamount = 0;
        public GamePage()
        {
            InitializeComponent();
        }
        private void GamePage_Load(object sender, EventArgs e)
        {
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void GamePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 실행 중인 코드를 종료하고 애플리케이션을 종료합니다.
            Environment.Exit(0);

        }

        private CancellationTokenSource delayCancellation;

        private async Task WaitForBettingImageSelection()
        {
            delayCancellation = new CancellationTokenSource(); //delayCancellation 객체가 CancellationTokenSource로 초기화됩니다. 이 객체는 Task.Delay 작업을 취소하기 위해 사용됩니다.

            try
            {
                await Task.Delay(100000, delayCancellation.Token); //비동기적으로 100초 기다리게 하기. (= 다른 작업 수행 가능)
            }
            catch (TaskCanceledException)
            {
                // 예외 처리를 코드
                return;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (user.cash < bet_amount) // 유저가 있는 돈보다 더 많은 금액을 베팅하려고 할 때 올인으로 처리.
            {
                bet_amount = user.cash;

                total_betamount += bet_amount;

                user.cash -= bet_amount;

                textBox1.Text = user.cash.ToString();
                textBox2.Text = total_betamount.ToString();
            }
            else if(user.cash == 0)
            {
                MessageBox.Show("Not enough cash to Betting!", "error!");
            }
            else
            {
                bet_amount = 1;

                total_betamount += bet_amount;

                user.cash -= bet_amount;

                textBox1.Text = user.cash.ToString();
                textBox2.Text = total_betamount.ToString();
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (user.cash < bet_amount) // 유저가 있는 돈보다 더 많은 금액을 베팅하려고 할 때 올인으로 처리.
            {
                bet_amount = user.cash;

                total_betamount += bet_amount;

                user.cash -= bet_amount;

                textBox1.Text = user.cash.ToString();
                textBox2.Text = total_betamount.ToString();

            }
            else if (user.cash == 0)
            {
                MessageBox.Show("Not enough cash to Betting!", "error!");
            }

            else
            {
                bet_amount = 5;

                total_betamount += bet_amount;

                user.cash -= bet_amount;

                textBox1.Text = user.cash.ToString();
                textBox2.Text = total_betamount.ToString();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (user.cash < bet_amount) // 유저가 있는 돈보다 더 많은 금액을 베팅하려고 할 때 올인으로 처리.
            {
                bet_amount = user.cash;

                total_betamount += bet_amount;

                user.cash -= bet_amount;

                textBox1.Text = user.cash.ToString();
                textBox2.Text = total_betamount.ToString();

            }
            else if (user.cash == 0)
            {
                MessageBox.Show("Not enough cash to Betting!", "error!");
            }
            else
            {
                bet_amount = 10;

                total_betamount += bet_amount;

                user.cash -= bet_amount;

                textBox1.Text = user.cash.ToString();
                textBox2.Text = total_betamount.ToString();
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (user.cash < bet_amount) // 유저가 있는 돈보다 더 많은 금액을 베팅하려고 할 때 올인으로 처리.
            {
                bet_amount = user.cash;

                total_betamount += bet_amount;

                user.cash -= bet_amount;

                textBox1.Text = user.cash.ToString();
                textBox2.Text = total_betamount.ToString();

            }
            else if (user.cash == 0)
            {
                MessageBox.Show("Not enough cash to Betting!", "error!");
            }
            else
            {
                bet_amount = 50;

                total_betamount += bet_amount;

                user.cash -= bet_amount;

                textBox1.Text = user.cash.ToString();
                textBox2.Text = total_betamount.ToString();
            }

        }
        private void button5_Click(object sender, EventArgs e)
        {

            if (user.cash < bet_amount) // 유저가 있는 돈보다 더 많은 금액을 베팅하려고 할 때 올인으로 처리.
            {
                bet_amount = user.cash;

                total_betamount += bet_amount;

                user.cash -= bet_amount;

                textBox1.Text = user.cash.ToString();
                textBox2.Text = total_betamount.ToString();

            }
            else if (user.cash == 0)
            {
                MessageBox.Show("Not enough cash to Betting!", "error!");
            }
            else
            {
                bet_amount = 100;

                total_betamount += bet_amount;

                user.cash -= bet_amount;

                textBox1.Text = user.cash.ToString();
                textBox2.Text = total_betamount.ToString();
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (user.cash < bet_amount) // 유저가 있는 돈보다 더 많은 금액을 베팅하려고 할 때 올인으로 처리.
            {
                bet_amount = user.cash;

                total_betamount += bet_amount;

                user.cash -= bet_amount;

                textBox1.Text = user.cash.ToString();
                textBox2.Text = total_betamount.ToString();

            }
            else if (user.cash == 0)
            {
                MessageBox.Show("Not enough cash to Betting!", "error!");
            }
            else
            {
                bet_amount = 500;

                total_betamount += bet_amount;

                user.cash -= bet_amount;

                textBox1.Text = user.cash.ToString();
                textBox2.Text = total_betamount.ToString();
            }


        }
        static void showResult(BP.Dealer dealer, BP.User user)
        {
            string result;
            result = BP.ResultGame(dealer, user);
            MessageBox.Show(result);

            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Wanna play more?", "BlackJack", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                Environment.Exit(0);
            }
        }
        public void clearImage()  //카드 이미지 clear 
        {
            PictureBox[] boxes =
            {
                pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6,
                pictureBox7,pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12,
                pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18,
                pictureBox19, pictureBox20, pictureBox21, pictureBox22,pictureBox23,pictureBox24
            };
            foreach (PictureBox box in boxes)
            {
                box.Image = null;
                box.Visible = false;
                /*
                 * 사진 잘리는 버그 fix
                 * visible = false, backColor = transparent
                 * 카드 받을때 visible = true;
                 */
            }
        }
        static bool Surrender(BP.Dealer dealer, BP.User user)
        {
            DialogResult result;
            result = MessageBox.Show("Do you want to surrender?", "Surrender", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                user.Surrender(dealer);
         
                return true;

            }
            else
            {
                return false;
            }

        }

        BP.User user;
        BP.Dealer dealer;

        private static bool isBettingCompleted = false;
        public async void GameStart()
        {

            int dealer_index = 0;
            int user_index = 12;

            PictureBox[] boxes =
            {
                pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6,
                pictureBox7,pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12,
                pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18,
                pictureBox19, pictureBox20, pictureBox21, pictureBox22,pictureBox23,pictureBox24
            };
            foreach (PictureBox box in boxes)
            {
                box.Image = null;
                box.Visible = false;
            }

            /*
            ----------안에서 여러가지 함수 실행되며 게임 진행됨-----------
            -대략적인 진행상황(카드를 받을 때마다 카드의 정보를 show_card를 통해 보여줌, score계산으로 21이 넘는지 계속 확인)-
            카드 셔플 진행 -> 배팅 진행 -> 페어 배팅 여부 확인 -> 플레이어1과 딜러 카드 2장씩 부여받음 -> 서렌더 여부 판단 -> 인슈어런스 여부 판단 -> 
            더블다운 여부 확인 -> hit or stay 여부 확인 -> 등 등 계속 게임 진행 -> 21이 넘지 않고 게임 마무리될경우 result_game으로 결과 확인
             */
            int dealing;
            bool surrender;
            bool ask_for_insurance;
            char[] shape = { 'c', 'd', 'h', 's' };
            bet_amount = 0;
            total_betamount = 0;

            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;

            user = new BP.User();
            dealer = new BP.Dealer();

            for (int i = 0; i < 4; i++)           //카드 정보입력
            {
                for (int j = 0; j < 13; j++)
                {
                    BP.PushInformationCard(shape[i], j + 1);
                }
            }

            blackjack_windform.StartPage.PushCardImage(); // 카드 이미지 넣기

            while (user.cash > 0)        // 유저 잔고가 0이상일 경우 계속 게임을 할 수 있다.
            {
                dealer_index = 0;
                user_index = 12;
                dealing = 0;  //나눠줄 올카드 인덱스
                BP.Shuffle();  //카드를 섞는다. 
                textBox1.Text = user.cash.ToString();
                //user.bet_cash = BP.Betting(user, 1);       //배팅
                textBox2.Text = bet_amount.ToString();
                BP.pair_bet = BP.PairBetting(user);

                textBox6.Text = BP.pair_bet.ToString();

                //Surrender을 실행하기전 먼저 배팅을 해야하기 때문에 5초동안의 배팅할 시간을 주고 이후 surrender 여부를 판단하는 messagebox가 뜨도록 구현
                MessageBox.Show("Bet by clicking on the betting image, press the confirm button.", "Betting");

                await WaitForBettingImageSelection();





                boxes[dealer_index].Visible = true;
                boxes[dealer_index++].Image = StartPage.cardImage[dealing];
                dealer.GetCard(BP.all_card[dealing++]);          //딜러와 유저 카드 두장씩 받는다.
                                                                 // dealer가 ace카드 일 때의 예시 넣기
                                                                 //딜러의 카드가 ace일때 insurance 할지
                ask_for_insurance = BP.Insuarance(dealer, user);
                if (ask_for_insurance)
                {
                    CanDoInsuranceBetting();
                }
                else
                {
                    label1.Enabled = false;
                    textBox5.Text = BP.insurance_bet.ToString();
                }

                //while (!insurance_box_has_value)
                //{
                //    System.Threading.Thread.Sleep(100);
                //}

                boxes[dealer_index].Visible = true;
                boxes[dealer_index++].Image = StartPage.back_card;
                dealer.GetCard(BP.all_card[dealing++]);

                boxes[user_index].Visible = true;
                boxes[user_index++].Image = StartPage.cardImage[dealing];
                user.GetCard(BP.all_card[dealing++]);

                boxes[user_index].Visible = true;
                boxes[user_index++].Image = StartPage.cardImage[dealing];
                user.GetCard(BP.all_card[dealing++]);

                if (BP.pair_bet > 0)
                {
                    BP.CheckPairBetting(user);
                    textBox1.Text = user.cash.ToString(); // 여기 왜 최신화가 안되지 ?
                }

                //카드받을 때마다 점수 보여주기
                
                textBox3.Text = Convert.ToString(dealer.score);
                textBox4.Text = Convert.ToString(user.score);


                surrender = Surrender(dealer, user);

                if (surrender)
                {
                    MessageBox.Show("Dealer Win");
                    clearImage();
                    BP.NewGame(dealer, user);
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    DialogResult dialogResult;


                    dialogResult = MessageBox.Show("Wanna play more?", "BlackJack", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.No)
                    {
                        Environment.Exit(0);
                    }

                    continue;
                }

                DialogResult dr = MessageBox.Show("Are you going to double down?", "DoubleDown_YesNo", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes && user.cash > 0)
                {
                    boxes[user_index].Visible = true;
                    boxes[user_index++].Image = StartPage.cardImage[dealing];
                    user.GetCard(BP.all_card[dealing++]);

                    //카드받을 때마다 점수 보여주기
                    textBox3.Text = Convert.ToString(dealer.score);
                    textBox4.Text = Convert.ToString(user.score);
                    user.cash -= total_betamount;
                    textBox1.Text = user.cash.ToString();

                    //배팅 2배로
                    total_betamount *= 2;

                    textBox2.Text = Convert.ToString(int.Parse(textBox2.Text) * 2);

                    if (user.busted)            //유저가 버스트 되었다면 게임 종료
                    {
                        showResult(dealer, user);
                        clearImage();
                        BP.NewGame(dealer, user);
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        textBox6.Text = "";
                        continue;
                    }

                    while (!dealer.busted && dealer.score < 17)    //유저가 카드 받기를 멈췄고 버스트되지 않았다면 점수가 17이상이 될떄까지 딜러가 카드를 받기 시작한다.
                    {
                        boxes[dealer_index].Visible = true;
                        boxes[dealer_index++].Image = StartPage.back_card;
                        dealer.GetCard(BP.all_card[dealing++]);

                        //카드받을 때마다 점수 보여주기
                        textBox3.Text = Convert.ToString(dealer.score);
                        textBox4.Text = Convert.ToString(user.score);
                    }

                    showResult(dealer, user);
                    clearImage();
                    BP.NewGame(dealer, user);
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    continue;
                }

                else if (dr == DialogResult.Yes && user.cash == 0)
                {
                    MessageBox.Show("Not enough cash to doubledown!", "error!");
                }

                DialogResult result;
                do
                {
                    result = MessageBox.Show("Do you want to HIT? If you want to STAY, Press No.",
                        "HIT_or_STAY", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        boxes[user_index].Visible = true;
                        boxes[user_index++].Image = StartPage.cardImage[dealing];
                        user.GetCard(BP.all_card[dealing++]);

                        //카드받을 때마다 점수 보여주기
                        textBox3.Text = Convert.ToString(dealer.score);
                        textBox4.Text = Convert.ToString(user.score);

                        if (user.busted)            //유저가 버스트 되었다면 게임 종료
                        {

                            break;
                        }

                    }
                    else
                    {
                        while (!dealer.busted && dealer.score < 17)    //유저가 카드 받기를 멈췄고 버스트되지 않았다면 점수가 17이상이 될떄까지 딜러가 카드를 받기 시작한다.
                        {
                            boxes[dealer_index].Visible = true;
                            boxes[dealer_index++].Image = StartPage.back_card;
                            dealer.GetCard(BP.all_card[dealing++]);

                            //카드받을 때마다 점수 보여주기
                            textBox3.Text = Convert.ToString(dealer.score);
                            textBox4.Text = Convert.ToString(user.score);
                        }

                        break;
                    }

                } while (result == DialogResult.Yes);


                if (user.busted)            //유저가 버스트 되었다면 게임 종료
                {
                    showResult(dealer, user);
                    clearImage();
                    BP.NewGame(dealer, user);
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    continue;
                }

                while (!dealer.busted && dealer.score < 17)    //유저가 카드 받기를 멈췄고 버스트되지 않았다면 점수가 17이상이 될떄까지 딜러가 카드를 받기 시작한다.
                {
                    dealer.GetCard(BP.all_card[dealing++]);
                }
                showResult(dealer, user); //게임 결과
                clearImage();
                BP.NewGame(dealer, user);
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
            }

        }


        private void GamePage_Shown(object sender, EventArgs e)
        {
            GameStart();
        }

        public void CanDoInsuranceBetting()
        {
            DialogResult result;

            result = MessageBox.Show("You can Insurance betting now!");
            label3.Enabled = true;
        }
        private void label3_Click(object sender, EventArgs e)
        {
            DialogResult result;
            if (BP.insurance_bet > bet_amount / 2)
            {
                result = MessageBox.Show("베팅 금액의 절반까지만 베팅할 수 있습니다! 다시 베팅해주세요");
            }
            else
            {
                BP.insurance_bet = (int)bet_amount;
                textBox5.Text = BP.insurance_bet.ToString();
                //인슈런스 베팅은 가상의 금액이라고 생각해야함 ( 캐시에서 빼는거 아님 )
                bet_amount = 0;
                textBox2.Text = bet_amount.ToString();
            }
            label3.Enabled = false;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e) // pair bet
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)// insurance bet
        {
            insurance_box_has_value = !string.IsNullOrEmpty(textBox5.Text);
        }

        private void button7_Click(object sender, EventArgs e) // 베팅확정
        {
            if (total_betamount == 0)
            {
                MessageBox.Show("You have to bet!", "error!");
            }
            else
            {
                if (delayCancellation != null)
                {
                    delayCancellation.Cancel();
                    delayCancellation = null;
                }


                textBox2.Text = total_betamount.ToString();
            }
        }

        private void button8_Click(object sender, EventArgs e) // 베팅취소
        {


            user.cash += total_betamount;
            textBox1.Text = user.cash.ToString();
            total_betamount = 0;
            textBox2.Text = total_betamount.ToString();
        }
    }

}
