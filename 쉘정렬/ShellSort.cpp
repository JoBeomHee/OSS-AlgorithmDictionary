/*
�� ���� (Shell Sort) - Donald L. Shell �̶�� ����� ������ ������λ��� ������ ��� ���� ���ĵ� �迭�� ���ؼ��� 
					   �����ٴ°Ϳ� ������ ���. ���� ���İ��� �ٸ��� ��ü�� ����Ʈ�� �ѹ��� �������� �ʰ�
					   ���� �����ؾ��� ����Ʈ�� ������ ���ؿ� ���� �з��Ͽ� ���������� ���� �������� �κ� ����Ʈ�� �����,
					   �� �κ� ����Ʈ�� ���� ������ �̿��Ͽ� ����.
					   ��� ����Ʈ�� ���ĵǸ� �� ������ �ٽ� ��ü ����Ʈ�� �� ���� �κ� ����Ʈ�� ���� �� �˰����� �ݺ�. 
					   (����Ʈ�� ������ 1�� �ɶ� ����.)

					   �������Ŀ� ���� ������
						1. ��ȯ�Ǵ� ��ҵ��� �������ĺ��� ��������ġ�� ���� ���ɼ��� ����.
						2.�⺻������ ���� ������ �����ϴ� �������� ������ ����.

*/
#include <stdio.h>

int size;                                 //�迭�� ũ��
int count = 0;                            //�� Ƚ���� ���� ����

void intervalSort(int a[], int begin, int end, int interval); //�� �� �����Լ�
void ShellSort(int a[], int size);                            //������ ������ �Լ�

void main()
{
	int list[10] = { 35,67,40,8,2,17,0,10,42,69 };    //�迭�� �ʱ�
	size = 10;                                       //�迭�� ũ��
	ShellSort(list, size);                          //������ �Լ� ȣ��
}

void intervalSort(int a[], int begin, int end, int interval)
{
	int i, j, num;
	for (i = begin + interval; i <= end; i = i + interval) 
	{
		num = a[i];
		for (j = i - interval; j >= begin && num<a[j]; j = j - interval)
		{
			a[j + interval] = a[j];                //�տ� ���� Ŭ��
			count++;
		}
		a[j + interval] = num;                   //�տ� ���� ������
	}
	count++;
}

void ShellSort(int a[], int size)
{
	int i, t, interval;
	for (t = 0; t < size; t++)
		printf("%d \n", a[t]);
	interval = size / 2;                            //������ ����

	while (interval >= 1)
	{
		for (i = 0; i < interval; i++)
			intervalSort(a, i, size - 1, interval); //������ ������ �Լ� ȣ��
		printf("interval = %d  >> ", interval);

		for (t = 0; t < size; t++)
			printf("%d \n", a[t]);
		interval = interval / 2;
	}
	printf("\n [�� ������ �� Ƚ��: %d�� ]\n", count);   //��Ƚ�� ���
}