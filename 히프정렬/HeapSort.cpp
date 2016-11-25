/*
히프정렬 : 우선 순위 큐인 힙을 이용하여, 모든 원소를 힙에 집어넣었다가 빼는 방식으로 정렬을 하는 알고리즘

1.n개의 노드에 대한 완전 이진 트리를 구성.
2.최대 힙을 구성.
3.가장 큰 수(루트에 위치)를 가장 작은 수와 교환.
4.2와 3을 반복.
*/

void adjust(int *list, int i, int n);

void HeapSort(int *list, int n)
{
	int i, temp;
	for (i = (n / 2); i >= 1; i--)   // 초기 히프
		adjust(list, i, n);
	for (i = (n - 1); i >= 1; i--)
	{
		temp = list[i + 1];
		list[i + 1] = list[1];
		list[1] = temp;
		adjust(list, 1, i);
	}
}

void adjust(int *list, int i, int n)
{
	int j, k, done;

	done = 0;
	k = list[i];
	j = 2 * i;

	while ((j <= n) && (!done))
	{
		if (j<n)
			if (list[j] < list[j + 1])
				j++;        // 자식노드들 중 큰 노드를 선택 

		if (k >= list[j])
			done = 1;     // 자식 노드보다 크므로 중단
		else
		{
			list[j / 2] = list[j];
			j *= 2;
		}
	}
	list[j / 2] = k;   //처음 저장한 노드의 값을 저장 
}