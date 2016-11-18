#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#define N 7
void search(int i);
int visit[N + 1];

int dfs[N + 1][N + 1] =
{
	{ 0,0,0,0,0,0,0,0 },
	{ 0,0,1,1,0,0,0,0 },
	{ 0,1,0,0,1,1,0,0 },
	{ 0,1,0,0,0,0,0,0 },
	{ 0,0,1,0,0,0,0,1 },
	{ 0,0,1,0,0,0,1,0 },
	{ 0,0,0,0,0,1,0,0 },
	{ 0,0,0,0,1,0,0,0 }
};

int main()
{
	search(1);

	return 0;
}

void search(int i)
{
	int j;
	visit[i] = 1; // 방문한곳은 1
	for (j = 1; j <= N; j++)
	{
		if (dfs[i][j] == 1 && visit[j] == 0)
		{
			printf("%d -> %d로 이동\n", i, j);
			search(j);
		}
	}
}