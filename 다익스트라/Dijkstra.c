/*
<< �˰��� ���� >>
- ���� �� ��� :
���ͽ�Ʈ���� �ִ� ��� �˰����� ��Ʈ��ũ���� �ϳ��� ���� �������κ��� ��� �ٸ� ���������� �ִ� ��θ� ã�� �˰����̴�. 
�ִ� ��δ� ����� ���̼����� ��������.
*/
#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <limits.h>

#define TRUE       1
#define FALSE      0
#define NODES     7         /* ����� �� */
#define INF  9999            /* ���� ��(������ ���� ���) */

void shortest_path(int start, int cost[][NODES], int distance[], int n, int found[]);
// ������ �ִ� �ִܰŸ��� ���ο� �ִܰŸ��� ���Ͽ� �������� ����, distance���� �ٲ��ִ� �Լ�
void print_distance();   // �ִ� �Ÿ��� ����ϴ� �Լ�
void print_path(int start, int end);  // ������带 ������ִ� �Լ�
int choose(int distance[], int n, int found[]); // �ִܰŸ��� ã�Ƴ� ��ȯ���ִ� �Լ�

int distance[NODES];         /* ���۳��κ����� �ִܰ�� �Ÿ� */
int path[NODES];             /* ���� ���  */
int found[NODES];          /* �湮�� ��� ǥ�� */

/*  ������ �׷��� */
int cost[NODES][NODES] =
{
  //  0,   1,     2,      3,      4,      5,      6
	{ 0,    7,     INF,   INF,   3,     10,    INF },  // 0 ���
	{ 7,    0,       4,   10,    2,     6,     INF },  // 1 ���
	{ INF,  4,       0,   2,     INF,   INF,   INF },  // 2 ���
	{ INF,  10,      2,   0,     11,    9,     4 },  // 3 ���
	{ 3,    2,     INF,   11,    0,     INF,   5 },  // 4 ��� 
	{ 10,   6,     INF,   9,     INF,   0,     INF },  // 5 ���
	{ INF,  INF,   INF,   4,     5,     INF,   0 }  // 6 ���
};
void main()
{
	printf("\n                   <���ͽ�Ʈ��(Dijkstra) �˰���>                  \n");
	printf("\n ");
	printf("\n +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
	printf("\n +                                                                 +");
	printf("\n +                          [0]-------10-----[5]                   +");
	printf("\n +                         ) |              / |                    +");
	printf("\n +                       )   |        _____/  |                    +");
	printf("\n +                     3     7       6        |                    +");
	printf("\n +                   )       |     /          |                    +");
	printf("\n +                 )         |   /            |                    +");
	printf("\n +               )           | /              |                    +");
	printf("\n +             [4]----2-----[1]---4---[2]     9                    +");
	printf("\n +              |(            (         |     |                    +");
	printf("\n +              | (             10       |    |                    +");
	printf("\n +              5  (________ 11 __(_______2   |                    +");
	printf("\n +              |                     (   (|  |                    +");
	printf("\n +              |                        ( (| |                    +");
	printf("\n +             [6]�ѤѤѤѤѤ� 4�ѤѤѤ�[   3  ]                   +");
	printf("\n +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");
	printf("\n ");
	//////////////////////////////////////////////////////////////////////////////////// 

	shortest_path(0, cost, distance, NODES, found);
	print_path(0, 3);
	printf("\tdijkstra�� �ִ� ���\n ");
	print_distance();
}

void shortest_path(int start, int cost[][NODES], int distance[], int n, int found[]) // start : ��������, cost: �׷���, distance: �ִܰ�� �Ÿ�, n: ����, found: �湮�� ���
// ������ �ִ� �ִܰŸ��� ���ο� �ִܰŸ��� ���Ͽ� �������� ����, distance���� �ٲ��ִ� �Լ�
/* ���۳�� start  */
{
	int i, u, w;
	for (i = 0; i<n; i++) /* �׷���ó�� �ʱ�ȭ */
	{
		distance[i] = cost[start][i]; // ��� �ʱ�ȭ
		path[i] = start;
		found[i] = FALSE;
	}

	found[start] = TRUE;    /* ���۳�� �湮 ǥ�� */
	distance[start] = 0; // ���۳�� ��ΰŸ� 0
	for (i = 0; i<n; i++)
	{
		print_distance();  // �ִ� �Ÿ��� ���
		u = choose(distance, n, found); // ª������� ��带 ����
		found[u] = TRUE; // ��� �湮
		for (w = 0; w < n; w++)
		{
			if (!found[w]) 
			{
				if (distance[u] + cost[u][w] < distance[w]) // 
				{
					distance[w] = distance[u] + cost[u][w];
					path[w] = u;         /* ������� ���� */
				}
			}
		}
	}
}

void print_path(int start, int end)   // ������带 ������ִ� �Լ�
{
	if (path[end] != start)
	{
		print_path(start, path[end]);
	}
	printf("\t<%d->%d> \n ", path[end], end);
}

void print_distance()  // �ִ� �Ÿ��� ����ϴ� �Լ�
{
	int i;
	for (i = 0; i<NODES; i++)
	{
		printf(" \tdistance[%d]=%d\n ", i, distance[i]);
	}
	printf("------------------------------------------");
	printf("\n");
}

int choose(int distance[], int n, int found[])
{
	int i, min, minpos;
	min = INT_MAX;
	minpos = -1;
	for (i = 0; i < n; i++)
	{
		if (distance[i] < min && !found[i]) // �� ��ΰ� ª��, �湮���� ���� ��尡 �������
		{
			min = distance[i]; 
			minpos = i;
		}
	}
	return minpos;
}