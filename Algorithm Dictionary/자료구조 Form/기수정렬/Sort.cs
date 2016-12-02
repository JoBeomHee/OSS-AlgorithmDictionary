using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithm_Dictionary.자료구조_Form.기수정렬
{
    public partial class Sort : Form
    {
        public Sort()
        {
            InitializeComponent();
        }

        private void Sort_Load(object sender, EventArgs e)
        {
            tb_sort.AppendText("//공백큐를 생성하는 연산"+Environment.NewLine);
            tb_sort.AppendText("LQueueType *createLinkedQueue()" + Environment.NewLine);
            tb_sort.AppendText("{" + Environment.NewLine);
            tb_sort.AppendText("LQueueType *LQ;" + Environment.NewLine);
            tb_sort.AppendText("LQ = (LQueueType *)malloc(sizeof(LQueueType));" + Environment.NewLine);
            tb_sort.AppendText("LQ->front = NULL;" + Environment.NewLine);
            tb_sort.AppendText("LQ->rear = NULL;" + Environment.NewLine);
            tb_sort.AppendText("return LQ;" + Environment.NewLine);
            tb_sort.AppendText("}" + Environment.NewLine);

            tb_sort.AppendText(Environment.NewLine);
            tb_sort.AppendText(Environment.NewLine);

            tb_sort.AppendText("// 큐가 공백인지 확인하는 연산" + Environment.NewLine);
            tb_sort.AppendText("int isEmpty(LQueueType *LQ)" + Environment.NewLine);
            tb_sort.AppendText("{" + Environment.NewLine);
            tb_sort.AppendText("if (LQ->front == NULL)return 1;" + Environment.NewLine);
            tb_sort.AppendText("else return 0;" + Environment.NewLine);
            tb_sort.AppendText("}" + Environment.NewLine);

            tb_sort.AppendText(Environment.NewLine);
            tb_sort.AppendText(Environment.NewLine);

            tb_sort.AppendText("// 큐의 rear에 원소를 삽입하는 연산" + Environment.NewLine);
            tb_sort.AppendText("void enQueue(LQueueType *LQ, element item)" + Environment.NewLine);
            tb_sort.AppendText("{" + Environment.NewLine);
            tb_sort.AppendText("QNode *newNode = (QNode *)malloc(sizeof(QNode));" + Environment.NewLine);
            tb_sort.AppendText("newNode->data = item;" + Environment.NewLine);
            tb_sort.AppendText("newNode->link = NULL;" + Environment.NewLine);
            tb_sort.AppendText("if (LQ->front == NULL) {" + Environment.NewLine);
            tb_sort.AppendText("LQ->front = newNode;" + Environment.NewLine);
            tb_sort.AppendText("LQ->rear = newNode;" + Environment.NewLine);
            tb_sort.AppendText("}" + Environment.NewLine);
            tb_sort.AppendText("else {" + Environment.NewLine);
            tb_sort.AppendText("LQ->rear->link = newNode;" + Environment.NewLine);
            tb_sort.AppendText("LQ->rear = newNode;" + Environment.NewLine);
            tb_sort.AppendText("}" + Environment.NewLine);
            tb_sort.AppendText("}" + Environment.NewLine);

            tb_sort.AppendText(Environment.NewLine);
            tb_sort.AppendText(Environment.NewLine);

            tb_sort.AppendText(" // 큐의 front에서 원소를 삭제하고 반환하는 연산" + Environment.NewLine);
            tb_sort.AppendText("element deQueue(LQueueType *LQ) {" + Environment.NewLine);
            tb_sort.AppendText("QNode *old = LQ->front;" + Environment.NewLine);
            tb_sort.AppendText("element item;" + Environment.NewLine);
            tb_sort.AppendText("if (isEmpty(LQ)) return 0;" + Environment.NewLine);
            tb_sort.AppendText("else {" + Environment.NewLine);
            tb_sort.AppendText("item = old->data;" + Environment.NewLine);
            tb_sort.AppendText("LQ->front = LQ->front->link;" + Environment.NewLine);
            tb_sort.AppendText("if (LQ->front == NULL)" + Environment.NewLine);
            tb_sort.AppendText("LQ->rear = NULL;" + Environment.NewLine);
            tb_sort.AppendText("free(old);" + Environment.NewLine);
            tb_sort.AppendText("return item;" + Environment.NewLine);
            tb_sort.AppendText("}" + Environment.NewLine);
            tb_sort.AppendText("}" + Environment.NewLine);

            tb_sort.AppendText(Environment.NewLine);
            tb_sort.AppendText(Environment.NewLine);
            tb_sort.AppendText(Environment.NewLine);

            tb_sort.AppendText(" // 배열 list에 있는 n개 원소에 대해서 기수 정렬을 수행하는 연산을 수행." + Environment.NewLine);
            tb_sort.AppendText("void radixSort(int list[], int n)" + Environment.NewLine);
            tb_sort.AppendText("{" + Environment.NewLine);
            tb_sort.AppendText("int i, bucket, d, factor = 1;" + Environment.NewLine);
            tb_sort.AppendText(" // 정렬할 자료의 기수, 즉 RADIX에 따라 10개의 버킷을 큐로 생성." + Environment.NewLine);
            tb_sort.AppendText("LQueueType *Q[RADIX];" + Environment.NewLine);
            tb_sort.AppendText("for (bucket = 0; bucket < RADIX; bucket++)" + Environment.NewLine);
            tb_sort.AppendText("Q[bucket] = createLinkedQueue();" + Environment.NewLine);
            tb_sort.AppendText("// 키값의 자릿수만큼, 즉 두 번 기수 정렬을 반복 수행." + Environment.NewLine);
            tb_sort.AppendText("for (d = 0; d < DIGIT; d++) { " + Environment.NewLine);
            tb_sort.AppendText("// 키값의 1의 자리에 대한 버킷을 찾아 원소를 저장. (enQueue)" + Environment.NewLine);
            tb_sort.AppendText("for (i = 0; i < n; i++)" + Environment.NewLine);
            tb_sort.AppendText("// 키값의 10의 자리에 대한 버킷을 찾아 원소를 저장. (enQueue)" + Environment.NewLine);
            tb_sort.AppendText("enQueue(Q[(list[i] / factor) % 10], list[i]);" + Environment.NewLine);
            tb_sort.AppendText("// 버킷 0 부터 커빗 9 까지 저장된 원소를 순서대로 꺼내어 (deQueue) 배열 list에 저장." + Environment.NewLine);
            tb_sort.AppendText("for (bucket = 0, i = 0; bucket < RADIX; bucket++) " + Environment.NewLine);
            tb_sort.AppendText(" // 1의 자리에 대하여 기수 정렬이 끝난 현재 상태를 출력." + Environment.NewLine);
            tb_sort.AppendText("while (!isEmpty(Q[bucket])) list[i++] = deQueue(Q[bucket])printf(\n\n%d 단계: \n\t, d + 1); " + Environment.NewLine);
            tb_sort.AppendText("// 10의 자리에 대하여 기수 정렬이 끝난 현재 상태를 출력." + Environment.NewLine);
            tb_sort.AppendText("for (i = 0; i < n; i++) printf( % d  , list[i]); " + Environment.NewLine);
            tb_sort.AppendText("// 10의 자리에 대해 기수 정렬을 반복하기 위해서 factor를 10으로 수정하고 74 ~83 열 반복" + Environment.NewLine);
            tb_sort.AppendText("factor = factor * 10;" + Environment.NewLine);
            tb_sort.AppendText("}" + Environment.NewLine);
            tb_sort.AppendText("}" + Environment.NewLine);

        }
    }
}
