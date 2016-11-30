/*
<< 알고리즘 설명 >>
- 목적 및 기능 :
prim의 알고리즘은 시작 정점에서부터 출발하여 신장 트리 집합을 단계적으로 확장해나가는 방법이다.
시작 단계에서는 시작 정점만이 신장 트리 집합에 포함된다.
prim의 방법은 신장트리집합에, 인접한 정점들 중에서 최저간선으로 연결된 정점을 선택하여 트리를 확장한다.
이 과정은 트리가 n-1개의 간선을 가질때까지 계속된다.
예를 들어 아래 그림을 보면 이미 신장트리 집합에는 정점{ a, f }가 포함되어 있다. 
이 상태에서 신장 트리 집합에 인접한 정점을 살펴보면 b와e가 있다.간선( a, b )와 간선( f, e )의 가중치를 비교해 보면( f, e )가 27로서 ( a, b )의 29보다 낮다. 
따라서 ( f, e )간선이 선택되고 정점e 가 신장트리 집합에 포함된다. 
다음 단계에서 신장트리 집합은 { a, f, e }가 되고 같은 과정이 되풀이 된다. 
신장 트리 집합에 정점의 개수가 n-1개가 될 때까지 이 과정은 계속된다.
*/
#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#define TRUE 1
#define FALSE 0

#define VERTICES 7
#define INF 1000L

int adj_mat[VERTICES][VERTICES] = // 임의의 그래프
{
	///  a,   b,    c,    d,    e,   f,   g 
		{ 0, 29, INF, INF, INF, 10, INF },  // a
		{ 29,  0, 16, INF, INF, INF, 15 },  // b
		{ INF, 16, 0, 12, INF, INF, INF },  // c
		{ INF, INF, 12, 0, 22, INF, 18 },  // d
		{ INF, INF, INF, 22, 0, 27, 25 },  // e
		{ 10, INF, INF, INF, 27, 0, INF },  // f
		{ INF, 15, INF, 18, 25, INF, 0 }  // g
};

int selected[VERTICES]; // 방문표시를 저장하기 위한 배열
int dist[VERTICES]; // 최소값을 저장하기 위한 배열
int get_min_vertex(int n); // 최소 dist[v] 값을 갖는 정점을 반환
void prim(int s, int n); // prim 함수


void main() // 트리그래프
{
	printf("\n                   <prim 알고리즘>                  \n");
	printf("\n 주어진 그래프에서 prim의 최소비용 신장트리를 알려줍니다.");
	printf("\n +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
	printf("\n +                                                                 +");
	printf("\n +                         [a]-------29------[b]                   +");
	printf("\n +                         /                 / (                   +");
	printf("\n +                        /                 /   (                  +");
	printf("\n +                      10                15     16                +");
	printf("\n +                      /                /         (               +");
	printf("\n +                     /                /           (              +");
	printf("\n +                    [f]           [g]            [c]             +");
	printf("\n +                     (           /   (            /              +");
	printf("\n +                      (         /      (         /               +");
	printf("\n +                      27       25       18      12               +");
	printf("\n +                        (     /           (    /                 +");
	printf("\n +                          (  /             (  /                  +");
	printf("\n +                           [e]------22-------[d]                 +");
	printf("\n +                                                                 +");
	printf("\n +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");
	
	prim(0, VERTICES);
}

void prim(int s, int n)
{
	int i, u, v, min = 0;
	// i = 정점의 번호
	// u = 방문한 정점
	// v = 방문할 정점
	// min = 최소거리들의 합
	for (u = 0; u < n; u++)
	{
		dist[u] = INF; // 최소값들 초기화
	}
	dist[s] = 0; // 첫 정점의 방문거리 0
	for (i = 0; i<n; i++)
	{
		u = get_min_vertex(n);
		selected[u] = TRUE; // 방문표시
		if (dist[u] == INF) 
		{
			return;
		}
		min += dist[u]; // 방문거리 더하기
		printf("\n\t %d번째  %c방문  거리=%d, 최소 비용=%d \n", i, u + 65, dist[u], min);
		for (v = 0; v < n; v++)
		{
			if (adj_mat[u][v] != INF) // 방문한 정점중에서 주위에 방문하지 않은 정점이 있고 간선이 있는경우
			{
				if (!selected[v] && adj_mat[u][v] < dist[v]) // 방문하지 않은 정점이면서, 더 짧은 간선이 존재하는 경우
				{
					dist[v] = adj_mat[u][v];
				}
			}
		}
	}
	printf("\n");
}

int get_min_vertex(int n) // 최소 dist[v] 값을 갖는 정점을 반환
{
	int v, i;
	// v = i의 인접 정점
	// i = 방문한 정점
	for (i = 0; i < n; i++)
	{
		if (!selected[i]) // 방문하지 않은 정점을 찾는 작업
		{
			v = i;
			break;
		}
	}
	for (i = 0; i < n; i++)
	{
		if (!selected[i] && (dist[i] < dist[v])) // 방문하지 않은 정점중에서 거리가 가장 짧은 정점 찾는 작업
		{
			v = i;
		}
	}
	return (v);
}