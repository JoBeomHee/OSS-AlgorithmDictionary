/*
������� : �׸���� ������ �����ϱ� ���� ���տ� �� �׸��� �p ���� �ִ��� �۾���
�ϸ鼭 ���� �ð��� �����ϴ� ȿ������ �˰���. �ӵ��� �����鼭 ������.
�ð����⵵ O(n)�� ������ �˰���.

���ѻ��� : ������ ������ ǥ���� �� �ִ� �ڷῡ ���ؼ��� ����.
ī��Ʈ���� ���� ����� ������ �Ҵ��Ϸ��� ���ճ��� ū ������ �˾ƾ���.
*/
#include <stdio.h>
#include <stdlib.h>

void CountingSort(int *array, int n, int min, int max)
{
	int i, j, z;

	int range = max - min + 1;
	int *count = (int *)malloc(range * sizeof(*array));	//�ִ밪 ũ�⸸ŭ �޸� �Ҵ�

	for (i = 0; i < range; i++)
		count[i] = 0;
	for (i = 0; i < n; i++)
		count[array[i] - min]++;

	for (i = min, z = 0; i <= max; i++)		//ī��Ʈ ����
	{
		for (j = 0; j < count[i - min]; j++)
		{
			array[z++] = i;
		}
	}
	free(count);
}

void Counting_Sort(int *array, int n)
{
	int i, min, max;

	min = max = array[0];
	for (i = 1; i < n; i++)
	{
		if (array[i] < min)
		{
			min = array[i];
		}
		else if (array[i] > max)
		{
			max = array[i];
		}
	}
}