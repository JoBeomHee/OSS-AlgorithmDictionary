/*
*������(Quick Sort) : ������ ��ü ���ҿ� ���ؼ� ������ �������� �ʰ� ���ذ��� �߽����� ���� �κ����հ� ������ �κ��������� ����.
���� �κ����տ��� ���ذ����� ���� ���ҵ��� �̵���Ű��, ������ �κ����տ��� ���ذ����� ū ���ҵ��� �̵���Ų��.
�̶� ����ϴ� ���ذ��� �Ǻ�(Pivot)�̶�� �ϴµ�, �Ϲ������� ��ü ���� �߿��� ����� ��ġ�� ���Ҹ� �Ǻ����� ����.

�� ������ ������ 2���� �⺻ �۾��� �ݺ� �����Ͽ� �ϼ��Ѵ�.

(1) ����(Divide) : ������ �ڷ���� ���ذ��� �߽����� 2���� �κ��������� ����.
(2) ����(Conquer) : �κ������� ���ҵ� �߿��� ���ذ����� ���� ���ҵ��� ���� �κ���������, ���ذ����� ū ���ҵ��� ������ �κ��������� �����Ѵ�.
�κ������� ũ�Ⱑ 1���Ϸ� ����� ���� ������ ��ȯ ȣ���� �̿��Ͽ� �ٽ� ����
*/

#include <stdio.h>
#include <stdlib.h>��
#include <math.h>

int size, i = 0;

int partition(int List[], int begin, int end);
void quickSort(int List[], int begin, int end);


void main() {


	int list[8] = { 69, 10, 30, 2, 16, 8, 31, 22 };   // �����ϰ��� �ϴ� ���Ҹ���Ʈ List
	int size = sizeof(list) / sizeof(list[0]);        // ��ü �迭�� ũ�⸦ ������ ũ��� ������ �迭�� ũ�⸦ �� �� �ִ�.

	printf("**������ (Quick Sort)\n");                // �����Ŀ� ���Ͽ�
	printf("������ ��ü ���ҿ� ���ؼ� ������ �������� �ʰ� ���ذ��� �߽����� ���� �κ����հ������� �κ��������� �����ϴ� ��� \n\n");

	printf("\n������ ����\n");
	for (i = 0; i < size; i++) {   // list�迭 ���� �����ϰ��� �ϴ� ���ҵ� ���
		printf("%3d", list[i]);
	}
	printf("\n");

	quickSort(list, 0, size - 1);                      //������ �Լ� ȣ��

	printf("\n => ���� �� \n");                       //������ �� ���� ���.
	for (int i = 0; i < size; i++) {
		printf("%d ", list[i]);
	}
	printf("\n");
	getchar();

}

int partition(int List[], int begin, int end)     // �κ����� �ȿ��� �Ǻ��� ��ġ�� ã�� Ȯ���ϴ� ����
{
	int pivot, temp, L, R, sort;                  // ���� �۾��� ��ȯ������ �ݺ��ϸ鼭 �Ǻ��� ���� �κ����հ� ������ �κ������� �����ϴ� ������� ��ü ���ҵ��� ����.
												  // �κ��������� �����ϱ� ���ؼ� L�� R�� ���.

	L = begin;
	R = end;

	pivot = (int)floor((begin + end) / 2);        // �߰��� ��ġ�� �ڷḦ �Ǻ� ���ҷ� ����
	
	printf("\n [ pivot =%d]\n", List[pivot]);
	
	while (L < R) {
		while ((List[L] <= List[pivot]) && (L <= R)) L++; // List[L]�� List[pivot]���� �۰ų� ���� L�� R���� �۰ų� �������� L�� ����.
		                                                  // ��, pivot���Һ��� ���ų� ū ���Ҹ� ã�� �� ���� �Ǵ� L�� R�� ���� �� ���� L��
		                                                  // ���ʿ��� ������ ���� �̵�.

		while ((List[R] > List[pivot]) && (L <= R)) R--;  // List[R]�� List[pivot]���� ũ�� L�� R���� �۰ų� �������� L�� ����.
														  // ��, pivot���Һ��� ���� ���Ҹ� ã�� �� ���� �Ǵ� L�� R�� ���� �� ���� R��
														  // �����ʿ��� ���� ���� �̵�.

		if (L <= R) {
			temp = List[L];                               // List[L]�� List[R]�� ���� ��ȯ
			List[L] = List[R];
			List[R] = temp;

			if (R == pivot) {                           // R�� pivot�� ���� ��� Pivot ���ҿ� ���� �ڸ���ȯ�� �߻��Ͽ����Ƿ� pivot�� ��ġ�� Ȯ���ϰ�
				for (sort = 0; sort < size; sort++)     
				{
					printf(" %d", List[sort]);          // ������ ���� ���� ���
				}
				printf("\n");
				return L;                               // pivot�� Ȯ���� ��ġ L�� ��ȯ
			}
		}

	}
	//  while (L < R)
	//		(L > R)�� �� ���

	temp = List[pivot];           // List[pivot]�� List[R]�� ���α�ȯ
	List[pivot] = List[R];        // Pivot ���ҿ� ���� �ڸ���ȯ�� �߻��Ͽ����Ƿ� pivot�� ��ġ�� Ȯ��
	List[R] = temp;
	printf("\n");
	return R;                     // pivot�� Ȯ���� ��ġ R�� ��ȯ
}

void quickSort(int List[], int begin, int end) {

	if (begin < end) {            // �迭 List�� ���ؼ� begin���� end������ ������ �ϴ� �κ����տ� ���� 
		int p_operation;         
								                    // �� ������ �����ϱ����� �Լ�ȣ��
		p_operation = partition(List, begin, end);  // �Լ����� �� ��ȯ�� R, �� ���� Ȯ���� �Ǻ��� �ڸ��� ���� p_operation�� ����

		for (int i = 0; i < 8; i++) {
			printf("%d ", List[i]);
		}
		printf("\n");

		                                                             // ���� Ȯ���� �Ǻ���ġ  p_operation �߽����� ���� ������ �κ����տ� ���� ����
		quickSort(List, begin, p_operation - 1);                     // �Ǻ��� ���� �κ����տ� ���� �� ���� ���ȣ��
		quickSort(List, p_operation + 1, end);                       // �Ǻ��� ������ �κ����տ� ���� �� ���� ���ȣ��
	}
}
