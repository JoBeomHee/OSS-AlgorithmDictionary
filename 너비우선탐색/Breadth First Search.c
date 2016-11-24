#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#define N 7
void search();
int visit[N + 1];
int queue[100];

int bfs[N + 1][N + 1] =
{
	{ 0,0,0,0,0,0,0,0 },
	{ 0,0,1,1,0,0,0,0 },
	{ 0,1,0,0,1,1,1,0 },
	{ 0,1,0,0,0,0,0,0 },
	{ 0,0,1,0,0,0,0,0 },
	{ 0,0,1,0,0,0,0,1 },
	{ 0,0,1,0,0,0,0,0 },
	{ 0,0,0,0,0,1,0,0 }
};

int main()
{
	search();

	return 0;
}

void search()
{
	int i, j;
	int head = 0;
	int tail = 0;

	visit[4] = 1;
	queue[tail++] = 4;

	do 
	{
		i = queue[head++];
		for (j = 1; j <= N; j++)
		{
			if (bfs[i][j] == 1 && visit[j] == 0)
			{
				queue[tail++] = j;
				visit[j] = 1;
				printf("%d -> %d∑Œ ¿Ãµø\n", i, j);
			}
		}
	} while (head < tail);
}