using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithm_Dictionary.자료구조_Form.큐
{
    public partial class Queue : Form
    {
        AlgorithmMenu am;
        QueueInit qi;
        QueueFullEmpty qfe;
        EnQueue eq;
        DeQueue dq;
        QueueDispose qd;

        public Queue()
        {
            InitializeComponent();
        }

        private void Queue_Load(object sender, EventArgs e)
        {
            tb_description.AppendText("큐는 순차적으로 자료를 보관하고 가장 최근에 보관한 자료를 꺼내는(FIFO, First In First Out) 버퍼입니다.\r\n여기에서는 버퍼의 크기가 정적인 배열로 정의하는 것을 먼저 구현할 겁니다.\r\n배열로 큐를 정의할 때 자료를 보관하는 버퍼 외에 자료를 보관할 위치와 꺼낼 인덱스를 기억하고 있습니다.\r\n보관할 위치는 맨 뒤에 보관해서 rear라고 부르고 꺼낼 위치는 맨 앞이어서 front라 부릅니다.\r\n그리고 큐에 자료를 보관하는 행위를 EnQueue 혹은 Put이라 부릅니다.\r\n큐에서 자료를 꺼내는 행위는 DeDueue 혹은 Get이라 부릅니다.\r\n그리고 배열로 큐를 구현할 때는 큐가 비었는지 혹은 꽉 찼는지 확인할 수 있는 기능을 제공합니다.\r\n다음은 배열로 구현한 원형 큐입니다.원형 큐는 맨 뒤에 보관한 다음 다시 앞에 보관하는 큐를 말합니다.\r\n이와 같이 보관하면 큐가 꽉 찼을 때와 비었을 때 구분하지 못하는 문제가 있습니다.\r\n이를 해결하는 방법 중에 rear 다음이 front일 때 꽉 찬 것으로 취급하는 방법이 있습니다.\r\n여기에서는 이 방법을 사용하여 구현했습니다.\r\n우리는 원형큐를 가지고 큐를 구현하겠습니다.");

            tb_Init.AppendText("다음은 큐의 초기화 함수입니다.\r\n여기서는 큐를 일단 동적으로 생성을 해주고 front와 rear를 0으로 설정을 해주고 보관 개수를 0으로 설정 해줍니다.\r\n이 기능을 코드로 구현 하였는데 코드로 보고 싶으시면 코드보기 버튼을 클랙해 주세요.");

            tb_FullEmpty.AppendText("다음은 큐의 저장소가 꽉 찼는지 비었는지에 대해서 알아보는 함수입니다.\r\n먼저 꽉 찼는지 확인 하려면 보관 개수가 qsize와 같으면 큐가 꽉 찼다는 얘기고 큐가 비었는지 확인하는 함수는 보관 개수가 0이면 빈 상태입니다.\r\n이것을 코드로 보고 싶으시다면 아래 코드보기 버튼을 클릭해 주세요.");

            tb_Enqueue.AppendText("다음은 큐의 데이터를 삽입하는 함수입니다.\r\n여기서는 큐가 꽉 찼을 때 메시지로 알려주고 rear 인덱스에 데이터를 보관해주고 다음에 rear를 다음 위치로 설정해주고 나서 마지막으로 보관 개수를 1증가 시켜주는 작업을 합니다.\r\n이것을 코드로 보고 싶으시다면 아래 코드보기 버튼을 클릭해 주세요.");

            tb_DeQueue.AppendText("다음은 큐의 데이터를 삭제하는 함수입니다.\r\n여기서는 큐가 비었을 때 메시지로 알려주고 먼저 front 인덱스에 보관한 값을 re에 설정해주고 front를 다음 위치로 설정하고 보관 개수를 1 감소 시켜줍니다.\r\n이것을 코드로 보고 싶으시다면 아래 코드보기 버튼을 클릭해 주세요.");

            tb_dispose.AppendText("다음은 큐 해제화 함수입니다. 여기서는 free 해주면 됩니다.\r\n이것을 코드로 보고 싶으시다면 아래 코드보기 버튼을 클릭해 주세요.");
        }

        private void btn_stack_Click(object sender, EventArgs e)
        {
            qi = new QueueInit();
            qi.FormClosed += Qi_FormClosed;
            qi.Show();
        }

        private void Qi_FormClosed(object sender, FormClosedEventArgs e)
        {
            qi = null;
        }

        private void btn_FullEmpty_Click(object sender, EventArgs e)
        {
            qfe = new QueueFullEmpty();
            qfe.FormClosed += Qfe_FormClosed;
            qfe.Show();
        }

        private void Qfe_FormClosed(object sender, FormClosedEventArgs e)
        {
            qfe = null;
        }

        private void btn_Enqueue_Click(object sender, EventArgs e)
        {
            eq = new EnQueue();
            eq.FormClosed += Eq_FormClosed;
            eq.Show();
        }

        private void Eq_FormClosed(object sender, FormClosedEventArgs e)
        {
            eq = null;
        }

        private void btn_Dequeue_Click(object sender, EventArgs e)
        {
            dq = new DeQueue();
            dq.FormClosed += Dq_FormClosed;
            dq.Show();
        }

        private void Dq_FormClosed(object sender, FormClosedEventArgs e)
        {
            dq = null;
        }

        private void btn_dispose_Click(object sender, EventArgs e)
        {
            qd = new QueueDispose();
            qd.FormClosed += Qd_FormClosed;
            qd.Show();
        }

        private void Qd_FormClosed(object sender, FormClosedEventArgs e)
        {
            qd = null;
        }

        private void pb_back_Click(object sender, EventArgs e)
        {
            am = new AlgorithmMenu();
            am.FormClosed += Am_FormClosed;
            am.Show();
            this.Close();
        }

        private void Am_FormClosed(object sender, FormClosedEventArgs e)
        {
            am = null;
        }

        private void lb_link_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://ehclub.co.kr/2559");
        }
    }
}
