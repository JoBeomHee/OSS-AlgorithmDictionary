using Algorithm_Dictionary.자료구조_Form.계수정렬;
using Algorithm_Dictionary.자료구조_Form.기수정렬;
using Algorithm_Dictionary.자료구조_Form.깊이우선탐색;
using Algorithm_Dictionary.자료구조_Form.너비우선탐색;
using Algorithm_Dictionary.자료구조_Form.다익스트라;
using Algorithm_Dictionary.자료구조_Form.링크드리스트;
using Algorithm_Dictionary.자료구조_Form.머지정렬;
using Algorithm_Dictionary.자료구조_Form.버블정렬;
using Algorithm_Dictionary.자료구조_Form.버킷정렬;
using Algorithm_Dictionary.자료구조_Form.삽입정렬;
using Algorithm_Dictionary.자료구조_Form.선택정렬;
using Algorithm_Dictionary.자료구조_Form.쉘정렬;
using Algorithm_Dictionary.자료구조_Form.이진탐색트리;
using Algorithm_Dictionary.자료구조_Form.퀵정렬;
using Algorithm_Dictionary.자료구조_Form.큐;
using Algorithm_Dictionary.자료구조_Form.프림알고리즘;
using Algorithm_Dictionary.자료구조_Form.히프정렬;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Algorithm_Dictionary
{
    public partial class AlgorithmMenu : Form
    {
        Stack stack;
        LinkedList ll;
        InsertSort Is;
        SelectionSort ss;
        BinarySearchTree bst;
        QUeue q;
        ShellSort shellSort;
        DepthFirstSearch dfs;
        BreadthFirstSearch bfs;
        BubbleSort bs;
        QuickSort qs;
        HeapSort hs;
        RadixSort rs;
        BucketSort bucketsort;
        Dijkstra dijkstra;
        MergeSort mergesort;
        CountingSort cs;
        Prim prim;

        List<string> items = new List<string>();

        public AlgorithmMenu()
        {
            InitializeComponent();

            items.AddRange(new string[] { "스택(Stack)", "연결리스트(LinkedList)", "큐(Queue)", "다익스트라알고리즘(Dijkstra algorithm)", "프림알고리즘(Prim's algorithm)", "깊이우선탐색(Depth-first search)", "너비우선탐색(Breadth-first search)", "이진탐색트리(BinarySearchTree)", "삽입정렬(InsertSort)", "선택정렬(SelectionSort)", "쉘정렬(ShellSort)", "버블정렬(BubbleSort)", "힙정렬(HeapSort)", "퀵정렬(QuickSort)", "카운팅정렬(CountingSort)", "기수정렬(RadixSort)", "버킷정렬(BucketSort)", "머지정렬(MergeSort)" });

            foreach (string str in items)
            {
                lb_menu.Items.Add(str);
            }
        }

        private void pb_Search_Click(object sender, EventArgs e)
        {
            if (tb_Search.Text.ToString() == "스택(Stack)")
            {
                stack = new Stack();
                stack.FormClosed += Stack_FormClosed;
                stack.Show();
                this.Close();
            }
            if (tb_Search.Text.ToString() == "연결리스트(LinkedList)")
            {
                ll = new LinkedList();
                ll.FormClosed += Ll_FormClosed;
                ll.Show();
                this.Close();
            }
            if (tb_Search.Text.ToString() == "삽입정렬(InsertSort)")
            {
                Is = new InsertSort();
                Is.FormClosed += Is_FormClosed;
                Is.Show();
                this.Close();
            }
            if (tb_Search.Text.ToString() == "선택정렬(SelectionSort)")
            {
                ss = new SelectionSort();
                ss.FormClosed += Ss_FormClosed;
                ss.Show();
                this.Close();
            }
            if (tb_Search.Text.ToString() == "이진탐색트리(BinarySearchTree)")
            {
                bst = new BinarySearchTree();
                bst.FormClosed += Bst_FormClosed;
                bst.Show();
                this.Close();
            }
            if (tb_Search.Text.ToString() == "큐(Queue)")
            {
                q = new QUeue();
                q.FormClosed += Q_FormClosed;
                q.Show();
                this.Close();
            }
            if (tb_Search.Text.ToString() == "쉘정렬(ShellSort)")
            {
                shellSort = new ShellSort();
                shellSort.FormClosed += ShellSort_FormClosed;
                shellSort.Show();
                this.Close();
            }
            if (tb_Search.Text.ToString() == "깊이우선탐색(Depth-first search)")
            {
                dfs = new DepthFirstSearch();
                dfs.FormClosed += Dfs_FormClosed;
                dfs.Show();
                this.Close();
            }
            if (tb_Search.Text.ToString() == "너비우선탐색(Breadth-first search)")
            {
                bfs = new BreadthFirstSearch();
                bfs.FormClosed += Bfs_FormClosed;
                bfs.Show();
                this.Close();
            }
            if (tb_Search.Text.ToString() == "버블정렬(BubbleSort)")
            {
                bs = new BubbleSort();
                bs.FormClosed += Bs_FormClosed;
                bs.Show();
                this.Close();
            }
            if (tb_Search.Text.ToString() == "퀵정렬(QuickSort)")
            {
                qs = new QuickSort();
                qs.FormClosed += Qs_FormClosed;
                qs.Show();
                this.Close();
            }
            if (tb_Search.Text.ToString() == "힙정렬(HeapSort)")
            {
                hs = new HeapSort();
                hs.FormClosed += Hs_FormClosed;
                hs.Show();
                this.Close();
            }
            if (tb_Search.Text.ToString() == "기수정렬(RadixSort)")
            {
                rs = new RadixSort();
                rs.FormClosed += Rs_FormClosed;
                rs.Show();
                this.Close();
            }
            if (tb_Search.Text.ToString() == "버킷정렬(BucketSort)")
            {
                bucketsort = new BucketSort();
                bucketsort.FormClosed += Bucketsort_FormClosed;
                bucketsort.Show();
                this.Close();
            }
            if (tb_Search.Text.ToString() == "다익스트라알고리즘(Dijkstra algorithm)")
            {
                dijkstra = new Dijkstra();
                dijkstra.FormClosed += Dijkstra_FormClosed;
                dijkstra.Show();
                this.Close();
            }
            if (tb_Search.Text.ToString() == "프림알고리즘(Prim's algorithm)")
            {
                prim = new Prim();
                prim.FormClosed += Prim_FormClosed;
                prim.Show();
                this.Close();
            }
            if (tb_Search.Text.ToString() == "머지정렬(MergeSort)")
            {
                mergesort = new MergeSort();
                mergesort.FormClosed += Mergesort_FormClosed;
                mergesort.Show();
                this.Close();
            }
            if (tb_Search.Text.ToString() == "카운팅정렬(CountingSort)")
            {
                cs = new CountingSort();
                cs.FormClosed += Cs_FormClosed;
                cs.Show();
                this.Close();
            }
        }

        private void Prim_FormClosed(object sender, FormClosedEventArgs e)
        {
            prim = null;
        }

        private void Cs_FormClosed(object sender, FormClosedEventArgs e)
        {
            cs = null;
        }

        private void Mergesort_FormClosed(object sender, FormClosedEventArgs e)
        {
            mergesort = null;
        }

        private void Dijkstra_FormClosed(object sender, FormClosedEventArgs e)
        {
            dijkstra = null;
        }

        private void Bucketsort_FormClosed(object sender, FormClosedEventArgs e)
        {
            bucketsort = null;
        }

        private void Rs_FormClosed(object sender, FormClosedEventArgs e)
        {
            rs = null;
        }

        private void Hs_FormClosed(object sender, FormClosedEventArgs e)
        {
            hs = null;
        }

        private void Qs_FormClosed(object sender, FormClosedEventArgs e)
        {
            qs = null;
        }

        private void Bs_FormClosed(object sender, FormClosedEventArgs e)
        {
            bs = null;
        }

        private void Bfs_FormClosed(object sender, FormClosedEventArgs e)
        {
            bfs = null;
        }

        private void Dfs_FormClosed(object sender, FormClosedEventArgs e)
        {
            dfs = null;
        }

        private void ShellSort_FormClosed(object sender, FormClosedEventArgs e)
        {
            shellSort = null;
        }

        private void Q_FormClosed(object sender, FormClosedEventArgs e)
        {
            q = null;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            tb_Search.Text = tb_Search.Text;
        }

        private void Bst_FormClosed(object sender, FormClosedEventArgs e)
        {
            bst = null;
        }

        private void Ss_FormClosed(object sender, FormClosedEventArgs e)
        {
            ss = null;
        }

        private void Is_FormClosed(object sender, FormClosedEventArgs e)
        {
            Is = null;
        }

        private void Ll_FormClosed(object sender, FormClosedEventArgs e)
        {
            ll = null;
        }

        private void Stack_FormClosed(object sender, FormClosedEventArgs e)
        {
            stack = null;
        }

        private void Key_Enter(object sender, KeyPressEventArgs e) //엔터키 눌렀을 때 검색
        {
            if (e.KeyChar == '\r')
            {
                pb_Search_Click(sender, e);

            }
        }

        private void tb_search(object sender, KeyPressEventArgs e) //엔터키 눌렀을 때 검색
        {
            if (e.KeyChar == '\r')
            {
                pb_Search_Click(sender, e);

            }
        }


        private void lb_menu_SelectedIndexChanged(object sender, EventArgs e) // 리스트 박스 선택
        {
            try
            {
                tb_Search.Text = lb_menu.SelectedItem.ToString();
            }
            catch (Exception error)
            { }
        }

        private void lb_Enter(object sender, KeyPressEventArgs e)  //엔터키 눌렀을 때 적용
        {
            if (e.KeyChar == '\r')
            {
                pb_Search_Click(sender, e);

            }
        }

        private void pb_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_Search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lb_menu.Items.Clear();
                foreach (string str in items)
                {
                    if (str.StartsWith(tb_Search.Text, StringComparison.CurrentCultureIgnoreCase))
                    {
                        lb_menu.Items.Add(str);
                    }
                }

                if (tb_Search.Text.ToString() == "스")
                {
                    tb_Search.Text = "스택(Stack)";
                }
                if (tb_Search.Text.ToString() == "스택")
                {
                    tb_Search.Text = "스택(Stack)";
                }
                if (tb_Search.Text.ToString() == "연")
                {
                    tb_Search.Text = "연결리스트(LinkedList)";
                }
                if (tb_Search.Text.ToString() == "연결리스트")
                {
                    tb_Search.Text = "연결리스트(LinkedList)";
                }
                if (tb_Search.Text.ToString() == "큐")
                {
                    tb_Search.Text = "큐(Queue)";
                }
                if (tb_Search.Text.ToString() == "다")
                {
                    tb_Search.Text = "다익스트라알고리즘(Dijkstra algorithm)";
                }
                if (tb_Search.Text.ToString() == "다익스트라알고리즘")
                {
                    tb_Search.Text = "다익스트라알고리즘(Dijkstra algorithm)";
                }
                if (tb_Search.Text.ToString() == "프")
                {
                    tb_Search.Text = "프림알고리즘(Prim's algorithm)";
                }
                if (tb_Search.Text.ToString() == "프림알고리즘")
                {
                    tb_Search.Text = "프림알고리즘(Prim's algorithm)";
                }
                if (tb_Search.Text.ToString() == "깊이")
                {
                    tb_Search.Text = "깊이우선탐색(Depth-first search)";
                }
                if (tb_Search.Text.ToString() == "깊이우선탐색")
                {
                    tb_Search.Text = "깊이우선탐색(Depth-first search)";
                }
                if (tb_Search.Text.ToString() == "너")
                {
                    tb_Search.Text = "너비우선탐색(Breadth-first search)";
                }
                if (tb_Search.Text.ToString() == "너비우선탐색")
                {
                    tb_Search.Text = "너비우선탐색(Breadth-first search)";
                }
                if (tb_Search.Text.ToString() == "이")
                {
                    tb_Search.Text = "이진탐색트리(BinarySearchTree)";
                }
                if (tb_Search.Text.ToString() == "이진탐색트리")
                {
                    tb_Search.Text = "이진탐색트리(BinarySearchTree)";
                }
                if (tb_Search.Text.ToString() == "삽")
                {
                    tb_Search.Text = "삽입정렬(InsertSort)";
                }
                if (tb_Search.Text.ToString() == "삽입정렬")
                {
                    tb_Search.Text = "삽입정렬(InsertSort)";
                }
                if (tb_Search.Text.ToString() == "선")
                {
                    tb_Search.Text = "선택정렬(SelectionSort)";
                }
                if (tb_Search.Text.ToString() == "선택정렬")
                {
                    tb_Search.Text = "선택정렬(SelectionSort)";
                }
                if (tb_Search.Text.ToString() == "쉘")
                {
                    tb_Search.Text = "쉘정렬(ShellSort)";
                }
                if (tb_Search.Text.ToString() == "쉘정렬")
                {
                    tb_Search.Text = "쉘정렬(ShellSort)";
                }
                if (tb_Search.Text.ToString() == "버블")
                {
                    tb_Search.Text = "버블정렬(BubbleSort)";
                }
                if (tb_Search.Text.ToString() == "버블정렬")
                {
                    tb_Search.Text = "버블정렬(BubbleSort)";
                }
                if (tb_Search.Text.ToString() == "힙")
                {
                    tb_Search.Text = "힙정렬(HeapSort)";
                }
                if (tb_Search.Text.ToString() == "힙정렬")
                {
                    tb_Search.Text = "힙정렬(HeapSort)";
                }
                if (tb_Search.Text.ToString() == "퀵")
                {
                    tb_Search.Text = "퀵정렬(QuickSort)";
                }
                if (tb_Search.Text.ToString() == "퀵정렬")
                {
                    tb_Search.Text = "퀵정렬(QuickSort)";
                }
                if (tb_Search.Text.ToString() == "카")
                {
                    tb_Search.Text = "카운팅정렬(CountingSort)";
                }
                if (tb_Search.Text.ToString() == "카운팅정렬")
                {
                    tb_Search.Text = "카운팅정렬(CountingSort)";
                }
                if (tb_Search.Text.ToString() == "기수")
                {
                    tb_Search.Text = "기수정렬(RadixSort)";
                }
                if (tb_Search.Text.ToString() == "기수정렬")
                {
                    tb_Search.Text = "기수정렬(RadixSort)";
                }
                if (tb_Search.Text.ToString() == "버킷")
                {
                    tb_Search.Text = "버킷정렬(BucketSort)";
                }
                if (tb_Search.Text.ToString() == "버킷정렬")
                {
                    tb_Search.Text = "버킷정렬(BucketSort)";
                }
                if (tb_Search.Text.ToString() == "머")
                {
                    tb_Search.Text = "머지정렬(MergeSort)";
                }
                if (tb_Search.Text.ToString() == "머지정렬")
                {
                    tb_Search.Text = "머지정렬(MergeSort)";
                }
            }
            catch (Exception error)
            {

            }
        }
    }
}
