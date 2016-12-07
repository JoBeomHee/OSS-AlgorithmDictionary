/*
<< 알고리즘 설명 >>
- 목적 및 기능 :
다익스트라의 최단 경로 알고리즘은 네트위크에서 하나의 시작 정점으로부터 모든 다른 정점까지의 최단 경로를 찾는 알고리즘이다. 
최단 경로는 경로의 길이순으로 구해진다.
*/
#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <limits.h>

#define TRUE       1
#define FALSE      0
#define NODES     7         /* 노드의 수 */
#define INF  9999            /* 무한 값(연결이 없는 경우) */

void shortest_path(int start, int cost[][NODES], int distance[], int n, int found[]);
// 기존에 있던 최단거리와 새로운 최단거리를 비교하여 작은수를 저장, distance값을 바꿔주는 함수
void print_distance();   // 최단 거리를 출력하는 함수
void print_path(int start, int end);  // 경유노드를 출력해주는 함수
int choose(int distance[], int n, int found[]); // 최단거리를 찾아내 반환해주는 함수

int distance[NODES];         /* 시작노드로부터의 최단경로 거리 */
int path[NODES];             /* 경유 노드  */
int found[NODES];          /* 방문한 노드 표시 */

/*  임의의 그래프 */
int cost[NODES][NODES] =
{
  //  0,   1,     2,      3,      4,      5,      6
	{ 0,    7,     INF,   INF,   3,     10,    INF },  // 0 노드
	{ 7,    0,       4,   10,    2,     6,     INF },  // 1 노드
	{ INF,  4,       0,   2,     INF,   INF,   INF },  // 2 노드
	{ INF,  10,      2,   0,     11,    9,     4 },  // 3 노드
	{ 3,    2,     INF,   11,    0,     INF,   5 },  // 4 노드 
	{ 10,   6,     INF,   9,     INF,   0,     INF },  // 5 노드
	{ INF,  INF,   INF,   4,     5,     INF,   0 }  // 6 노드
};
void main()
{
	printf("\n                   <다익스트라(Dijkstra) 알고리즘>                  \n");
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
	printf("\n +             [6]ㅡㅡㅡㅡㅡㅡ 4ㅡㅡㅡㅡ[   3  ]                   +");
	printf("\n +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");
	printf("\n ");
	//////////////////////////////////////////////////////////////////////////////////// 

	shortest_path(0, cost, distance, NODES, found);
	print_path(0, 3);
	printf("\tdijkstra의 최단 경로\n ");
	print_distance();
}

void shortest_path(int start, int cost[][NODES], int distance[], int n, int found[]) // start : 시작지점, cost: 그래프, distance: 최단경로 거리, n: 노드수, found: 방문한 노드
// 기존에 있던 최단거리와 새로운 최단거리를 비교하여 작은수를 저장, distance값을 바꿔주는 함수
/* 시작노드 start  */
{
	int i, u, w;
	for (i = 0; i<n; i++) /* 그래프처럼 초기화 */
	{
		distance[i] = cost[start][i]; // 경로 초기화
		path[i] = start;
		found[i] = FALSE;
	}

	found[start] = TRUE;    /* 시작노드 방문 표시 */
	distance[start] = 0; // 시작노드 경로거리 0
	for (i = 0; i<n; i++)
	{
		print_distance();  // 최단 거리를 출력
		u = choose(distance, n, found); // 짧은경로의 노드를 선택
		found[u] = TRUE; // 노드 방문
		for (w = 0; w < n; w++)
		{
			if (!found[w]) 
			{
				if (distance[u] + cost[u][w] < distance[w]) // 
				{
					distance[w] = distance[u] + cost[u][w];
					path[w] = u;         /* 경유노드 저장 */
				}
			}
		}
	}
}

void print_path(int start, int end)   // 경유노드를 출력해주는 함수
{
	if (path[end] != start)
	{
		print_path(start, path[end]);
	}
	printf("\t<%d->%d> \n ", path[end], end);
}

void print_distance()  // 최단 거리를 출력하는 함수
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
		if (distance[i] < min && !found[i]) // 더 경로가 짧고, 방문하지 않은 노드가 있을경우
		{
			min = distance[i]; 
			minpos = i;
		}
	}
	return minpos;
}