/*
�պ����� mergesort

�ش� ���Ŀ��Ұ� �������� �� �� ���Կ����� ���� �߻�.
���� �� ������ �ּ�ȭ�ϱ� ���Ͽ� �����ϰ��� �ϴ� �ش� �迭��
�ϳ��� ������ ������ �� �Ųٷ� �պ��ϸ鼭 ������ �Ͽ�
���������� ��ü �迭�� ������ �ϴ� ���

1.���� : �迭 ������ �ϳ��� ���� ������ ���� ����.
2.���� : ���ҵ� ������ ���ҿ� ���� ������ ���� ���Ͽ� sorting�� ����.
3.sorting ���� :
-> ���ս��� sorting���� => �켱 �����Ϸ��� �ϴ� ũ���� �޸𸮸� �Ҵ�
-> �� ���� ���ҿ� ���� ������ ���Ͽ� �Ҵ�� �޸𸮿� ����ִ´�.
*/
#include <stdio.h> 
#include <stdlib.h>
#define LEN 9 

void merge_sort(int num[], int start, int end);
void merge(int num[], int start, int mid, int end);
void tracer(int num[], int len);

int main(void) {

	int i = 0;
	int testArr[LEN] = { 69, 10, 30, 2, 16, 8, 31, 22, 10 };
	int size = sizeof(testArr) / sizeof(testArr[0]);        // ��ü �迭�� ũ�⸦ ������ ũ��� ������ �迭�� ũ�⸦ �� �� �ִ�.
	
	printf("**�պ����� (mergesort)\n");  
		printf("�ش� ���Ŀ��Ұ� �������� �� �� ���Կ����� ���� �߻�. ���� �� ������ �ּ�ȭ\n�ϱ� ���Ͽ� �����ϰ��� �ϴ� �ش� �迭�� �ϳ��� ������ ������ �� �Ųٷ� �պ��ϸ鼭 ������ �Ͽ� ���������� ��ü �迭�� ������ �ϴ� ��� \n\n");


	
	printf("\n �Է¿��� >>");
	for (i = 0; i < size; i++)printf("%4d", testArr[i]);


	printf("\n\n<<<<<<<<<<<<< �������� ���� >>>>>>>>>>>>>>>\n\n");
	merge_sort(testArr, 0, LEN - 1);
	system("pause");
}

void merge_sort(int num[], int start, int end) {  // Array�� �ΰ��� ����� ����
	int median = (start + end) / 2;               // �߰��� ����
	if (start < end) {                            // ����� ���Ұ� �ϳ��� ������
		merge_sort(num, start, median);
		merge_sort(num, median + 1, end);         // ������ ����� ����Լ� ȣ�� 
		merge(num, start, median, end);           // ������ ����� �����鼭 ����
	}
}

void merge(int num[], int start, int median, int end) {
	int i, j, k, m, n;
	int tempArr[LEN]; // �ӽ÷� �����͸� ������ �迭
	i = start;        // ���� ����� ���� Index
	j = median + 1;   // ���� ����� ���� Index
	k = start;        // �ӽ� �迭�� ���� Index

	while (i <= median && j <= end) {
		tempArr[k++] = (num[i] > num[j]) ? num[j++] : num[i++];
		             //���� ���ڸ� ã�� �ӽ� �迭�� �ִ´�. ����� ����� Index�� ���� ������ �������´�.
	}

	                 // ���� �迭�� ������ ���� �κе��� �ֱ� ���� �κ�
	m = (i > median) ? j : i; // ���� ���Ұ� �����ִ� ����� ������� �ľ�
	n = (i > median) ? end : median; // ����������, for���� �� Index�� ���ϱ� ����

	for (; m <= n; m++) {            // �տ��� ���� m, n���� �迭�� ������ ���� ���ҵ��� ä��
		tempArr[k++] = num[m];
	}

	for (m = start; m <= end; m++) {
		num[m] = tempArr[m];         // �ӽ� �迭���� ���� �迭�� ������ �ű��
	}
	printf("Merging: %d ~ %d & %d ~ %d\n", start, median, median + 1, end);
	tracer(num, LEN);
}

void tracer(int num[], int len) {
	int i;
	for (i = 0; i<len; i++) {
		printf("%d\t", num[i]);
	}
	printf("\n\n");
}