/*
�������� : �켱 ���� ť�� ���� �̿��Ͽ�, ��� ���Ҹ� ���� ����־��ٰ� ���� ������� ������ �ϴ� �˰���

1.n���� ��忡 ���� ���� ���� Ʈ���� ����.
2.�ִ� ���� ����.
3.���� ū ��(��Ʈ�� ��ġ)�� ���� ���� ���� ��ȯ.
4.2�� 3�� �ݺ�.
*/

void adjust(int *list, int i, int n);

void HeapSort(int *list, int n)
{
	int i, temp;
	for (i = (n / 2); i >= 1; i--)   // �ʱ� ����
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
				j++;        // �ڽĳ��� �� ū ��带 ���� 

		if (k >= list[j])
			done = 1;     // �ڽ� ��庸�� ũ�Ƿ� �ߴ�
		else
		{
			list[j / 2] = list[j];
			j *= 2;
		}
	}
	list[j / 2] = k;   //ó�� ������ ����� ���� ���� 
}