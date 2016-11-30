/*
��Ŷ���� : Ű ���� �����Ӹ��� �ƴ϶� �� ���� ������ Ű ���� Ȯ��������
�յ��ϰ� �����ȴٰ� ������ �� ���� �� ������ �� �ִ� ���.

Ű ���� 0�� 1 ���̶�� �����Ҷ�, n���� Ű�� ����[0,1]�� n����ϰ� ���� �ϳ��� ��Ŷ������.
�� Ű�� ũ�⿡ ���� �� ��Ŷ�� �й��Ѵٸ�, Ű�� ���� ������ �յ��ϰ� �����Ѵ� ���������Ƿ�
�ϳ��� ��Ŷ���� �ϳ��� Ű�� ���� Ȯ���� ����.
���� �� ��Ŷ�� ���� Ű�� ���� �ȴٸ� ���� ��Ŷ�� ���ϴ� Ű������ ������ ���� �˰������� ������.
*/

#include <stdio.h>
#include <stdlib.h>
#include <conio.h>

void BucketSort(int* arr, int n)
{
	int i, j = 0;
	int* count = (int*)malloc(sizeof(int)*n);

	for (i = 0; i < n; i++)	//�ʱ� ī���� ����
		count[i] = 0;

	for (i = 0; i < n; i++)	// �迭 �ѹ� ī��Ʈ
		count[arr[i]]++;


	for (i = 0; i < n; i++)	// �迭���� ����
	{
		for (; count[i] > 0; count[i]--)
		{
			arr[j++] = i;
		}
	}
}
void output(int *arr, int n)
{
	int i;

	for (i = 0; i < n; i++)
	{
		printf("%d\n", arr[i]);
	}
}
int main()
{
	int arr[] = { 54,42,68,56,97,32,43,98,3,11 };
	int n = 10;
	int i;

	output(arr, n);
	BucketSort(arr, n);
	output(arr, n);
	_getch();

	return 0;
}